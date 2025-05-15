namespace Vererbung
{
	public class Quader : Rechteck
	{
		private int tiefe;

		public Quader(int h, int b, int t) : base(h, b)
		{
			tiefe = t;
		}

		public int volumen()
		{
			return flaeche() * tiefe;
		}

		public int oberflaeche()
		{
			return 2 * (flaeche() + (tiefe * breite) + (tiefe * hoehe));
		}
	}
}