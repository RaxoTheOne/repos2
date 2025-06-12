using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class Datenbank
    {
        //
        private MySqlConnection conn;

        public Datenbank()
        {
            string connstring = "SERVER=localhost;UID='root';PASSWORD='';DATABASE=zoo";
            conn = new MySqlConnection(connstring);
        }

        public void insertIntoKontinent(Kontinent k)
        {

            conn.Open();

            try
            {
                MySqlCommand command= conn.CreateCommand();
                command.CommandText = string.Format("INSERT INTO kontinent VALUES (NULL," +
                    "'{0}');", k.KBezeichnung);

                command.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);


            }
            conn.Close();
            }

        public List<Kontinent> getKontinents()
        {
            List<Kontinent> kliste = new List<Kontinent>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM kontinent";

            try
            {
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    kliste.Add(new Kontinent(reader.GetInt32(0),
                        reader.GetString(1)));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return kliste;

        }
        public void kontinentLoeschen(int knr)
        {
            try
            {
                MySqlCommand command = conn.CreateCommand();
                conn.Open();
                command.CommandText = "DELETE FROM kontinent WHERE knummer=" + knr;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        }
    }
