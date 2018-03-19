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
    public partial class FormBuy : Form
    {
        private DatabaseConnection connection;
        private string idSupplier;

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Constructor de la clase FormBuy limita el tamaño de los textBoxes y hace la conexion con la base de datos.
         * */
        public FormBuy()
        {
            InitializeComponent();
            connection = new DatabaseConnection(@"GATEWAY-NE\SQLEXPRESS", "databasecar");
            textBoxCarBrand.MaxLength = textBoxCarModel.MaxLength = textBoxCarName.MaxLength = 25;
            textBoxCarSerialNumber.MaxLength = 17;
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Cuando se presiona el boton "Aceptar" verifica que ningun campo quede vacio en caso contrario
         * muestra un mensaje al usuario.
         * */
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string idCar = "-1";
            if (textBoxCarBrand.Text.Equals("") || textBoxCarModel.Text.Equals("") || textBoxCarName.Text.Equals("") || textBoxCarSerialNumber.Text.Equals("") || numericUpDownCarPrice.Value == 0)
                MessageBox.Show("No puedes dejar campos en blanco", "Error");
            else
            {
                if (connection.GetId("Auto", "*", string.Format("Modelo='{0}' AND Marca='{1}' AND Nombre = '{2}'", textBoxCarModel.Text, textBoxCarBrand.Text, textBoxCarName.Text)).Equals("-1"))
                    connection.InsertInto("Auto", "Modelo,Nombre,Marca,PrecioFabrica,Cantidad", string.Format("'{0}','{1}','{2}',{3},0", textBoxCarModel.Text, textBoxCarName.Text, textBoxCarBrand.Text, numericUpDownCarPrice.Value));
                idCar = connection.GetId("Auto", "*", string.Format("Modelo='{0}' AND Marca='{1}' AND Nombre = '{2}'", textBoxCarModel.Text, textBoxCarBrand.Text, textBoxCarName.Text));
                connection.InsertInto("Instancia_Auto", "NoSerie,IdAuto,Bandera", string.Format("'{0}',{1},1", textBoxCarSerialNumber.Text, idCar));
                connection.InsertInto("Compra", "idProveedor,idAgente,NoSerie", string.Format("{0},{1},'{2}'", idSupplier, 1, textBoxCarSerialNumber.Text));
                MessageBox.Show("Se realizo la compra exitosamente");
                this.Close();
            }
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Cuando se presiona el boton "Cancelar" cierra la forma.
         * */
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Enriquez Capetiillo Gerardo Arturo
         * Cuando se presiona el boton de busqueda manda llamar la ventana de Proveedores.
         * */
        private void buttonSupplierSeek_Click(object sender, EventArgs e)
        {
            FormSeekSupplier SeekSup = new FormSeekSupplier();

            SeekSup.ShowDialog();

            List<string> datos = SeekSup.get_data();
            if (datos != null)
            {
                idSupplier = datos[0];
                labelSupplierName.Text += datos[1];
                labelSupplierBusinessName.Text += datos[2];
                labelPhone.Text += datos[3];
            }
        }
    }
}
