using System;

public class Artikel1
{
	private decimal preis;
	private string bezeichnung;
	private int artikelnummer;

	public Artikel1(decimal preis, string bezeichnung, int artikelnummer)
	{
		this.preis = preis;
        this.bezeichnung = bezeichnung;
        this.artikelnummer = artikelnummer;
	}

	//Getter-Methoden
	public decimal GetPreis()
    {
        return preis;
    }

	public string GetBezeichnung()
    {
        return bezeichnung;
    }

	public int GetArtikelnummer()
    {
        return artikelnummer;
    }

    // Gibt alle Eigenschaften als zuammengesetzten String zurück
    public string GetDetails()
    {
        return $"Artikelnummer: {artikelnummer}, Bezeichnung: {bezeichnung}, Preis: {preis} EUR";
    }
}
