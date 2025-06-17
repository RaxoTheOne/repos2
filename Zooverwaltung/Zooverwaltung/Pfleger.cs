using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Zooverwaltung
{
    public class Pfleger
    {
        int nr;
        string vorname = "";
        string nachname = "";
        string telefon = "";

        public Pfleger(int nr, string vorname, string nachname, string telefon)
        {
            this.Nr = nr;
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Telefon = telefon;
        }

        public int Nr { get => nr; set => nr = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
