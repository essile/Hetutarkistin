namespace Hetutarkistin
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
            this.lbOtsikko = new System.Windows.Forms.Label();
            this.lbSelite = new System.Windows.Forms.Label();
            this.txtHetu = new System.Windows.Forms.TextBox();
            this.bTarkistaHetu = new System.Windows.Forms.Button();
            this.txtTuloste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbOtsikko
            // 
            this.lbOtsikko.AutoSize = true;
            this.lbOtsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtsikko.Location = new System.Drawing.Point(16, 17);
            this.lbOtsikko.Name = "lbOtsikko";
            this.lbOtsikko.Size = new System.Drawing.Size(317, 16);
            this.lbOtsikko.TabIndex = 0;
            this.lbOtsikko.Text = "Suomalaisen henkilötunnuksen tarkistaminen";
            // 
            // lbSelite
            // 
            this.lbSelite.AutoSize = true;
            this.lbSelite.Location = new System.Drawing.Point(16, 33);
            this.lbSelite.Name = "lbSelite";
            this.lbSelite.Size = new System.Drawing.Size(350, 13);
            this.lbSelite.TabIndex = 1;
            this.lbSelite.Text = "Syötä tähän suomalainen henkilötunnus ja kerromme, onko se todellinen.";
            // 
            // txtHetu
            // 
            this.txtHetu.Location = new System.Drawing.Point(19, 61);
            this.txtHetu.Name = "txtHetu";
            this.txtHetu.Size = new System.Drawing.Size(183, 20);
            this.txtHetu.TabIndex = 2;
            this.txtHetu.TextChanged += new System.EventHandler(this.txtHetu_TextChanged);
            // 
            // bTarkistaHetu
            // 
            this.bTarkistaHetu.Location = new System.Drawing.Point(209, 59);
            this.bTarkistaHetu.Name = "bTarkistaHetu";
            this.bTarkistaHetu.Size = new System.Drawing.Size(124, 23);
            this.bTarkistaHetu.TabIndex = 3;
            this.bTarkistaHetu.Text = "Tarkista hetu";
            this.bTarkistaHetu.UseVisualStyleBackColor = true;
            this.bTarkistaHetu.Click += new System.EventHandler(this.bTarkistaHetu_Click);
            // 
            // txtTuloste
            // 
            this.txtTuloste.Location = new System.Drawing.Point(19, 100);
            this.txtTuloste.Name = "txtTuloste";
            this.txtTuloste.Size = new System.Drawing.Size(347, 20);
            this.txtTuloste.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 143);
            this.Controls.Add(this.txtTuloste);
            this.Controls.Add(this.bTarkistaHetu);
            this.Controls.Add(this.txtHetu);
            this.Controls.Add(this.lbSelite);
            this.Controls.Add(this.lbOtsikko);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOtsikko;
        private System.Windows.Forms.Label lbSelite;
        private System.Windows.Forms.TextBox txtHetu;
        private System.Windows.Forms.Button bTarkistaHetu;
        private System.Windows.Forms.TextBox txtTuloste;
    }
}

