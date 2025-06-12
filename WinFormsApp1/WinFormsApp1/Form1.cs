namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        List<Kontinent> kontinentliste = new List<Kontinent>();
        List<Gehege> gehegeliste = new List<Gehege>();
        private Datenbank db = new Datenbank();


        public Form1()
        {
            InitializeComponent();
            kontinentliste = db.getKontinents();
            kontinentAnzeigen();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateGDatum.Value = DateTime.Now;
        }

        private void btnksave_Click(object sender, EventArgs e)
        {
            string kBezeichnung = txtkbezeichnung.Text;
            Kontinent neuek = new Kontinent(0, kBezeichnung);
            db.insertIntoKontinent(neuek);


            kontinentAnzeigen();


        }
        private void kontinentAnzeigen()
        {
            kontinentliste.Clear();
            kontinentliste = db.getKontinents();
            lbKontinent.Items.Clear();
            cbKontinent.Items.Clear();
            foreach (var a in kontinentliste)
            {
                lbKontinent.Items.Add(a.KBezeichnung);
                cbKontinent.Items.Add(a.KBezeichnung);
            }
        }

        private void btnkloeschen_Click(object sender, EventArgs e)
        {
            int kontinentnummer = kontinentliste[lbKontinent.SelectedIndex].Knummer;
            db.kontinentLoeschen(kontinentnummer);

            lbKontinent.Items.Clear();
            cbKontinent.Items.Clear();
            kontinentliste.Clear();
            kontinentliste = db.getKontinents();
            foreach (var a in kontinentliste)
            {
                lbKontinent.Items.Add(a.KBezeichnung);
                cbKontinent.Items.Add(a.KBezeichnung);
            }
        }

        private void ExportTiereToCSV()
        {
            string dateipfad = "tiere.csv";

            List<Tiere> tiere = db.getTiere();
        }

        private void btnToCSV_Click(object sender, EventArgs e)
        {
            ExportTiereToCSV();
        }
    }
}
