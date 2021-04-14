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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);

            int res = 0;

            do
            {
                res = b;
                b = a % b;
                a = res;
            } while (b != 0);

            textBox3.Text = Convert.ToString(res);
        }
    }
}
