namespace Kontaktinfos
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
            listBoxKontakte = new ListBox();
            lblKontaktliste = new Label();
            txtName = new TextBox();
            txtNachname = new TextBox();
            txtEmail = new TextBox();
            txtHandy = new TextBox();
            txtStrasse = new TextBox();
            txtHausNr = new TextBox();
            txtPZL = new TextBox();
            txtStadt = new TextBox();
            btnHinzufuegen = new Button();
            btnBearbeiten = new Button();
            btnLoeschen = new Button();
            btnSpeicher = new Button();
            SuspendLayout();
            // 
            // listBoxKontakte
            // 
            listBoxKontakte.BackColor = Color.FromArgb(224, 224, 224);
            listBoxKontakte.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxKontakte.FormattingEnabled = true;
            listBoxKontakte.Location = new Point(414, 50);
            listBoxKontakte.Name = "listBoxKontakte";
            listBoxKontakte.Size = new Size(364, 340);
            listBoxKontakte.TabIndex = 10;
            listBoxKontakte.SelectedIndexChanged += listBoxKontakte_SelectedIndexChanged;
            // 
            // lblKontaktliste
            // 
            lblKontaktliste.AutoSize = true;
            lblKontaktliste.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKontaktliste.Location = new Point(527, 22);
            lblKontaktliste.Name = "lblKontaktliste";
            lblKontaktliste.Size = new Size(111, 23);
            lblKontaktliste.TabIndex = 11;
            lblKontaktliste.Text = "Kontakt-Liste";
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 23);
            txtName.TabIndex = 0;
            txtName.Text = "Name";
            // 
            // txtNachname
            // 
            txtNachname.Location = new Point(219, 27);
            txtNachname.Name = "txtNachname";
            txtNachname.Size = new Size(154, 23);
            txtNachname.TabIndex = 1;
            txtNachname.Text = "Nachname";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email-Adresse";
            // 
            // txtHandy
            // 
            txtHandy.Location = new Point(219, 71);
            txtHandy.Name = "txtHandy";
            txtHandy.Size = new Size(154, 23);
            txtHandy.TabIndex = 3;
            txtHandy.Text = "Handynummer";
            // 
            // txtStrasse
            // 
            txtStrasse.Location = new Point(25, 120);
            txtStrasse.Name = "txtStrasse";
            txtStrasse.Size = new Size(152, 23);
            txtStrasse.TabIndex = 4;
            txtStrasse.Text = "Strasse";
            // 
            // txtHausNr
            // 
            txtHausNr.Location = new Point(219, 120);
            txtHausNr.Name = "txtHausNr";
            txtHausNr.Size = new Size(59, 23);
            txtHausNr.TabIndex = 5;
            txtHausNr.Text = "HausNr.";
            // 
            // txtPZL
            // 
            txtPZL.Location = new Point(25, 173);
            txtPZL.Name = "txtPZL";
            txtPZL.Size = new Size(90, 23);
            txtPZL.TabIndex = 6;
            txtPZL.Text = "PZL";
            // 
            // txtStadt
            // 
            txtStadt.Location = new Point(219, 173);
            txtStadt.Name = "txtStadt";
            txtStadt.Size = new Size(120, 23);
            txtStadt.TabIndex = 7;
            txtStadt.Text = "Stadt";
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Location = new Point(44, 269);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(112, 36);
            btnHinzufuegen.TabIndex = 8;
            btnHinzufuegen.Text = "Hinzufügen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // btnBearbeiten
            // 
            btnBearbeiten.Location = new Point(227, 269);
            btnBearbeiten.Name = "btnBearbeiten";
            btnBearbeiten.Size = new Size(112, 36);
            btnBearbeiten.TabIndex = 9;
            btnBearbeiten.Text = "Bearbeiten";
            btnBearbeiten.UseVisualStyleBackColor = true;
            btnBearbeiten.Click += btnBearbeiten_Click;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Location = new Point(44, 333);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(112, 36);
            btnLoeschen.TabIndex = 12;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // btnSpeicher
            // 
            btnSpeicher.Location = new Point(227, 333);
            btnSpeicher.Name = "btnSpeicher";
            btnSpeicher.Size = new Size(112, 36);
            btnSpeicher.TabIndex = 13;
            btnSpeicher.Text = "Speichern";
            btnSpeicher.UseVisualStyleBackColor = true;
            btnSpeicher.Click += btnSpeicher_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSpeicher);
            Controls.Add(btnLoeschen);
            Controls.Add(btnBearbeiten);
            Controls.Add(btnHinzufuegen);
            Controls.Add(txtStadt);
            Controls.Add(txtPZL);
            Controls.Add(txtHausNr);
            Controls.Add(txtStrasse);
            Controls.Add(txtHandy);
            Controls.Add(txtEmail);
            Controls.Add(txtNachname);
            Controls.Add(txtName);
            Controls.Add(lblKontaktliste);
            Controls.Add(listBoxKontakte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxKontakte;
        private Label lblKontaktliste;
        private TextBox txtName;
        private TextBox txtNachname;
        private TextBox txtEmail;
        private TextBox txtHandy;
        private TextBox txtStrasse;
        private TextBox txtHausNr;
        private TextBox txtPZL;
        private TextBox txtStadt;
        private Button btnHinzufuegen;
        private Button btnBearbeiten;
        private Button btnLoeschen;
        private Button btnSpeicher;
    }
}
