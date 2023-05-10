using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";

            lblResultado.Text = "";
            txtN1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, media;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);
            n4 = double.Parse(txtN4.Text);

            media = (n1 + n2 + n3 + n4) / 4;

            lblResultado.Text = media.ToString();
        }
    }
}
