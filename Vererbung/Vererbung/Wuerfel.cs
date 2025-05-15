using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
	// Die Klasse Wuerfel erbt von der Klasse Quader
	public class Wuerfel : Quader
	{
		public Wuerfel(int b) : base(b, b, b)
		{

		}
	}
}