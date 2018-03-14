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
    public partial class FormViewDataCar : Form
    {
        private DatabaseConnection connection;
        private string tableName = "Auto";

        public FormViewDataCar()
        {
            InitializeComponent();
            connection = new DatabaseConnection(@"GATEWAY-NE\SQLEXPRESS", "databasecar");
            dataGridViewDataCar.DataSource = connection.RefreshAutoVista();
        }

        private void dataGridViewDataCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSerialNumber.Text = dataGridViewDataCar[5, e.RowIndex].Value.ToString();
            textBoxName.Text = dataGridViewDataCar[2, e.RowIndex].Value.ToString();
            textBoxBrand.Text = dataGridViewDataCar[1, e.RowIndex].Value.ToString();
            textBoxModel.Text = dataGridViewDataCar[0, e.RowIndex].Value.ToString();
            numericBuyPrice.Value = (decimal)Convert.ToSingle(dataGridViewDataCar[3, e.RowIndex].Value.ToString());
        }

        private bool verify_Fields()
        {
            if (textBoxSerialNumber.Text == String.Empty)
            {
                error_Message("El campo Numero de serie no puede estar vacio");
                return false;
            }
            if (textBoxName.Text == String.Empty)
            {
                error_Message("El campo Nombre no puede estar vacio");
                return false;
            }
            if (textBoxBrand.Text == String.Empty)
            {
                error_Message("El campo Marca no puede estar vacio");
                return false;
            }
            if (textBoxModel.Text == String.Empty)
            {
                error_Message("El campo Modelo no puede estar vacio");
                return false;
            }
            if (numericBuyPrice.Value.ToString() == String.Empty)
            {
                error_Message("El precio de compra no puede estar vacio");
                return false;
            }
            return true;
        }

        private void error_Message(string text)
        {
            MessageBox.Show(text);
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(verify_Fields())
            {
                string values = String.Format("NoSerie='{0}', Nombre='{1}', Marca='{2}', Modelo='{3}', PrecioFabrica={4}",
                    textBoxSerialNumber.Text, textBoxName.Text, textBoxBrand.Text, textBoxModel.Text, numericBuyPrice.Value);

                connection.UpdateSetAuto(tableName, "NoSerie", textBoxSerialNumber.Text, values);
                dataGridViewDataCar.DataSource = connection.RefreshAutoVista();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //connection.DeleteFromAuto(tableName,"NoSerie",textBoxSerialNumber.Text);
            connection.UpdateSetAuto("Instancia_Auto", "NoSerie", textBoxSerialNumber.Text, "0");
            clearRow();
            dataGridViewDataCar.DataSource = connection.RefreshAutoVista();
        }

        private void clearRow()
        {
            textBoxSerialNumber.Text = "";
            textBoxName.Text = "";
            textBoxBrand.Text = "";
            textBoxModel.Text = "";
            numericBuyPrice.Value = 0;
        }
    }
}
