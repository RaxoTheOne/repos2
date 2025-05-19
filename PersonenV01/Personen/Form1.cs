namespace PersonenV01
{
    public partial class Form1 : Form
    {
        Person[] personen = new Person[20];
        int personzaehler = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vname = txtVorname.Text;
            string nname = txtNachname.Text;

            if (!string.IsNullOrEmpty(vname) && !string.IsNullOrEmpty(nname))
            {

                Person person1 = new Person(nname, vname);

                personen[personzaehler] = person1;
                listPerson.Items.Add(person1.personInfo());

                personzaehler++;

                txtVorname.Clear();
                txtNachname.Clear();
            }

        }

        private void listPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexnummer = listPerson.SelectedIndices[0];

            Person p = personen[indexnummer];

            txtVorname.Text = p.Vorname;
            txtNachname.Text = p.Nachname;


        }

        private void Bearbeiten_Click(object sender, EventArgs e)
        {
            int index = listPerson.SelectedIndices[0];
            string neuevname = txtVorname.Text;
            string neuenname = txtNachname.Text;

            // neue Person wird erstellt 
            // Person neuePerson = new Person(neuenname, neuevname);
            
            // personen[index].Vorname = neuevname;
            personen[index].Nachname = neuenname;
            personen[index].Vorname = neuevname;


            txtVorname.Clear() ;
            txtNachname.Clear() ;

            listPerson.Items.Clear();

            for (int i = 0; i< personzaehler; i++)
            {
                listPerson.Items.Add(personen[i].personInfo());
            }

        }
    }
}
