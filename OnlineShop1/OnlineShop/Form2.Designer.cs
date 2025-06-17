namespace OnlineShop
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
            lblProduktname = new Label();
            lblPreis = new Label();
            lblLagerbestand = new Label();
            txtLagerbestand = new TextBox();
            txtPreis = new TextBox();
            txtProduktname = new TextBox();
            lbProdukte = new ListBox();
            btnSpeichern = new Button();
            lblBild = new Label();
            btnBildAuswahl = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnBearbeiten = new Button();
            lblWillkommen = new Label();
            btnAusloggen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblProduktname
            // 
            lblProduktname.AutoSize = true;
            lblProduktname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblProduktname.Location = new Point(51, 28);
            lblProduktname.Name = "lblProduktname";
            lblProduktname.Size = new Size(133, 25);
            lblProduktname.TabIndex = 0;
            lblProduktname.Text = "Produktname:";
            lblProduktname.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblPreis.Location = new Point(125, 106);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(58, 25);
            lblPreis.TabIndex = 1;
            lblPreis.Text = "Preis:";
            lblPreis.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLagerbestand
            // 
            lblLagerbestand.AutoSize = true;
            lblLagerbestand.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblLagerbestand.Location = new Point(51, 184);
            lblLagerbestand.Name = "lblLagerbestand";
            lblLagerbestand.Size = new Size(132, 25);
            lblLagerbestand.TabIndex = 2;
            lblLagerbestand.Text = "Lagerbestand:";
            lblLagerbestand.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtLagerbestand
            // 
            txtLagerbestand.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtLagerbestand.Location = new Point(197, 181);
            txtLagerbestand.Name = "txtLagerbestand";
            txtLagerbestand.Size = new Size(267, 33);
            txtLagerbestand.TabIndex = 3;
            // 
            // txtPreis
            // 
            txtPreis.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtPreis.Location = new Point(197, 103);
            txtPreis.Name = "txtPreis";
            txtPreis.Size = new Size(267, 33);
            txtPreis.TabIndex = 4;
            // 
            // txtProduktname
            // 
            txtProduktname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtProduktname.Location = new Point(197, 25);
            txtProduktname.Name = "txtProduktname";
            txtProduktname.Size = new Size(267, 33);
            txtProduktname.TabIndex = 5;
            // 
            // lbProdukte
            // 
            lbProdukte.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbProdukte.FormattingEnabled = true;
            lbProdukte.ItemHeight = 21;
            lbProdukte.Location = new Point(524, 28);
            lbProdukte.Name = "lbProdukte";
            lbProdukte.Size = new Size(335, 445);
            lbProdukte.TabIndex = 6;
            lbProdukte.SelectedIndexChanged += lbProdukte_SelectedIndexChanged;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnSpeichern.Location = new Point(51, 371);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(154, 42);
            btnSpeichern.TabIndex = 7;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // lblBild
            // 
            lblBild.AutoSize = true;
            lblBild.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblBild.Location = new Point(134, 285);
            lblBild.Name = "lblBild";
            lblBild.Size = new Size(49, 25);
            lblBild.TabIndex = 8;
            lblBild.Text = "Bild:";
            lblBild.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBildAuswahl
            // 
            btnBildAuswahl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnBildAuswahl.Location = new Point(197, 276);
            btnBildAuswahl.Name = "btnBildAuswahl";
            btnBildAuswahl.Size = new Size(154, 42);
            btnBildAuswahl.TabIndex = 9;
            btnBildAuswahl.Text = "Bild auswählen";
            btnBildAuswahl.UseVisualStyleBackColor = true;
            btnBildAuswahl.Click += btnBildAuswahl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(357, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBearbeiten
            // 
            btnBearbeiten.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnBearbeiten.Location = new Point(277, 371);
            btnBearbeiten.Name = "btnBearbeiten";
            btnBearbeiten.Size = new Size(154, 42);
            btnBearbeiten.TabIndex = 11;
            btnBearbeiten.Text = "Bearbeiten";
            btnBearbeiten.UseVisualStyleBackColor = true;
            btnBearbeiten.Click += btnBearbeiten_Click;
            // 
            // lblWillkommen
            // 
            lblWillkommen.AutoSize = true;
            lblWillkommen.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWillkommen.Location = new Point(35, 467);
            lblWillkommen.Name = "lblWillkommen";
            lblWillkommen.Size = new Size(216, 25);
            lblWillkommen.TabIndex = 12;
            lblWillkommen.Text = "Wilkommen Benutzer 1!";
            // 
            // btnAusloggen
            // 
            btnAusloggen.BackColor = Color.IndianRed;
            btnAusloggen.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAusloggen.ForeColor = SystemColors.ButtonHighlight;
            btnAusloggen.Location = new Point(257, 455);
            btnAusloggen.Name = "btnAusloggen";
            btnAusloggen.Size = new Size(131, 47);
            btnAusloggen.TabIndex = 13;
            btnAusloggen.Text = "Ausloggen";
            btnAusloggen.UseVisualStyleBackColor = false;
            btnAusloggen.Click += btnAusloggen_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 520);
            Controls.Add(btnAusloggen);
            Controls.Add(lblWillkommen);
            Controls.Add(btnBearbeiten);
            Controls.Add(pictureBox1);
            Controls.Add(btnBildAuswahl);
            Controls.Add(lblBild);
            Controls.Add(btnSpeichern);
            Controls.Add(lbProdukte);
            Controls.Add(txtProduktname);
            Controls.Add(txtPreis);
            Controls.Add(txtLagerbestand);
            Controls.Add(lblLagerbestand);
            Controls.Add(lblPreis);
            Controls.Add(lblProduktname);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduktname;
        private Label lblPreis;
        private Label lblLagerbestand;
        private TextBox txtLagerbestand;
        private TextBox txtPreis;
        private TextBox txtProduktname;
        private ListBox lbProdukte;
        private Button btnSpeichern;
        private Label lblBild;
        private Button btnBildAuswahl;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnBearbeiten;
        private Label lblWillkommen;
        private Button btnAusloggen;
    }
}