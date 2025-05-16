namespace ArtikelUebung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artikel1 artikel = new Artikel1(119.99m, "(XBox Spiel)Monster Hunter Wilds", 36789);
            Console.WriteLine(artikel.GetDetails());
        }
    }
}
