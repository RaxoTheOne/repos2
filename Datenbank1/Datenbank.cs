using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datenbank1
{

    public class Datenbank
    {
        private MySqlConnection conn;
        
        public Datenbank()
        {
            string connstr = "SERVER=localhost;UID='root';PASSWORD='';DATABASE=artikel;";
            conn = new MySqlConnection(connstr);
        }

        public List<Warengruppe> getWarengruppe()
        {
            List<Warengruppe> liWaGr = new List<Warengruppe>();
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
            
            return liWaGr;
        }

        public void saveWarengruppe(Warengruppe wg)
        {


            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "INSERT INTO warengruppe (wgbezeichnung)" + "VALUES( '" + wg.wgBezeichnung + "')";
                com.ExecuteNonQuery();
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
