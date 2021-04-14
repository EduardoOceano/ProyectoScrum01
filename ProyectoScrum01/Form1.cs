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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio7_Click(object sender, EventArgs e)
        {
            Ejercicio7 ejercicio7 = new Ejercicio7();
            ejercicio7.Show();
        }

        private void btnEjercicio8_Click(object sender, EventArgs e)
        {

            Ejercicio8 ejercicio8 = new Ejercicio8();
            ejercicio8.Show();
        }

        private void btnEjercicio6_Click(object sender, EventArgs e)
        {
            Ejercicio6 ejercicio6 = new Ejercicio6();
            ejercicio6.Show();
        }
    }
}
