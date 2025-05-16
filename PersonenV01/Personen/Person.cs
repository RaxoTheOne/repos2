using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    public class Person
    {
        private string nachname;
        private string vorname;

        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }

        public Person( string nn, string vn )
        {
            nachname = nn;
            vorname = vn;
        }

        public string personInfo()
        {
            return nachname + ", " + vorname;
        }

        
    }
}
