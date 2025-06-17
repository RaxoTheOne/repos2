using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineShop
{
    public class Datenbank
    {
        private MySqlConnection conn;
        private string connstr = "SERVER=localhost;UID='root';PASSWORD='';DATABASE=onlineshop2";

        public Datenbank()
        {
            conn = new MySqlConnection(connstr);
        }

        public Benutzer BenutzerUeberpruefen(string benutzer, string passwort)
        {
            Benutzer bn = null;
            conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from benutzer where benutzername='" + benutzer + "'" + " AND passwort='" + passwort + "';";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bn = new Benutzer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            conn.Close();
            return bn;
        }

        public void ProduktInsert(Produkte p)
        {
            conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string pr = p.Preis.ToString().Replace(',', '.');
                cmd.CommandText = string.Format("insert into produkte values (null, '{0}', {1}, {2});",
                    p.Bezeichnung,
                    pr,
                    p.Lagerbestand);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public List<Produkte> ProduktEinlesen()
        {
            List<Produkte> p = new List<Produkte>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select * from produkte;");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Produkte produkt = new Produkte(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "" : reader.GetString(1),
                        reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2),
                        reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        );

                    p.Add(produkt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return p;
        }

        public void BenutzerHinzufuegen(Benutzer benutzer)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("insert into benutzer values (NULL, '{0}', '{1}');", benutzer.Benutzername, benutzer.Passwort);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        public void ProduktAktualisieren(Produkte produkte)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                    "update produkte set Bezeichnung='{0'," + "Preis={1}, Lagerbestand={2} where produktid={3};",
                    produkte.Bezeichnung, produkte.Preis, produkte.Lagerbestand, produkte.ProduktID
                    );
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }
    }
}
