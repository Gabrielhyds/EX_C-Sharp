using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAantecessor
{
    public partial class Antecessor : Form
    {
        public Antecessor()
        {
            InitializeComponent();
        }

        private void Antecessor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            lblResultado.Text = "";

            txtValor.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor;

            valor = double.Parse(txtValor.Text);

            valor = valor - 1;

            lblResultado.Text = valor.ToString();
        }
    }
}
