using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooverwaltung
{
    public class Futter
    {
        int nummer;
        string name = "";

        public Futter(int nummer, string name)
        {
            Nummer = nummer;
            Name = name;
        }

        public int Nummer { get => nummer; set => nummer = value; }
        public string Name { get => name; set => name = value; }
    }
}
