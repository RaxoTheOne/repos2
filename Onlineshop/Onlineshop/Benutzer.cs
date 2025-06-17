using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop
{
    public class Benutzer
    {
        private string benutzername;
        private string passwort;
        private int benutzerid;
        public string Benutzername { get => benutzername; set => benutzername = value; }
        public string Passwort { get => passwort; set => passwort = value; }
        public int Benutzerid { get => benutzerid; set => benutzerid = value; }

        public Benutzer(int bid, string bn, string p)
        {
            benutzerid = bid;
            benutzername = bn;
            passwort = p;
        }
    
    }
}
