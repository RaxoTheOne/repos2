﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Auto
{
	public class Auto()
	{
		public string model;
		public int baujahr;
		public string farbe;
		public int geschwindigkeit;

		public Auto(string m, int bauj, string f)
        {
            model = m;
            baujahr = bauj;
            farbe = f;
        }

		public void autoanzeigen()
        {
            Console.WriteLine("Auto-Model:", + model);
			Console.WriteLine("Baujahr:", + baujahr);
			Console.WriteLine("Farbe:", + farbe);
			Console.WriteLine("================================================");
        }

		public void autofahren()
        {
            Console.WriteLine("Das Auto " + model + " fährt mit " + geschwindigkeit + "km/H");
        }

		public void autobeschleunigen()
		{
			geschwindigkeit += 10
		}

		public void autobremsen()
        {
            if (geschwindigkeit > 0)
            {
                geschwindigkeit -= 10;
            }
            else
            {
                Console.WriteLine("Das Auto ist bereits gestoppt.");
            }
        }
	}
}
