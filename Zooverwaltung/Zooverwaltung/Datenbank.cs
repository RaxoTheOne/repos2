using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooverwaltung
{
    public class Datenbank
    {
        private MySqlConnection conn;
        public Datenbank()
        {
            string connstr = "server=localhost;user='root';password='';database=zooverwaltung;";
            conn = new MySqlConnection(connstr);
        }



        //select abfragen für die 5 Tabellen

        public List<Futter> GetFutter()
        {
            List<Futter> futter = new List<Futter>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from futter";
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Futter x = new Futter(reader.GetInt32(0), reader.GetString(1));
                    futter.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return futter;
        }


        public List<Kontinent> GetKontinents()
        {
            List<Kontinent> kontinents = new List<Kontinent>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from kontinent";
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kontinent x = new Kontinent(reader.GetInt32(0), reader.GetString(1));
                    kontinents.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return kontinents;
        }
        public List<Tierart> GetTierarten()
        {
            List<Tierart> tierarten = new List<Tierart>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tierart";
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tierart x = new Tierart(reader.GetInt32(0), reader.GetString(1));
                    tierarten.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return tierarten;
        }
        public List<Tier> GetTiere()
        {
            List<Tier> tiere = new List<Tier>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tiere";
               // cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tier x = new Tier(
                reader.GetInt32(0), // tierenr
                reader.IsDBNull(1) ? "" : reader.GetString(1), // name
                reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2), // gewicht
                DateOnly.FromDateTime( reader.GetDateTime(3)), // geburtsdatum
                reader.IsDBNull(4) ? 0 : reader.GetInt32(4), // gehegenr
                reader.IsDBNull(5) ? 0 : reader.GetInt32(5)  // tierartnr
            );
                    tiere.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return tiere;
        }

        public List<Gehege> GetGehege()
        {
            List<Gehege> gehege = new List<Gehege>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from gehege";
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Gehege x = new Gehege(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                    gehege.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return gehege;
        }

        public void getFutterung(ListBox x)
        {
            try
            {
                x.Items.Clear();
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select tiere.name, futter.name,time_format(tierzufutter.zeit, \"%H:%i\"), tierzufutter.menge" +
                    " from tierzufutter inner join futter on tierzufutter.futternr = futter.nr" +
                    " inner join tiere on tierzufutter.tiernummer = tiere.tierenr " +
                    "order by tierzufutter.nr desc";
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    x.Items.Add($"{reader.GetString(0)}, {reader.GetDouble(3)}g {reader.GetString(1)} um {reader.GetString(2)}");
                }
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



        //insert für die tabellen
        public void insertGehege(string Gehege, int Kontinentnr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"insert into gehege values (null,'{Gehege}',{Kontinentnr})";
                cmd.ExecuteNonQuery();
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

        public void insertKontinent(string Kontinent)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"insert into kontinent values (null,'{Kontinent}')";
                cmd.ExecuteNonQuery();
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

        public void insertTierart(string tierart)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"insert into tierart values (null,'{tierart}')";
                cmd.ExecuteNonQuery();
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

        public void insertTier(string name, double gewicht, string gbdatum, int gehegenr, int tierartnr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"insert into tiere values " +
                    $"(null,'{name}',{gewicht},'{gbdatum}',{gehegenr},{tierartnr})";
                cmd.ExecuteNonQuery();
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

        public void insertFutter(string futter)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"insert into futter values (null,'{futter}')";
                cmd.ExecuteNonQuery();
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

        public void insertFutterung(string menge, string uhrzeit, int tiernummer, int futternr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"insert into tierzufutter values (null,'{uhrzeit}',{menge},{tiernummer},{futternr})";
                cmd.ExecuteNonQuery();
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


        // deletes für die tabellen

        public void deleteGehege(int Gehegenr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"delete from gehege where gehegenr = {Gehegenr}";
                cmd.ExecuteNonQuery();
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

        public void deleteKontinent(int Kontinentnr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"delete from kontinent where knummer = {Kontinentnr}";
                cmd.ExecuteNonQuery();
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

        public void deleteTierart(int tierartnr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"delete from tierart where tierartnr = {tierartnr}";
                cmd.ExecuteNonQuery();
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

        public void deleteTiere(int tiernr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"delete from tiere where tierenr = {tiernr}";
                cmd.ExecuteNonQuery();
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

        public void deleteFutter(int Futternr)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"delete from futter where nr = {Futternr}";
                cmd.ExecuteNonQuery();
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

        //insert für die tabellen
        public void insertXMLTier(string name, string gewicht, string gbdatum, int gehegenr, int tierartnr)
        {
            try
            {

                // Verbindung öffnen und SQL-Befehl vorbereiten
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string[] a = gbdatum.Split('.');
                gbdatum = a[2] + '-' + a[1] + '-' + a[0];
                cmd.CommandText = string.Format("INSERT INTO tiere VALUES (null, '{0}', {1}, '{2}' , {3}, {4});", name, gewicht, gbdatum, gehegenr, tierartnr);

                // Parameter setzen
                //cmd.Parameters.AddWithValue("@name", name);
                //cmd.Parameters.AddWithValue("@gewicht", gewicht);
                //cmd.Parameters.AddWithValue("@geburtsdatum", gbdatum.ToString("yyyy-MM-dd"));

                // Ausführen
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tier erfolgreich eingefügt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einfügen: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
