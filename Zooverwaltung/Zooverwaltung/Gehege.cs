using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooverwaltung
{
    public class Gehege
    {
        private int nummer;
        private string bezeichnung = "";
        private int kontinentnr;

        public Gehege(int nummer, string bezeichnung, int kontinentnr)
        {
            Nummer = nummer;
            Bezeichnung = bezeichnung;
            Kontinentnr = kontinentnr;
        }

        public int Nummer { get => nummer; set => nummer = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public int Kontinentnr { get => kontinentnr; set => kontinentnr = value; }


    }
}
