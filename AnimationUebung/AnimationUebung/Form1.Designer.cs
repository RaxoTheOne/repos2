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
            pictureBox2 = new PictureBox();
            pbGruen2 = new PictureBox();
            pbGelb2 = new PictureBox();
            pbRot2 = new PictureBox();
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGeschwindigkeitsregler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGelb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGruen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGruen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGelb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRot2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(262, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 58);
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
            StopButton.Location = new Point(220, 66);
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
            StartButton.Location = new Point(48, 66);
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
            pbRot.Location = new Point(355, 118);
            pbRot.Name = "pbRot";
            pbRot.Size = new Size(37, 68);
            pbRot.SizeMode = PictureBoxSizeMode.Zoom;
            pbRot.TabIndex = 5;
            pbRot.TabStop = false;
            // 
            // pbGelb
            // 
            pbGelb.Image = (Image)resources.GetObject("pbGelb.Image");
            pbGelb.Location = new Point(355, 118);
            pbGelb.Name = "pbGelb";
            pbGelb.Size = new Size(37, 68);
            pbGelb.SizeMode = PictureBoxSizeMode.Zoom;
            pbGelb.TabIndex = 6;
            pbGelb.TabStop = false;
            // 
            // pbGruen
            // 
            pbGruen.Image = (Image)resources.GetObject("pbGruen.Image");
            pbGruen.Location = new Point(355, 118);
            pbGruen.Name = "pbGruen";
            pbGruen.Size = new Size(37, 68);
            pbGruen.SizeMode = PictureBoxSizeMode.Zoom;
            pbGruen.TabIndex = 7;
            pbGruen.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 800;
            timer2.Tick += timer2_Tick;
            // 
            // RückwärtsButton
            // 
            RückwärtsButton.BackColor = SystemColors.ActiveCaption;
            RückwärtsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RückwärtsButton.Location = new Point(394, 66);
            RückwärtsButton.Name = "RückwärtsButton";
            RückwärtsButton.Size = new Size(132, 36);
            RückwärtsButton.TabIndex = 8;
            RückwärtsButton.Text = "Rückwärts";
            RückwärtsButton.UseVisualStyleBackColor = false;
            RückwärtsButton.Click += RückwärtsButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(394, 307);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pbGruen2
            // 
            pbGruen2.Image = (Image)resources.GetObject("pbGruen2.Image");
            pbGruen2.Location = new Point(355, 369);
            pbGruen2.Name = "pbGruen2";
            pbGruen2.Size = new Size(37, 68);
            pbGruen2.SizeMode = PictureBoxSizeMode.Zoom;
            pbGruen2.TabIndex = 12;
            pbGruen2.TabStop = false;
            // 
            // pbGelb2
            // 
            pbGelb2.Image = (Image)resources.GetObject("pbGelb2.Image");
            pbGelb2.Location = new Point(355, 369);
            pbGelb2.Name = "pbGelb2";
            pbGelb2.Size = new Size(37, 68);
            pbGelb2.SizeMode = PictureBoxSizeMode.Zoom;
            pbGelb2.TabIndex = 11;
            pbGelb2.TabStop = false;
            // 
            // pbRot2
            // 
            pbRot2.Image = (Image)resources.GetObject("pbRot2.Image");
            pbRot2.Location = new Point(355, 369);
            pbRot2.Name = "pbRot2";
            pbRot2.Size = new Size(37, 68);
            pbRot2.SizeMode = PictureBoxSizeMode.Zoom;
            pbRot2.TabIndex = 10;
            pbRot2.TabStop = false;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 800;
            timer3.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbGruen2);
            Controls.Add(pbGelb2);
            Controls.Add(pbRot2);
            Controls.Add(pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGruen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGelb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRot2).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pbGruen2;
        private PictureBox pbGelb2;
        private PictureBox pbRot2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
