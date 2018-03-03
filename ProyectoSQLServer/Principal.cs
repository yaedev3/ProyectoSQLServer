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
    public partial class Principal : Form
    {

        /**
       *  Moreno Sabás Mayra Karina
       * Constructor de la pagina principal 
       * */
        public Principal()
        {
            InitializeComponent();
        }

        private void Venta_Auto(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui estara la ventana de venta del auto");
        }

        private void Compra_Auto(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui estara la ventana de compra del auto");

        }

        private void Inventario_Auto(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui estara ventana de el inventario");
        }

        private void Empleado(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui estara la ventana de el empleado");

        }

        private void Proveedores_auto(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui estara la ventana de los proveedores");

        }

        private void Cliente(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui estara la venta de el cliente");

        }
    }
}
