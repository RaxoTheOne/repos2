using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Produkte
    {
        private int produktID;
        private string bezeichnung ="";
        private double preis;
        private int lagerbestand;

        public Produkte(int pID, string b, double p, int lb)
        {
            this.produktID = pID;
            this.bezeichnung = b;
            this.preis = p;
            this.lagerbestand = lb;
        }

        public int ProduktID { get => produktID; set => produktID = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public double Preis { get => preis; set => preis = value; }
        public int Lagerbestand { get => lagerbestand; set => lagerbestand = value; }
        
    }
}
