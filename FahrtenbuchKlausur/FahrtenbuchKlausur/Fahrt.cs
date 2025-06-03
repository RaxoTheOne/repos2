using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FahrtenbuchKlausur // Namespace für das Fahrtenbuch-Projekt, das die Klassen und Logik für die Verwaltung von Fahrten enthält
{

	public class Fahrt // Klasse für eine Fahrt, die die Eigenschaften einer Fahrt definiert
	{
		public string? Stadt { get; set; } // Name der Stadt, in die die Fahrt geht
		public string? Bundesland { get; set; } // Bundesland, in dem sich die Stadt befindet
		public int Entfernung { get; set; } // Entfernung in Kilometern, die für die Fahrt zurückgelegt wird

		// So wird die Fahrt ín der Liste angezeigt
		public override string ToString() // Wandelt die Eingabe in einen lesbaren String um
		{
			return $"{Stadt}, {Bundesland}, {Entfernung} km"; // Formatierung des Strings
		}

		// So wird die Fahrt als Textzeile für die CSV-Datei geschrieben
		public string ToCSV() // Wandelt die Eingabe in einen CSV-String um
		{
			return $"{Stadt};{Bundesland};{Entfernung}"; // Formatierung des CSV-Strings
		}

		// So wird eine Textzeile in ein Fahrt-Objekt umgewandelt
		public static Fahrt FromCSV(string zeile)
		{
			string[] teile = zeile.Split(';'); // Zerlegt die CSV-Zeile in ihre Bestandteile
			Fahrt f = new Fahrt();
			f.Stadt = teile[0]; // Setzt die Stadt
			f.Bundesland = teile[1]; // Setzt das Bundesland
			f.Entfernung = int.Parse(teile[2]); // Setzt die Entfernung, konvertiert den String in einen Integer
			return f; // Gibt das Fahrt-Objekt zurück
		}
	}
}