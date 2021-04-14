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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int res = Convert.ToInt32(listBox1.Items[0]);
            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                res += Convert.ToInt32(listBox1.Items[i]);
            }
            textBox2.Text = res.ToString();
        }
    }
}
