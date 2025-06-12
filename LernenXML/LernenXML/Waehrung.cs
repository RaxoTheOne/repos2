using System;

namespace LernenXML
{

	public class Waehrung
	{
		private string wname = "";
		private double wkurs;

        public Waehrung(string wname, double wkurs)
        {
            this.Wname = wname;
            this.Wkurs = wkurs;
        }

        public string Wname { get => wname; set => wname = value; }
        public double Wkurs { get => wkurs; set => wkurs = value; }

        public string waehrungInfo()
		{
			return "Währung: " + Wname + "| Kusrwert: " + Wkurs;
		}
	}
}