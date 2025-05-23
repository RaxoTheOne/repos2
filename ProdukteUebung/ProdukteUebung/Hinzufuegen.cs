using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdukteUebung
{
    public partial class Hinzufuegen : Form
    {
        Auto a;
        List<Auto> autoList;

        public Hinzufuegen(List<Auto> autos)
        {
            InitializeComponent();
            autoList = autos;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            string autoart = "";

            if (rbtnBenzin.Checked)
            {
                autoart = "Benzin";
            }
            if (rbtnDiesel.Checked)
            {
                autoart = "Diesel";
            }

            string extras = "";

            if (checkBoxKlimaAnlage.Checked)
            {
                extras += checkBoxKlimaAnlage.Text;
            }
            if (checkBoxSitzHeizung.Checked)
            {
                extras += "," + checkBoxSitzHeizung.Text;
            }

            a = new Auto(txtModellname.Text, comboBoxMarke.Text, double.Parse(txtPreis.Text), autoart, extras);

            autoList.Add(a);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBoxMarke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarke.SelectedIndex != -1)
            {
                string marke = comboBoxMarke.Text;
                pictureBoxLogo.Image = Image.FromFile("C:\\Users\\tn\\LogoBilder\\" + marke + ".png");
            }
        }
    }
}