﻿using KlinkDatenSchicht;
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
    public partial class ctrMitarbeiterEinfügen : UserControl
    {
        public ctrMitarbeiterEinfügen()
        {
            InitializeComponent();
        }
      

        clsMitarbeiterDaten _mitarbeiter;

        // Definiere einen Mitarbeiter Evenhanlder
        public event Action<int> OnMitarbeiterSelectedID;
        protected virtual void MitarbeiterSelected(int MitarbeiterID)
        {
            Action<int> handler = OnMitarbeiterSelectedID;
            if (handler != null)
            {
                handler(MitarbeiterID);
            }
            //if (OnMitarbeiterSelectedID != null)
            //{
            //    OnMitarbeiterSelectedID(MitarbeiterID); // Freigabe der MitarbeiterID beim Auslösen des Ereignis.
            //}
        }

        private void ctrMitarbeiterEinfügen_Load(object sender, EventArgs e)
        {
            lblErstelltBeiUser.Text = clsGlobaleKlasse.BenutzerDaten.BenutzerID.ToString();
        }

        private void _LoadVersicherungenDaten()
        {
            DataTable dtVersicherungen = clsVersicherungDaten.GetAllVersicherungen();

            cbVersichertBei.Items.Clear();

            if (dtVersicherungen != null)
            {
                foreach (DataRow row in dtVersicherungen.Rows)
                {
                    cbVersichertBei.Items.Add(row["VersicherungsName"]);
                }
            }
            cbVersichertBei.SelectedIndex = 0;
        }


        public void AddNew(bool IsModeAddNew, int PersonID)
        {
            _ResetDefaultValue();

            if (IsModeAddNew)
            {
                _mitarbeiter = new clsMitarbeiterDaten();
                lblPersonID.Text = PersonID.ToString();
            }
        }

        private void _ResetDefaultValue()
        {
            lblPersonID.Text = "[???]";
            lblMitarbeiterID.Text = "[???]";
            lblErstelltBeiUser.Text = "[?????]";

            txtSteuerID.Text = _ErzeugeSteuerID();

            cbMitarbeiterZustand.SelectedIndex = 0;
            dtpEingestelltAm.Value = DateTime.Now.Date;
            txtGefeuertAm.Clear();
 

            _LoadVersicherungenDaten();
       
            //lblErstelltBeiUser.Text = clsGlobaleKlasse.BenutzerDaten.Rollenname;
        }

        private string _ErzeugeSteuerID()
        {
            Random zufälligezahl = new Random();
            string steuerID = "";
            
            for(int i = 0; i < 11; i++)
            {
                steuerID += zufälligezahl.Next(0, 10);
            }
            return steuerID;
        }
        private void _FillMitarbeiterWithData()
        {  
            _mitarbeiter.PersonID = Convert.ToInt32(lblPersonID.Text);
            _mitarbeiter.VersicherungsID = clsVersicherungDaten.Find(cbVersichertBei.SelectedItem as string).VersicherungID;
            _mitarbeiter.SteuerID = txtSteuerID.Text;
            _mitarbeiter.EingestelltAm = dtpEingestelltAm.Value.Date;
            _mitarbeiter.GefeuertAm = txtGefeuertAm.Text;

            //nur zum Testen habe ich die Userspalte auf User3 gesetzt 
            _mitarbeiter.EingestelltBeiUser = clsGlobaleKlasse.BenutzerDaten.BenutzerID; 
            _mitarbeiter.Zustand = cbMitarbeiterZustand.SelectedItem as string;
        }

        public void LoadMitarbeiterDataByPersonID(int PersonID)
        {
            _ResetDefaultValue();

            _mitarbeiter = clsMitarbeiterDaten.FindByPersonID(PersonID);
            if (_mitarbeiter != null)
            {
                lblPersonID.Text = _mitarbeiter.PersonID.ToString();
                lblMitarbeiterID.Text = _mitarbeiter.MitarbeiterID.ToString();
                lblErstelltBeiUser.Text = clsBenutzerDaten.Find(_mitarbeiter.EingestelltBeiUser).Rollenname;
                txtSteuerID.Text = _mitarbeiter.SteuerID;
                cbVersichertBei.SelectedItem = clsVersicherungDaten.Find(_mitarbeiter.VersicherungsID).VersicherungsName;
      
                dtpEingestelltAm.Value = _mitarbeiter.EingestelltAm;
                txtGefeuertAm.Text = _mitarbeiter.GefeuertAm;
                cbMitarbeiterZustand.Text = _mitarbeiter.Zustand;
            }
            else
            {
                MessageBox.Show("Mitarbeiter mit der PersonID [ " + PersonID + " ] konnte im System nicht " +
                    "gefunden werden", "Fhelermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadMitarbeiterDataByMitarbeiterID(int MitarbeiterID)
        {
            _ResetDefaultValue();

            _mitarbeiter = clsMitarbeiterDaten.Find(MitarbeiterID);
            if (_mitarbeiter != null)
            {
                lblPersonID.Text = _mitarbeiter.PersonID.ToString();
                lblMitarbeiterID.Text = _mitarbeiter.MitarbeiterID.ToString();
                lblErstelltBeiUser.Text = clsBenutzerDaten.Find(_mitarbeiter.EingestelltBeiUser).Rollenname;
                txtSteuerID.Text = _mitarbeiter.SteuerID;
                cbVersichertBei.SelectedItem = clsVersicherungDaten.Find(_mitarbeiter.VersicherungsID).VersicherungsName;

                dtpEingestelltAm.Value = _mitarbeiter.EingestelltAm;
                txtGefeuertAm.Text = _mitarbeiter.GefeuertAm;
                cbMitarbeiterZustand.Text = _mitarbeiter.Zustand;
            }
            else
            {
                MessageBox.Show("Mitarbeiter mit der MitarbeiterID [ " + MitarbeiterID + " ] konnte im System nicht " +
                    "gefunden werden", "Fhelermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool MitarbeiterDatenSpeichern()
        {
            if (lblPersonID.Text == "[???]")
            {
                MessageBox.Show("Für welche PersonID möchten Sie die Daten hinzufügen!!", "Fehlende Angaben",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;
            }
            _FillMitarbeiterWithData();

            if (_mitarbeiter.Save())
            {
                lblMitarbeiterID.Text = _mitarbeiter.MitarbeiterID.ToString();
                if(OnMitarbeiterSelectedID != null)
                {
                    MitarbeiterSelected(_mitarbeiter.MitarbeiterID);
                }
                return true;
            }
            return false ;
        }
        private void txtSteuerID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSteuerID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSteuerID, "Die SteuerID muss noch angegeben werden");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSteuerID, null);
            }
        }

        private void gbMitarbeiterInfo_Enter(object sender, EventArgs e)
        {       
      
        }
    }
}
