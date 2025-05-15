using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosV03___Sortieren
{
	public class Auto
	{
		// Instanzvariablen
		private string modell;
		public int baujahr;

		// static Variable Klassenvariable
		public static int autoAnzahl = 0;

		public Auto(string m, int bauj)
		{
			// Initialisieren der Instanzvariable
			modell = m;
			baujahr = bauj;

			// static / Klassenvariable
			autoAnzahl++;
		}

		public void autoAnzeigen()
		{
			Console.WriteLine("Auto Modell: " + modell);
			Console.WriteLine("Auto Baujahr: " + baujahr);
		}
	}
}