using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lager1
{
    public class Datei
    {
        public string datei = "lager.csv";
        private FileStream stream;

        public void schreibeCSV(List<Artikel> liart)
        {
            stream = new FileStream(datei, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(stream);

            foreach (Artikel l in liart)
            {
                sr.WriteLine(l.toCSV());
            }

            sr.Close();
            stream.Close();
        }

        public List<Artikel> leseCSV()
        {
            List<Artikel> artikel = new List<Artikel>();
            string s;
            string[] arrstr;

            stream = new FileStream(datei, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);

            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                arrstr = s.Split(';');
                artikel.Add(
                    new Artikel(Convert.ToInt32(arrstr[0]), arrstr[1],
                                arrstr[2], Convert.ToDouble(arrstr[3]),
                                Convert.ToInt32(arrstr[4])));
            }

            sr.Close();
            stream.Close();

            return artikel;
        }
    }
}