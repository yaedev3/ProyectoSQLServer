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
    public partial class Form1 : Form
    {
        private DatabaseConnection databaseconnection;

        public Form1()
        {
            InitializeComponent();
            databaseconnection = new DatabaseConnection(@"DESKTOP-Q77ELOA\SQLEXPRESS", "databasecar");
            //databaseconnection.InsertInto("Auto", "NoSerie, Nombre, Marca, Modelo, PrecioFabrica, PrecioVenta", "'hoolamundo','tsuru','niisan','hibrido',10.5,50.5");
            databaseconnection.InsertInto("Cliente", "Nombre,Domicilio,Telefono,Ocupacion", "'Juan Perez','Himno Nacional', '4444954621','Estudiante'");
            this.dataGridView1.DataSource = databaseconnection.Refresh("Cliente", "*");
        }
    }
}
