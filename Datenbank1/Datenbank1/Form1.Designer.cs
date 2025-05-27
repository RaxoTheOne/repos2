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
            listBox1 = new ListBox();
            btnEinlesen = new Button();
            txtWarengruppe = new TextBox();
            btnSpeichern = new Button();
            tabControl1 = new TabControl();
            tbpWarengruppe = new TabPage();
            tbpArtikel = new TabPage();
            listBoxArtikel = new ListBox();
            btnEinlesen2 = new Button();
            lblBezeichnung = new Label();
            textBox1 = new TextBox();
            lblPreis = new Label();
            textBox2 = new TextBox();
            lblLagerbestand = new Label();
            textBox3 = new TextBox();
            lblWarengruppe = new Label();
            cbWarengruppe = new ComboBox();
            btnArtikel = new Button();
            tabControl1.SuspendLayout();
            tbpWarengruppe.SuspendLayout();
            tbpArtikel.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(228, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 298);
            listBox1.TabIndex = 0;
            // 
            // btnEinlesen
            // 
            btnEinlesen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEinlesen.Location = new Point(228, 324);
            btnEinlesen.Name = "btnEinlesen";
            btnEinlesen.Size = new Size(212, 39);
            btnEinlesen.TabIndex = 1;
            btnEinlesen.Text = "Einlesen";
            btnEinlesen.UseVisualStyleBackColor = true;
            btnEinlesen.Click += btnEinlesen_Click;
            // 
            // txtWarengruppe
            // 
            txtWarengruppe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWarengruppe.Location = new Point(24, 13);
            txtWarengruppe.Name = "txtWarengruppe";
            txtWarengruppe.Size = new Size(152, 33);
            txtWarengruppe.TabIndex = 2;
            txtWarengruppe.Text = "Warengruppe";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpeichern.Location = new Point(24, 68);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(152, 33);
            btnSpeichern.TabIndex = 3;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpWarengruppe);
            tabControl1.Controls.Add(tbpArtikel);
            tabControl1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(492, 415);
            tabControl1.TabIndex = 4;
            // 
            // tbpWarengruppe
            // 
            tbpWarengruppe.Controls.Add(listBox1);
            tbpWarengruppe.Controls.Add(btnSpeichern);
            tbpWarengruppe.Controls.Add(btnEinlesen);
            tbpWarengruppe.Controls.Add(txtWarengruppe);
            tbpWarengruppe.Location = new Point(4, 27);
            tbpWarengruppe.Name = "tbpWarengruppe";
            tbpWarengruppe.Padding = new Padding(3);
            tbpWarengruppe.Size = new Size(484, 384);
            tbpWarengruppe.TabIndex = 0;
            tbpWarengruppe.Text = "Warengruppe";
            tbpWarengruppe.UseVisualStyleBackColor = true;
            // 
            // tbpArtikel
            // 
            tbpArtikel.Controls.Add(btnArtikel);
            tbpArtikel.Controls.Add(cbWarengruppe);
            tbpArtikel.Controls.Add(lblWarengruppe);
            tbpArtikel.Controls.Add(textBox3);
            tbpArtikel.Controls.Add(lblLagerbestand);
            tbpArtikel.Controls.Add(textBox2);
            tbpArtikel.Controls.Add(lblPreis);
            tbpArtikel.Controls.Add(textBox1);
            tbpArtikel.Controls.Add(lblBezeichnung);
            tbpArtikel.Controls.Add(btnEinlesen2);
            tbpArtikel.Controls.Add(listBoxArtikel);
            tbpArtikel.Location = new Point(4, 27);
            tbpArtikel.Name = "tbpArtikel";
            tbpArtikel.Padding = new Padding(3);
            tbpArtikel.Size = new Size(484, 384);
            tbpArtikel.TabIndex = 1;
            tbpArtikel.Text = "Artikel";
            tbpArtikel.UseVisualStyleBackColor = true;
            // 
            // listBoxArtikel
            // 
            listBoxArtikel.FormattingEnabled = true;
            listBoxArtikel.ItemHeight = 18;
            listBoxArtikel.Location = new Point(267, 19);
            listBoxArtikel.Name = "listBoxArtikel";
            listBoxArtikel.Size = new Size(211, 292);
            listBoxArtikel.TabIndex = 0;
            // 
            // btnEinlesen2
            // 
            btnEinlesen2.Location = new Point(267, 349);
            btnEinlesen2.Name = "btnEinlesen2";
            btnEinlesen2.Size = new Size(108, 32);
            btnEinlesen2.TabIndex = 1;
            btnEinlesen2.Text = "Einlesen";
            btnEinlesen2.UseVisualStyleBackColor = true;
            // 
            // lblBezeichnung
            // 
            lblBezeichnung.AutoSize = true;
            lblBezeichnung.Location = new Point(22, 22);
            lblBezeichnung.Name = "lblBezeichnung";
            lblBezeichnung.Size = new Size(117, 18);
            lblBezeichnung.TabIndex = 2;
            lblBezeichnung.Text = "Bezeichnung:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 3;
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Location = new Point(22, 72);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(54, 18);
            lblPreis.TabIndex = 4;
            lblPreis.Text = "Preis:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 5;
            // 
            // lblLagerbestand
            // 
            lblLagerbestand.AutoSize = true;
            lblLagerbestand.Location = new Point(22, 125);
            lblLagerbestand.Name = "lblLagerbestand";
            lblLagerbestand.Size = new Size(125, 18);
            lblLagerbestand.TabIndex = 6;
            lblLagerbestand.Text = "Lagerbestand:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 26);
            textBox3.TabIndex = 7;
            // 
            // lblWarengruppe
            // 
            lblWarengruppe.AutoSize = true;
            lblWarengruppe.Location = new Point(22, 183);
            lblWarengruppe.Name = "lblWarengruppe";
            lblWarengruppe.Size = new Size(122, 18);
            lblWarengruppe.TabIndex = 8;
            lblWarengruppe.Text = "Warengruppe:";
            // 
            // cbWarengruppe
            // 
            cbWarengruppe.FormattingEnabled = true;
            cbWarengruppe.Location = new Point(150, 180);
            cbWarengruppe.Name = "cbWarengruppe";
            cbWarengruppe.Size = new Size(100, 26);
            cbWarengruppe.TabIndex = 9;
            // 
            // btnArtikel
            // 
            btnArtikel.Location = new Point(40, 260);
            btnArtikel.Name = "btnArtikel";
            btnArtikel.Size = new Size(117, 33);
            btnArtikel.TabIndex = 10;
            btnArtikel.Text = "Speichern";
            btnArtikel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbpWarengruppe.ResumeLayout(false);
            tbpWarengruppe.PerformLayout();
            tbpArtikel.ResumeLayout(false);
            tbpArtikel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnEinlesen;
        private TextBox txtWarengruppe;
        private Button btnSpeichern;
        private TabControl tabControl1;
        private TabPage tbpWarengruppe;
        private TabPage tbpArtikel;
        private TextBox textBox2;
        private Label lblPreis;
        private TextBox textBox1;
        private Label lblBezeichnung;
        private Button btnEinlesen2;
        private ListBox listBoxArtikel;
        private Button btnArtikel;
        private ComboBox cbWarengruppe;
        private Label lblWarengruppe;
        private TextBox textBox3;
        private Label lblLagerbestand;
    }
}
