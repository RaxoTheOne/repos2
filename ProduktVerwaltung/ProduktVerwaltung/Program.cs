using System;
using System.Collections.Generic;

namespace ProduktVerwaltung
{
    class Program
    {
        static List<Produkt> produkte = new List<Produkt>();
        static void Main()
        {
            int auswahl;

            do
            {
                Console.WriteLine("\n===== Produktverwaltung =====");
                Console.WriteLine("1. Produkt hinzufügen");
                Console.WriteLine("2. Produkt anzeigen");
                Console.WriteLine("3. Produkte nach Preis sortieren");
                Console.WriteLine("4. Beenden");
                Console.Write("Bitte wählen Sie eine Option: ");

                // Eingabe einlesen und Prüfen
                if (!int.TryParse(Console.ReadLine(), out auswahl))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte versuchen Sie es erneut.");
                    continue;
                }

                switch (auswahl)
                {
                    case 1:
                        produktHinzufuegen();
                        break;
                    case 2:
                        produktAnzeigen();
                        break;
                    case 3:
                        produkteNachPreisSortieren();
                        break;
                    case 4:
                        Console.WriteLine("Programm wird beendet.");
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl! Bitte wählen Sie eine Option zwischen 1 und 4.");
                        break;
                }
            } while (auswahl != 4);
        }
        static void produktHinzufuegen()
        {
            Console.Write("Produktnamen: ");
            string name = Console.ReadLine();

            Console.Write("Preis: ");
            if (!double.TryParse(Console.ReadLine(), out double preis))
            { 
                Console.WriteLine("Ungültige Eingabe für den Preis. Bitte versuchen Sie es erneut.");
                return;
            }

            Console.Write("Hersteller: ");
            string hersteller = Console.ReadLine();

            // Neues Produkt erstellen und zur Liste hinzufügen
            Produkt p = new Produkt(name, preis, hersteller);
            produkte.Add(p);

            Console.WriteLine("Produkt hinzugefügt: " + p.name);
        }

        // Funktion: alle Produkte anzeigen
        static void produktAnzeigen()
        {
            if (produkte.Count == 0)
            {
                Console.WriteLine("Keine Produkte vorhanden.");
                return;
            }

            Console.WriteLine("\n------Produktliste------");
            foreach (Produkt p in produkte)
            {
                p.produktAnzeigen();
            }
        }

        // Funktion: Produkte nach Preis sortieren
        static void produkteNachPreisSortieren()
        {
            produkte.Sort((a, b) => a.preis.CompareTo(b.preis));
            Console.WriteLine("\nProdukte wurden nach Preis sortiert.");

            // Sortierte Liste anzeigen
            foreach (Produkt p in produkte)
            {
                p.produktAnzeigen();
            }
        }
    }
}
