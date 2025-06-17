namespace Onlineshop
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBezeichnung = new TextBox();
            txtPreis = new TextBox();
            txtLager = new TextBox();
            btnSpeichern = new Button();
            lbProdukte = new ListBox();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnBildAuswahl = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 0;
            label1.Text = "Produkt Bezeichnung:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 144);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Preis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 217);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 2;
            label3.Text = "Lagerbestand:";
            // 
            // txtBezeichnung
            // 
            txtBezeichnung.Location = new Point(307, 74);
            txtBezeichnung.Name = "txtBezeichnung";
            txtBezeichnung.Size = new Size(234, 34);
            txtBezeichnung.TabIndex = 3;
            // 
            // txtPreis
            // 
            txtPreis.Location = new Point(306, 141);
            txtPreis.Name = "txtPreis";
            txtPreis.Size = new Size(235, 34);
            txtPreis.TabIndex = 4;
            // 
            // txtLager
            // 
            txtLager.Location = new Point(307, 217);
            txtLager.Name = "txtLager";
            txtLager.Size = new Size(234, 34);
            txtLager.TabIndex = 5;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(55, 432);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(231, 47);
            btnSpeichern.TabIndex = 6;
            btnSpeichern.Text = "Hinzufuegen";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // lbProdukte
            // 
            lbProdukte.FormattingEnabled = true;
            lbProdukte.ItemHeight = 28;
            lbProdukte.Location = new Point(621, 67);
            lbProdukte.Name = "lbProdukte";
            lbProdukte.Size = new Size(304, 368);
            lbProdukte.TabIndex = 7;
            lbProdukte.SelectedIndexChanged += lbProdukte_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 309);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 8;
            label4.Text = "Produkt  Bild:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBildAuswahl
            // 
            btnBildAuswahl.Location = new Point(307, 303);
            btnBildAuswahl.Name = "btnBildAuswahl";
            btnBildAuswahl.Size = new Size(139, 41);
            btnBildAuswahl.TabIndex = 9;
            btnBildAuswahl.Text = "Bild-Auswahl";
            btnBildAuswahl.UseVisualStyleBackColor = true;
            btnBildAuswahl.Click += btnBildAuswahl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(475, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 526);
            label5.Name = "label5";
            label5.Size = new Size(225, 28);
            label5.TabIndex = 11;
            label5.Text = "Welkommen Benutzer 1!";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(294, 517);
            button1.Name = "button1";
            button1.Size = new Size(131, 47);
            button1.TabIndex = 12;
            button1.Text = "Ausloggen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(352, 432);
            button2.Name = "button2";
            button2.Size = new Size(207, 44);
            button2.TabIndex = 13;
            button2.Text = "Bearbeiten";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 584);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnBildAuswahl);
            Controls.Add(label4);
            Controls.Add(lbProdukte);
            Controls.Add(btnSpeichern);
            Controls.Add(txtLager);
            Controls.Add(txtPreis);
            Controls.Add(txtBezeichnung);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBezeichnung;
        private TextBox txtPreis;
        private TextBox txtLager;
        private Button btnSpeichern;
        private ListBox lbProdukte;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Button btnBildAuswahl;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}