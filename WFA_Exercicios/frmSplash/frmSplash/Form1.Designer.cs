
namespace frmSplash
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.pgbTermometro = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tmrTempo
            // 
            this.tmrTempo.Enabled = true;
            this.tmrTempo.Interval = 500;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // pgbTermometro
            // 
            this.pgbTermometro.Location = new System.Drawing.Point(-1, 493);
            this.pgbTermometro.Name = "pgbTermometro";
            this.pgbTermometro.Size = new System.Drawing.Size(576, 42);
            this.pgbTermometro.TabIndex = 0;
            this.pgbTermometro.Click += new System.EventHandler(this.pgbTermometro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmSplash.Properties.Resources.ae9a889bdd2a489862b6314399c84b45;
            this.ClientSize = new System.Drawing.Size(575, 533);
            this.Controls.Add(this.pgbTermometro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.ProgressBar pgbTermometro;
    }
}

