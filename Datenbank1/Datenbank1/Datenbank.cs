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
                conn.Open();  // Verbindung zur Datenbank öffnen
                if (wg.WgNr == -1)
                {
                    com.CommandText = "INSERT INTO warengruppe (wgbezeichnung)" + "VALUES( '" + wg.WgBezeichnung + "')"; // SQL Befehl zum Einfügen von Daten
                }
                else
                {
                    com.CommandText = $"UPDATE warengruppe SET wgbezeichnung = '{wg.WgBezeichnung}' WHERE wgnr = {wg.WgNr}"; // SQL Befehl zum Aktualisieren von Daten
                }
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void deleteWarengruppe(int wgNr)
        {
            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = $"DELETE FROM warengruppe WHERE wgnr = {wgNr}"; // SQL Befehl zum Löschen von Daten
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Artikel> getArtikel()
        {
            List<Artikel> liArt = new List<Artikel>();
            try
            {
                liArt.Clear(); // wichtig, sonst wird die Liste immer länger
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = "SELECT * FROM artikel";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read()) // liest die Daten aus der Datenbank
                {
                    liArt.Add(new Artikel(
                        reader.GetInt32(0), //  weitere Variante("artikelNr") 
                        reader.IsDBNull(1) ? "" : reader.GetString(1), // weitere Variante("artikelBezeichnung")
                        reader.IsDBNull(2) ? 0 : reader.GetDouble(2), // weitere Variante("artikelPreis")
                        reader.IsDBNull(3) ? 0 : reader.GetInt32(3), // weitere Variante("artLagerbestand")
                        reader.IsDBNull(4) ? -1 : reader.GetInt32(4) // weitere Variante("artWg")
                    ));
                }
                reader.Close(); // wichtig, sonst bleibt die Verbindung offen
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return liArt;
        }

        public void saveArtikel(Artikel a)
        {
            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = $"INSERT INTO artikel VALUES(NULL, '{a.ArtikelBezeichnung}', {a.ArtikelPreis.ToString().Replace(',', '.')}, {a.ArtLagerbestand}, {a.ArtWg})"; // SQL Befehl zum Einfügen von Daten
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void deleteArtikel(int artikelNr)
        {
            try
            {
                MySqlCommand com = conn.CreateCommand();
                conn.Open();
                com.CommandText = $"DELETE FROM artikel WHERE artnr = {artikelNr}"; // SQL Befehl zum Löschen von Daten
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}