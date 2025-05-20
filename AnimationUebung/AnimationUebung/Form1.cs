namespace AnimationUebung
{
    public partial class Form1 : Form
    {
        int geschwindigkeit = 1;

        // 0 = rot, 1 = gelb, 2 = grün
        int phase = 0;

        int rueckwaerts = 0;

        PictureBox[] ampel = new PictureBox[3];

        public Form1()
        {
            InitializeComponent();

            ampel[0] = pbRot;
            ampel[1] = pbGelb;
            ampel[2] = pbGruen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rueckwaerts == 0)
            {
                if (!(phase == 0 && pictureBox1.Location.X >= 300 && pictureBox1.Location.X <= 350))
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - geschwindigkeit, pictureBox1.Location.Y);

                    if (pictureBox1.Location.X < -pictureBox1.Width)
                    {
                        pictureBox1.Location = new Point(this.Width, pictureBox1.Location.Y);
                    }
                }
            }
            else
            {
                if (!(phase == 0 && pictureBox1.Location.X >= 130 && pictureBox1.Location.X<= 175))
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + geschwindigkeit, pictureBox1.Location.Y);

                    if (pictureBox1.Location.X > this.Width)
                    {
                        pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                    }
                }
            }
        }

        private void numGeschwindigkeitsregler_ValueChanged(object sender, EventArgs e)
        {
            geschwindigkeit = (int)numGeschwindigkeitsregler.Value;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            numGeschwindigkeitsregler.Value = 1;
            rueckwaerts = 0;

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            numGeschwindigkeitsregler.Value = 0;
        }
        private void RückwärtsButton_Click(object sender, EventArgs e)
        {
           // numGeschwindigkeitsregler.Value = -1;
            rueckwaerts =1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Alle Bilder zuerst unsichtbar machen
            pbRot.Visible = false;
            pbGelb.Visible = false;
            pbGruen.Visible = false;

            // Bild je nach Phase sichbar machen
            switch (phase)
            {
                // Phase 0 = rot
                case 0:
                    pbRot.Visible = true;
                    break;
                // Phase 1 = Gelb/Rot
                case 1:
                    pbRot.Visible = true;
                    pbGelb.Visible = true;
                    break;
                // Phase 2 = Gelb
                case 2:
                    pbGelb.Visible = true;
                    break;
                // Phase 3 = grün
                case 3:
                    pbGruen.Visible = true;
                    break;
                // Phase 4 = GRün/Gelb
                case 4:
                    pbGruen.Visible = true;
                    pbGelb.Visible = true;
                    break;
                // Phase 5 = Gelb
                case 5:
                    pbGelb.Visible = true;
                    break;
                // Phase 6 = Rot
                case 6:
                    pbRot.Visible = true;
                    break;
            }
            // Phase erhöhen
            phase = (phase + 1) % 7;
        }
    }
}
