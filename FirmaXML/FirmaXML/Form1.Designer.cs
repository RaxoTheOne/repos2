namespace FirmaXML
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
            lblMitarbeiter = new Label();
            lblVorname = new Label();
            blNachname = new Label();
            label4 = new Label();
            txtVorname = new TextBox();
            txtNachname = new TextBox();
            txtTelefonnummer = new TextBox();
            lbMitarbeiter = new ListBox();
            btnXMLSpeichern = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHinzufuegen.Location = new Point(37, 261);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(130, 33);
            btnHinzufuegen.TabIndex = 0;
            btnHinzufuegen.Text = "Hinzufügen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // lblMitarbeiter
            // 
            lblMitarbeiter.AutoSize = true;
            lblMitarbeiter.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMitarbeiter.Location = new Point(27, 25);
            lblMitarbeiter.Name = "lblMitarbeiter";
            lblMitarbeiter.Size = new Size(111, 22);
            lblMitarbeiter.TabIndex = 1;
            lblMitarbeiter.Text = "Mitarbeiter";
            // 
            // lblVorname
            // 
            lblVorname.AutoSize = true;
            lblVorname.Font = new Font("Arial Rounded MT Bold", 12F);
            lblVorname.Location = new Point(82, 71);
            lblVorname.Name = "lblVorname";
            lblVorname.Size = new Size(85, 18);
            lblVorname.TabIndex = 2;
            lblVorname.Text = "Vorname:";
            // 
            // blNachname
            // 
            blNachname.AutoSize = true;
            blNachname.Font = new Font("Arial Rounded MT Bold", 12F);
            blNachname.Location = new Point(68, 124);
            blNachname.Name = "blNachname";
            blNachname.Size = new Size(99, 18);
            blNachname.TabIndex = 3;
            blNachname.Text = "Nachname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(30, 182);
            label4.Name = "label4";
            label4.Size = new Size(137, 18);
            label4.TabIndex = 4;
            label4.Text = "Telefonnummer:";
            // 
            // txtVorname
            // 
            txtVorname.Font = new Font("Arial Rounded MT Bold", 12F);
            txtVorname.Location = new Point(192, 68);
            txtVorname.Name = "txtVorname";
            txtVorname.Size = new Size(100, 26);
            txtVorname.TabIndex = 5;
            // 
            // txtNachname
            // 
            txtNachname.Font = new Font("Arial Rounded MT Bold", 12F);
            txtNachname.Location = new Point(192, 121);
            txtNachname.Name = "txtNachname";
            txtNachname.Size = new Size(100, 26);
            txtNachname.TabIndex = 6;
            // 
            // txtTelefonnummer
            // 
            txtTelefonnummer.Font = new Font("Arial Rounded MT Bold", 12F);
            txtTelefonnummer.Location = new Point(192, 179);
            txtTelefonnummer.Name = "txtTelefonnummer";
            txtTelefonnummer.Size = new Size(100, 26);
            txtTelefonnummer.TabIndex = 7;
            // 
            // lbMitarbeiter
            // 
            lbMitarbeiter.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbMitarbeiter.FormattingEnabled = true;
            lbMitarbeiter.ItemHeight = 18;
            lbMitarbeiter.Location = new Point(423, 12);
            lbMitarbeiter.Name = "lbMitarbeiter";
            lbMitarbeiter.Size = new Size(323, 346);
            lbMitarbeiter.TabIndex = 8;
            lbMitarbeiter.SelectedIndexChanged += lbMitarbeiter_SelectedIndexChanged;
            // 
            // btnXMLSpeichern
            // 
            btnXMLSpeichern.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXMLSpeichern.Location = new Point(484, 367);
            btnXMLSpeichern.Name = "btnXMLSpeichern";
            btnXMLSpeichern.Size = new Size(207, 33);
            btnXMLSpeichern.TabIndex = 9;
            btnXMLSpeichern.Text = "XML Datei Speichern";
            btnXMLSpeichern.UseVisualStyleBackColor = true;
            btnXMLSpeichern.Click += btnXMLSpeichern_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(226, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 33);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnXMLSpeichern);
            Controls.Add(lbMitarbeiter);
            Controls.Add(txtTelefonnummer);
            Controls.Add(txtNachname);
            Controls.Add(txtVorname);
            Controls.Add(label4);
            Controls.Add(blNachname);
            Controls.Add(lblVorname);
            Controls.Add(lblMitarbeiter);
            Controls.Add(btnHinzufuegen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHinzufuegen;
        private Label lblMitarbeiter;
        private Label lblVorname;
        private Label blNachname;
        private Label label4;
        private TextBox txtVorname;
        private TextBox txtNachname;
        private TextBox txtTelefonnummer;
        private ListBox lbMitarbeiter;
        private Button btnXMLSpeichern;
        private Button btnDelete;
    }
}
