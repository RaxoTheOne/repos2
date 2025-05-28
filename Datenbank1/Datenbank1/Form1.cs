using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datenbank1
{
    public partial class Form1 : Form
    {
        private Datenbank db = new Datenbank(); // Instanz der Datenbankklasse
        private List<Warengruppe> liWaGr = new List<Warengruppe>(); // Liste f�r Warengruppen
        private List<Artikel> liArt = new List<Artikel>(); // Liste f�r Artikel

        public Form1()
        {
            InitializeComponent(); // Initialisierung der Form
            wgAnzeigen(); // Anzeige der Warengruppen beim Start der Anwendung
            artAnzeigen(); // Anzeige der Artikel beim Start der Anwendung
        }

        // Anzeige der Warengruppen in der ListBox und ComboBox
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

        // Abspeichern der Warengruppe
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

        // L�schen der Warengruppe
        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int index = listBoxWarengruppe.SelectedIndex;
            if (index != -1)
            {
                index = liWaGr[index].WgNr;
                db.deleteWarengruppe(index);
                MessageBox.Show("Warengruppe wurde gel�scht.");
                wgAnzeigen();
            }
            else
            {
                MessageBox.Show("Bitte w�hlen Sie eine Warengruppe zum L�schen aus.");
            }
            wgAnzeigen();
        }

        // Anzeige der Artikel in der ListBox
        public void artAnzeigen()
        {
            liArt = db.getArtikel(); // Artikel aus der Datenbank abrufen
            listBoxArtikel.Items.Clear(); // ListBox leeren
            dgvArtikel.Rows.Clear(); // Grid-View leeren

            foreach (Artikel artikel in liArt) // Artikel durchlaufen
            {
                listBoxArtikel.Items.Add(artikel.ArtikelBezeichnung); // Artikelbezeichnung in ListBox hinzuf�gen

                // Gruppenbezeichnung suchen
                int wgIndex = liWaGr.FindIndex(wg => wg.WgNr == artikel.ArtWg); // Warengruppe anhand der Nummer finden
                string wgbezeichnung = liWaGr[wgIndex].WgBezeichnung; // Warengruppe Bezeichnung

                // Grid-View f�r Artikel f�llen
                dgvArtikel.Rows.Add( // Spalte f�r Artikel hinzuf�gen
                    artikel.ArtikelNr, // Spalte 0: Artikelnummer
                    artikel.ArtikelBezeichnung, // Spalte 1: Artikelbezeichnung
                    artikel.ArtikelPreis, // Spalte 2: Artikelpreis
                    artikel.ArtLagerbestand, // Spalte 3: Lagerbestand
                    wgbezeichnung); // Spalte 4: Warengruppe Bezeichnung
            }
        }

        // Abspeichern oder Bearbeiten des Artikels mittels if-else Bedingung
        private void btnArtikelSpeichern_Click(object sender, EventArgs e)
        {
            try // Versuch, die Eingaben zu speichern
            {
                if (listBoxArtikel.SelectedIndex == -1) // wenn kein Artikel ausgew�hlt ist, dann wird ein neuer Artikel erstellt
                {
                    Artikel a = new Artikel(-1, txtArtikelBezeichnung.Text, Double.Parse(txtArtikelPreis.Text),
                    int.Parse(txtArtLagerbestand.Text), liWaGr[cbWarengruppe.SelectedIndex].WgNr);
                    db.saveArtikel(a);
                }
                else // wenn ein Artikel ausgew�hlt ist, dann wird dieser bearbeitet
                {
                    int index = listBoxArtikel.SelectedIndex;
                    index = liArt[index].ArtikelNr;
                    Artikel a = new Artikel(index, txtArtikelBezeichnung.Text, Double.Parse(txtArtikelPreis.Text),
                    int.Parse(txtArtLagerbestand.Text), liWaGr[cbWarengruppe.SelectedIndex].WgNr);
                    db.saveArtikel(a);
                }
                artAnzeigen(); // Artikel anzeigen aktualisieren

                // Eingabefelder leeren
                txtArtikelBezeichnung.Clear();
                txtArtikelPreis.Clear();
                txtArtLagerbestand.Clear();
                cbWarengruppe.SelectedIndex = -1;
            }
            catch (Exception ex) // Fehlerbehandlung
            {
                MessageBox.Show("Fehler beim Speichern des Artikels: " + ex.Message);
            }
        }

        // L�schen des ausgew�hlten Artikels
        private void btnArtikelLoeschen_Click(object sender, EventArgs e)
        {
            int index = listBoxArtikel.SelectedIndex; // Index des ausgew�hlten Artikels in der ListBox ermitteln
            if (index != 1) // Wenn ein Artikel ausgew�hlt ist
            {
                index = liArt[index].ArtikelNr;
                db.deleteArtikel(index);
                artAnzeigen();
            }
            else // Wenn kein Artikel ausgew�hlt ist
            {
                MessageBox.Show("Bitte w�hlen Sie einen Artikel zum L�schen aus.");
            }
        }

        // Ereignisbehandlung f�r die ListBox Warengruppe
        private void listBoxWarengruppe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbpWarengruppe.Text = liWaGr[listBoxWarengruppe.SelectedIndex].WgBezeichnung;
        }

        // Ereignisbehandlung f�r die ListBox Artikel
        private void listBoxArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArtikelBezeichnung.Text = liArt[listBoxArtikel.SelectedIndex].ArtikelBezeichnung;
            txtArtikelPreis.Text = liArt[listBoxArtikel.SelectedIndex].ArtikelPreis.ToString();
            txtArtLagerbestand.Text = liArt[listBoxArtikel.SelectedIndex].ArtLagerbestand.ToString();
            cbWarengruppe.SelectedIndex = liWaGr.FindIndex(wg => wg.WgNr == liArt[listBoxArtikel.SelectedIndex].ArtWg);
            tbpArtikel.Text = liArt[listBoxArtikel.SelectedIndex].ArtikelBezeichnung;
        }
    }
}
