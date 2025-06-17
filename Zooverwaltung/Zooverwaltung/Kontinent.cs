using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooverwaltung
{
    public class Kontinent
    {
        private int nummer;
        private string bezeichnung = "";

        public Kontinent(int nummer, string bezeichnung)
        {
            Nummer = nummer;
            Bezeichnung = bezeichnung;
        }

        public int Nummer { get => nummer; set => nummer = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
    }
}
