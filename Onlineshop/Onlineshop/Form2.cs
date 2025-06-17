using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onlineshop
{
    public partial class Form2 : Form
    {
        string bildpfad;
        Datenbank db = new Datenbank();
        List<Produkte> listprodukte = new List<Produkte>();
        string bname;
        public Form2(string benutzername)
        {
            bname = benutzername;
            InitializeComponent();
            label5.Text = "Wilkommen " + bname;


            produkteAnzeigen();
        }
        public void produkteAnzeigen()
        {
            listprodukte = db.produktEinlesen();
            lbProdukte.Items.Clear();
            foreach (Produkte a in listprodukte)
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
            string bezeichnung = txtBezeichnung.Text;
            double preis = double.Parse(txtPreis.Text);
            int lager = int.Parse(txtLager.Text);

            Produkte p = new Produkte(-1, bezeichnung, preis, lager);

            //Speichern die Datei in der Datenbank
            db.produktInsert(p);

            //Kopieren das Bild in einem Ordner
            string extension = Path.GetExtension(bildpfad);//.jpg / .png
            //neue Name des Bilds + extension
            string bildName = txtBezeichnung.Text.Trim() + extension;

            string zielOrdner = @"C:\produktbilder";
            //erstellen einen neuen Ordner
            Directory.CreateDirectory(zielOrdner);

            string zielPfad = Path.Combine(zielOrdner, bildName);

            //Kopieren das Bild
            File.Copy(bildpfad, zielPfad, true);


            txtBezeichnung.Text = "";
            txtLager.Text = "";
            txtPreis.Text = "";
            pictureBox1.Image = null;
            //aktualisieren Produkt-ListBox
            produkteAnzeigen();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void lbProdukte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbProdukte.SelectedIndex;
            txtBezeichnung.Text = listprodukte[index].Bezeichnung;
            txtPreis.Text = listprodukte[index].Preis.ToString();
            txtLager.Text = listprodukte[index].Lagerbestand.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\produktbilder\" +
                                listprodukte[index].Bezeichnung + ".jpg");
            }
            catch (Exception ex)
            {
                pictureBox1.Image = Image.FromFile(@"C:\produktbilder\" +
                                listprodukte[index].Bezeichnung + ".png");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = lbProdukte.SelectedIndex;

            listprodukte[index].Bezeichnung = txtBezeichnung.Text;
            listprodukte[index].Preis = double.Parse(txtPreis.Text);
            listprodukte[index].Lagerbestand = int.Parse(txtLager.Text);

            db.produktAktualisieren(listprodukte[index]);
            //
            //Kopieren das Bild in einem Ordner
            string extension = Path.GetExtension(bildpfad);//.jpg / .png
            //neue Name des Bilds + extension
            string bildName = txtBezeichnung.Text.Trim() + extension;

            string zielOrdner = @"C:\ProduktbilderOS";
            //erstellen einen neuen Ordner
            Directory.CreateDirectory(zielOrdner);

            string zielPfad = Path.Combine(zielOrdner, bildName);

            //Kopieren das Bild
            File.Copy(bildpfad, zielPfad, true);

            txtBezeichnung.Text = "";
            txtPreis.Text = "";
            txtLager.Text = "";
            pictureBox1.Image = null;

            produkteAnzeigen();
        }
    }
}
