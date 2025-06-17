using System;
using System.Xml;

namespace Zooverwaltung
{
    public partial class Form1 : Form
    {
        List<Gehege> geheges = new List<Gehege>();
        List<Kontinent> kontinents = new List<Kontinent>();
        List<Tier> tiere = new List<Tier>();
        List<Tierart> tierarten = new List<Tierart>();
        List<Futter> futter = new List<Futter>();
        Datenbank datenbank = new Datenbank();
        public Form1()
        {
            InitializeComponent();
            getKontinent();
            getGehege();
            getTierarten();
            getTiere();
            getFutter();
            datenbank.getFutterung(listBoxFutterung);
            ExportXMLTiere();
        }

        private void getKontinent()
        {
            kontinents.Clear();
            listBoxKontinente.Items.Clear();
            cbGehegeKontinent.Items.Clear();
            Datenbank d = new Datenbank();

            kontinents = d.GetKontinents();

            foreach (Kontinent kontinent in kontinents)
            {
                listBoxKontinente.Items.Add(kontinent.Bezeichnung);
                cbGehegeKontinent.Items.Add(kontinent.Bezeichnung);
            }

        }

        private void getGehege()
        {
            geheges.Clear();
            listBoxGehege.Items.Clear();
            cbTierGehege.Items.Clear();
            Datenbank d = new Datenbank();

            geheges = d.GetGehege();

            foreach (Gehege gehege in geheges)
            {
                listBoxGehege.Items.Add(gehege.Bezeichnung);
                cbTierGehege.Items.Add(gehege.Bezeichnung);
            }
        }

        private void getFutter()
        {
            futter.Clear();
            listBoxFutter.Items.Clear();
            cbFutterungFutter.Items.Clear();
            Datenbank d = new Datenbank();

            futter = d.GetFutter();

            foreach (Futter futter in futter)
            {
                listBoxFutter.Items.Add(futter.Name);
                cbFutterungFutter.Items.Add(futter.Name);
            }

        }

        private void getTiere()
        {
            tiere.Clear();
            listBoxTiere.Items.Clear();
            dgvTiere.Rows.Clear();
            cbFutterungTiere.Items.Clear();
            Datenbank d = new Datenbank();
            //neu doppelte einträge verhindern
            //dgvTiere.Rows.Add(tier.Name, tier.Gewicht, tier.Gbdatum, tierartstring, gehegestring, kontinentstring);
            //string name, gewicht, gbdatum, tierart, gehege, kontinent;
            //string prevName ,prevGewicht ,prevGBdatum ,prevTierart , prevGehege , prevKontinent;

            tiere = d.GetTiere();
            foreach (Tier tier in tiere)
            {
                listBoxTiere.Items.Add(tier.Name + ", geboren: " + tier.Gbdatum);

                //Tierart gridbox
                string tierartstring = "unbekannt";
                int indexTierart = tierarten.FindIndex(x => tier.Tierartnr == x.Nummer);
                if (indexTierart != -1)
                {
                    tierartstring = tierarten[indexTierart].Bezeichnung;
                }



                //gehege gridbox
                string gehegestring = "unbekannt";
                int indexgehege = geheges.FindIndex(x => tier.Gehegenr == x.Nummer);
                if (indexgehege != -1)
                {
                    gehegestring = geheges[indexgehege].Bezeichnung;
                }



                string kontinentstring = "unbekannt";
                int indexkontinent = kontinents.FindIndex(x => geheges[indexgehege].Kontinentnr == x.Nummer);
                if (indexgehege != -1)  // First check if we found a valid enclosure
                {

                    {
                        kontinentstring = kontinents[indexkontinent].Bezeichnung;
                    }
                }


                //gridbox
                dgvTiere.Rows.Add(tier.Name, tier.Gewicht, tier.Gbdatum, tierartstring, gehegestring, kontinentstring);

                cbFutterungTiere.Items.Add(tier.Name);
            }

        }

        private void getTierarten()
        {
            tierarten.Clear();
            listBoxTierart.Items.Clear();
            cbTierTierart.Items.Clear();
            Datenbank d = new Datenbank();

            tierarten = d.GetTierarten();

            foreach (Tierart tierart in tierarten)
            {
                listBoxTierart.Items.Add(tierart.Bezeichnung);
                cbTierTierart.Items.Add(tierart.Bezeichnung);
            }

        }

