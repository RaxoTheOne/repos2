namespace GridView
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
            tabControl1 = new TabControl();
            tbpArtikel = new TabPage();
            btnSpeichern = new Button();
            lblFarbe = new Label();
            txtFarbe = new TextBox();
            txtPreis = new TextBox();
            lblPreis = new Label();
            txtArtikelBezeichnung = new TextBox();
            lblArtikelName = new Label();
            tbpArtikelliste = new TabPage();
            dataGridViewArtikel = new DataGridView();
            Artikel = new DataGridViewTextBoxColumn();
            ArtikelPreis = new DataGridViewTextBoxColumn();
            ArtikelFarbe = new DataGridViewTextBoxColumn();
            ArtikelArt = new DataGridViewTextBoxColumn();
            lblArtikelArt = new Label();
            txtArtikelArt = new TextBox();
            tabControl1.SuspendLayout();
            tbpArtikel.SuspendLayout();
            tbpArtikelliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtikel).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpArtikel);
            tabControl1.Controls.Add(tbpArtikelliste);
            tabControl1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 434);
            tabControl1.TabIndex = 0;
            // 
            // tbpArtikel
            // 
            tbpArtikel.Controls.Add(txtArtikelArt);
            tbpArtikel.Controls.Add(lblArtikelArt);
            tbpArtikel.Controls.Add(btnSpeichern);
            tbpArtikel.Controls.Add(lblFarbe);
            tbpArtikel.Controls.Add(txtFarbe);
            tbpArtikel.Controls.Add(txtPreis);
            tbpArtikel.Controls.Add(lblPreis);
            tbpArtikel.Controls.Add(txtArtikelBezeichnung);
            tbpArtikel.Controls.Add(lblArtikelName);
            tbpArtikel.Location = new Point(4, 28);
            tbpArtikel.Name = "tbpArtikel";
            tbpArtikel.Padding = new Padding(3);
            tbpArtikel.Size = new Size(778, 402);
            tbpArtikel.TabIndex = 0;
            tbpArtikel.Text = "Artikel";
            tbpArtikel.UseVisualStyleBackColor = true;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(150, 204);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(128, 37);
            btnSpeichern.TabIndex = 5;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // lblFarbe
            // 
            lblFarbe.AutoSize = true;
            lblFarbe.Location = new Point(31, 151);
            lblFarbe.Name = "lblFarbe";
            lblFarbe.Size = new Size(56, 19);
            lblFarbe.TabIndex = 4;
            lblFarbe.Text = "Farbe:";
            // 
            // txtFarbe
            // 
            txtFarbe.Location = new Point(150, 148);
            txtFarbe.Name = "txtFarbe";
            txtFarbe.Size = new Size(128, 27);
            txtFarbe.TabIndex = 3;
            // 
            // txtPreis
            // 
            txtPreis.Location = new Point(150, 82);
            txtPreis.Name = "txtPreis";
            txtPreis.Size = new Size(128, 27);
            txtPreis.TabIndex = 2;
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Location = new Point(31, 85);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(51, 19);
            lblPreis.TabIndex = 2;
            lblPreis.Text = "Preis:";
            // 
            // txtArtikelBezeichnung
            // 
            txtArtikelBezeichnung.Location = new Point(150, 24);
            txtArtikelBezeichnung.Name = "txtArtikelBezeichnung";
            txtArtikelBezeichnung.Size = new Size(128, 27);
            txtArtikelBezeichnung.TabIndex = 1;
            // 
            // lblArtikelName
            // 
            lblArtikelName.AutoSize = true;
            lblArtikelName.Location = new Point(31, 27);
            lblArtikelName.Name = "lblArtikelName";
            lblArtikelName.Size = new Size(108, 19);
            lblArtikelName.TabIndex = 0;
            lblArtikelName.Text = "Artikel Name:";
            // 
            // tbpArtikelliste
            // 
            tbpArtikelliste.Controls.Add(dataGridViewArtikel);
            tbpArtikelliste.Location = new Point(4, 28);
            tbpArtikelliste.Name = "tbpArtikelliste";
            tbpArtikelliste.Padding = new Padding(3);
            tbpArtikelliste.Size = new Size(778, 402);
            tbpArtikelliste.TabIndex = 1;
            tbpArtikelliste.Text = "Artikelliste";
            tbpArtikelliste.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArtikel
            // 
            dataGridViewArtikel.AllowUserToAddRows = false;
            dataGridViewArtikel.AllowUserToDeleteRows = false;
            dataGridViewArtikel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArtikel.Columns.AddRange(new DataGridViewColumn[] { Artikel, ArtikelPreis, ArtikelFarbe, ArtikelArt });
            dataGridViewArtikel.Location = new Point(19, 21);
            dataGridViewArtikel.Name = "dataGridViewArtikel";
            dataGridViewArtikel.ReadOnly = true;
            dataGridViewArtikel.Size = new Size(444, 239);
            dataGridViewArtikel.TabIndex = 0;
            // 
            // Artikel
            // 
            Artikel.HeaderText = "Artikel Bezeichnung";
            Artikel.Name = "Artikel";
            Artikel.ReadOnly = true;
            // 
            // ArtikelPreis
            // 
            ArtikelPreis.HeaderText = "Artikel Preis";
            ArtikelPreis.Name = "ArtikelPreis";
            ArtikelPreis.ReadOnly = true;
            // 
            // ArtikelFarbe
            // 
            ArtikelFarbe.HeaderText = "Artikel Farbe";
            ArtikelFarbe.Name = "ArtikelFarbe";
            ArtikelFarbe.ReadOnly = true;
            // 
            // ArtikelArt
            // 
            ArtikelArt.HeaderText = "Artikel Art";
            ArtikelArt.Name = "ArtikelArt";
            ArtikelArt.ReadOnly = true;
            // 
            // lblArtikelArt
            // 
            lblArtikelArt.AutoSize = true;
            lblArtikelArt.Location = new Point(331, 32);
            lblArtikelArt.Name = "lblArtikelArt";
            lblArtikelArt.Size = new Size(87, 19);
            lblArtikelArt.TabIndex = 6;
            lblArtikelArt.Text = "Artikel Art:";
            // 
            // txtArtikelArt
            // 
            txtArtikelArt.Location = new Point(424, 29);
            txtArtikelArt.Name = "txtArtikelArt";
            txtArtikelArt.Size = new Size(128, 27);
            txtArtikelArt.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbpArtikel.ResumeLayout(false);
            tbpArtikel.PerformLayout();
            tbpArtikelliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtikel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpArtikel;
        private TabPage tbpArtikelliste;
        private Label lblFarbe;
        private TextBox txtFarbe;
        private TextBox txtPreis;
        private Label lblPreis;
        private TextBox txtArtikelBezeichnung;
        private Label lblArtikelName;
        private DataGridView dataGridViewArtikel;
        private Button btnSpeichern;
        private DataGridViewTextBoxColumn Artikel;
        private DataGridViewTextBoxColumn ArtikelPreis;
        private DataGridViewTextBoxColumn ArtikelFarbe;
        private DataGridViewTextBoxColumn ArtikelArt;
        private TextBox txtArtikelArt;
        private Label lblArtikelArt;
    }
}
