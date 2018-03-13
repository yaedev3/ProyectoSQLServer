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
    public partial class login : Form
    {
        private DatabaseConnection databaseconnection;
        /**
       * Moreno Sabás Mayra Karina
       * Constructor de la clase login, hace una llamada a la conexion de la base de datos(databaseconnection)
       * */
        public login()
        {
            InitializeComponent();
            databaseconnection = new DatabaseConnection("", "");
        }

        /**
       *  Moreno Sabás Mayra Karina
       * Metodo del boton aceptar, en el se hace un if para verificar que lo que existe en el texbox de usuario 
       * y en el de contraseña sea diferente de un 1, si resulta valido llama a la ventana de principal y muestra
       * el menu para las demas ventanas sino muestra un error 
       * */
        private void Boton_Aceptar(object sender, EventArgs e)
        {   
                if (databaseconnection.login(text_usuario.Text, text_contrasena.Text) == -1)
                {

                    Principal p = new Principal();
                    p.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Contraseña incorrecta");
        }


        private void Cancelar_Sesion(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
