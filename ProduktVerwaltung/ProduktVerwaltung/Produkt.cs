namespace ProduktVerwaltung;

public class Produkt
{
	// Erstelle drei öffentliche Felder für: Name, Preis, Hersteller
	public string name;
	public double preis;
	public string hersteller;

	// Erstelle einen Konstruktor, der die Felder initialisiert / Werte zuweist
	public Produkt(string name, double preis, string hersteller)
	{
		this.name = name;
		this.preis = preis;
		this.hersteller = hersteller;
	}

	// Methode zur Anzeige der Produktinformationen
	public void produktAnzeigen()
    {
        Console.WriteLine($"Name: {name}, Preis: {preis} €, Hersteller: {hersteller}");
    }
}
