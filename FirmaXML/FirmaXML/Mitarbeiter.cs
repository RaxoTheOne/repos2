using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaXML
{
    public class Mitarbeiter
    {
        private string vorname = "";
        private string nachname = "";
        private string telefonnummer = "";

        public Mitarbeiter(string vorname, string nachname, string telefonnummer)
        {
            Vorname = vorname;
            Nachname = nachname;
            Telefonnummer = telefonnummer;
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Telefonnummer { get => telefonnummer; set => telefonnummer = value; }

        public string MitarbeiterInfo()
        {
            return $"{Vorname}, {Nachname}, Tel. {Telefonnummer}";
        }
    }


}