using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lager1
{
    public partial class Form1 : Form
    {
        List<Artikel> artikel = new List<Artikel>();

        public Form1()
        {
            InitializeComponent();
            holeListe();
        }

        public void holeListe()
        {
            artikel.Clear();
            Datei dt = new Datei();
            artikel = dt.leseCSV();
            listeAusgeben();
            AktualisiereLagerwert();
        }

        public void listeAusgeben()
        {
            lbLager.Items.Clear();
            foreach (Artikel l in artikel)
            {
                lbLager.Items.Add(l.LagerInfo());
            }
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArtikelNr.Text) ||
                string.IsNullOrWhiteSpace(txtBezeichnung.Text) ||
                string.IsNullOrWhiteSpace(txtPreis.Text) ||
                string.IsNullOrWhiteSpace(cbKategorien.Text) ||
                string.IsNullOrWhiteSpace(txtLagerbestand.Text))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.");
            }

            if (!int.TryParse(txtArtikelNr.Text, out int artikelNr))
            {
                MessageBox.Show("Artikelnummer muss eine Zahl sein.");
                return;
            }

            if (!double.TryParse(txtPreis.Text, out double preis))
            {
                MessageBox.Show("Preis muss eine Zahl sein.");
                return;
            }

            if (!int.TryParse(txtLagerbestand.Text, out int lagerBestand))
            {
                MessageBox.Show("Lagerbestand muss eine Zahl sein.");
                return;
            }

            string bezeichnung = txtBezeichnung.Text;
            string kategorie = cbKategorien.Text;

            Artikel l = new Artikel(artikelNr, bezeichnung, kategorie, preis, lagerBestand);

            artikel.Add(l);
            lbLager.Items.Add(l.LagerInfo());
            AktualisiereLagerwert();
            ClearTextfelder();

            // Felder zurücksetzen
            ClearTextfelder();
        }

        private void lbLager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLager.SelectedIndex == -1)
                return;

            btnHinzufuegen.Enabled = false;
            btnBearbeiten.Enabled = true;

            int index = lbLager.SelectedIndex;
            Artikel l = artikel[index];

            txtArtikelNr.Text = l.ArtikelNr.ToString();
            txtBezeichnung.Text = l.Bezeichnung;
            cbKategorien.Text = l.Kategorie;
            txtPreis.Text = l.Preis.ToString();
            txtLagerbestand.Text = l.Lagerbestand.ToString();
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if (lbLager.SelectedIndex == -1)
                return;

            if (!int.TryParse(txtArtikelNr.Text, out int neueArtikelNr))
            {
                MessageBox.Show("Artikelnummer muss eine Zahl sein.");
                return;
            }

            if (!double.TryParse(txtPreis.Text, out double neuerPreis))
            {
                MessageBox.Show("Preis muss eine Zahl sein.");
                return;
            }

            if (!int.TryParse(txtLagerbestand.Text, out int neuerLagerbestand))
            {
                MessageBox.Show("Lagerbestand muss eine Zahl sein.");
                return;
            }

            int index = lbLager.SelectedIndex;

            artikel[index].ArtikelNr = neueArtikelNr;
            artikel[index].Bezeichnung = txtBezeichnung.Text;
            artikel[index].Kategorie = cbKategorien.Text;
            artikel[index].Preis = neuerPreis;
            artikel[index].Lagerbestand = neuerLagerbestand;

            lbLager.Items[index] = artikel[index].LagerInfo();
            AktualisiereLagerwert();
            ClearTextfelder(); // Felder zurücksetzen

            btnHinzufuegen.Enabled = true;
            btnBearbeiten.Enabled = true;
            btnLoeschen.Enabled = false;
        }

        private void ClearTextfelder()
        {
            txtArtikelNr.Clear();
            txtBezeichnung.Clear();
            cbKategorien.Text = string.Empty;
            txtPreis.Clear();
            txtLagerbestand.Clear();
        }

        private void AktualisiereLagerwert()
        {

            double lagerwert = artikel.Sum(a => a.Preis * a.Lagerbestand);
            lblLagerwert.Text = $"Lagerwert: {lagerwert} €";
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int index = lbLager.SelectedIndex;
            if (index == -1)
            {

                MessageBox.Show("Bitte einen Artikel auswählen.");
                return;
            }

            artikel.RemoveAt(index);
            lbLager.Items.RemoveAt(index);
            AktualisiereLagerwert();
            ClearTextfelder();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Datei dt = new Datei();
            dt.schreibeCSV(artikel);
        }
    }
}
