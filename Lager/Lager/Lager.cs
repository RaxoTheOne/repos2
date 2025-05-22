using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager1
{
	public class Artikel
	{
		private int artikelNr;
		private string bezeichnung;
		private string kategorie;
		private double preis;
		private int lagerBestand;

		public int ArtikelNr { get => artikelNr; set => artikelNr = value; }
		public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
		public string Kategorie { get => kategorie; set => kategorie = value; }
		public double Preis { get => preis; set => preis = value; }
		public int Lagerbestand { get => lagerBestand; set => lagerBestand = value; }

		public Artikel(int artikelNr, string bezeichnung, string kategorie, double Preis, int lagerBestand)
		{
			this.artikelNr = artikelNr;
			this.bezeichnung = bezeichnung;
			this.kategorie = kategorie;
			this.preis = Preis;
			this.lagerBestand = lagerBestand;
		}

		public string LagerInfo()
		{
			return $"{artikelNr} - {bezeichnung} - {kategorie} - {preis} - {lagerBestand}";
		}

		public string toCSV()
		{
			return $"{artikelNr};{bezeichnung};{kategorie};{preis};{lagerBestand}";
		}
	}
}