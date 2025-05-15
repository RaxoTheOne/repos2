using System.ComponentModel.DataAnnotations;

namespace Vererbung
{

	public class Rechteck
	{
		protected int hoehe;
		protected int breite;

		public Rechteck(int h, int b)
		{
			hoehe = h;
			breite = b;
		}

		public int flaeche()
		{
			return hoehe + breite;
		}

		public int umfang()
		{
			return 2 * (hoehe + breite);
		}
	}
}
