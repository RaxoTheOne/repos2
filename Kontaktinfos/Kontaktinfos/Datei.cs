using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktinfos
{
    public class Datei
    {
        public string datei = "kontakte.csv";
        private FileStream stream;

        public void schreibeCSV(List<Kontakte> likon)
        {
            stream = new FileStream(datei, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(stream);

            foreach (Kontakte k in likon)
            {
                sr.WriteLine(k.toCSV());
            }

            sr.Close();
            stream.Close();
        }

        public List<Kontakte> leseCSV()
        {
            List<Kontakte> kontakte = new List<Kontakte>();
            string s;
            string[] arrstr;

            stream = new FileStream(datei, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);

            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                arrstr = s.Split(';');
                kontakte.Add(
                    new Kontakte(arrstr[0], arrstr[1],
                                 arrstr[2], arrstr[3],
                                 arrstr[4], int.Parse(arrstr[5]),
                                 arrstr[6], arrstr[7]));
            }

            sr.Close();
            stream.Close();

            return kontakte;
        }
    }
}
