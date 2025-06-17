using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Form2 : Form
    {
        string bildpfad = "";
        private Datenbank db = new Datenbank();
        List<Produkte> liPro = new List<Produkte>();
        string bname;

        public Form2(string benutzername)
        {
            bname = benutzername;
            InitializeComponent();
            lblWillkommen.Text = "Willkommen " + bname;

            ProdukteAnzeigen();
        }

        public void ProdukteAnzeigen()
        {
            liPro = db.ProduktEinlesen();
            lbProdukte.Items.Clear();
            foreach (Produkte a in liPro)
            {
                lbProdukte.Items.Add(a.Bezeichnung);
            }
        }

        private void btnBildAuswahl_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bildpfad = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(bildpfad);
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string bezeichnung = txtProduktname.Text;
            double preis = Double.Parse(txtPreis.Text);
            int lager = int.Parse(txtLagerbestand.Text);

            Produkte p = new Produkte(-1, bezeichnung, preis, lager);

            // Speichern die Datei in Datenbank
            db.ProduktInsert(p);

            // Kopieren das Bild in einen Ordner
            string extension = Path.GetExtension(bildpfad); // .jpg / .png
            // neuer Name des Bildes + Extension
            string bildName = txtProduktname.Text.Trim() + extension;
            // Pfad zum Zielordner
            string zielOrdner = @"C:\ProduktbilderOS";
            //erstellen einen neuen Ordner
            Directory.CreateDirectory(zielOrdner);

            string zielPfad = Path.Combine(zielOrdner, bildName);

            //Kopieren das Bild
            File.Copy(bildpfad, zielPfad, true);

            txtProduktname.Text = "";
            txtLagerbestand.Text = "";
            txtPreis.Text = "";
            pictureBox1.Image = null;
            // Aktualisieren Produkt-ListBox
            ProdukteAnzeigen();
        }

        private void btnAusloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void lbProdukte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbProdukte.SelectedIndex;
            txtProduktname.Text = liPro[index].Bezeichnung;
            txtPreis.Text = liPro[index].Preis.ToString();
            txtLagerbestand.Text = liPro[index].Lagerbestand.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\ProduktbilderOS\" +
                    liPro[index].Bezeichnung + ".png");
            }
            catch (Exception ex)
            {
                pictureBox1.Image = Image.FromFile(@"C:\ProduktbilderOS\" +
                    liPro[index].Bezeichnung + ".png");
            }
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            int index = lbProdukte.SelectedIndex;

            liPro[index].Bezeichnung = txtProduktname.Text;
            liPro[index].Preis = double.Parse(txtPreis.Text);
            liPro[index].Lagerbestand = int.Parse(txtLagerbestand.Text);

            db.ProduktAktualisieren(liPro[index]);
            //
            //Kopieren das Bild in einem Ordner
            string extension = Path.GetExtension(bildpfad);//.jpg / .png
            //neue Name des Bilds + extension
            string bildName = txtProduktname.Text.Trim() + extension;

            string zielOrdner = @"C:\ProduktbilderOS";
            //erstellen einen neuen Ordner
            Directory.CreateDirectory(zielOrdner);

            string zielPfad = Path.Combine(zielOrdner, bildName);

            //Kopieren das Bild
            File.Copy(bildpfad, zielPfad, true);

            txtProduktname.Text = "";
            txtPreis.Text = "";
            txtLagerbestand.Text = "";
            pictureBox1.Image = null;

            ProdukteAnzeigen();
        }
    }
}
