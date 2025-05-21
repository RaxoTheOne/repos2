using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktinfos
{
    public class Kontakte
    {
        private string name;
        private string nachname;
        private string email;
        private string handy;
        private string strasse;
        private int hausNr;
        private string pzl;
        private string stadt;

        public string Name { get => name; set => name = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Email { get => email; set => email = value; }
        public string Handy { get => handy; set => handy = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public int HausNr { get => hausNr; set => hausNr = value; }
        public string Pzl { get => pzl; set => pzl = value; }
        public string Stadt { get => stadt; set => stadt = value; }

        public Kontakte(string name, string nachname, string email, string handy, string strasse, int hausNr, string pzl, string stadt)
        {
            this.name = name;
            this.nachname = nachname;
            this.email = email;
            this.handy = handy;
            this.strasse = strasse;
            this.hausNr = hausNr;
            this.pzl = pzl;
            this.stadt = stadt;
        }

        public string KontaktInfo()
        {
            return $"{name};{nachname};{email};{handy};{strasse};{hausNr};{pzl};{stadt}";
        }

        public string toCSV()
        {
            return $"{name};{nachname};{email};{handy};{strasse};{hausNr};{pzl};{stadt}";
        }
    }
}