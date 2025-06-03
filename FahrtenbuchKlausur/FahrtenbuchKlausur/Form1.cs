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
        public Form1() // Konstruktor der Form1-Klasse, der die grafischen Komponenten initialisiert
        {
            InitializeComponent(); // Initialisiert die grafischen Komponenten der Form
            lblGesamtKm.Text = "Gesamtstrecke: 0km"; // Setzt den Text des Labels für die Gesamtstrecke auf 0 km
        }

        public void LadeFahrtenAusCSV(object sender, EventArgs e) // Methode zum Laden der Fahrten aus der CSV-Datei
        {
            // Überprüft, ob die CSV-Datei existiert, und lädt die Fahrten aus der Datei
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

        private void btnSpeichern_Click(object sender, EventArgs e) // Methode zum Speichern einer neuen Fahrt
        {
            // Überprüft, ob alle erforderlichen Felder ausgefüllt sind
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


        int gesamtsumme = 0; // Variable, die die Summe der Entfernungen aller Fahrten speichert
        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            // Überprüft, ob eine Fahrt in der ListBox ausgewählt ist
            if (listBoxStrecken.SelectedItem == null)
            {
                MessageBox.Show("Bitte zuerst eine Fahrt auswählen."); // Zeigt eine Fehlermeldung an, wenn keine Fahrt ausgewählt ist
                return; // Beendet die Methode, wenn keine Fahrt ausgewählt ist
            }

            // Überprüft, ob die Anzahl der Fahrten eingegeben wurde und ob sie eine gültige Zahl ist
            if (!int.TryParse(txtAnzahl.Text, out int anzahl) || anzahl <= 0)
            {
                // Überprüft, ob die eingegebene Anzahl eine gültige Zahl ist und größer als 0
                MessageBox.Show("Bitte eine gültige Anzahl eingeben."); // Zeigt eine Fehlermeldung an, wenn die Anzahl ungültig ist
                return; // Beendet die Methode, wenn die Anzahl ungültig ist
            }

            // Holt die ausgewählte Fahrt aus der ListBox
            Fahrt ausgewaehlt = (Fahrt)listBoxStrecken.SelectedItem; // Holt die ausgewählte Fahrt aus der ListBox

            // Berechnet die Teilstrecke und fügt sie zur ListBox für die Gesamtstrecke hinzu
            int teilstrecke = ausgewaehlt.Entfernung * anzahl; // Berechnet die Teilstrecke basierend auf der Entfernung der ausgewählten Fahrt und der Anzahl der Fahrten
            listBoxGesamtstrecke.Items.Add($"{ausgewaehlt} x {anzahl} = {teilstrecke} km"); // Fügt die berechnete Teilstrecke zur ListBox für die Gesamtstrecke hinzu

            // Aktualisiert die Gesamtsumme der Entfernungen
            gesamtsumme += teilstrecke; // Addiert die Teilstrecke zur Gesamtsumme
            lblGesamtKm.Text = $"Gesamtstrecke: {gesamtsumme} km"; // Aktualisiert das Label für die Gesamtstrecke mit der neuen Gesamtsumme


        }

        // Methode zum Zurücksetzen der ListBox und der Gesamtstrecke
        private void btnNeu_Click(object sender, EventArgs e) // Methode zum Zurücksetzen
        {
            listBoxGesamtstrecke.Items.Clear(); // Leert die ListBox für die Gesamtstrecke
            gesamtKm = 0; // Setzt die Gesamtstrecke zurück
            lblGesamtKm.Text = "Gesamtstrecke: 0 km"; // Setzt das Label für die Gesamtstrecke zurück
        }

        // Methode für ausgewählte Fahrt in der ListBox
        private void listBoxStrecken_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeigeAusgewaehlteFahrt();
        }

        // Methode zum Anzeigen der ausgewählten Fahrt in den Textfeldern
        private void ZeigeAusgewaehlteFahrt()
        {
            if (listBoxStrecken.SelectedItem is Fahrt f)
            {
                txtStadt.Text = f.Stadt; // Setzt das Textfeld für die Stadt auf den Namen der ausgewählten Fahrt
                txtBundesland.Text = f.Bundesland; // Setzt das Textfeld für das Bundesland auf das Bundesland der ausgewählten Fahrt
                txtEntfernung.Text = f.Entfernung.ToString(); // Setzt das Textfeld für die Entfernung auf die Entfernung der ausgewählten Fahrt
            }
        }
    }
}
