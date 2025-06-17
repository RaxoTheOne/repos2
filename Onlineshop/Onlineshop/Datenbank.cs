using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop
{
    public class Datenbank
    {
        private MySqlConnection conn;
        private string connstr = "SERVER=localhost;UID='root';PASSWORD='';DATABASE=onlineshop";

        public Datenbank()
        {
            conn = new MySqlConnection(connstr);
        }

        public Benutzer benutzerUberpruefen(string benutzer, string passwort)
        {
            conn.Open();
            Benutzer bn = null;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * from benutzer WHERE benutzername='"
                    +benutzer+"'"+" AND passwort='"+passwort+"';";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bn = new Benutzer(reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); 
            return bn;
        }
        public void produktInsert(Produkte p)
        {
            conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string pr = p.Preis.ToString().Replace(',', '.');//3,99 => 3.99
                cmd.CommandText = string.Format(
                   "INSERT INTO produkte VALUES (NULL, '{0}', {1}, {2});",
                   p.Bezeichnung, pr, p.Lagerbestand

                    );
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public List<Produkte> produktEinlesen()
        {
            List<Produkte> p = new List<Produkte>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT * FROM produkte;");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Produkte produkt = new Produkte(
                        reader.GetInt32(0),
                        reader.IsDBNull(1)? "" : reader.GetString(1),
                        reader.IsDBNull(2)? 0.0 : reader.GetDouble(2),
                        reader.IsDBNull(3)? 0 : reader.GetInt32(3)
                        );

                    p.Add(produkt);

                }





            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conn.Close();
            return p;

        }
        public void benutzerHinzufuegen(Benutzer benutzer)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO benutzer VALUES " +
                    "(NULL, '{0}', '{1}');", benutzer.Benutzername, benutzer.Passwort);
                cmd.ExecuteNonQuery();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close() ;

        }
        public void produktAktualisieren(Produkte produkte)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(
                    "UPDATE produkte  SET Bezeichnung='{0}'," +
                    "Preis={1}, Lagerbestand={2} WHERE produktid={3};", 
                    produkte.Bezeichnung, produkte.Preis, produkte.Lagerbestand,
                    produkte.ProduktID
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
