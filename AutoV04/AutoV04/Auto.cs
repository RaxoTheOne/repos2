using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoV04
{
    public class Auto
    {
        private string marke;
        private string modellname;
        private int baujahr;
        private double preis;

        public string Marke { get => marke; set => marke = value; }
        public string Modellname { get => modellname; set => modellname = value; }
        public int Baujahr { get => baujahr; set => baujahr = value; }
        public double Preis { get => preis; set => preis = value; }

        public Auto(string marke, string modellname, int baujahr, double preis)
        {
            this.marke = marke;
            this.modellname = modellname;
            this.baujahr = baujahr;
            this.preis = preis;
        }

        public string AutoInfo()
        {
            return $"{marke} {modellname}, Baujahr: {baujahr}, Preis: {preis:C}";
        
        }
    }
}
