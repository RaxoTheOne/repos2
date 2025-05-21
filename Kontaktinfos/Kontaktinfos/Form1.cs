using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kontaktinfos
{
    public partial class Form1 : Form
    {
        List<Kontakte> kontakte = new List<Kontakte>();

        public Form1()
        {
            InitializeComponent();
            btnBearbeiten.Enabled = false;
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            // Eingabefelder prüfen
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNachname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtHandy.Text) ||
                string.IsNullOrWhiteSpace(txtStrasse.Text) ||
                string.IsNullOrWhiteSpace(txtHausNr.Text) ||
                string.IsNullOrWhiteSpace(txtPZL.Text) ||
                string.IsNullOrWhiteSpace(txtStadt.Text))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtHausNr.Text, out int hausNr))
            {
                MessageBox.Show("Bitte eine gültige Hausnummer eingeben (nur Zahlen).", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtName.Text;
            string nachname = txtNachname.Text;
            string email = txtEmail.Text;
            string handy = txtHandy.Text;
            string strasse = txtStrasse.Text;
            string pzl = txtPZL.Text;
            string stadt = txtStadt.Text;

            Kontakte k = new Kontakte(name, nachname, email, handy, strasse, hausNr, pzl, stadt);

            kontakte.Add(k);
            listBoxKontakte.Items.Add(k.KontaktInfo());

            // Felder leeren
            ClearTextfelder();
        }

        private void listBoxKontakte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKontakte.SelectedIndex == -1)
                return;

            btnHinzufuegen.Enabled = false;
            btnBearbeiten.Enabled = true;

            int index = listBoxKontakte.SelectedIndex;
            Kontakte k = kontakte[index];

            txtName.Text = k.Name;
            txtNachname.Text = k.Nachname;
            txtEmail.Text = k.Email;
            txtHandy.Text = k.Handy;
            txtStrasse.Text = k.Strasse;
            txtHausNr.Text = k.HausNr.ToString();
            txtPZL.Text = k.Pzl;
            txtStadt.Text = k.Stadt;
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if (listBoxKontakte.SelectedIndex == -1)
                return;

            if (!int.TryParse(txtHausNr.Text, out int neueHausNr))
            {
                MessageBox.Show("Bitte eine gültige Hausnummer eingeben (nur Zahlen).", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = listBoxKontakte.SelectedIndex;

            kontakte[index].Name = txtName.Text;
            kontakte[index].Nachname = txtNachname.Text;
            kontakte[index].Email = txtEmail.Text;
            kontakte[index].Handy = txtHandy.Text;
            kontakte[index].Strasse = txtStrasse.Text;
            kontakte[index].HausNr = neueHausNr;
            kontakte[index].Pzl = txtPZL.Text;
            kontakte[index].Stadt = txtStadt.Text;

            listBoxKontakte.Items[index] = kontakte[index].KontaktInfo();

            ClearTextfelder();
            btnHinzufuegen.Enabled = true;
            btnBearbeiten.Enabled = true;
            btnLoeschen.Enabled = false;
        }

        private void ClearTextfelder()
        {
            txtName.Clear();
            txtNachname.Clear();
            txtEmail.Clear();
            txtHandy.Clear();
            txtStrasse.Clear();
            txtHausNr.Clear();
            txtPZL.Clear();
            txtStadt.Clear();
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int index = listBoxKontakte.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Bitte einen Kontakt auswählen, um ihn zu löschen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kontakte.RemoveAt(index);
            listBoxKontakte.Items.RemoveAt(index);

            ClearTextfelder();
            btnHinzufuegen.Enabled = false;
            btnBearbeiten.Enabled = true;
            btnLoeschen.Enabled = true;
        }

        private void btnSpeicher_Click(object sender, EventArgs e)
        {
            Datei dt = new Datei();
            dt.schreibeCSV(kontakte);
        }
    }
}
