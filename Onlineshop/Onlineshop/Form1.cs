namespace Onlineshop
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
            string bname = txtBenutzername.Text;
            string passwort = txtPasswort.Text;

            Benutzer b = db.benutzerUberpruefen(bname, passwort);
            if (b != null)
            {
                this.Hide();
                Form2 form2 = new Form2(b.Benutzername);
                form2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Benutzer Name oder Kenttwort ist falsch!");
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string benutzername = txtBenutzername.Text;
            string passwort = txtPasswort.Text;
            if (db.benutzerUberpruefen(benutzername, passwort) != null)
            {
                MessageBox.Show("Es gib einen Benutzer in der Datenbank!");
            }
            else
            {
                Benutzer neuenBenutzer = new Benutzer(0, benutzername, passwort);
                //Fuegen den Benutzer in der Datenbank
                db.benutzerHinzufuegen(neuenBenutzer);

                MessageBox.Show("Das Konto wird erfolgreich erstellt!");
            }
        }
    }
}
