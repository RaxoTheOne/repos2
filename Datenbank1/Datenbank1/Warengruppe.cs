using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datenbank1
{
	public class Warengruppe
	{
		private int wgNr;
		private string wgBezeichnung;

		public int WgNr { get => wgNr; set => wgNr = value; }
		public string WgBezeichnung { get => wgBezeichnung; set => wgBezeichnung = value; }

		public Warengruppe(int nr, string bez)
		{
			this.wgNr = nr;
			this.wgBezeichnung = bez;
		}
	}
}