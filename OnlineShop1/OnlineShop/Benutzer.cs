using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{

	public class Benutzer
	{
		private int benutzerid;
		private string benutzername = "";
		private string passwort = "";

		public Benutzer(int benutzerid, string benutzername, string passwort)
        {
			this.benutzerid = benutzerid;
            this.benutzername = benutzername;
            this.passwort = passwort;
        }

		public int Benutzerid { get => benutzerid; set => benutzerid = value; }
		public string Benutzername { get => benutzername; set => benutzername = value; }
		public string Passwort { get => passwort; set => passwort = value; }
	}
}