using System;
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
            int[] v2 = new int[pid.Length];

            for (int v = 0; v < pid.Length; v++)
            {
                v2[v] = int.Parse(pid[v]);


            }
            var menor = v2.Min();
            txtNumero.Text = menor.ToString();
        }
    }
}
