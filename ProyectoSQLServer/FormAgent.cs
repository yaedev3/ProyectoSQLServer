using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSQLServer
{
    public partial class FormAgent : Form
    {
        private DatabaseConnection connection;
        private int idAgente = -1;
        private string tableName = "Agente";

        public FormAgent()
        {
            InitializeComponent();
            connection = new DatabaseConnection(@"DESKTOP-91T9VRR\SQLEXPRESS", "databasecar");
            dataGridViewAgent.DataSource = connection.Refresh(tableName, "*");
            propertyFormAgent();
        }

        private void propertyFormAgent()
        {
            textBoxNameAgent.MaxLength = textBoxAddress.MaxLength = textBoxEmail.MaxLength = 25;
            textBoxRFCAgent.MaxLength = 12;
            textBoxPhone.MaxLength = 15;
            numericUpSalary.Maximum = int.MaxValue;
        }

        private bool existEmptyFields()
        {
            bool res = false;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (control.Text.Length == 0)
                    {
                        res = true;
                        break;
                    }
                }
            }
            return (res);
        }

        private string generateStringValue(string action)
        {
            string aux = "";
            switch (action)
            {
                case "INSERT":
                    aux = "'" + textBoxNameAgent.Text + "','" + textBoxRFCAgent.Text + "','" + numericUpSalary.Value.ToString() + "','" + textBoxAddress.Text + "','" + textBoxPhone.Text + "','" + textBoxEmail.Text + "'";
                    break;
                case "UPDATE":
                    aux = "Nombre='" + textBoxNameAgent.Text + "',RFC='" + textBoxRFCAgent.Text + "',Salario='" + numericUpSalary.Value.ToString() + "',Domicilio='" + textBoxAddress.Text + "',Celular='" + textBoxPhone.Text + "',Email='" + textBoxEmail.Text + "'";
                    break;
            }

            return (aux);
        }

        private void cleanForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    control.Text = "";
                else
                     if (control.GetType() == typeof(NumericUpDown))
                    numericUpSalary.Value = 0;
            }
            idAgente = -1;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (existEmptyFields() != true)
            {
                connection.InsertInto(tableName, "Nombre,RFC,Salario,Domicilio,Celular,Email", generateStringValue("INSERT"));
                dataGridViewAgent.DataSource = connection.Refresh(tableName, "*");
                cleanForm();
            }
            else
                MessageBox.Show("Es Obligatorio llenar todos los campos");
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (idAgente != -1)
            {
                if (existEmptyFields() != true)
                {
                    connection.UpdateSet(tableName, idAgente.ToString(), generateStringValue("UPDATE"));
                    dataGridViewAgent.DataSource = connection.Refresh(tableName, "*");
                    cleanForm();
                }
                else
                    MessageBox.Show("Es OBLIGATORIO llenar todos los campos");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (idAgente != -1)
            {
                connection.DeleteFrom(tableName, idAgente.ToString());
                dataGridViewAgent.DataSource = connection.Refresh(tableName, "*");
                cleanForm();
            }
        }

        private void dataGridViewAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNameAgent.Text = dataGridViewAgent[1, e.RowIndex].Value.ToString();
            textBoxRFCAgent.Text = dataGridViewAgent[2, e.RowIndex].Value.ToString();
            numericUpSalary.Value = (decimal)Convert.ToSingle(dataGridViewAgent[3, e.RowIndex].Value.ToString());
            textBoxAddress.Text = dataGridViewAgent[4, e.RowIndex].Value.ToString();
            textBoxPhone.Text = dataGridViewAgent[5, e.RowIndex].Value.ToString();
            textBoxEmail.Text = dataGridViewAgent[6, e.RowIndex].Value.ToString();
            idAgente = Convert.ToInt32(dataGridViewAgent[0, e.RowIndex].Value.ToString());
        }
    }
}
