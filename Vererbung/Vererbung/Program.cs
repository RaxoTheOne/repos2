namespace Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck r = new Rechteck(3, 10);
            Console.WriteLine("Rechteck Fläche = " + r.flaeche());
            Console.WriteLine("Rechteck Umfang = " + r.umfang());

            Quadrat q = new Quadrat(5);
            Console.WriteLine("Quadrat Fläche: " + q.flaeche());
            Console.WriteLine("Quadrat Umfang: " + q.umfang());

            Quader qr = new Quader(3, 4, 5);
            Console.WriteLine("Quader Volumen: " + qr.flaeche());
            Console.WriteLine("Quader Oberfläche: " + qr.umfang());

            Wuerfel w = new Wuerfel(3);
            Console.WriteLine("Würfel Volumen: " + w.flaeche());
            Console.WriteLine("Würfel Oberfläche: " + w.umfang());
        }
    }
}