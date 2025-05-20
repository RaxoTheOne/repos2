namespace AnimationUebung
{
    public partial class Form1 : Form
    {
        int geschwindigkeit = 1;

        // 0 = rot, 1 = gelb, 2 = grün
        int phase = 0;
        int phase2 = 0;

        int rueckwaerts = 0;

        PictureBox[] ampel = new PictureBox[3];
        PictureBox[] ampel2 = new PictureBox[3];

        public Form1()
        {
            InitializeComponent();

            ampel[0] = pbRot;
            ampel[1] = pbGelb;
            ampel[2] = pbGruen;

            ampel2[0] = pbRot2;
            ampel2[1] = pbGelb2;
            ampel2[2] = pbGruen2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Fahrzeug 1 bewegen
            if (rueckwaerts == 0)
            {
                if (!(phase == 0 && pictureBox1.Location.X >= 390 && pictureBox1.Location.X <= 410))
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
                if (!(phase == 0 && pictureBox1.Location.X >= 260 && pictureBox1.Location.X <= 280))
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + geschwindigkeit, pictureBox1.Location.Y);

                    if (pictureBox1.Location.X > this.Width)
                    {
                        pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                    }
                }
            }

            // Fahrzeug 2 bewegen – dieselbe Logik, andere Position prüfen
            if (rueckwaerts == 0)
            {
                if (!(phase2 == 0 && pictureBox2.Location.X >= 390 && pictureBox2.Location.X <= 410))
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X - geschwindigkeit, pictureBox2.Location.Y);

                    if (pictureBox2.Location.X < -pictureBox2.Width)
                    {
                        pictureBox2.Location = new Point(this.Width, pictureBox2.Location.Y);
                    }
                }
            }
            else
            {
                if (!(phase2 == 0 && pictureBox2.Location.X >= 260 && pictureBox2.Location.X <= 280))
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + geschwindigkeit, pictureBox2.Location.Y);

                    if (pictureBox2.Location.X > this.Width)
                    {
                        pictureBox2.Location = new Point(0, pictureBox2.Location.Y);
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
            numGeschwindigkeitsregler.Value = 1;
            rueckwaerts = 1;
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Alle Bilder zuerst unsichtbar machen
            pbRot2.Visible = false;
            pbGelb2.Visible = false;
            pbGruen2.Visible = false;

            // Bild je nach Phase sichbar machen
            switch (phase2)
            {
                // Phase 0 = rot
                case 0:
                    pbRot2.Visible = true;
                    break;
                // Phase 1 = Gelb/Rot
                case 1:
                    pbRot2.Visible = true;
                    pbGelb2.Visible = true;
                    break;
                // Phase 2 = Gelb
                case 2:
                    pbGelb2.Visible = true;
                    break;
                // Phase 3 = grün
                case 3:
                    pbGruen2.Visible = true;
                    break;
                // Phase 4 = GRün/Gelb
                case 4:
                    pbGruen2.Visible = true;
                    pbGelb2.Visible = true;
                    break;
                // Phase 5 = Gelb
                case 5:
                    pbGelb2.Visible = true;
                    break;
                // Phase 6 = Rot
                case 6:
                    pbRot2.Visible = true;
                    break;
            }
            // Phase erhöhen
            phase2 = (phase2 + 1) % 7;
        }
    }
}
