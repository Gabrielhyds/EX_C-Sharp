using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFARevendedoraDeCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario, comissao, carro, vendas;
            
            carro = double.Parse(txtValor1.Text);
            vendas = double.Parse(txtValor2.Text);
            comissao = double.Parse(txtValor3.Text);

            salario = comissao + (comissao * carro) + (vendas * 0.05);

            lblResultado.Text = salario.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            txtValor3.Text = "";
            lblResultado.Text = "";
            txtValor1.Focus();
        }
    }
}
