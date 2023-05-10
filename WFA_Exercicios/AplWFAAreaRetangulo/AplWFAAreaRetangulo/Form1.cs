using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAAreaRetangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";

            lblResultado.Text = "";
            txtValor1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b, a,area;

            b = double.Parse(txtValor1.Text);
            a = double.Parse(txtValor2.Text);
            area = b * a;

            lblResultado.Text = area.ToString();

        }
    }
}
