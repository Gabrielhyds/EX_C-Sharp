using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAMaiorValor
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblResultado.Text = "";

            txtValor1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, res;

            n1 = double.Parse(txtValor1.Text);
            n2 = double.Parse(txtValor2.Text);

            if(n1 > n2)
            {
                res = n1;
                lblResultado.Text = res.ToString();
            }
            else
            {
                res = n2;
                lblResultado.Text = res.ToString();
            }
            

        }
    }
}
