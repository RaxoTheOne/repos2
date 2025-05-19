namespace Tiere
{
    public partial class Form1 : Form
    {
        // Attribute
        List<Tiere> tierListe = new List<Tiere>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tierName = txtTierName.Text;
            string tierArt = comboBox1.Text;
            int tierAlter = (int)numericUpDown1.Value;

            Tiere t = new Tiere(tierName, tierAlter, tierArt);

            tierListe.Add(t);

            listeTiere.Items.Add(t.tierInfo());
            txtTierName.Clear();
            comboBox1.Text = "";
            numericUpDown1.Value = 1;
        }

        private void listeTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexnummer = listeTiere.SelectedIndices[0];

            Tiere t = tierListe[indexnummer];

            txtTierName.Text = t.Name;
            numericUpDown1.Value = t.Alter;
            comboBox1.Text = t.Tierart;
        }

        private void buttonBearbeiten1_Click(object sender, EventArgs e)
        {
            int index = listeTiere.SelectedIndices[0];

            string neuename = txtTierName.Text;
            string neueTierart = comboBox1.Text;
            int neueAlter = (int)numericUpDown1.Value;

            // Tiere t = new Tiere(neuename, neueAlter, neueTierart);

            tierListe[index].Name = neuename; // Aktualisiere die Eigenschaften des existierenden Objekts
            tierListe[index].Alter = neueAlter; // Updated das existierende Tier-Objekt in der Liste
            tierListe[index].Tierart = neueTierart; // Updated das existierende Tier-Objekt in der Liste

            listeTiere.Items[index] = tierListe[index].tierInfo(); // Aktualisiere die Anzeige in der ListBox

            txtTierName.Clear();
            comboBox1.Text = "";
            numericUpDown1.Value = 1;


            button1.Enabled = true; // Reaktiviere den Hinzufügen-Button
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            if (listeTiere.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bitte wähle ein Tier aus, das gelöscht werden soll.", "Keine Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Methode verlassen
            }
            int index = listeTiere.SelectedIndices[0];

            tierListe.RemoveAt(index); // Entferne das Tier-Objekt aus der Liste

            listeTiere.Items.Clear(); // Leere die ListBox

            foreach (Tiere a in tierListe)
            {
                listeTiere.Items.Add(a.tierInfo()); // Füge alle verbleibenden Tiere wieder hinzu
            }

            txtTierName.Clear();
            comboBox1.Text = "";
            numericUpDown1.Value = 1;
        }
    }
}
