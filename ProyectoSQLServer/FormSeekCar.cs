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
    public delegate void GetCarFeatures(string serial, string name, string brand, string model, string price);
    public partial class FormSeekCar : Form
    {
        private DatabaseConnection connection;
        private string serialNumber, name, brand, model, price;
        private string nameQuery, brandQuery, modelQuery, query;
        private GetCarFeatures car;

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Constructor de la clase FormSeeCar inicializa las variables que tendran los criterios de la consulta.
         * */
        public FormSeekCar()
        {
            InitializeComponent();
            name = nameQuery = brandQuery = modelQuery = "";            
        }

        /**
        * Enriquez Capetillo Gerardo Arturo
        * Cuando se le da clic a un renglon del dataGridViewCars asigna los valores
        * numero de serie, nombre, marca, modelo y precio en variables.
        * */
        private void dataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serialNumber = dataGridViewCars.SelectedRows[0].Cells[0].Value.ToString();
            name = dataGridViewCars.SelectedRows[0].Cells[1].Value.ToString();
            brand = dataGridViewCars.SelectedRows[0].Cells[2].Value.ToString();
            model = dataGridViewCars.SelectedRows[0].Cells[3].Value.ToString();
            price = dataGridViewCars.SelectedRows[0].Cells[4].Value.ToString();
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Hace la conexion con la base de datos para despues hacer un 
         * SELECT NoSerie,Nombre,Marca,Modelo,PrecioVenta FROM Auto.
         * */
        private void FormSeekCar_Load(object sender, EventArgs e)
        {
            connection = new DatabaseConnection(@"GATEWAY-NE\SQLEXPRESS", "databasecar");
            //this.dataGridViewCars.DataSource = connection.Refresh("Auto", "NoSerie,Nombre,Marca,Modelo,PrecioVenta");
            query = "SELECT Instancia_Auto.NoSerie, Auto.Nombre, Auto.Marca, Auto.Modelo, Instancia_Auto.PrecioVenta FROM Auto"+
                " INNER JOIN Instancia_Auto ON Auto.IdAuto = Instancia_Auto.IdAuto WHERE Instancia_Auto.Bandera = 1";
            this.dataGridViewCars.DataSource = connection.RefreshAuto(query);
            fillComboBox(comboBoxName, 1);
            fillComboBox(comboBoxBrand, 2);
            fillComboBox(comboBoxModel, 3);
            for (int j = 0; j < dataGridViewCars.Columns.Count; j++)
                dataGridViewCars.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Llena un ComboBox con los valores del dataGridViewCars selecionados por un indice.
         * ComboBox box - ComboBox que almacenara los datos.
         * int index - Indice de la columna del dataGridViewCars.
         * */
        private void fillComboBox(ComboBox box, int index)
        {
            foreach (DataGridViewRow row in dataGridViewCars.Rows)
                if (!box.Items.Contains(row.Cells[index].Value.ToString()))
                    box.Items.Add(row.Cells[index].Value.ToString());
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Cuando el valor del comboBoxName cambia almacena el nombre del auto y actualiza el dataGridViewCars.
         * */
        private void comboBoxName_SelectedValueChanged(object sender, EventArgs e)
        {
            nameQuery = comboBoxName.Text;
            makeQuery();
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Cuando el valor del comboBoxBrand cambia almacena la marca del auto y actualiza el dataGridViewCars.
         * */
        private void comboBoxBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            brandQuery = comboBoxBrand.Text;
            makeQuery();
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Cuando el valor del comboBoxModel cambia almacena el modelo del auto y actualiza el dataGridViewCars.
         * */
        private void comboBoxModel_SelectedValueChanged(object sender, EventArgs e)
        {
            modelQuery = comboBoxModel.Text;
            makeQuery();
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Cuando se presiona el boton "Aceptar" hace una accion.
         * */
        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (!name.Equals(""))
            {
                car(serialNumber, name, brand, model, price);
                this.Close();
            }
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Construye las restricciones de una consulta con los valores de los comboBoxes seleccionados y
         * ejecuta una consulta SELECT.
         * */
        private void makeQuery()
        {
            string subquery = "";
            if (!nameQuery.Equals(""))
                subquery += string.Format("Nombre = '{0}' AND ", nameQuery);
            if (!brandQuery.Equals(""))
                subquery += string.Format("Marca = '{0}' AND ", brandQuery);
            if (!modelQuery.Equals(""))
                subquery += string.Format("Modelo = '{0}' AND ", modelQuery);
            subquery = subquery.Remove(subquery.Length - 5, 4);
            this.dataGridViewCars.DataSource = connection.RefreshAuto(query + " AND " + subquery);
            for (int j = 0; j < dataGridViewCars.Columns.Count; j++)
                dataGridViewCars.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Metodo de acceso para las caracteristicas del auto.
         * */
        public GetCarFeatures AccessFeatures
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
            }
        }
    }
}
