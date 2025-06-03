using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FahrtenbuchKlausur
{
    public partial class Form1 : Form
    {
        // Liste, die alle Fahrten speichert
        List<Fahrt> fahrtenListe = new List<Fahrt>();
        string dateiPfad = "Fahrtenbuch.csv"; // Pfad zur CSV-Datei, in der die Fahrten gespeichert werden
        int gesamtKm = 0; // Variable, die die Gesamtentfernung aller Fahrten speichert

        // Konstruktor der Form1-Klasse, der die Initialisierung der Komponenten durchführt
        public Form1()
        {
            InitializeComponent(); // Initialisiert die grafischen Komponenten der Form
            lblGesamtKm.Text = "Gesamtstrecke: " + gesamtKm + " km"; // Setzt den Text des Labels für die Gesamtstrecke auf 0 km
        }

        public void LadeFahrtenAusCSV(object sender, EventArgs e)
        {
            if (File.Exists(dateiPfad))
            {
                var zeilen = File.ReadAllLines(dateiPfad); // Liest alle Zeilen der CSV-Datei
                foreach (var zeile in zeilen) // Iteriert über jede Zeile in der CSV-Datei
                {
                    var fahrt = Fahrt.FromCSV(zeile); // Wandelt jede Zeile in ein Fahrt-Objekt um
                    fahrtenListe.Add(fahrt); // Fügt das Fahrt-Objekt der Liste hinzu
                    listBoxStrecken.Items.Add(fahrt); // Fügt die Fahrt zur ListBox hinzu
                }
            }
        }

        // Speichert die aktuelle Fahrt in der Liste und in der CSV-Datei
        public void SpeichereFahrtenInCSV()
        {
            var alleZeilen = fahrtenListe.Select(f => f.ToCSV()); // Wandelt jede Fahrt in eine CSV-Zeile um
            File.WriteAllLines(dateiPfad, alleZeilen); // Schreibt alle Zeilen in die CSV-Datei
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Fahrt neueFahrt = new Fahrt
            {
                Stadt = txtStadt.Text, // Liest die Stadt aus dem Textfeld
                Bundesland = txtBundesland.Text, // Liest das Bundesland aus dem Textfeld
                Entfernung = int.Parse(txtEntfernung.Text) // Liest die Entfernung aus dem Textfeld und konvertiert sie in einen Integer
            };

            fahrtenListe.Add(neueFahrt); // Fügt die neue Fahrt der Liste hinzu
            listBoxStrecken.Items.Add(neueFahrt); // Fügt die neue Fahrt zur ListBox hinzu

            SpeichereFahrtenInCSV(); // Speichert die Fahrten in der CSV-Datei

            txtStadt.Clear(); // Leert das Textfeld für die Stadt
            txtBundesland.Clear(); // Leert das Textfeld für das Bundesland
            txtEntfernung.Clear(); // Leert das Textfeld für die Entfernung
        }

        // Methode zum Laden der Fahrten aus der CSV-Datei beim Laden des Formulars
        private void Form1_Load(object sender, EventArgs e)
        {
            LadeFahrtenAusCSV(sender, e); // Lädt die Fahrten aus der CSV-Datei beim Laden des Formulars
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            if (listBoxStrecken.SelectedItem is Fahrt ausgewaehlt && int.TryParse(txtAnzahl.Text, out int anzahl))
            {
                int strecke = ausgewaehlt.Entfernung * anzahl; // Berechnet die Strecke basierend auf der ausgewählten Fahrt und der Anzahl der Fahrten
                listBoxGesamtstrecke.Items.Add($"{ausgewaehlt.Stadt} - {ausgewaehlt.Entfernung} km x {anzahl} ={strecke} km"); // Fügt die berechnete Strecke zur ListBox hinzu
                gesamtKm += strecke; // Addiert die berechnete Strecke zur Gesamtstrecke
                lblGesamtKm.Text = $"Gesamtstrecke: {gesamtKm} km"; // Aktualisiert das Label mit der Gesamtstrecke
            }
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            listBoxGesamtstrecke.Items.Clear(); // Leert die ListBox für die Gesamtstrecke
            gesamtKm = 0; // Setzt die Gesamtstrecke zurück
            lblGesamtKm.Text = "Gesamtstrecke: 0 km"; // Setzt das Label für die Gesamtstrecke zurück
        }
    }
}

