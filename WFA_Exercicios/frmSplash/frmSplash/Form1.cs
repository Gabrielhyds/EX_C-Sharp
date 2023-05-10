using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSplash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            if (pgbTermometro.Value == 100)
            {
                tmrTempo.Enabled = false;
                this.Hide();
                frmLogin objTela = new frmLogin();
                objTela.ShowDialog();
            }
            else
            {
                this.Opacity += 0.1;
                pgbTermometro.Value += 10;
            }
        }

        private void pgbTermometro_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
