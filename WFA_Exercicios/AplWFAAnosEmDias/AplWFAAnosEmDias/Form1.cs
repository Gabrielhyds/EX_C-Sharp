using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAAnosEmDias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor3.Text = "";
            lblResultado.Text = "";
            txtValor1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ano, mes, dia, idade_em_dias;
            ano = double.Parse(txtValor1.Text);
            mes = double.Parse(txtValor2.Text);
            dia = double.Parse(txtValor3.Text);

            idade_em_dias = (ano * 365) + (mes * 30) + dia;

            lblResultado.Text = idade_em_dias.ToString();
        }
    }
}
