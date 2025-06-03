namespace FahrtenbuchKlausur
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
            btnSpeichern = new Button();
            lblStadt = new Label();
            lblBundesland = new Label();
            lblEntfernung = new Label();
            lblAnzahlDerFahrten = new Label();
            lblGesamtKm = new Label();
            btnBerechnen = new Button();
            btnNeu = new Button();
            txtStadt = new TextBox();
            txtBundesland = new TextBox();
            txtEntfernung = new TextBox();
            txtAnzahl = new TextBox();
            listBoxStrecken = new ListBox();
            listBoxGesamtstrecke = new ListBox();
            SuspendLayout();
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            btnSpeichern.Location = new Point(22, 218);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(133, 32);
            btnSpeichern.TabIndex = 0;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // lblStadt
            // 
            lblStadt.AutoSize = true;
            lblStadt.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            lblStadt.Location = new Point(125, 37);
            lblStadt.Name = "lblStadt";
            lblStadt.Size = new Size(59, 23);
            lblStadt.TabIndex = 1;
            lblStadt.Text = "Stadt:";
            // 
            // lblBundesland
            // 
            lblBundesland.AutoSize = true;
            lblBundesland.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            lblBundesland.Location = new Point(68, 69);
            lblBundesland.Name = "lblBundesland";
            lblBundesland.Size = new Size(116, 23);
            lblBundesland.TabIndex = 2;
            lblBundesland.Text = "Bundesland:";
            // 
            // lblEntfernung
            // 
            lblEntfernung.AutoSize = true;
            lblEntfernung.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            lblEntfernung.Location = new Point(71, 115);
            lblEntfernung.Name = "lblEntfernung";
            lblEntfernung.Size = new Size(113, 23);
            lblEntfernung.TabIndex = 3;
            lblEntfernung.Text = "Entfernung:";
            // 
            // lblAnzahlDerFahrten
            // 
            lblAnzahlDerFahrten.AutoSize = true;
            lblAnzahlDerFahrten.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            lblAnzahlDerFahrten.Location = new Point(1, 160);
            lblAnzahlDerFahrten.Name = "lblAnzahlDerFahrten";
            lblAnzahlDerFahrten.Size = new Size(183, 23);
            lblAnzahlDerFahrten.TabIndex = 4;
            lblAnzahlDerFahrten.Text = "Anzahl der Fahrten:";
            // 
            // lblGesamtKm
            // 
            lblGesamtKm.AutoSize = true;
            lblGesamtKm.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            lblGesamtKm.Location = new Point(502, 331);
            lblGesamtKm.Name = "lblGesamtKm";
            lblGesamtKm.Size = new Size(111, 23);
            lblGesamtKm.TabIndex = 5;
            lblGesamtKm.Text = "GesamtKm:";
            // 
            // btnBerechnen
            // 
            btnBerechnen.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            btnBerechnen.Location = new Point(173, 218);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(133, 32);
            btnBerechnen.TabIndex = 6;
            btnBerechnen.Text = "Berechnen";
            btnBerechnen.UseVisualStyleBackColor = true;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // btnNeu
            // 
            btnNeu.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            btnNeu.Location = new Point(22, 276);
            btnNeu.Name = "btnNeu";
            btnNeu.Size = new Size(133, 32);
            btnNeu.TabIndex = 7;
            btnNeu.Text = "Neu";
            btnNeu.UseVisualStyleBackColor = true;
            btnNeu.Click += btnNeu_Click;
            // 
            // txtStadt
            // 
            txtStadt.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            txtStadt.Location = new Point(190, 31);
            txtStadt.Name = "txtStadt";
            txtStadt.Size = new Size(94, 29);
            txtStadt.TabIndex = 8;
            // 
            // txtBundesland
            // 
            txtBundesland.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            txtBundesland.Location = new Point(190, 69);
            txtBundesland.Name = "txtBundesland";
            txtBundesland.Size = new Size(94, 29);
            txtBundesland.TabIndex = 9;
            // 
            // txtEntfernung
            // 
            txtEntfernung.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            txtEntfernung.Location = new Point(190, 112);
            txtEntfernung.Name = "txtEntfernung";
            txtEntfernung.Size = new Size(94, 29);
            txtEntfernung.TabIndex = 10;
            // 
            // txtAnzahl
            // 
            txtAnzahl.Font = new Font("Berlin Sans FB Demi", 14.25F, FontStyle.Bold);
            txtAnzahl.Location = new Point(190, 157);
            txtAnzahl.Name = "txtAnzahl";
            txtAnzahl.Size = new Size(94, 29);
            txtAnzahl.TabIndex = 11;
            // 
            // listBoxStrecken
            // 
            listBoxStrecken.FormattingEnabled = true;
            listBoxStrecken.ItemHeight = 15;
            listBoxStrecken.Location = new Point(340, 56);
            listBoxStrecken.Name = "listBoxStrecken";
            listBoxStrecken.Size = new Size(206, 214);
            listBoxStrecken.TabIndex = 12;
            listBoxStrecken.SelectedIndexChanged += listBoxStrecken_SelectedIndexChanged;
            // 
            // listBoxGesamtstrecke
            // 
            listBoxGesamtstrecke.FormattingEnabled = true;
            listBoxGesamtstrecke.ItemHeight = 15;
            listBoxGesamtstrecke.Location = new Point(582, 56);
            listBoxGesamtstrecke.Name = "listBoxGesamtstrecke";
            listBoxGesamtstrecke.Size = new Size(206, 214);
            listBoxGesamtstrecke.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxGesamtstrecke);
            Controls.Add(listBoxStrecken);
            Controls.Add(txtAnzahl);
            Controls.Add(txtEntfernung);
            Controls.Add(txtBundesland);
            Controls.Add(txtStadt);
            Controls.Add(btnNeu);
            Controls.Add(btnBerechnen);
            Controls.Add(lblGesamtKm);
            Controls.Add(lblAnzahlDerFahrten);
            Controls.Add(lblEntfernung);
            Controls.Add(lblBundesland);
            Controls.Add(lblStadt);
            Controls.Add(btnSpeichern);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpeichern;
        private Label lblStadt;
        private Label lblBundesland;
        private Label lblEntfernung;
        private Label lblAnzahlDerFahrten;
        private Label lblGesamtKm;
        private Button btnBerechnen;
        private Button btnNeu;
        private TextBox txtStadt;
        private TextBox txtBundesland;
        private TextBox txtEntfernung;
        private TextBox txtAnzahl;
        private ListBox listBoxStrecken;
        private ListBox listBoxGesamtstrecke;
    }
}
