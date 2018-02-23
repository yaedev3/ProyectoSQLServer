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
            databaseconnection = new DatabaseConnection(@"DESKTOP-Q77ELOA\SQLEXPRESS", "universidad");
            this.dataGridView1.DataSource = databaseconnection.Refresh("Informacion_universidad.Zona");
        }
    }
}
