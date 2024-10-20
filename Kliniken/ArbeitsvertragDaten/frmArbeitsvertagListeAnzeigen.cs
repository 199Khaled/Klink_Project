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
    public partial class frmArbeitsvertagListeAnzeigen : Form
    {
        DataTable _dtVertrag;
         BindingSource  _bidingsource;
        public frmArbeitsvertagListeAnzeigen()
        {
            InitializeComponent();
            _bidingsource = new BindingSource();
        }

        private void _ladeAllAbteilungen()
        {
            DataTable dtAbteilung = clsAbteilungDaten.GetAllAbteilungen();
            cbFilterWert.Items.Clear();

            cbFilterWert.Items.Add("Allgemein");
            if (dtAbteilung != null)
            {
                foreach (DataRow zeile in dtAbteilung.Rows)
                {
                    cbFilterWert.Items.Add(zeile["Abteilungname"]);
                }
            }
            cbFilterWert.SelectedIndex = 0;
        }

        private void _DataGridViewEinrichten()
        {
            _dtVertrag = clsArbeitsVertragDaten.GetArbeitsvertrag_View();

            _bidingsource.DataSource = _dtVertrag;
            datagvArbeitsvertrag.DataSource = _bidingsource;

            if(datagvArbeitsvertrag.Rows.Count > 0)
            {
                datagvArbeitsvertrag.Columns[0].Width = 100;
                datagvArbeitsvertrag.Columns[2].Width = 270;
                datagvArbeitsvertrag.Columns[3].Width = 150;
                datagvArbeitsvertrag.Columns[4].Width = 200;
                datagvArbeitsvertrag.Columns[5].Width = 150;
                datagvArbeitsvertrag.Columns[8].Width = 150;
     
            }
        }
        private void frmArbeitsvertagListeAnzeigen_Load(object sender, EventArgs e)
        {
            _ladeAllAbteilungen();
            _DataGridViewEinrichten();
        }

        private void _ResourcenFreigeben()
        {
            _bidingsource.Dispose();
        }

        private void cbFilterWert_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbFilterWert.Text == "Allgemein")
            {
                _bidingsource.Filter = string.Empty;
                return;
            }

            // Holen des ausgewählten Spaltennamens
            string filterwert= cbFilterWert.SelectedItem as string;
            _bidingsource.Filter = $"Abteilungname Like '{filterwert}%'";


        }
    }
}
