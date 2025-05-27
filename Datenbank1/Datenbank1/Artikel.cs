using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Datenbank1
{
    public class Artikel
    {
        private int artikelNr;
        private string artikelBezeichnung;
        private double artikelPreis;
        private int artLagerbestand;
        private int artWg;

        public Artikel(int artikelNr, string artikelBezeichnung, double artikelPreis, int artLagerbestand, int artWg)
        {
            this.artikelNr = artikelNr;
            this.artikelBezeichnung = artikelBezeichnung;
            this.artikelPreis = artikelPreis;
            this.artLagerbestand = artLagerbestand;
            this.artWg = artWg;
        }
    }
}