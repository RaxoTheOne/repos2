using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoV04
{
    public partial class Form1 : Form
    {
        List<Auto> autos = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
            comboMarke.Items.AddRange(new string[] { "Audi", "BMW", "Mercedes", "Volkswagen" });
            comboMarke.SelectedIndex = 0;
            numBaujahr.Minimum = 1900;
            numBaujahr.Maximum = 2030;
            btnBearbeiten.Enabled = false;
            btnLoeschen.Enabled = false;
        }

        private void AktualisiereStatistik()
        {
            lblAnzahl.Text = $"Anzahl Autos: {autos.Count}";
            lblDurchschnitt.Text = autos.Count > 0 ? $"Ø Preis: {autos.Average(a => a.Preis):F2} €"
                : "Ø Preis: -";
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModell.Text) || !double.TryParse(txtPreis.Text, out double preis))
            {
                MessageBox.Show("Bitte gültige Werte eingeben.");
                return;
            }

            Auto a = new Auto(
                comboMarke.Text,
                txtModell.Text,
                (int)numBaujahr.Value,
                preis
            );

            autos.Add(a);
            listAutos.Items.Add(a.AutoInfo());
            AktualisiereStatistik();

            // Felder zurücksetzen
            txtModell.Clear();
            txtPreis.Clear();
            comboMarke.SelectedIndex = 0;
            numBaujahr.Value = 2000;
        }

        private void listAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAutos.SelectedIndex == -1)
                return;

            Auto ausgewaehlt = autos[listAutos.SelectedIndex];

            comboMarke.Text = ausgewaehlt.Marke;
            txtModell.Text = ausgewaehlt.Modellname;
            numBaujahr.Value = ausgewaehlt.Baujahr;
            txtPreis.Text = ausgewaehlt.Preis.ToString();

            btnBearbeiten.Enabled = true;
            btnLoeschen.Enabled = true;
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            int index = listAutos.SelectedIndex;
            if (index == -1)
                return;

            if (string.IsNullOrWhiteSpace(txtModell.Text) || !double.TryParse(txtPreis.Text, out double neuerPreis))
            {
                MessageBox.Show("Bitte gültige Werte eingeben.");
                return;
            }

            // Daten ändern
            Auto a = autos[index];
            a.Marke = comboMarke.Text;
            a.Modellname = txtModell.Text;
            a.Baujahr = (int)numBaujahr.Value;
            a.Preis = neuerPreis;

            // Anzeige aktualisieren
            listAutos.Items[index] = a.AutoInfo();
            AktualisiereStatistik();

            // Felder zurücksetzen
            listAutos.ClearSelected();
            btnBearbeiten.Enabled = false;
            btnLoeschen.Enabled = false;
        }
    }
}