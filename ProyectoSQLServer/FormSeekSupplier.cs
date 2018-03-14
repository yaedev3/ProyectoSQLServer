using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProyectoSQLServer
{

    /*

        Búsqueda de Proveedores

        Esta pantalla sirve para buscar proveedores de la base de datos por su nombre.

        Autor: Rafael Acuña
        Fecha: 25/02/18
         
         */
    
    public partial class FormSeekSupplier : Form
    {
        private DatabaseConnection connection;
        // Al iniciar la pantalla, se muestra la lista con todos los proveedores.
        private List<string> datos;

        public FormSeekSupplier()
        {
            InitializeComponent();
            connection = new DatabaseConnection(@"GATEWAY-NE\SQLEXPRESS", "databasecar");
            datos = new List<string>();
            updateDataGrid();
        }

        // Método para evitar que el botón de búsqueda sea presionado con el campo de nombre vacío.

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.TextLength > 0)
                bSeek.Enabled = true;
            else
                bSeek.Enabled = false;
        }

        // Este método actualiza el DataGridView de los proveedores con la información de todos los mismos.

        public void updateDataGrid()
        {
            //OleDbConnection con = new OleDbConnection(@"Provider=SQLNCLI11;Server=CASA-PC;Database=databasecar;Trusted_Connection=yes;");

            //con.Open();
            //if (con.State != ConnectionState.Open) { return; }

            //OleDbCommand command = new OleDbCommand("SELECT * FROM dbo.Proveedor", con);
            //OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            //DataTable table = new DataTable();
            //adapter.Fill(table);

            dgvSuppliers.DataSource = connection.Refresh("dbo.Proveedor", "*"); ;

            //con.Close();
        }

        // Evento accionado por el click en el botón de búsqueda.
        // Se ejecuta la consulta SQL para mostrar los proveedores con el nombre introducido.

        private void bSeek_Click(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection(@"Provider=SQLNCLI11;Server=GATEWAY-NE\SQLEXPRESS;Database=databasecar;Trusted_Connection=yes;");

            //con.Open();
            //if (con.State != ConnectionState.Open) { return; }

            //OleDbCommand command = new OleDbCommand("SELECT * FROM dbo.Proveedor WHERE Nombre='" + tbName.Text + "'", con);
            //OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            //DataTable table = new DataTable();
            //adapter.Fill(table);

            dgvSuppliers.DataSource = connection.Refresh("dbo.Proveedor", "*", string.Format("Nombre='{0}'", tbName.Text)); ;

            //con.Close();
        }

        public List<string> get_data()
        {
            return datos;
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datos.Add(dgvSuppliers[0, e.RowIndex].Value.ToString());
            datos.Add(dgvSuppliers[1, e.RowIndex].Value.ToString());
            datos.Add(dgvSuppliers[4, e.RowIndex].Value.ToString());
            datos.Add(dgvSuppliers[2, e.RowIndex].Value.ToString());

            //serialNumber = dataGridViewCars.SelectedRows[0].Cells[0].Value.ToString();
            //name = dataGridViewCars.SelectedRows[0].Cells[1].Value.ToString();
            //brand = dataGridViewCars.SelectedRows[0].Cells[2].Value.ToString();
            //model = dataGridViewCars.SelectedRows[0].Cells[3].Value.ToString();
            //price = dataGridViewCars.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
