using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datenbank1
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private List<Warengruppe> liWaGr = new List<Warengruppe>();

        public Form1()
        {
            InitializeComponent();
            string connstr = "SERVER=localhost;UID='root';PASSWORD='';DATABASE=artikel;";
            conn = new MySqlConnection(connstr);
        }

        private void wgAnzeigen()
        {

            listBox1.Items.Clear();
            foreach (Warengruppe wg in liWaGr)
            {
                listBox1.Items.Add(wg.WgBezeichnung);
            }
        }
        private void btnEinlesen_Click(object sender, EventArgs e)
        {
            try
            {
                liWaGr.Clear();
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM warengruppe";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liWaGr.Add(new Warengruppe(
                        reader.GetInt32(0), //  weitere Variante("wgNr") 
                        reader.GetString(1) // weitere Variante("wgBezeichnung")
                    ));
                }
                reader.Close();
                wgAnzeigen(); // Optional: Löschen der Liste nach dem Anzeigen, falls nicht mehr benötigt wird
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
