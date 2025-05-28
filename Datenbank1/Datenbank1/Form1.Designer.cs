namespace Datenbank1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            listBoxWarengruppe = new ListBox();
            txtWarengruppe = new TextBox();
            btnSpeichern = new Button();
            tabControl1 = new TabControl();
            tbpWarengruppe = new TabPage();
            btnLoeschen = new Button();
            tbpArtikel = new TabPage();
            btnArtikelLoeschen = new Button();
            btnArtikelSpeichern = new Button();
            cbWarengruppe = new ComboBox();
            lblWarengruppe = new Label();
            txtArtLagerbestand = new TextBox();
            lblLagerbestand = new Label();
            txtArtikelPreis = new TextBox();
            lblPreis = new Label();
            txtArtikelBezeichnung = new TextBox();
            lblBezeichnung = new Label();
            listBoxArtikel = new ListBox();
            tbpArtikelliste = new TabPage();
            dgvArtikel = new DataGridView();
            artnr = new DataGridViewTextBoxColumn();
            artikelbezeichnung = new DataGridViewTextBoxColumn();
            artikelPreis = new DataGridViewTextBoxColumn();
            artLagerbestand = new DataGridViewTextBoxColumn();
            artwg = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tbpWarengruppe.SuspendLayout();
            tbpArtikel.SuspendLayout();
            tbpArtikelliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtikel).BeginInit();
            SuspendLayout();
            // 
            // listBoxWarengruppe
            // 
            listBoxWarengruppe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxWarengruppe.FormattingEnabled = true;
            listBoxWarengruppe.ItemHeight = 21;
            listBoxWarengruppe.Location = new Point(228, 13);
            listBoxWarengruppe.Name = "listBoxWarengruppe";
            listBoxWarengruppe.Size = new Size(212, 298);
            listBoxWarengruppe.TabIndex = 0;
            listBoxWarengruppe.SelectedIndexChanged += listBoxWarengruppe_SelectedIndexChanged;
            // 
            // txtWarengruppe
            // 
            txtWarengruppe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWarengruppe.Location = new Point(24, 13);
            txtWarengruppe.Name = "txtWarengruppe";
            txtWarengruppe.Size = new Size(152, 33);
            txtWarengruppe.TabIndex = 2;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpeichern.Location = new Point(42, 62);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(114, 33);
            btnSpeichern.TabIndex = 3;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpWarengruppe);
            tabControl1.Controls.Add(tbpArtikel);
            tabControl1.Controls.Add(tbpArtikelliste);
            tabControl1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(-3, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(818, 455);
            tabControl1.TabIndex = 4;
            // 
            // tbpWarengruppe
            // 
            tbpWarengruppe.Controls.Add(btnLoeschen);
            tbpWarengruppe.Controls.Add(listBoxWarengruppe);
            tbpWarengruppe.Controls.Add(btnSpeichern);
            tbpWarengruppe.Controls.Add(txtWarengruppe);
            tbpWarengruppe.Location = new Point(4, 29);
            tbpWarengruppe.Name = "tbpWarengruppe";
            tbpWarengruppe.Padding = new Padding(3);
            tbpWarengruppe.Size = new Size(810, 422);
            tbpWarengruppe.TabIndex = 0;
            tbpWarengruppe.Text = "Warengruppe";
            tbpWarengruppe.UseVisualStyleBackColor = true;
            // 
            // btnLoeschen
            // 
            btnLoeschen.BackColor = Color.Salmon;
            btnLoeschen.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoeschen.Location = new Point(228, 329);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(114, 34);
            btnLoeschen.TabIndex = 4;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = false;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // tbpArtikel
            // 
            tbpArtikel.Controls.Add(btnArtikelLoeschen);
            tbpArtikel.Controls.Add(btnArtikelSpeichern);
            tbpArtikel.Controls.Add(cbWarengruppe);
            tbpArtikel.Controls.Add(lblWarengruppe);
            tbpArtikel.Controls.Add(txtArtLagerbestand);
            tbpArtikel.Controls.Add(lblLagerbestand);
            tbpArtikel.Controls.Add(txtArtikelPreis);
            tbpArtikel.Controls.Add(lblPreis);
            tbpArtikel.Controls.Add(txtArtikelBezeichnung);
            tbpArtikel.Controls.Add(lblBezeichnung);
            tbpArtikel.Controls.Add(listBoxArtikel);
            tbpArtikel.Location = new Point(4, 29);
            tbpArtikel.Name = "tbpArtikel";
            tbpArtikel.Padding = new Padding(3);
            tbpArtikel.Size = new Size(810, 422);
            tbpArtikel.TabIndex = 1;
            tbpArtikel.Text = "Artikel";
            tbpArtikel.UseVisualStyleBackColor = true;
            // 
            // btnArtikelLoeschen
            // 
            btnArtikelLoeschen.Location = new Point(22, 307);
            btnArtikelLoeschen.Name = "btnArtikelLoeschen";
            btnArtikelLoeschen.Size = new Size(117, 32);
            btnArtikelLoeschen.TabIndex = 12;
            btnArtikelLoeschen.Text = "Löschen";
            btnArtikelLoeschen.UseVisualStyleBackColor = true;
            btnArtikelLoeschen.Click += btnArtikelLoeschen_Click;
            // 
            // btnArtikelSpeichern
            // 
            btnArtikelSpeichern.Location = new Point(22, 242);
            btnArtikelSpeichern.Name = "btnArtikelSpeichern";
            btnArtikelSpeichern.Size = new Size(117, 33);
            btnArtikelSpeichern.TabIndex = 10;
            btnArtikelSpeichern.Text = "Speichern";
            btnArtikelSpeichern.UseVisualStyleBackColor = true;
            btnArtikelSpeichern.Click += btnArtikelSpeichern_Click;
            // 
            // cbWarengruppe
            // 
            cbWarengruppe.FormattingEnabled = true;
            cbWarengruppe.Location = new Point(150, 180);
            cbWarengruppe.Name = "cbWarengruppe";
            cbWarengruppe.Size = new Size(100, 28);
            cbWarengruppe.TabIndex = 9;
            // 
            // lblWarengruppe
            // 
            lblWarengruppe.AutoSize = true;
            lblWarengruppe.Location = new Point(22, 183);
            lblWarengruppe.Name = "lblWarengruppe";
            lblWarengruppe.Size = new Size(95, 20);
            lblWarengruppe.TabIndex = 8;
            lblWarengruppe.Text = "Warengruppe:";
            // 
            // txtArtLagerbestand
            // 
            txtArtLagerbestand.Location = new Point(150, 122);
            txtArtLagerbestand.Name = "txtArtLagerbestand";
            txtArtLagerbestand.Size = new Size(100, 26);
            txtArtLagerbestand.TabIndex = 7;
            // 
            // lblLagerbestand
            // 
            lblLagerbestand.AutoSize = true;
            lblLagerbestand.Location = new Point(22, 125);
            lblLagerbestand.Name = "lblLagerbestand";
            lblLagerbestand.Size = new Size(97, 20);
            lblLagerbestand.TabIndex = 6;
            lblLagerbestand.Text = "Lagerbestand:";
            // 
            // txtArtikelPreis
            // 
            txtArtikelPreis.Location = new Point(150, 69);
            txtArtikelPreis.Name = "txtArtikelPreis";
            txtArtikelPreis.Size = new Size(100, 26);
            txtArtikelPreis.TabIndex = 5;
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Location = new Point(22, 72);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(45, 20);
            lblPreis.TabIndex = 4;
            lblPreis.Text = "Preis:";
            // 
            // txtArtikelBezeichnung
            // 
            txtArtikelBezeichnung.Location = new Point(150, 19);
            txtArtikelBezeichnung.Name = "txtArtikelBezeichnung";
            txtArtikelBezeichnung.Size = new Size(100, 26);
            txtArtikelBezeichnung.TabIndex = 3;
            // 
            // lblBezeichnung
            // 
            lblBezeichnung.AutoSize = true;
            lblBezeichnung.Location = new Point(22, 22);
            lblBezeichnung.Name = "lblBezeichnung";
            lblBezeichnung.Size = new Size(93, 20);
            lblBezeichnung.TabIndex = 2;
            lblBezeichnung.Text = "Bezeichnung:";
            // 
            // listBoxArtikel
            // 
            listBoxArtikel.FormattingEnabled = true;
            listBoxArtikel.ItemHeight = 20;
            listBoxArtikel.Location = new Point(267, 19);
            listBoxArtikel.Name = "listBoxArtikel";
            listBoxArtikel.Size = new Size(211, 284);
            listBoxArtikel.TabIndex = 0;
            listBoxArtikel.SelectedIndexChanged += listBoxArtikel_SelectedIndexChanged;
            // 
            // tbpArtikelliste
            // 
            tbpArtikelliste.Controls.Add(dgvArtikel);
            tbpArtikelliste.Location = new Point(4, 29);
            tbpArtikelliste.Name = "tbpArtikelliste";
            tbpArtikelliste.Size = new Size(810, 422);
            tbpArtikelliste.TabIndex = 2;
            tbpArtikelliste.Text = "Artikelliste";
            tbpArtikelliste.UseVisualStyleBackColor = true;
            // 
            // dgvArtikel
            // 
            dgvArtikel.AllowUserToAddRows = false;
            dgvArtikel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dgvArtikel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvArtikel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtikel.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvArtikel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvArtikel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtikel.Columns.AddRange(new DataGridViewColumn[] { artnr, artikelbezeichnung, artikelPreis, artLagerbestand, artwg });
            dgvArtikel.GridColor = SystemColors.Menu;
            dgvArtikel.Location = new Point(-1, 0);
            dgvArtikel.Name = "dgvArtikel";
            dgvArtikel.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvArtikel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.DarkOliveGreen;
            dgvArtikel.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvArtikel.Size = new Size(811, 418);
            dgvArtikel.TabIndex = 0;
            // 
            // artnr
            // 
            artnr.HeaderText = "ArtikelNr.";
            artnr.Name = "artnr";
            artnr.ReadOnly = true;
            // 
            // artikelbezeichnung
            // 
            artikelbezeichnung.HeaderText = "Bezeichnung";
            artikelbezeichnung.Name = "artikelbezeichnung";
            artikelbezeichnung.ReadOnly = true;
            // 
            // artikelPreis
            // 
            artikelPreis.HeaderText = "Preis";
            artikelPreis.Name = "artikelPreis";
            artikelPreis.ReadOnly = true;
            // 
            // artLagerbestand
            // 
            artLagerbestand.HeaderText = "Lagerbestand";
            artLagerbestand.Name = "artLagerbestand";
            artLagerbestand.ReadOnly = true;
            // 
            // artwg
            // 
            artwg.HeaderText = "Warengruppe";
            artwg.Name = "artwg";
            artwg.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 460);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbpWarengruppe.ResumeLayout(false);
            tbpWarengruppe.PerformLayout();
            tbpArtikel.ResumeLayout(false);
            tbpArtikel.PerformLayout();
            tbpArtikelliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArtikel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxWarengruppe;
        private TextBox txtWarengruppe;
        private Button btnSpeichern;
        private TabControl tabControl1;
        private TabPage tbpWarengruppe;
        private TabPage tbpArtikel;
        private TextBox txtArtikelPreis;
        private Label lblPreis;
        private TextBox txtArtikelBezeichnung;
        private Label lblBezeichnung;
        private ListBox listBoxArtikel;
        private Button btnArtikelSpeichern;
        private ComboBox cbWarengruppe;
        private Label lblWarengruppe;
        private TextBox txtArtLagerbestand;
        private Label lblLagerbestand;
        private Button btnArtikelLoeschen;
        private Button btnLoeschen;
        private TabPage tbpArtikelliste;
        private DataGridView dgvArtikel;
        private DataGridViewTextBoxColumn artnr;
        private DataGridViewTextBoxColumn artikelbezeichnung;
        private DataGridViewTextBoxColumn artikelPreis;
        private DataGridViewTextBoxColumn artLagerbestand;
        private DataGridViewTextBoxColumn artwg;
    }
}
