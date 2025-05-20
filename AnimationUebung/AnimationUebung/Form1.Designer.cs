namespace AnimationUebung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            numGeschwindigkeitsregler = new NumericUpDown();
            label1 = new Label();
            StopButton = new Button();
            StartButton = new Button();
            pbRot = new PictureBox();
            pbGelb = new PictureBox();
            pbGruen = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            RückwärtsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGeschwindigkeitsregler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGelb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGruen).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(455, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // numGeschwindigkeitsregler
            // 
            numGeschwindigkeitsregler.Location = new Point(237, 25);
            numGeschwindigkeitsregler.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numGeschwindigkeitsregler.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            numGeschwindigkeitsregler.Name = "numGeschwindigkeitsregler";
            numGeschwindigkeitsregler.Size = new Size(115, 23);
            numGeschwindigkeitsregler.TabIndex = 1;
            numGeschwindigkeitsregler.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numGeschwindigkeitsregler.ValueChanged += numGeschwindigkeitsregler_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 2;
            label1.Text = "Geschwindigkeitsregler";
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.Red;
            StopButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopButton.Location = new Point(220, 73);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(132, 36);
            StopButton.TabIndex = 3;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Lime;
            StartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(48, 73);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(132, 36);
            StartButton.TabIndex = 4;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // pbRot
            // 
            pbRot.Image = (Image)resources.GetObject("pbRot.Image");
            pbRot.Location = new Point(357, 133);
            pbRot.Name = "pbRot";
            pbRot.Size = new Size(104, 179);
            pbRot.SizeMode = PictureBoxSizeMode.Zoom;
            pbRot.TabIndex = 5;
            pbRot.TabStop = false;
            // 
            // pbGelb
            // 
            pbGelb.Image = (Image)resources.GetObject("pbGelb.Image");
            pbGelb.Location = new Point(357, 133);
            pbGelb.Name = "pbGelb";
            pbGelb.Size = new Size(104, 179);
            pbGelb.SizeMode = PictureBoxSizeMode.Zoom;
            pbGelb.TabIndex = 6;
            pbGelb.TabStop = false;
            // 
            // pbGruen
            // 
            pbGruen.Image = (Image)resources.GetObject("pbGruen.Image");
            pbGruen.Location = new Point(357, 133);
            pbGruen.Name = "pbGruen";
            pbGruen.Size = new Size(104, 179);
            pbGruen.SizeMode = PictureBoxSizeMode.Zoom;
            pbGruen.TabIndex = 7;
            pbGruen.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // RückwärtsButton
            // 
            RückwärtsButton.BackColor = SystemColors.ActiveCaption;
            RückwärtsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RückwärtsButton.Location = new Point(394, 73);
            RückwärtsButton.Name = "RückwärtsButton";
            RückwärtsButton.Size = new Size(132, 36);
            RückwärtsButton.TabIndex = 8;
            RückwärtsButton.Text = "Rückwärts";
            RückwärtsButton.UseVisualStyleBackColor = false;
            RückwärtsButton.Click += RückwärtsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RückwärtsButton);
            Controls.Add(pbGruen);
            Controls.Add(pbGelb);
            Controls.Add(pbRot);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(label1);
            Controls.Add(numGeschwindigkeitsregler);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGeschwindigkeitsregler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGelb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGruen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numGeschwindigkeitsregler;
        private Label label1;
        private Button StopButton;
        private Button StartButton;
        private PictureBox pbRot;
        private PictureBox pbGelb;
        private PictureBox pbGruen;
        private System.Windows.Forms.Timer timer2;
        private Button RückwärtsButton;
    }
}
