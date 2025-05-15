namespace AutosV03___Sortieren
{
    public class Program
    {
        public static Auto[] autos = new Auto[20];
        static void Main(string[] args)
        {
            int auswahl = 0;
            Console.WriteLine("=============== Auto-Verwaltung ===============");
            string[] menu = new string[4];
            menu[0] = "1. Neues Auto hinzufügen";
            menu[1] = "2. Autos auflisten";
            menu[2] = "3. Autos nach Baujahr sortieren";
            menu[3] = "4. Ende";

            do
            {
                foreach (string item in menu)
                {
                    Console.WriteLine(item);
                }
                Console.Write("Bitte Auswahl treffen: ");

                if (!int.TryParse(Console.ReadLine(), out auswahl))
                {
                    Console.WriteLine("Ungültige Auswahl!");
                }

                // Überprüfen wir die Auswahl
                switch (auswahl)
                {
                    case 1:
                        autoHinzufuegen();
                        break;
                    case 2:
                        autosEinlesen();
                        break;
                    case 3:
                        autosSortieren();
                        break;
                    case 4:
                        break;

                    default:
                        Console.WriteLine("Ungültige Auswahl!");
                        break;
                }
            } while (auswahl != 4);
        }
        
        public static void autoHinzufuegen()
        {
            Console.WriteLine("Wieviele Autos möchten Sie hinzufügen?");

            int anzahl = 0;

            if (!int.TryParse(Console.ReadLine(), out anzahl))
            {
                Console.WriteLine("Ungültige Eingabe für Anzahl der Autos!");
            }
            for (int i = 0; i < anzahl; i++) 
            {
                Console.WriteLine("+++++++++++++ Auto " + (i + 1) + " ++++++++++++++");
                Console.WriteLine("Auto Model:");
                string automodel = Console.ReadLine();

                Console.WriteLine("Auto Baujahr:");
                int baujahr = 0;
                if (!int.TryParse(Console.ReadLine(), out baujahr))
                    Console.WriteLine("Ungültige Eingabe für Baujahr!");

                // Instsanzieren die Objekte
                autos[i] = new Auto(automodel, baujahr);
            }
        }
        public static void autosEinlesen()
        {
            for (int i = 0; i < Auto.autoAnzahl; i++)
            {
                Console.WriteLine("--------- {Auto "+ (i + 1) + "} ---------");
                autos[i].autoAnzeigen();
            }

            Console.WriteLine("Anzahl der Autos: " + Auto.autoAnzahl);
        }

        public static void autosSortieren()
        {
            int gefunden = 1;
            while (gefunden != 0)
            {
                gefunden = 0;

                for (int i = 0; i < Auto.autoAnzahl - 1; i++)
                {
                    if (autos[i].baujahr > autos[i + 1].baujahr)
                    {
                        Auto temp = autos[i];
                        autos[i] = autos[i + 1];
                        autos[i + 1] = temp;
                        gefunden = 1;
                    }
                }
            }
            Console.WriteLine("Autos wurden nach Baujahr sortiert!");
        }
    }
}
