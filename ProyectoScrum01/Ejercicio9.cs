﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoScrum01
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string[] pid = txtVector.Text.Split(',');
            var menor = pid.Min();
            foreach (string v in pid)
            {
                txtNumero.Text = menor;

            }
        }
    }
}
