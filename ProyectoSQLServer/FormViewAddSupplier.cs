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
    public partial class FormViewAddSupplier : Form
    {
        private DatabaseConnection connection;
        private string tableName = "Proveedor";
        private string id = string.Empty;

        public FormViewAddSupplier()
        {
            InitializeComponent();

            connection = new DatabaseConnection(@"GATEWAY-NE\SQLEXPRESS", "databasecar");
            dataGridViewSuppliers.DataSource = connection.Refresh(tableName, "*");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string order = "Nombre, Telefono, Domicilio, RazonSocial, Email";

            if(verify_Fields())
            {
                string value = String.Format("'{0}','{1}','{2}','{3}','{4}'",
    textBoxName.Text, textBoxPhone.Text, textBoxResidency.Text, textBoxBusinessName.Text,
    textBoxEmail.Text);
                connection.InsertInto(tableName, order, value);
                dataGridViewSuppliers.DataSource = connection.Refresh(tableName, "*");
            }

        }

        private bool verify_Fields()
        {
            if(textBoxName.Text == String.Empty)
            {
                error_Message("El campo Nombre no puede estar vacio.");
                return false;
            }
            if (textBoxPhone.Text == String.Empty)
            {
                error_Message("El campo Telefono no puede estar vacio.");
                return false;
            }
            if (textBoxResidency.Text == String.Empty)
            {
                error_Message("El campo Domicilio no puede estar vacio.");
                return false;
            }
            if (textBoxBusinessName.Text == String.Empty)
            {
                error_Message("El campo Razon social no puede estar vacio.");
                return false;
            }
            if (textBoxEmail.Text == String.Empty)
            {
                error_Message("El campo Email no puede estar vacio.");
                return false;
            }
            return true;
        }

        private void error_Message(string text)
        {
            MessageBox.Show(text);
        }

        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                id = dataGridViewSuppliers[0, e.RowIndex].Value.ToString();
                textBoxName.Text = dataGridViewSuppliers[1, e.RowIndex].Value.ToString();
                textBoxPhone.Text = dataGridViewSuppliers[2, e.RowIndex].Value.ToString();
                textBoxResidency.Text = dataGridViewSuppliers[3, e.RowIndex].Value.ToString();
                textBoxBusinessName.Text = dataGridViewSuppliers[4, e.RowIndex].Value.ToString();
                textBoxEmail.Text = dataGridViewSuppliers[5, e.RowIndex].Value.ToString();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (id != string.Empty)
            {
                if (verify_Fields())
                {
                    string values = string.Format("Nombre='{0}', Telefono='{1}', Domicilio='{2}', RazonSocial='{3}', Email='{4}'",
                        textBoxName.Text, textBoxPhone.Text, textBoxResidency.Text, textBoxBusinessName.Text, textBoxEmail.Text);
                    connection.UpdateSet(tableName, id, values);
                    dataGridViewSuppliers.DataSource = connection.Refresh(tableName, "*");

                }
            }
            else
                error_Message("Primero selecciones un elemento");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (id != string.Empty)
            {
                if (verify_Fields())
                {
                    connection.DeleteFrom(tableName, id);
                    dataGridViewSuppliers.DataSource = connection.Refresh(tableName, "*");
                    clear_fields();
                }
            }
            else
                error_Message("Primero seleccione un elemento para eliminarlo");

        }

        private void clear_fields()
        {
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxResidency.Text = "";
            textBoxBusinessName.Text = "";
            textBoxEmail.Text = "";
        }
    }
}
