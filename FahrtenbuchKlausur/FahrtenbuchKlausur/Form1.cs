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

        // Konstruktor der Form1-Klasse, der die Initialisierung der Komponenten durchf�hrt
        public Form1() // Konstruktor der Form1-Klasse, der die grafischen Komponenten initialisiert
        {
            InitializeComponent(); // Initialisiert die grafischen Komponenten der Form
            lblGesamtKm.Text = "Gesamtstrecke: 0km"; // Setzt den Text des Labels f�r die Gesamtstrecke auf 0 km
        }

        public void LadeFahrtenAusCSV(object sender, EventArgs e) // Methode zum Laden der Fahrten aus der CSV-Datei
        {
            // �berpr�ft, ob die CSV-Datei existiert, und l�dt die Fahrten aus der Datei
            if (File.Exists(dateiPfad))
            {
                var zeilen = File.ReadAllLines(dateiPfad); // Liest alle Zeilen der CSV-Datei
                foreach (var zeile in zeilen) // Iteriert �ber jede Zeile in der CSV-Datei
                {
                    var fahrt = Fahrt.FromCSV(zeile); // Wandelt jede Zeile in ein Fahrt-Objekt um
                    fahrtenListe.Add(fahrt); // F�gt das Fahrt-Objekt der Liste hinzu
                    listBoxStrecken.Items.Add(fahrt); // F�gt die Fahrt zur ListBox hinzu
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
            // �berpr�ft, ob alle erforderlichen Felder ausgef�llt sind
            Fahrt neueFahrt = new Fahrt
            {
                Stadt = txtStadt.Text, // Liest die Stadt aus dem Textfeld
                Bundesland = txtBundesland.Text, // Liest das Bundesland aus dem Textfeld
                Entfernung = int.Parse(txtEntfernung.Text) // Liest die Entfernung aus dem Textfeld und konvertiert sie in einen Integer
            };

            fahrtenListe.Add(neueFahrt); // F�gt die neue Fahrt der Liste hinzu
            listBoxStrecken.Items.Add(neueFahrt); // F�gt die neue Fahrt zur ListBox hinzu

            SpeichereFahrtenInCSV(); // Speichert die Fahrten in der CSV-Datei

            txtStadt.Clear(); // Leert das Textfeld f�r die Stadt
            txtBundesland.Clear(); // Leert das Textfeld f�r das Bundesland
            txtEntfernung.Clear(); // Leert das Textfeld f�r die Entfernung 
        }

        // Methode zum Laden der Fahrten aus der CSV-Datei beim Laden des Formulars
        private void Form1_Load(object sender, EventArgs e)
        {
            LadeFahrtenAusCSV(sender, e); // L�dt die Fahrten aus der CSV-Datei beim Laden des Formulars
        }


        int gesamtsumme = 0; // Variable, die die Summe der Entfernungen aller Fahrten speichert
        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            // �berpr�ft, ob eine Fahrt in der ListBox ausgew�hlt ist
            if (listBoxStrecken.SelectedItem == null)
            {
                MessageBox.Show("Bitte zuerst eine Fahrt ausw�hlen."); // Zeigt eine Fehlermeldung an, wenn keine Fahrt ausgew�hlt ist
                return; // Beendet die Methode, wenn keine Fahrt ausgew�hlt ist
            }

            // �berpr�ft, ob die Anzahl der Fahrten eingegeben wurde und ob sie eine g�ltige Zahl ist
            if (!int.TryParse(txtAnzahl.Text, out int anzahl) || anzahl <= 0)
            {
                // �berpr�ft, ob die eingegebene Anzahl eine g�ltige Zahl ist und gr��er als 0
                MessageBox.Show("Bitte eine g�ltige Anzahl eingeben."); // Zeigt eine Fehlermeldung an, wenn die Anzahl ung�ltig ist
                return; // Beendet die Methode, wenn die Anzahl ung�ltig ist
            }

            // Holt die ausgew�hlte Fahrt aus der ListBox
            Fahrt ausgewaehlt = (Fahrt)listBoxStrecken.SelectedItem; // Holt die ausgew�hlte Fahrt aus der ListBox

            // Berechnet die Teilstrecke und f�gt sie zur ListBox f�r die Gesamtstrecke hinzu
            int teilstrecke = ausgewaehlt.Entfernung * anzahl; // Berechnet die Teilstrecke basierend auf der Entfernung der ausgew�hlten Fahrt und der Anzahl der Fahrten
            listBoxGesamtstrecke.Items.Add($"{ausgewaehlt} x {anzahl} = {teilstrecke} km"); // F�gt die berechnete Teilstrecke zur ListBox f�r die Gesamtstrecke hinzu

            // Aktualisiert die Gesamtsumme der Entfernungen
            gesamtsumme += teilstrecke; // Addiert die Teilstrecke zur Gesamtsumme
            lblGesamtKm.Text = $"Gesamtstrecke: {gesamtsumme} km"; // Aktualisiert das Label f�r die Gesamtstrecke mit der neuen Gesamtsumme


        }

        // Methode zum Zur�cksetzen der ListBox und der Gesamtstrecke
        private void btnNeu_Click(object sender, EventArgs e) // Methode zum Zur�cksetzen
        {
            listBoxGesamtstrecke.Items.Clear(); // Leert die ListBox f�r die Gesamtstrecke
            gesamtKm = 0; // Setzt die Gesamtstrecke zur�ck
            lblGesamtKm.Text = "Gesamtstrecke: 0 km"; // Setzt das Label f�r die Gesamtstrecke zur�ck
        }

        // Methode f�r ausgew�hlte Fahrt in der ListBox
        private void listBoxStrecken_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeigeAusgewaehlteFahrt();
        }

        // Methode zum Anzeigen der ausgew�hlten Fahrt in den Textfeldern
        private void ZeigeAusgewaehlteFahrt()
        {
            if (listBoxStrecken.SelectedItem is Fahrt f)
            {
                txtStadt.Text = f.Stadt; // Setzt das Textfeld f�r die Stadt auf den Namen der ausgew�hlten Fahrt
                txtBundesland.Text = f.Bundesland; // Setzt das Textfeld f�r das Bundesland auf das Bundesland der ausgew�hlten Fahrt
                txtEntfernung.Text = f.Entfernung.ToString(); // Setzt das Textfeld f�r die Entfernung auf die Entfernung der ausgew�hlten Fahrt
            }
        }
    }
}
