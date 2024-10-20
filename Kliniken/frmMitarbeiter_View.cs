using KlinkDatenSchicht;
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
    public partial class frmMitarbeiter_View : Form
    {
        DataTable _dtMitarbeiterView;
        string _vollname = string.Empty;
        public frmMitarbeiter_View(string vollname)
        {
            InitializeComponent();
            this._vollname = vollname;
        }

        private void _DataGridViewEinrichten()
        {
            _dtMitarbeiterView = clsMitarbeiterDaten.GetMitarbeiterByPersonVollname(_vollname);
            dgvMitarbeiter_View.DataSource = _dtMitarbeiterView;
        }

        private void frmMitarbeiter_View_Load(object sender, EventArgs e)
        {
            _DataGridViewEinrichten();
        }
    }
}
