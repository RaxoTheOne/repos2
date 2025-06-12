using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Kontinent
    {
       private int knummer;
       private  string kBezeichnung = "";

        public Kontinent (int kn, string bz)
        {
            Knummer = kn;
            KBezeichnung = bz;
        }

        public int Knummer { get => knummer; set => knummer = value; }
        public string KBezeichnung { get => kBezeichnung; set => kBezeichnung = value; }
    }
}
