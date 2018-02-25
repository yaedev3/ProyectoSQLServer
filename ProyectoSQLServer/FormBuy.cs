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
        private string idSupplier, idUser;

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Constructor de la clase FormBuy limita el tamaño de los textBoxes y hace la conexion con la base de datos.
         * */
        public FormBuy()
        {
            InitializeComponent();
            connection = new DatabaseConnection(@"DESKTOP-Q77ELOA\SQLEXPRESS", "databasecar");
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
            if (textBoxCarBrand.Text.Equals("") || textBoxCarModel.Text.Equals("") || textBoxCarName.Text.Equals("") || textBoxCarSerialNumber.Text.Equals("") || numericUpDownCarPrice.Value == 0)
                MessageBox.Show("No puedes dejar campos en blanco", "Error");
            else
            {
                //connection.InsertInto("Compra",)
                //INSERT INTO Auto VALUES (textBoxCarSerialNumber,textBoxCarName,textBoxCarBrand,textBoxCarModel,numericUpDownCarPrice,NULL);
                //INSERT INTO Compra (idProveedor,idAgente,NoSerie,FechaCompra) VALUES (idSupplier,idUser,textBoxCarSerialNumber,CurrentDate);
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

        }
    }
}
