

namespace LernenXML
{
    using System.Xml;
    public partial class Form1 : Form
    {
        List<Waehrung> liWae = new List<Waehrung>();
        string quellName = "C:\\Users\\tn\\source\\repos2\\LernenXML\\LernenXML\\eurofxref-daily.xml";
        string zielName = "Devisen.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnXMLLesen_Click(object sender, EventArgs e)
        {
            // XML Datei Objekt
            XmlReader reader = null;
            try
            {
                // XML Datei einlesen
                reader = new XmlTextReader(quellName);
                liWae.Clear();
                lbXmlDatei.Items.Clear();

                while (reader.Read())
                {
                    if (reader.Name != "")
                    {
                        // Prüfen ob es den Knoten/ Element Cube gibt
                        if (reader.Name == "Cube")
                        {
                            if (reader.AttributeCount == 1)
                            {
                                // Prüfen ob der Knoten/ Element nur 1 Atrribut enthält
                                reader.MoveToAttribute("time");
                                string hauptelementText = "European Central Bank : " + reader.Value;
                                lbXmlDatei.Items.Add(hauptelementText);
                            }
                            if (reader.AttributeCount == 2)
                            {
                                // Währungskennzeichen auslesen
                                reader.MoveToAttribute("currency");
                                string wkennzeichen = reader.Value;

                                // Kurs einlesen
                                reader.MoveToAttribute("rate");
                                double kurs = double.Parse(reader.Value.Replace('.', ','));

                                // Instanzierung Waehrung Objekt
                                Waehrung w = new Waehrung(wkennzeichen, kurs);

                                liWae.Add(w);
                                lbXmlDatei.Items.Add(w.waehrungInfo());
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

        private void btnXMLSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(zielName, System.Text.Encoding.UTF8);

                xmlTextWriter.Formatting = Formatting.Indented; // Formatierung der XML Datei
                xmlTextWriter.WriteStartDocument(false); // Start der XML Datei

                // Haupt Tag initialisieren
                xmlTextWriter.WriteStartElement("Wechselkurse");
                // <Wechselkurse>
                // <Devisen Kuerzel="" Kurs="">
                
                // Tags mit Attributen schreiben
                foreach (Waehrung w in liWae)
                {
                    xmlTextWriter.WriteStartElement("Deivsen"); // Start des Devisen Tags
                    xmlTextWriter.WriteAttributeString("Kuerzel", w.Wname); // Attribut Kuerzel
                    xmlTextWriter.WriteAttributeString("Kurs", w.Wkurs.ToString()); // Attribut Kurs
                    xmlTextWriter.WriteEndElement(); // Ende des Devisen Tags
                }

                xmlTextWriter.WriteEndElement(); // Ende des Haupt Tags Wechselkurse
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
    }
}
