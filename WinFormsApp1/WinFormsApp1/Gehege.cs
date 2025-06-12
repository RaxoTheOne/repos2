using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Gehege
    {

        private int gnummer;
        private string gBezeichnung = "";
        private int kontinentnr;

        public Gehege(int gn, string gB, int knr)
        {
            this.Gnummer = gn;
            this.GBezeichnung = gB;
            this.Kontinentnr = knr;
        }

        public int Gnummer { get => gnummer; set => gnummer = value; }
        public string GBezeichnung { get => gBezeichnung; set => gBezeichnung = value; }
        public int Kontinentnr { get => kontinentnr; set => kontinentnr = value; }
    }
}
