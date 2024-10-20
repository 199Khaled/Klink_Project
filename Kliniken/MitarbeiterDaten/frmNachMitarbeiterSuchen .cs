using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmNachMitarbeiterSuchen : Form
    {
        public frmNachMitarbeiterSuchen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vollname = txtMitarbietVollname.Text.Trim();

            if (string.IsNullOrEmpty(vollname))
            {
                MessageBox.Show("Bitte geben Sie den Vollname in den Eingabefeld ein!");
                return;
            }

            frmMitarbeiter_View frm = new frmMitarbeiter_View(vollname);
            frm.ShowDialog();
            frm.Dispose();
         
        }

    
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

 
    }
}
