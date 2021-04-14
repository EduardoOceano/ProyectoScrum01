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

        private void button7_Click(object sender, EventArgs e)
        {
            Ejercicio10 ejercicio10 = new Ejercicio10();
            ejercicio10.Show();
        }

        private void button01_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void button02_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void button03_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        private void button04_Click(object sender, EventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
        }

        private void button05_Click(object sender, EventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }

        private void button09_Click(object sender, EventArgs e)
        {
            Ejercicio9 ejercicio9 = new Ejercicio9();
            ejercicio9.Show();
        }
    }
}
