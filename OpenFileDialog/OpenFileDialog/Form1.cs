namespace OpenFileDialog
{
    public partial class Form1 : Form
    {
        private string bildPfad;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.png";
            
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                bildPfad = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string extension = Path.GetExtension(bildPfad); //.jpg
            string neuesBildname= textBox1.Text.Trim()+extension;

            string speicherOrdner = @"C:\tierebilder";
            Directory.CreateDirectory(speicherOrdner);

            string speicherBildAdresse = Path.Combine(speicherOrdner, neuesBildname);
            
            File.Copy(bildPfad, speicherBildAdresse, true);

            pictureBox1.Image = Image.FromFile(speicherBildAdresse);
        }
    }
}
