﻿using System;
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
        public FormAddSale()
        {
            InitializeComponent();
        }

        private void buttonSClient_Click(object sender, EventArgs e)
        {
            FormSeekClient form = new FormSeekClient();
            form.Show();
        }

        private void buttonSAuto_Click(object sender, EventArgs e)
        {
            FormSeekCar form = new FormSeekCar();
            form.AccessFeatures += Features;
            form.Show();
        }

        /**
         * Enriquez Capetillo Gerardo Arturo
         * Metodo del delegado para asginar las caracteristicas del auto.
         * */
        private void Features(string serial, string name, string brand, string model, string price)
        {
            labelSerialNumber.Text = "Numero de serie: " + serial;
            labelCarName.Text = "Nombre: " + name;
            labelBrand.Text = "Marca: " + brand;
            labelModel.Text = "Modelo: " + model;
            labelPrice.Text = "Precio: " + price;
        }

        private void comboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxCredit.Enabled = false;
            if (comboBoxPaymentType.SelectedIndex == 1)
            {
                groupBoxCredit.Enabled = true;
            }
        }
    }
}
