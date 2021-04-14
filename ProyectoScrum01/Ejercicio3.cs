using System;
using System.Windows.Forms;

namespace ProyectoScrum01
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        public static int division(int n1,int n2) {

            int dividendo = n1 - n2;
            int contador = 0;
            while (dividendo >= 0)
            {
                contador = contador + 1;
                dividendo = dividendo - n2;

            }
            return contador;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string numeroBase = txtBase.Text;
            int n1 = Int32.Parse(numeroBase);
            string numeroResta = txtNumeroResta.Text;
            int n2 = Int32.Parse(numeroResta);

            txtContador.Text = division(n1, n2) + "";


        }
    }
}