        private void btnGehegeSpeichern_Click(object sender, EventArgs e)
        {

            if (cbGehegeKontinent.SelectedIndex != -1)
            {
                Datenbank d = new Datenbank();
                int indexcb = cbGehegeKontinent.SelectedIndex;

                d.insertGehege(txtGehegeBezeichnung.Text, kontinents[indexcb].Nummer);
                getGehege();
            }
            else
            {
                MessageBox.Show("Bitte Kontinent auswählen!");
            }
        }

        private void btnGehegeLoeschen_Click(object sender, EventArgs e)
        {
            Datenbank d = new Datenbank();
            int indexListbox = listBoxGehege.SelectedIndex;
            if (indexListbox != -1)
            {
                d.deleteGehege(geheges[indexListbox].Nummer);

                getGehege();
            }
        }

        private void btnKontinentSpeichern_Click(object sender, EventArgs e)
        {
            if (txtKontinentBezeichnung.Text != "")
            {
                Datenbank d = new Datenbank();
                d.insertKontinent(txtKontinentBezeichnung.Text);
                getKontinent();
            }
            else
            {
                MessageBox.Show("Bezeichnung darf nicht leer sein.");
            }
        }

        private void btnKontinentLoeschen_Click(object sender, EventArgs e)
        {
            Datenbank d = new Datenbank();
            int indexListbox = listBoxKontinente.SelectedIndex;
            if (indexListbox != -1)
            {
                d.deleteKontinent(kontinents[indexListbox].Nummer);

                getKontinent();
            }
        }

        private void btnTierartSpeichern_Click(object sender, EventArgs e)
        {
            if (txtTierartBezeichnung.Text != "")
            {
                Datenbank d = new Datenbank();

                d.insertTierart(txtTierartBezeichnung.Text);
                getTierarten();
            }
            else
            {
                MessageBox.Show("Bitte Kontinent auswählen!");
            }
        }

        private void btnTierartLoeschen_Click(object sender, EventArgs e)
        {
            Datenbank d = new Datenbank();
            int indexListbox = listBoxTierart.SelectedIndex;
            if (indexListbox != -1)
            {
                d.deleteTierart(tierarten[indexListbox].Nummer);

                getTierarten();
            }
        }

        // tiere buttons
        private void btnTierSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTierGehege.SelectedIndex != -1 && cbTierTierart.SelectedIndex != -1)
                {
                    Datenbank d = new Datenbank();
                    int indexgehege = cbTierGehege.SelectedIndex;
                    int indextierart = cbTierTierart.SelectedIndex;
                    d.insertTier(txtTierBezeichnung.Text, Double.Parse(txtTierGewicht.Text), datePickerTierGb.Value.ToString("yyyy-MM-dd"),
                        geheges[indexgehege].Nummer, tierarten[indextierart].Nummer);
                    getTiere();

                }
                else
                {
                    //MessageBox.Show("Bitte in jeder box eine Auswahl treffen!");
                    //MessageBox.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTierLoeschen_Click(object sender, EventArgs e)
        {
            Datenbank d = new Datenbank();
            int indexListbox = listBoxTiere.SelectedIndex;
            if (indexListbox != -1)
            {
                d.deleteTiere(tiere[indexListbox].Nummer);

                getTiere();
            }
        }

        private void listBoxTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTiere.SelectedIndex;
            if (index != -1)
            {
                datePickerTierGb.Value = DateTime.Parse(tiere[index].Gbdatum.ToString());
            }
        }

        private void btnFutterSpeichern_Click(object sender, EventArgs e)
        {
            if (txtFutterName.Text != "")
            {
                Datenbank d = new Datenbank();
                d.insertFutter(txtFutterName.Text);
                getFutter();
            }
            else
            {
                MessageBox.Show("Bezeichnung darf nicht leer sein.");
            }
        }

