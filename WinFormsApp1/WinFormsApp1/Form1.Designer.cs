namespace WinFormsApp1
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
            tabPage1 = new TabPage();
            btnksave = new Button();
            btnkloeschen = new Button();
            lbKontinent = new ListBox();
            txtkbezeichnung = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            cbKontinent = new ComboBox();
            label3 = new Label();
            btngloeschen = new Button();
            btngsave = new Button();
            lbgehege = new ListBox();
            txtgbezeichnung = new TextBox();
            label2 = new Label();
            Tierart = new TabPage();
            btntaloeschen = new Button();
            btntasave = new Button();
            lbTierart = new ListBox();
            txtTierart = new TextBox();
            label4 = new Label();
            tabPage4 = new TabPage();
            btnToCSV = new Button();
            cbgehege = new ComboBox();
            label9 = new Label();
            dgvTierListe = new DataGridView();
            dateGDatum = new DateTimePicker();
            label8 = new Label();
            txtTiergewicht = new TextBox();
            label7 = new Label();
            cbTierart = new ComboBox();
            label5 = new Label();
            btntloeschen = new Button();
            btntsave = new Button();
            lbTiere = new ListBox();
            txtTiername = new TextBox();
            label6 = new Label();
            Tiername = new DataGridViewTextBoxColumn();
            Gewicht = new DataGridViewTextBoxColumn();
            Geburtsdatum = new DataGridViewTextBoxColumn();
            Tierart2 = new DataGridViewTextBoxColumn();
            Gehege = new DataGridViewTextBoxColumn();
            Kontinent = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            Tierart.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTierListe).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(Tierart);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(22, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 651);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnksave);
            tabPage1.Controls.Add(btnkloeschen);
            tabPage1.Controls.Add(lbKontinent);
            tabPage1.Controls.Add(txtkbezeichnung);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 15F);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kontinent";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnksave
            // 
            btnksave.Location = new Point(163, 189);
            btnksave.Name = "btnksave";
            btnksave.Size = new Size(185, 50);
            btnksave.TabIndex = 5;
            btnksave.Text = "Speichern";
            btnksave.UseVisualStyleBackColor = true;
            btnksave.Click += btnksave_Click;
            // 
            // btnkloeschen
            // 
            btnkloeschen.Location = new Point(163, 245);
            btnkloeschen.Name = "btnkloeschen";
            btnkloeschen.Size = new Size(185, 50);
            btnkloeschen.TabIndex = 4;
            btnkloeschen.Text = "Loeschen";
            btnkloeschen.UseVisualStyleBackColor = true;
            btnkloeschen.Click += btnkloeschen_Click;
            // 
            // lbKontinent
            // 
            lbKontinent.FormattingEnabled = true;
            lbKontinent.ItemHeight = 28;
            lbKontinent.Location = new Point(495, 35);
            lbKontinent.Name = "lbKontinent";
            lbKontinent.Size = new Size(249, 340);
            lbKontinent.TabIndex = 2;
            // 
            // txtkbezeichnung
            // 
            txtkbezeichnung.Location = new Point(163, 46);
            txtkbezeichnung.Name = "txtkbezeichnung";
            txtkbezeichnung.Size = new Size(185, 34);
            txtkbezeichnung.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 46);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Bezeichnung:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbKontinent);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btngloeschen);
            tabPage2.Controls.Add(btngsave);
            tabPage2.Controls.Add(lbgehege);
            tabPage2.Controls.Add(txtgbezeichnung);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Segoe UI", 15F);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(874, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gehege";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbKontinent
            // 
            cbKontinent.FormattingEnabled = true;
            cbKontinent.Location = new Point(234, 96);
            cbKontinent.Name = "cbKontinent";
            cbKontinent.Size = new Size(182, 36);
            cbKontinent.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 96);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 10;
            label3.Text = "Kontinent:";
            // 
            // btngloeschen
            // 
            btngloeschen.Location = new Point(231, 253);
            btngloeschen.Name = "btngloeschen";
            btngloeschen.Size = new Size(185, 50);
            btngloeschen.TabIndex = 9;
            btngloeschen.Text = "Loeschen";
            btngloeschen.UseVisualStyleBackColor = true;
            // 
            // btngsave
            // 
            btngsave.Location = new Point(231, 185);
            btngsave.Name = "btngsave";
            btngsave.Size = new Size(185, 50);
            btngsave.TabIndex = 8;
            btngsave.Text = "Speichern";
            btngsave.UseVisualStyleBackColor = true;
            // 
            // lbgehege
            // 
            lbgehege.FormattingEnabled = true;
            lbgehege.ItemHeight = 28;
            lbgehege.Location = new Point(483, 22);
            lbgehege.Name = "lbgehege";
            lbgehege.Size = new Size(249, 340);
            lbgehege.TabIndex = 7;
            // 
            // txtgbezeichnung
            // 
            txtgbezeichnung.Location = new Point(231, 38);
            txtgbezeichnung.Name = "txtgbezeichnung";
            txtgbezeichnung.Size = new Size(185, 34);
            txtgbezeichnung.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 38);
            label2.Name = "label2";
            label2.Size = new Size(198, 28);
            label2.TabIndex = 5;
            label2.Text = "Gehege Bezeichnung:";
            // 
            // Tierart
            // 
            Tierart.Controls.Add(btntaloeschen);
            Tierart.Controls.Add(btntasave);
            Tierart.Controls.Add(lbTierart);
            Tierart.Controls.Add(txtTierart);
            Tierart.Controls.Add(label4);
            Tierart.Font = new Font("Segoe UI", 15F);
            Tierart.Location = new Point(4, 24);
            Tierart.Name = "Tierart";
            Tierart.Size = new Size(874, 623);
            Tierart.TabIndex = 2;
            Tierart.Text = "Tierart";
            Tierart.UseVisualStyleBackColor = true;
            // 
            // btntaloeschen
            // 
            btntaloeschen.Location = new Point(159, 184);
            btntaloeschen.Name = "btntaloeschen";
            btntaloeschen.Size = new Size(185, 50);
            btntaloeschen.TabIndex = 9;
            btntaloeschen.Text = "Loeschen";
            btntaloeschen.UseVisualStyleBackColor = true;
            // 
            // btntasave
            // 
            btntasave.Location = new Point(159, 115);
            btntasave.Name = "btntasave";
            btntasave.Size = new Size(185, 50);
            btntasave.TabIndex = 8;
            btntasave.Text = "Speichern";
            btntasave.UseVisualStyleBackColor = true;
            // 
            // lbTierart
            // 
            lbTierart.FormattingEnabled = true;
            lbTierart.ItemHeight = 28;
            lbTierart.Location = new Point(483, 25);
            lbTierart.Name = "lbTierart";
            lbTierart.Size = new Size(249, 312);
            lbTierart.TabIndex = 7;
            // 
            // txtTierart
            // 
            txtTierart.Location = new Point(159, 41);
            txtTierart.Name = "txtTierart";
            txtTierart.Size = new Size(185, 34);
            txtTierart.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 41);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 5;
            label4.Text = "Tierart:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnToCSV);
            tabPage4.Controls.Add(cbgehege);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(dgvTierListe);
            tabPage4.Controls.Add(dateGDatum);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(txtTiergewicht);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(cbTierart);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(btntloeschen);
            tabPage4.Controls.Add(btntsave);
            tabPage4.Controls.Add(lbTiere);
            tabPage4.Controls.Add(txtTiername);
            tabPage4.Controls.Add(label6);
            tabPage4.Font = new Font("Segoe UI", 15F);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(874, 623);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tiere";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnToCSV
            // 
            btnToCSV.Location = new Point(515, 354);
            btnToCSV.Name = "btnToCSV";
            btnToCSV.Size = new Size(185, 50);
            btnToCSV.TabIndex = 26;
            btnToCSV.Text = "ToCSV";
            btnToCSV.UseVisualStyleBackColor = true;
            btnToCSV.Click += btnToCSV_Click;
            // 
            // cbgehege
            // 
            cbgehege.FormattingEnabled = true;
            cbgehege.Location = new Point(188, 242);
            cbgehege.Name = "cbgehege";
            cbgehege.Size = new Size(182, 36);
            cbgehege.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 245);
            label9.Name = "label9";
            label9.Size = new Size(83, 28);
            label9.TabIndex = 24;
            label9.Text = "Gehege:";
            // 
            // dgvTierListe
            // 
            dgvTierListe.AllowUserToAddRows = false;
            dgvTierListe.AllowUserToDeleteRows = false;
            dgvTierListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTierListe.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvTierListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTierListe.Columns.AddRange(new DataGridViewColumn[] { Tiername, Gewicht, Geburtsdatum, Tierart2, Gehege, Kontinent });
            dgvTierListe.Location = new Point(27, 427);
            dgvTierListe.Name = "dgvTierListe";
            dgvTierListe.ReadOnly = true;
            dgvTierListe.Size = new Size(829, 196);
            dgvTierListe.TabIndex = 23;
            // 
            // dateGDatum
            // 
            dateGDatum.Format = DateTimePickerFormat.Short;
            dateGDatum.Location = new Point(187, 147);
            dateGDatum.Name = "dateGDatum";
            dateGDatum.Size = new Size(183, 34);
            dateGDatum.TabIndex = 22;
            dateGDatum.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 147);
            label8.Name = "label8";
            label8.Size = new Size(142, 28);
            label8.TabIndex = 21;
            label8.Text = "Geburtsdatum:";
            // 
            // txtTiergewicht
            // 
            txtTiergewicht.Location = new Point(185, 93);
            txtTiergewicht.Name = "txtTiergewicht";
            txtTiergewicht.Size = new Size(185, 34);
            txtTiergewicht.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 93);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 19;
            label7.Text = "Gewicht:";
            // 
            // cbTierart
            // 
            cbTierart.FormattingEnabled = true;
            cbTierart.Location = new Point(188, 196);
            cbTierart.Name = "cbTierart";
            cbTierart.Size = new Size(182, 36);
            cbTierart.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 199);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 17;
            label5.Text = "Tierart:";
            // 
            // btntloeschen
            // 
            btntloeschen.Location = new Point(185, 354);
            btntloeschen.Name = "btntloeschen";
            btntloeschen.Size = new Size(185, 50);
            btntloeschen.TabIndex = 16;
            btntloeschen.Text = "Loeschen";
            btntloeschen.UseVisualStyleBackColor = true;
            // 
            // btntsave
            // 
            btntsave.Location = new Point(187, 287);
            btntsave.Name = "btntsave";
            btntsave.Size = new Size(185, 50);
            btntsave.TabIndex = 15;
            btntsave.Text = "Speichern";
            btntsave.UseVisualStyleBackColor = true;
            // 
            // lbTiere
            // 
            lbTiere.FormattingEnabled = true;
            lbTiere.ItemHeight = 28;
            lbTiere.Location = new Point(483, 25);
            lbTiere.Name = "lbTiere";
            lbTiere.Size = new Size(249, 312);
            lbTiere.TabIndex = 14;
            // 
            // txtTiername
            // 
            txtTiername.Location = new Point(187, 38);
            txtTiername.Name = "txtTiername";
            txtTiername.Size = new Size(185, 34);
            txtTiername.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 41);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 12;
            label6.Text = "Name:";
            // 
            // Tiername
            // 
            Tiername.HeaderText = "Tiername";
            Tiername.Name = "Tiername";
            Tiername.ReadOnly = true;
            // 
            // Gewicht
            // 
            Gewicht.HeaderText = "Gewicht";
            Gewicht.Name = "Gewicht";
            Gewicht.ReadOnly = true;
            // 
            // Geburtsdatum
            // 
            Geburtsdatum.HeaderText = "Geburtsdatum";
            Geburtsdatum.Name = "Geburtsdatum";
            Geburtsdatum.ReadOnly = true;
            // 
            // Tierart2
            // 
            Tierart2.HeaderText = "Tier Art";
            Tierart2.Name = "Tierart2";
            Tierart2.ReadOnly = true;
            // 
            // Gehege
            // 
            Gehege.HeaderText = "Gehege";
            Gehege.Name = "Gehege";
            Gehege.ReadOnly = true;
            // 
            // Kontinent
            // 
            Kontinent.HeaderText = "Kontinent";
            Kontinent.Name = "Kontinent";
            Kontinent.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 675);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            Tierart.ResumeLayout(false);
            Tierart.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTierListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox lbKontinent;
        private TextBox txtkbezeichnung;
        private Label label1;
        private TabPage tabPage2;
        private TabPage Tierart;
        private TabPage tabPage4;
        private Button btnkloeschen;
        private Button btngloeschen;
        private Button btngsave;
        private ListBox lbgehege;
        private TextBox txtgbezeichnung;
        private Label label2;
        private ComboBox cbKontinent;
        private Label label3;
        private Button btntaloeschen;
        private Button btntasave;
        private ListBox lbTierart;
        private TextBox txtTierart;
        private Label label4;
        private DateTimePicker dateGDatum;
        private Label label8;
        private TextBox txtTiergewicht;
        private Label label7;
        private ComboBox cbTierart;
        private Label label5;
        private Button btntloeschen;
        private Button btntsave;
        private ListBox lbTiere;
        private TextBox txtTiername;
        private Label label6;
        private DataGridView dgvTierListe;
        private DataGridViewTextBoxColumn Tiername;
        private DataGridViewTextBoxColumn Gewicht;
        private DataGridViewTextBoxColumn Geburtsdatum;
        private DataGridViewTextBoxColumn Tierart2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Kontinent;
        private Button btnksave;
        private ComboBox cbgehege;
        private Label label9;
        private Button btnToCSV;
        private DataGridViewTextBoxColumn Gehege;
    }
}
