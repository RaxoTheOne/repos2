using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdukteUebung
{
    public class Auto
    {
        private string modellname;
        private string marke;
        private double preis;
        private string autoart;
        private string extras;

        public string Modellname { get => modellname; set => modellname = value; }
        public string Marke { get => marke; set => marke = value; }
        public double Preis { get => preis; set => preis = value; }
        public string Autoart { get => autoart; set => autoart = value; }
        public string Extras { get => extras; set => extras = value; }

        public Auto(string modellname, string marke, double preis, string autoart,string extras)
        {
            this.modellname = modellname;
            this.marke = marke;
            this.preis = preis;
            this.autoart = autoart;
            this.extras = extras;
        }

        public string AutoInfo()
        {
            return $"{marke}, {modellname}, {Math.Round(preis, 2)} €, {autoart}, {extras}";
        }
    }
}
