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
    public partial class FormClient : Form
    {
        private DatabaseConnection connection;
        private int idClient = -1;
        private string tableName = "Cliente";

        public FormClient()
        {
            InitializeComponent(); connection = new DatabaseConnection(@"DESKTOP-91T9VRR\SQLEXPRESS", "databasecar");
            dataGridViewClient.DataSource = connection.Refresh(tableName, "*");
            propertyFormAgent();

        }

        private void propertyFormAgent()
        {
            textBoxNameClient.MaxLength = textBoxAddress.MaxLength = textBoxPhone.MaxLength = textBoxOcupation.MaxLength = 30;

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
                    aux = "'" + textBoxNameClient.Text + "','" + textBoxAddress.Text + "','" + textBoxPhone.Text + "','" + textBoxOcupation.Text + "'";
                    break;
                case "UPDATE":
                    aux = "Nombre='" + textBoxNameClient.Text + "',Domicilio='" + textBoxAddress.Text + "',Telefono='" + textBoxPhone.Text + "',Ocupacion='" + textBoxOcupation.Text + "'";
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
            }
            idClient = -1;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (existEmptyFields() != true)
            {
                connection.InsertInto(tableName, "Nombre,Domicilio,Telefono,Ocupacion", generateStringValue("INSERT"));
                dataGridViewClient.DataSource = connection.Refresh(tableName, "*");
                cleanForm();
            }
            else
                MessageBox.Show("Es Obligatorio llenar todos los campos");
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (idClient != -1)
            {
                if (existEmptyFields() != true)
                {
                    connection.UpdateSet(tableName, idClient.ToString(), generateStringValue("UPDATE"));
                    dataGridViewClient.DataSource = connection.Refresh(tableName, "*");
                    cleanForm();
                }
                else
                    MessageBox.Show("Es OBLIGATORIO llenar todos los campos");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (idClient != -1)
            {
                connection.DeleteFrom(tableName, idClient.ToString());
                dataGridViewClient.DataSource = connection.Refresh(tableName, "*");
                cleanForm();
            }
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNameClient.Text = dataGridViewClient[1, e.RowIndex].Value.ToString();
            textBoxAddress.Text = dataGridViewClient[2, e.RowIndex].Value.ToString();
            textBoxPhone.Text = dataGridViewClient[3, e.RowIndex].Value.ToString();
            textBoxOcupation.Text = dataGridViewClient[4, e.RowIndex].Value.ToString();
            idClient = Convert.ToInt32(dataGridViewClient[0, e.RowIndex].Value.ToString());
        }
    }
}
