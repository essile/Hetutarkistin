using System;
using System.Windows.Forms;

namespace Hetutarkistin
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHetu_TextChanged(object sender, EventArgs e)
        {
            // hetuboksi
        }

        private void bTarkistaHetu_Click(object sender, EventArgs e)
        {
            string kokoHetu = txtHetu.Text;
            string virheilmoitus;

            bool ok = TarkistaHenkilotunnus.TarkistaHetu(kokoHetu, out virheilmoitus);
            if (ok)
                txtTuloste.Text = "Henkilötunnus on oikea.";
            else
                txtTuloste.Text = "Henkilötunnus ei ole aito. " + virheilmoitus;

        }
    }
}
