namespace Lager1
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
            btnHinzufuegen = new Button();
            btnBearbeiten = new Button();
            cbKategorien = new ComboBox();
            btnLoeschen = new Button();
            lbLager = new ListBox();
            label1 = new Label();
            txtArtikelNr = new TextBox();
            txtBezeichnung = new TextBox();
            txtPreis = new TextBox();
            btnSpeichern = new Button();
            txtLagerbestand = new TextBox();
            lblLagerwert = new Label();
            lblAtrikelNr = new Label();
            lblBezeichnung = new Label();
            lblPreis = new Label();
            lblKategorien = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHinzufuegen.Location = new Point(25, 341);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(132, 36);
            btnHinzufuegen.TabIndex = 10;
            btnHinzufuegen.Text = "Hinzufügen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // btnBearbeiten
            // 
            btnBearbeiten.Font = new Font("Segoe UI", 12F);
            btnBearbeiten.Location = new Point(173, 341);
            btnBearbeiten.Name = "btnBearbeiten";
            btnBearbeiten.Size = new Size(132, 36);
            btnBearbeiten.TabIndex = 11;
            btnBearbeiten.Text = "Bearbeiten";
            btnBearbeiten.UseVisualStyleBackColor = true;
            btnBearbeiten.Click += btnBearbeiten_Click;
            // 
            // cbKategorien
            // 
            cbKategorien.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKategorien.FormattingEnabled = true;
            cbKategorien.Items.AddRange(new object[] { "Elektronik", "Lebensmittel", "Drogerie/Kosmetik", "Haushalt", "Garten", "Erotikartikel", "Sport", "Handwerk" });
            cbKategorien.Location = new Point(173, 223);
            cbKategorien.Name = "cbKategorien";
            cbKategorien.Size = new Size(153, 33);
            cbKategorien.TabIndex = 7;
            cbKategorien.Text = "Kategorien";
            // 
            // btnLoeschen
            // 
            btnLoeschen.Font = new Font("Segoe UI", 12F);
            btnLoeschen.Location = new Point(25, 402);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(132, 36);
            btnLoeschen.TabIndex = 12;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // lbLager
            // 
            lbLager.FormattingEnabled = true;
            lbLager.ItemHeight = 15;
            lbLager.Location = new Point(398, 70);
            lbLager.Name = "lbLager";
            lbLager.Size = new Size(368, 244);
            lbLager.TabIndex = 15;
            lbLager.SelectedIndexChanged += lbLager_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(524, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 14;
            label1.Text = "Lagerliste";
            // 
            // txtArtikelNr
            // 
            txtArtikelNr.Font = new Font("Segoe UI", 14F);
            txtArtikelNr.Location = new Point(173, 57);
            txtArtikelNr.Name = "txtArtikelNr";
            txtArtikelNr.Size = new Size(153, 32);
            txtArtikelNr.TabIndex = 1;
            txtArtikelNr.Text = "ArtikelNr.";
            // 
            // txtBezeichnung
            // 
            txtBezeichnung.Font = new Font("Segoe UI", 14F);
            txtBezeichnung.Location = new Point(173, 114);
            txtBezeichnung.Name = "txtBezeichnung";
            txtBezeichnung.Size = new Size(153, 32);
            txtBezeichnung.TabIndex = 3;
            txtBezeichnung.Text = "Bezeichnung";
            // 
            // txtPreis
            // 
            txtPreis.Font = new Font("Segoe UI", 14F);
            txtPreis.Location = new Point(173, 169);
            txtPreis.Name = "txtPreis";
            txtPreis.Size = new Size(153, 32);
            txtPreis.TabIndex = 5;
            txtPreis.Text = "Preis";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Segoe UI", 12F);
            btnSpeichern.Location = new Point(173, 402);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(132, 36);
            btnSpeichern.TabIndex = 13;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // txtLagerbestand
            // 
            txtLagerbestand.Font = new Font("Segoe UI", 14F);
            txtLagerbestand.Location = new Point(173, 283);
            txtLagerbestand.Name = "txtLagerbestand";
            txtLagerbestand.Size = new Size(153, 32);
            txtLagerbestand.TabIndex = 9;
            txtLagerbestand.Text = "Lagerbestand";
            // 
            // lblLagerwert
            // 
            lblLagerwert.AutoSize = true;
            lblLagerwert.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLagerwert.Location = new Point(398, 344);
            lblLagerwert.Name = "lblLagerwert";
            lblLagerwert.Size = new Size(187, 25);
            lblLagerwert.TabIndex = 16;
            lblLagerwert.Text = "Aktueller Lagerwert:";
            // 
            // lblAtrikelNr
            // 
            lblAtrikelNr.AutoSize = true;
            lblAtrikelNr.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblAtrikelNr.Location = new Point(25, 57);
            lblAtrikelNr.Name = "lblAtrikelNr";
            lblAtrikelNr.Size = new Size(100, 25);
            lblAtrikelNr.TabIndex = 0;
            lblAtrikelNr.Text = "ArtikelNr.:";
            // 
            // lblBezeichnung
            // 
            lblBezeichnung.AutoSize = true;
            lblBezeichnung.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblBezeichnung.Location = new Point(25, 114);
            lblBezeichnung.Name = "lblBezeichnung";
            lblBezeichnung.Size = new Size(126, 25);
            lblBezeichnung.TabIndex = 2;
            lblBezeichnung.Text = "Bezeichnung:";
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblPreis.Location = new Point(25, 169);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(58, 25);
            lblPreis.TabIndex = 4;
            lblPreis.Text = "Preis:";
            // 
            // lblKategorien
            // 
            lblKategorien.AutoSize = true;
            lblKategorien.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblKategorien.Location = new Point(25, 230);
            lblKategorien.Name = "lblKategorien";
            lblKategorien.Size = new Size(100, 25);
            lblKategorien.TabIndex = 6;
            lblKategorien.Text = "Kategorie:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(25, 283);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 8;
            label6.Text = "Lagerbestand:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(784, 450);
            Controls.Add(label6);
            Controls.Add(lblKategorien);
            Controls.Add(lblPreis);
            Controls.Add(lblBezeichnung);
            Controls.Add(lblAtrikelNr);
            Controls.Add(lblLagerwert);
            Controls.Add(txtLagerbestand);
            Controls.Add(btnSpeichern);
            Controls.Add(txtPreis);
            Controls.Add(txtBezeichnung);
            Controls.Add(txtArtikelNr);
            Controls.Add(label1);
            Controls.Add(lbLager);
            Controls.Add(btnLoeschen);
            Controls.Add(cbKategorien);
            Controls.Add(btnBearbeiten);
            Controls.Add(btnHinzufuegen);
            Name = "Form1";
            Text = "Lager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHinzufuegen;
        private Button btnBearbeiten;
        private ComboBox cbKategorien;
        private Button btnLoeschen;
        private ListBox lbLager;
        private Label label1;
        private TextBox txtArtikelNr;
        private TextBox txtBezeichnung;
        private TextBox txtPreis;
        private Button btnSpeichern;
        private TextBox txtLagerbestand;
        private Label lblLagerwert;
        private Label lblAtrikelNr;
        private Label lblBezeichnung;
        private Label lblPreis;
        private Label lblKategorien;
        private Label label6;
    }
}
