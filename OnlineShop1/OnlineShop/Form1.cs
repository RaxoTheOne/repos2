namespace OnlineShop
{
    public partial class Form1 : Form
    {
        Datenbank db = new Datenbank();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string bname = txtBenuztername.Text;
            string passwort = txtPasswort.Text;

            Benutzer b = db.BenutzerUeberpruefen(bname, passwort);
            if (b != null)
            {
                this.Hide();
                Form2 form2 = new Form2(b.Benutzername);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch");
            }
        }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            string benutzername = txtBenuztername.Text;
            string passwort = txtPasswort.Text;
            if (db.BenutzerUeberpruefen(benutzername, passwort) != null)
            {
                MessageBox.Show("Es gibt einen Benutzer in der Datenbank!");
            }
            else
            {
                Benutzer neuenBenutzer = new Benutzer(0, benutzername, passwort);
                // Füge den Benutzer in die Datenbank ein
                db.BenutzerHinzufuegen(neuenBenutzer);

                MessageBox.Show("Das Konto wird erfolgreich erstellt!");
            }
        }
    }
}
