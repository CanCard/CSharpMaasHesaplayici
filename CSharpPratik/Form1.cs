using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPratik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maas = Convert.ToDouble(textBox1.Text.Replace(".", ","));
            double zam = Convert.ToDouble(textBox2.Text.Replace(".", ","));
            double prim = Convert.ToDouble(textBox3.Text.Replace(".", ","));

            double zamMiktari = (maas * zam) / 100;
            double yeniMaas = maas + zamMiktari + prim;

            label6.Text = zamMiktari.ToString();
            label7.Text = yeniMaas.ToString();
        }
    }
}
