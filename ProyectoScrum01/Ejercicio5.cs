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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }
        public static int sumaDigitos(int entero) {
            int resto = 0;
            while (entero % 10 != 0)
            {
                resto = entero % 10 + resto;
                entero = entero / 10;
            }
            return resto;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);
            textBox2.Text = sumaDigitos(numero) + "";
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {

        }
    }
}
