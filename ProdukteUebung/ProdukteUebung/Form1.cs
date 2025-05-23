using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdukteUebung
{
    public partial class Form1 : Form
    {
        List<Auto> autos = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNeueProdukte_Click(object sender, EventArgs e)
        {
            Hinzufuegen hinzufuegenForm = new Hinzufuegen(autos);
            if (hinzufuegenForm.ShowDialog() == DialogResult.OK)
            {
                // Die Liste anzeigen
                AutoListeAnzeigen();
                // Den Gesamtwert berechnen
                // GesamtwertBerechnen();
            }
        }

        /*public void GesamtwertBerechnen()
        {
            lblGesamtwert.Text = autos.Sum(a => a.Preis).ToString() + " Euro";
        } -> auskommentiert um andere Variante zu prüfen*/

        public void AutoListeAnzeigen()
        {
            listBoxAutos.Items.Clear();
            foreach (Auto auto in autos)
            {
                listBoxAutos.Items.Add(auto.AutoInfo());
            }

            // Gesamtwert berechnen
            lblGw.Text = autos.Sum(a => a.Preis).ToString() + " Euro";
        }
    }
}
