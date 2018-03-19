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
    public partial class FormAddSale : Form
    {
        private string idClient;
        private DatabaseConnection connection;

        public FormAddSale()
        {
            InitializeComponent();
            idClient = "";
            connection = new DatabaseConnection();
        }

        private void buttonSClient_Click(object sender, EventArgs e)
        {
            FormSeekClient form = new FormSeekClient();
            form.AccessFeatures += CliFeatures;
            form.Show();
        }

        private void CliFeatures(string name, string adddress, string phone, string id)
        {
            labelClientName.Text = "Nombre: " + name;
            labelAddress.Text = "Domicilio: " + adddress;
            labelPhone.Text = "Telefono: " + phone;
            idClient = id;
        }

        private void buttonSAuto_Click(object sender, EventArgs e)
        {
            FormSeekCar form = new FormSeekCar();
            form.AccessFeatures += CarFeatures;
            form.Show();
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Metodo del delegado para asginar las caracteristicas del auto.
         * */
        private void CarFeatures(string serial, string name, string brand, string model, string price)
        {
            labelSerialNumber.Text = "Numero de serie: " + serial;
            labelCarName.Text = "Nombre: " + name;
            labelBrand.Text = "Marca: " + brand;
            labelModel.Text = "Modelo: " + model;
            textBoxFinalPrice.Text = "$"  + price;
        }

        private void comboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxCredit.Enabled = false;
            if (comboBoxPaymentType.SelectedIndex == 1)
            {
                groupBoxCredit.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string values, order;

            if (CanInsert())
            {
                if (comboBoxPaymentType.Text.Equals("Contado"))
                {
                    values = string.Format("{0},{1},'{2}',{3},{4},{5},'{6}'", idClient, 1, labelSerialNumber.Text.Replace("Numero de serie: ", "")
                    , textBoxFinalPrice.Text.Replace("$", ""), 1, 0, comboBoxPaymentType.Text);
                    order = "idCliente,idAgente,NoSerie,MontoTotal,NoExhibiciones,Adeudo,TipoVenta";
                    connection.InsertInto("Venta", order, values);
                }                  
                else
                    values = string.Format("{0},{1},'{2}',{3},{4},{5},'{6}'", idClient, 1, labelSerialNumber.Text.Replace("Numero de serie: ", "")
                        , textBoxFinalPrice.Text.Replace("$", ""), numericExhibitions.Value, float.Parse(textBoxFinalPrice.Text.Replace("$", "")) - (float)numericStartingAmount.Value
                        , comboBoxPaymentType.Text);
                MessageBox.Show("Se realizo la venta exitosamente");
                this.Close();
            }
            else MessageBox.Show("No se pueden dejar espacios en blanco");
        }

        private bool CanInsert()
        {
            bool answer = true;

            if (idClient.Equals("") || labelSerialNumber.Text.Equals("Numero de serie: ") || comboBoxPaymentType.Text.Equals(""))
                answer = false;

            return answer;
        }
    }
}
