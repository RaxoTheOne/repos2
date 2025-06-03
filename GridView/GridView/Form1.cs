namespace GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            // dataGridViewArtikel.Rows.Clear();
            dataGridViewArtikel.Rows.Add(
                txtArtikelBezeichnung.Text,
                txtPreis.Text,
                txtFarbe.Text,
                txtArtikelArt.Text
                );
        }
    }
}
