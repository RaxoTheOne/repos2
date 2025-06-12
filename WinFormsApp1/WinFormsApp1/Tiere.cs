using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Tiere
    {
        private int tierenr;
        private string name = "";
        private double gewicht;
        private string GBdatum;
        private int gnr;
        private string tanr;

        public Tiere(int tinr, string name, double gewicht, string gbdatum, int gnr, int tanr)
        {
            Tierenr = tinr;
            Name = name;
            Gewicht = gewicht;
            GBdatum = gbdatum;
            Gnr = gnr;
            Tanr = tanr;
        }

        public int Tierenr { get => tierenr; set => tierenr = value; }
        public string Name { get => name; set => name = value; }
        public double Gewicht { get => gewicht; set => gewicht = value; }
        public string GBdatum1 { get => GBdatum; set => GBdatum = value; }
        public int Gnr { get => gnr; set => gnr = value; }
        public string Tanr { get => tanr; set => tanr = value; }
    }
}
