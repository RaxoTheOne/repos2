using System.Xml;

namespace FirmaXML
{
    public partial class Form1 : Form
    {
        List<Mitarbeiter> liMi = new List<Mitarbeiter>();
        string quellName = "Mitarbeiter.xml";
        string zielName = "Mitarbeiter.xml";

        public Form1()
        {
            InitializeComponent();
            initListe();
        }

        private void initListe()
        {
            // XML Datei Objekt
            XmlReader reader = null;
            try
            {
                // XML Datei einlesen
                reader = new XmlTextReader(quellName);
                liMi.Clear();
                lbMitarbeiter.Items.Clear();

                while (reader.Read())
                {
                    if (reader.Name != "")
                    {
                        // Prüfen ob es den Knoten/ Element Cube gibt
                        if (reader.Name == "Mitarbeiter")
                        {
                            if (reader.AttributeCount == 3)
                            {
                                // Prüfen ob der Knoten/ Element nur 1 Atrribut enthält
                                reader.MoveToAttribute("Vorname");
                                string hauptelementText = reader.Value;
                                lbMitarbeiter.Items.Add(hauptelementText);
                            }
                        }
                    }
                }
                btnXMLSpeichern.Enabled = true; // Button zum Speichern aktivieren
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }
        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            if (txtNachname.Text != "" && txtVorname.Text != "" && txtTelefonnummer.Text != "")
            {
                Mitarbeiter m = new Mitarbeiter(txtVorname.Text, txtNachname.Text, txtTelefonnummer.Text);
                lbMitarbeiter.Items.Add(m.MitarbeiterInfo());
                liMi.Add(m); // Mitarbeiter zur Liste hinzufügen
            }
            else
            {
                MessageBox.Show(Text = "Bitte füllen Sie alle Felder aus.");
            }
        }

        private void btnXMLSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(zielName, System.Text.Encoding.UTF8);

                xmlTextWriter.Formatting = Formatting.Indented; // Formatierung der XML Datei
                xmlTextWriter.WriteStartDocument(false); // Start der XML Datei

                // Haupt Tag initialisieren
                xmlTextWriter.WriteStartElement("Firma");
                // <Firma>
                // <Mitarbeiter Vorname="", Nachname="", Telefonnummer="">

                // Tags mit Attributen schreiben
                foreach (Mitarbeiter m in liMi)
                {
                    xmlTextWriter.WriteStartElement("Mitarbeiter"); // Start des Devisen Tags
                    xmlTextWriter.WriteAttributeString("Vorname", m.Vorname); // Attribut Vorname
                    xmlTextWriter.WriteAttributeString("Nachname", m.Nachname); // Attribut Nachname
                    xmlTextWriter.WriteAttributeString("Telefonnummer", m.Telefonnummer); // Attribut Telefonnummer
                    xmlTextWriter.WriteEndElement(); // Ende des Devisen Tags
                }

                xmlTextWriter.WriteEndElement(); // Ende des Haupt Tags Mitarbeiter
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbMitarbeiter.SelectedIndex != -1)
            {
                int index = lbMitarbeiter.SelectedIndex;

                // Mitarbeiter aus der Liste entfernen
                liMi.RemoveAt(index);
                lbMitarbeiter.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Mitarbeiter aus der Liste aus, den Sie löschen möchten.");
            }
        }

        private void lbMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMitarbeiter.SelectedIndex != -1)
            {
                btnDelete.Enabled = true; // Button zum Löschen aktivieren
            }
            else
            {
                btnDelete.Enabled = false; // Button zum Löschen deaktivieren
            }
        }
    }
}
