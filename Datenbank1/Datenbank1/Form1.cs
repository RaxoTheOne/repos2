using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datenbank1
{
    public partial class Form1 : Form
    {
        private Datenbank db = new Datenbank();
        private List<Warengruppe> liWaGr = new List<Warengruppe>();
        private List<Artikel> liArt = new List<Artikel>();

        public Form1()
        {
            InitializeComponent();
            wgAnzeigen();
            artAnzeigen();
        }

        private void wgAnzeigen()
        {
            liWaGr = db.getWarengruppe();
            listBoxWarengruppe.Items.Clear();
            cbWarengruppe.Items.Clear();
            foreach (Warengruppe wg in liWaGr)
            {
                listBoxWarengruppe.Items.Add(wg.WgBezeichnung);
                cbWarengruppe.Items.Add(wg.WgBezeichnung);
            }
        }


        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            int index = listBoxWarengruppe.SelectedIndex;
            if (index != -1)
            {
                index = liWaGr[index].WgNr;
            }

            Warengruppe wg = new Warengruppe(index, txtWarengruppe.Text);
            db.saveWarengruppe(wg);
            wgAnzeigen();
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int index = listBoxWarengruppe.SelectedIndex;
            if (index != -1)
            {
                index = liWaGr[index].WgNr;
                db.deleteWarengruppe(index);
                MessageBox.Show("Warengruppe wurde gelöscht.");
                wgAnzeigen();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Warengruppe zum Löschen aus.");
            }
            wgAnzeigen();
        }

        public void artAnzeigen()
        {
            liArt = db.getArtikel();
            listBoxArtikel.Items.Clear();

            foreach (Artikel artikel in liArt)
            {
                listBoxArtikel.Items.Add(artikel.ArtikelBezeichnung);
            }
        }

        private void btnArtikelSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                Artikel a = new Artikel(0, txtArtikelBezeichnung.Text, Double.Parse(txtArtikelPreis.Text), int.Parse(txtArtLagerbestand.Text), liWaGr[cbWarengruppe.SelectedIndex].WgNr);
                db.saveArtikel(a);
                artAnzeigen();

                // Eingabefelder leeren
                txtArtikelBezeichnung.Clear();
                txtArtikelPreis.Clear();
                txtArtLagerbestand.Clear();
                cbWarengruppe.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern des Artikels: " + ex.Message);
            }
        }

        private void btnArtikelLoeschen_Click(object sender, EventArgs e)
        {
            int index = listBoxArtikel.SelectedIndex;
            if (index != 1)
            {
                index = liArt[index].ArtikelNr;
                db.deleteArtikel(index);
                artAnzeigen();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Artikel zum Löschen aus.");
            }
        }

        private void listBoxWarengruppe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbpWarengruppe.Text = liWaGr[listBoxWarengruppe.SelectedIndex].WgBezeichnung;
        }

        private void listBoxArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbpArtikel.Text = liArt[listBoxArtikel.SelectedIndex].ArtikelBezeichnung;
        }

        private void btnEinlesen_Click(object sender, EventArgs e)
        {
            artAnzeigen();
        }
    }
}
