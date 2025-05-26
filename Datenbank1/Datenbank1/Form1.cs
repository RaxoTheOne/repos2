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

        private void btnEinlesen_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
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
