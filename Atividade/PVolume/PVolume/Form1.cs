using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double verify1, verify2;

            if ((double.TryParse(textBox1.Text, out verify1)) &&
                (double.TryParse(textBox2.Text, out verify2)))
            {
                double soma = (Math.PI * (verify1 * verify1)) * verify2;
                textBox3.Text = soma.ToString("N2");

            }

            else
                MessageBox.Show("Dados Invalidos");
                

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
