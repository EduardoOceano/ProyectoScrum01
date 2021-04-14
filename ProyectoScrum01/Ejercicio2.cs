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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent(); 
        }
        public static int potencia(int bas, int exponente) {
            if (exponente == 0)
            {
                return 1;
            }
            else {
                return bas * potencia(bas, exponente - 1);
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas = Convert.ToInt32(textBox1.Text);
            int exponente = Convert.ToInt32(textBox2.Text);
            int resultado = potencia(bas,exponente);
            string resultadoFinal = resultado + "";
            textBox3.Text = resultadoFinal;

        }
    }
}
