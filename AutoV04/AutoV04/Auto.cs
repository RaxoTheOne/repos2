using System;

namespace AutoV04
{

	public class AutoV04
    {
		public string Marke { get; set; }
		public string Modellname { get; set; }
		public string Baujahr { get; set; }
		public double Preis { get; set; }
    }

	public string AutoInfo()
	{
		return $"Marke: {Marke}, Modellname: {Modellname}, Baujahr: {Baujahr}, Preis: {Preis}";
	}

	public override string ToString()
    {
        return AutoInfo();
    }
}
