using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProyectoSQLServer
{
    /*

        Búsqueda de Clientes

        Esta pantalla sirve para buscar clientes de la base de datos por su nombre.

        Autor: Rafael Acuña
        Fecha: 25/02/18
         
         */
    public delegate void ClienteFeatures(string name, string address, string phone, string id);
    public partial class FormSeekClient : Form
    {

        // Al iniciar la pantalla, se muestra la lista con todos los clientes.
        private DatabaseConnection connection;
        private string name, address, phone, id;
        private ClienteFeatures features;

        public FormSeekClient()
        {
            InitializeComponent();
            connection = new DatabaseConnection("", "");
            dgvClients.DataSource = connection.Refresh("dbo.Cliente", "Nombre,Domicilio,Telefono");
            id = name = address = phone = "";
        }

        // Método para evitar que el botón de búsqueda sea presionado con el campo de nombre vacío.

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = connection.Refresh("dbo.Cliente", "Nombre,Domicilio,Telefono", string.Format("Nombre='{0}*'", tbName.Text));
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
            address = dgvClients.SelectedRows[0].Cells[1].Value.ToString();
            phone = dgvClients.SelectedRows[0].Cells[2].Value.ToString();
            id = connection.GetId("Cliente", "idCliente", string.Format("Nombre='{0}' AND Domicilio='{1}' AND Telefono='{2}'", name, address, phone));
        }

        // Evento accionado por el click en el botón de búsqueda.
        // Se ejecuta la consulta SQL para mostrar los clientes con el nombre introducido.

        private void bSeek_Click(object sender, EventArgs e)
        {
            if (!name.Equals(""))
            {
                features(name, address, phone, id);
                this.Close();
            }
        }

        public ClienteFeatures AccessFeatures
        {
            get
            {
                return features;
            }
            set
            {
                features = value;
            }
        }
    }
}
