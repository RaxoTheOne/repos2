using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datenbank1
{
    public partial class Form1 : Form
    {
        private Datenbank db = new Datenbank();   
        private List<Warengruppe> liWaGr = new List<Warengruppe>();

        public Form1()
        {
            InitializeComponent();
            wgAnzeigen();
        }

        private void wgAnzeigen()
        {
            liWaGr = db.getWarengruppe();
            listBox1.Items.Clear();
            foreach (Warengruppe wg in liWaGr)
            {
                listBox1.Items.Add(wg.WgBezeichnung);
            }
        }
        private void btnEinlesen_Click(object sender, EventArgs e)
        {
            wgAnzeigen();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Warengruppe wg = new Warengruppe(0, txtWarengruppe.Text);
            db.saveWarengruppe(wg);
            wgAnzeigen();
        }
    }
}