        private void btnFutterLoeschen_Click(object sender, EventArgs e)
        {
            Datenbank d = new Datenbank();
            int indexListbox = listBoxFutter.SelectedIndex;
            if (indexListbox != -1)
            {
                d.deleteFutter(futter[indexListbox].Nummer);

                getFutter();
            }
        }

        private void btnFutterungSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFutterungTiere.SelectedIndex != -1 && cbFutterungFutter.SelectedIndex != -1)
                {
                    Datenbank d = new Datenbank();
                    int indexfutter = cbFutterungFutter.SelectedIndex;
                    int indextier = cbFutterungTiere.SelectedIndex;
                    d.insertFutterung(txtFutterungMenge.Text,
                        timePickerFutterung.Text,
                        tiere[indextier].Nummer, futter[indexfutter].Nummer); // noch nicht fertig
                    datenbank.getFutterung(listBoxFutterung);

                }
                else
                {
                    //MessageBox.Show("Bitte in jeder box eine Auswahl treffen!");
                    //MessageBox.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFutterungLoeschen_Click(object sender, EventArgs e)
        {

        }

        private void ExportXMLTiere()
        {
            try
            {
                string zielName = "Tiere.xml";

                XmlTextWriter xmlTextWriter = new XmlTextWriter(zielName, System.Text.Encoding.UTF8);

                xmlTextWriter.Formatting = Formatting.Indented; // Formatierung der XML Datei
                xmlTextWriter.WriteStartDocument(false); // Start der XML Datei

                // Haupt Tag initialisieren
                xmlTextWriter.WriteStartElement("Tiere");
                // <Tiere>
                // <Devisen Kuerzel="" Kurs="">

                // Tags mit Attributen schreiben
                foreach (Tier t in tiere)
                {
                    int indexta = tierarten.FindIndex(ta => ta.Nummer == t.Tierartnr);
                    string tb = tierarten[indexta].Bezeichnung;

                    xmlTextWriter.WriteStartElement("Tier"); // Start des Tier Tags
                    xmlTextWriter.WriteAttributeString("Name", t.Name); // Attribut Name
                    xmlTextWriter.WriteAttributeString("Gewicht", t.Gewicht.ToString()); // Attribut Gewicht
                    xmlTextWriter.WriteAttributeString("Geburtsdatum", t.Gbdatum.ToString()); // Attribut Geburtsdatum
                    xmlTextWriter.WriteAttributeString("Tierart", tb);
                    xmlTextWriter.WriteEndElement(); // Ende des Tier Tags
                }

                xmlTextWriter.WriteEndElement(); // Ende des Haupt Tags Tiere
                xmlTextWriter.Flush(); // Daten in die Datei schreiben
                xmlTextWriter.Close(); // Schließen des Writers
                MessageBox.Show("XML Datei wurde erfolgreich gespeichert: " + zielName); // Erfolgsmeldung anzeigen
            }
            catch (Exception ex) // Fehlerbehandlung
            {
                MessageBox.Show(ex.Message); // Fehlermeldung anzeigen
            }
            finally
            {

            }
        }

        private void btnXMLDateiEinlesen_Click(object sender, EventArgs e)
        {
            // XML Datei Objekt
            XmlReader reader = null;
            try
            {
                string quellName = "C:/Users/tn/Desktop/Tiere.xml";
                // XML Datei einlesen
                reader = new XmlTextReader(quellName);

                while (reader.Read())
                {
                    if (reader.Name != "")
                    {
                        // Prüfen ob es den Knoten/ Element Cube gibt
                        if (reader.Name == "Tier")
                        {
                            //if (reader.AttributeCount == 4)
                            {
                                // Prüfen ob der Knoten/ Element nur 1 Atrribut enthält
                                reader.MoveToAttribute("name");
                                string name = reader.Value;

                                reader.MoveToAttribute("gewicht");
                                string gewicht = reader.Value;

                                reader.MoveToAttribute("geburtsdatum");
                                string geburtsdatum = reader.Value;

                                reader.MoveToAttribute("gehege");
                                string gehege = reader.Value;

                                reader.MoveToAttribute("tierart");
                                string tierart = reader.Value;
                                datenbank.insertXMLTier(name, gewicht, geburtsdatum, int.Parse(gehege), int.Parse(tierart));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                getTiere();
            }
        }
    }
}
