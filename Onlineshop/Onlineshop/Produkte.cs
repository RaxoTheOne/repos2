using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop
{
    public class Produkte
    {
        private int produktID;
        private string bezeichnung;
        private double preis;
        private int lagerbestand;
        //string bildextension;

        public Produkte(int pID, string b, double p, int lb)
        {
            produktID = pID;
            bezeichnung = b;
            preis = p;
            lagerbestand = lb;

        }

        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public double Preis { get => preis; set => preis = value; }
        public int Lagerbestand { get => lagerbestand; set => lagerbestand = value; }
        public int ProduktID { get => produktID; set => produktID = value; }
   
    
    
    
    
    }
}
