using System;
using System.Data;
using System.Windows.Forms;

namespace Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxVerlauf.DoubleClick += listBoxVerlauf_DoubleClick; //  richtiger Name
        }

        private void RechneFormel()
        {
            string eingabe = txtEingabe.Text;

            try
            {
                var dt = new DataTable();
                var ergebnis = dt.Compute(eingabe, null); // neue Variable ergebnis
                lblAnzeigeErgebnis.Text = ergebnis.ToString(); // Ergebnis anzeigen
                listBoxVerlauf.Items.Add($"{eingabe} = {ergebnis}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ungültiger Ausdruck: " + ex.Message);
            }
        }

        private void btnBerechneFormel_Click(object sender, EventArgs e)
        {
            RechneFormel();
        }

        private void listBoxVerlauf_DoubleClick(object? sender, EventArgs e)
        {
            if (listBoxVerlauf.SelectedItem is string eintrag)
            {
                int index = eintrag.IndexOf('=');
                if (index > 0)
                {
                    txtEingabe.Text = eintrag.Substring(0, index).Trim();
                    lblAnzeigeErgebnis.Text = eintrag.Substring(index + 1).Trim();
                }
            }
        }


        private void btnVerlaufLoeschen_Click(object sender, EventArgs e)
        {
            listBoxVerlauf.Items.Clear();
            lblAnzeigeErgebnis.Text = "";
        }
    }
}
