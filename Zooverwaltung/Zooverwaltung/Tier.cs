using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zooverwaltung
{
    public class Tier
    {
        private int nummer;
        private string name = "";
        private double gewicht;
        private DateOnly gbdatum;
        private int gehegenr;
        private int tierartnr;

        public Tier(int nummer, string name, double gewicht, DateOnly gbdatum, int gehegenr, int tierartnr)
        {
            Nummer = nummer;
            Name = name;
            Gewicht = gewicht;
            Gbdatum = gbdatum;
            Gehegenr = gehegenr;
            Tierartnr = tierartnr;
        }

        public int Nummer { get => nummer; set => nummer = value; }
        public string Name { get => name; set => name = value; }
        public double Gewicht { get => gewicht; set => gewicht = value; }
        public DateOnly Gbdatum { get => gbdatum; set => gbdatum = value; }
        public int Gehegenr { get => gehegenr; set => gehegenr = value; }
        public int Tierartnr { get => tierartnr; set => tierartnr = value; }
    }
}
