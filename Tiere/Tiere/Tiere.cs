using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiere
{

	public class Tiere
	{
		// Attribute
		private string name;
		private int alter;
		private string tierArt;

		// setter und getter Methoden erstellen
		public string Name { get => name; set => name = value; }
		public int Alter { get => alter; set => alter = value; }
		public string Tierart { get => tierArt; set => tierArt = value; }

		// Konstruktor
		public Tiere(string name, int alter, string tierArt)
        {
            this.name = name;
            this.alter = alter;
            this.tierArt = tierArt;
        }

		// Methode tierInfo();
		public string tierInfo()
        {
			return $"Name: {name}, Alter: {alter}, Tierart: {tierArt}";
        }



	}
}
