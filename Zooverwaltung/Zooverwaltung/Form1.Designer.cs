namespace Zooverwaltung
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
            listBoxKontinente = new ListBox();
            btnKontinentLoeschen = new Button();
            btnKontinentSpeichern = new Button();
            label1 = new Label();
            txtKontinentBezeichnung = new TextBox();
            tabPage2 = new TabPage();
            listBoxGehege = new ListBox();
            btnGehegeLoeschen = new Button();
            btnGehegeSpeichern = new Button();
            cbGehegeKontinent = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtGehegeBezeichnung = new TextBox();
            tabPage3 = new TabPage();
            listBoxTierart = new ListBox();
            btnTierartLoeschen = new Button();
            btnTierartSpeichern = new Button();
            label4 = new Label();
            txtTierartBezeichnung = new TextBox();
            tabPage4 = new TabPage();
            btnXMLDateiEinlesen = new Button();
            cbTierTierart = new ComboBox();
            label10 = new Label();
            dgvTiere = new DataGridView();
            tiername = new DataGridViewTextBoxColumn();
            gewicht = new DataGridViewTextBoxColumn();
            geburtsdatum = new DataGridViewTextBoxColumn();
            tierart = new DataGridViewTextBoxColumn();
            gehege = new DataGridViewTextBoxColumn();
            kontinent = new DataGridViewTextBoxColumn();
            cbTierGehege = new ComboBox();
            label8 = new Label();
            datePickerTierGb = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            txtTierGewicht = new TextBox();
            listBoxTiere = new ListBox();
            btnTierLoeschen = new Button();
            btnTierSpeichern = new Button();
            label5 = new Label();
            txtTierBezeichnung = new TextBox();
            tabPage5 = new TabPage();
            listBoxFutter = new ListBox();
            btnFutterLoeschen = new Button();
            btnFutterSpeichern = new Button();
            label9 = new Label();
            txtFutterName = new TextBox();
            tabPage6 = new TabPage();
            listBoxFutterung = new ListBox();
            btnFutterungLoeschen = new Button();
            btnFutterungSpeichern = new Button();
            cbFutterungFutter = new ComboBox();
            label11 = new Label();
            cbFutterungTiere = new ComboBox();
            label12 = new Label();
            timePickerFutterung = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            txtFutterungMenge = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiere).BeginInit();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(856, 731);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxKontinente);
            tabPage1.Controls.Add(btnKontinentLoeschen);
            tabPage1.Controls.Add(btnKontinentSpeichern);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtKontinentBezeichnung);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(848, 703);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kontinente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxKontinente
            // 
            listBoxKontinente.FormattingEnabled = true;
            listBoxKontinente.ItemHeight = 15;
            listBoxKontinente.Location = new Point(506, 3);
            listBoxKontinente.Name = "listBoxKontinente";
            listBoxKontinente.Size = new Size(336, 379);
            listBoxKontinente.TabIndex = 4;
            // 
            // btnKontinentLoeschen
            // 
            btnKontinentLoeschen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKontinentLoeschen.Location = new Point(133, 345);
            btnKontinentLoeschen.Name = "btnKontinentLoeschen";
            btnKontinentLoeschen.Size = new Size(121, 40);
            btnKontinentLoeschen.TabIndex = 3;
            btnKontinentLoeschen.Text = "Löschen";
            btnKontinentLoeschen.UseVisualStyleBackColor = true;
            btnKontinentLoeschen.Click += btnKontinentLoeschen_Click;
            // 
            // btnKontinentSpeichern
            // 
            btnKontinentSpeichern.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKontinentSpeichern.Location = new Point(6, 345);
            btnKontinentSpeichern.Name = "btnKontinentSpeichern";
            btnKontinentSpeichern.Size = new Size(121, 40);
            btnKontinentSpeichern.TabIndex = 2;
            btnKontinentSpeichern.Text = "Speichern";
            btnKontinentSpeichern.UseVisualStyleBackColor = true;
            btnKontinentSpeichern.Click += btnKontinentSpeichern_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 1;
            label1.Text = "Kontinent Bezeichnung";
            // 
            // txtKontinentBezeichnung
            // 
            txtKontinentBezeichnung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKontinentBezeichnung.Location = new Point(207, 34);
            txtKontinentBezeichnung.Name = "txtKontinentBezeichnung";
            txtKontinentBezeichnung.Size = new Size(251, 29);
            txtKontinentBezeichnung.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBoxGehege);
            tabPage2.Controls.Add(btnGehegeLoeschen);
            tabPage2.Controls.Add(btnGehegeSpeichern);
            tabPage2.Controls.Add(cbGehegeKontinent);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtGehegeBezeichnung);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(848, 703);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gehege";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxGehege
            // 
            listBoxGehege.FormattingEnabled = true;
            listBoxGehege.ItemHeight = 15;
            listBoxGehege.Location = new Point(506, 6);
            listBoxGehege.Name = "listBoxGehege";
            listBoxGehege.Size = new Size(336, 379);
            listBoxGehege.TabIndex = 10;
            // 
            // btnGehegeLoeschen
            // 
            btnGehegeLoeschen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGehegeLoeschen.Location = new Point(130, 345);
            btnGehegeLoeschen.Name = "btnGehegeLoeschen";
            btnGehegeLoeschen.Size = new Size(121, 40);
            btnGehegeLoeschen.TabIndex = 9;
            btnGehegeLoeschen.Text = "Löschen";
            btnGehegeLoeschen.UseVisualStyleBackColor = true;
            btnGehegeLoeschen.Click += btnGehegeLoeschen_Click;
            // 
            // btnGehegeSpeichern
            // 
            btnGehegeSpeichern.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGehegeSpeichern.Location = new Point(3, 345);
            btnGehegeSpeichern.Name = "btnGehegeSpeichern";
            btnGehegeSpeichern.Size = new Size(121, 40);
            btnGehegeSpeichern.TabIndex = 8;
            btnGehegeSpeichern.Text = "Speichern";
            btnGehegeSpeichern.UseVisualStyleBackColor = true;
            btnGehegeSpeichern.Click += btnGehegeSpeichern_Click;
            // 
            // cbGehegeKontinent
            // 
            cbGehegeKontinent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbGehegeKontinent.FormattingEnabled = true;
            cbGehegeKontinent.Location = new Point(173, 46);
            cbGehegeKontinent.Name = "cbGehegeKontinent";
            cbGehegeKontinent.Size = new Size(248, 29);
            cbGehegeKontinent.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 49);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 4;
            label3.Text = "Kontinent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 3;
            label2.Text = "Gehege Bezeichnung";
            // 
            // txtGehegeBezeichnung
            // 
            txtGehegeBezeichnung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGehegeBezeichnung.Location = new Point(173, 6);
            txtGehegeBezeichnung.Name = "txtGehegeBezeichnung";
            txtGehegeBezeichnung.Size = new Size(248, 29);
            txtGehegeBezeichnung.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listBoxTierart);
            tabPage3.Controls.Add(btnTierartLoeschen);
            tabPage3.Controls.Add(btnTierartSpeichern);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txtTierartBezeichnung);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(848, 703);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tierarten";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxTierart
            // 
            listBoxTierart.FormattingEnabled = true;
            listBoxTierart.ItemHeight = 15;
            listBoxTierart.Location = new Point(506, 3);
            listBoxTierart.Name = "listBoxTierart";
            listBoxTierart.Size = new Size(336, 379);
            listBoxTierart.TabIndex = 9;
            // 
            // btnTierartLoeschen
            // 
            btnTierartLoeschen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTierartLoeschen.Location = new Point(134, 342);
            btnTierartLoeschen.Name = "btnTierartLoeschen";
            btnTierartLoeschen.Size = new Size(121, 40);
            btnTierartLoeschen.TabIndex = 8;
            btnTierartLoeschen.Text = "Löschen";
            btnTierartLoeschen.UseVisualStyleBackColor = true;
            btnTierartLoeschen.Click += btnTierartLoeschen_Click;
            // 
            // btnTierartSpeichern
            // 
            btnTierartSpeichern.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTierartSpeichern.Location = new Point(7, 342);
            btnTierartSpeichern.Name = "btnTierartSpeichern";
            btnTierartSpeichern.Size = new Size(121, 40);
            btnTierartSpeichern.TabIndex = 7;
            btnTierartSpeichern.Text = "Speichern";
            btnTierartSpeichern.UseVisualStyleBackColor = true;
            btnTierartSpeichern.Click += btnTierartSpeichern_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 9);
            label4.Name = "label4";
            label4.Size = new Size(155, 21);
            label4.TabIndex = 6;
            label4.Text = "Tierart Bezeichnung";
            // 
            // txtTierartBezeichnung
            // 
            txtTierartBezeichnung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTierartBezeichnung.Location = new Point(168, 9);
            txtTierartBezeichnung.Name = "txtTierartBezeichnung";
            txtTierartBezeichnung.Size = new Size(251, 29);
            txtTierartBezeichnung.TabIndex = 5;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnXMLDateiEinlesen);
            tabPage4.Controls.Add(cbTierTierart);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(dgvTiere);
            tabPage4.Controls.Add(cbTierGehege);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(datePickerTierGb);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(txtTierGewicht);
            tabPage4.Controls.Add(listBoxTiere);
            tabPage4.Controls.Add(btnTierLoeschen);
            tabPage4.Controls.Add(btnTierSpeichern);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(txtTierBezeichnung);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(848, 703);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Tiere";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnXMLDateiEinlesen
            // 
            btnXMLDateiEinlesen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXMLDateiEinlesen.Location = new Point(261, 345);
            btnXMLDateiEinlesen.Name = "btnXMLDateiEinlesen";
            btnXMLDateiEinlesen.Size = new Size(167, 40);
            btnXMLDateiEinlesen.TabIndex = 20;
            btnXMLDateiEinlesen.Text = "XML Datei einlesen";
            btnXMLDateiEinlesen.UseVisualStyleBackColor = true;
            btnXMLDateiEinlesen.Click += btnXMLDateiEinlesen_Click;
            // 
            // cbTierTierart
            // 
            cbTierTierart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTierTierart.FormattingEnabled = true;
            cbTierTierart.Location = new Point(146, 180);
            cbTierTierart.Name = "cbTierTierart";
            cbTierTierart.Size = new Size(226, 29);
            cbTierTierart.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(7, 183);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 18;
            label10.Text = "Tierart";
            // 
            // dgvTiere
            // 
            dgvTiere.AllowUserToAddRows = false;
            dgvTiere.AllowUserToDeleteRows = false;
            dgvTiere.AllowUserToResizeColumns = false;
            dgvTiere.AllowUserToResizeRows = false;
            dgvTiere.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTiere.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiere.Columns.AddRange(new DataGridViewColumn[] { tiername, gewicht, geburtsdatum, tierart, gehege, kontinent });
            dgvTiere.Location = new Point(6, 391);
            dgvTiere.Name = "dgvTiere";
            dgvTiere.Size = new Size(836, 306);
            dgvTiere.TabIndex = 17;
            // 
            // tiername
            // 
            tiername.HeaderText = "Tiername";
            tiername.Name = "tiername";
            // 
            // gewicht
            // 
            gewicht.HeaderText = "Gewicht";
            gewicht.Name = "gewicht";
            // 
            // geburtsdatum
            // 
            geburtsdatum.HeaderText = "Geburtsdatum";
            geburtsdatum.Name = "geburtsdatum";
            // 
            // tierart
            // 
            tierart.HeaderText = "Tierart";
            tierart.Name = "tierart";
            // 
            // gehege
            // 
            gehege.HeaderText = "Gehege";
            gehege.Name = "gehege";
            // 
            // kontinent
            // 
            kontinent.HeaderText = "Kontinent";
            kontinent.Name = "kontinent";
            // 
            // cbTierGehege
            // 
            cbTierGehege.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTierGehege.FormattingEnabled = true;
            cbTierGehege.Location = new Point(145, 140);
            cbTierGehege.Name = "cbTierGehege";
            cbTierGehege.Size = new Size(226, 29);
            cbTierGehege.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 143);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 15;
            label8.Text = "Gehege";
            // 
            // datePickerTierGb
            // 
            datePickerTierGb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datePickerTierGb.Format = DateTimePickerFormat.Short;
            datePickerTierGb.Location = new Point(145, 95);
            datePickerTierGb.Name = "datePickerTierGb";
            datePickerTierGb.Size = new Size(226, 29);
            datePickerTierGb.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 101);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 13;
            label7.Text = "Geburtsdatum";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 54);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 11;
            label6.Text = "Gewicht";
            // 
            // txtTierGewicht
            // 
            txtTierGewicht.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTierGewicht.Location = new Point(145, 51);
            txtTierGewicht.Name = "txtTierGewicht";
            txtTierGewicht.Size = new Size(230, 29);
            txtTierGewicht.TabIndex = 10;
            // 
            // listBoxTiere
            // 
            listBoxTiere.FormattingEnabled = true;
            listBoxTiere.ItemHeight = 15;
            listBoxTiere.Location = new Point(494, 0);
            listBoxTiere.Name = "listBoxTiere";
            listBoxTiere.Size = new Size(348, 379);
            listBoxTiere.TabIndex = 9;
            listBoxTiere.SelectedIndexChanged += listBoxTiere_SelectedIndexChanged;
            // 
            // btnTierLoeschen
            // 
            btnTierLoeschen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTierLoeschen.Location = new Point(134, 345);
            btnTierLoeschen.Name = "btnTierLoeschen";
            btnTierLoeschen.Size = new Size(121, 40);
            btnTierLoeschen.TabIndex = 8;
            btnTierLoeschen.Text = "Löschen";
            btnTierLoeschen.UseVisualStyleBackColor = true;
            btnTierLoeschen.Click += btnTierLoeschen_Click;
            // 
            // btnTierSpeichern
            // 
            btnTierSpeichern.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTierSpeichern.Location = new Point(7, 345);
            btnTierSpeichern.Name = "btnTierSpeichern";
            btnTierSpeichern.Size = new Size(121, 40);
            btnTierSpeichern.TabIndex = 7;
            btnTierSpeichern.Text = "Speichern";
            btnTierSpeichern.UseVisualStyleBackColor = true;
            btnTierSpeichern.Click += btnTierSpeichern_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 6;
            label5.Text = "Tiername";
            // 
            // txtTierBezeichnung
            // 
            txtTierBezeichnung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTierBezeichnung.Location = new Point(145, 6);
            txtTierBezeichnung.Name = "txtTierBezeichnung";
            txtTierBezeichnung.Size = new Size(230, 29);
            txtTierBezeichnung.TabIndex = 5;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(listBoxFutter);
            tabPage5.Controls.Add(btnFutterLoeschen);
            tabPage5.Controls.Add(btnFutterSpeichern);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(txtFutterName);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(848, 703);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Futter";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // listBoxFutter
            // 
            listBoxFutter.FormattingEnabled = true;
            listBoxFutter.ItemHeight = 15;
            listBoxFutter.Location = new Point(492, 6);
            listBoxFutter.Name = "listBoxFutter";
            listBoxFutter.Size = new Size(336, 379);
            listBoxFutter.TabIndex = 9;
            // 
            // btnFutterLoeschen
            // 
            btnFutterLoeschen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFutterLoeschen.Location = new Point(129, 317);
            btnFutterLoeschen.Name = "btnFutterLoeschen";
            btnFutterLoeschen.Size = new Size(121, 40);
            btnFutterLoeschen.TabIndex = 8;
            btnFutterLoeschen.Text = "Löschen";
            btnFutterLoeschen.UseVisualStyleBackColor = true;
            btnFutterLoeschen.Click += btnFutterLoeschen_Click;
            // 
            // btnFutterSpeichern
            // 
            btnFutterSpeichern.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFutterSpeichern.Location = new Point(2, 317);
            btnFutterSpeichern.Name = "btnFutterSpeichern";
            btnFutterSpeichern.Size = new Size(121, 40);
            btnFutterSpeichern.TabIndex = 7;
            btnFutterSpeichern.Text = "Speichern";
            btnFutterSpeichern.UseVisualStyleBackColor = true;
            btnFutterSpeichern.Click += btnFutterSpeichern_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(2, 9);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 6;
            label9.Text = "Futtername";
            // 
            // txtFutterName
            // 
            txtFutterName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFutterName.Location = new Point(203, 6);
            txtFutterName.Name = "txtFutterName";
            txtFutterName.Size = new Size(251, 29);
            txtFutterName.TabIndex = 5;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(listBoxFutterung);
            tabPage6.Controls.Add(btnFutterungLoeschen);
            tabPage6.Controls.Add(btnFutterungSpeichern);
            tabPage6.Controls.Add(cbFutterungFutter);
            tabPage6.Controls.Add(label11);
            tabPage6.Controls.Add(cbFutterungTiere);
            tabPage6.Controls.Add(label12);
            tabPage6.Controls.Add(timePickerFutterung);
            tabPage6.Controls.Add(label13);
            tabPage6.Controls.Add(label14);
            tabPage6.Controls.Add(txtFutterungMenge);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(848, 703);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Fütterung";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // listBoxFutterung
            // 
            listBoxFutterung.FormattingEnabled = true;
            listBoxFutterung.ItemHeight = 15;
            listBoxFutterung.Location = new Point(506, 6);
            listBoxFutterung.Name = "listBoxFutterung";
            listBoxFutterung.Size = new Size(336, 379);
            listBoxFutterung.TabIndex = 32;
            // 
            // btnFutterungLoeschen
            // 
            btnFutterungLoeschen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFutterungLoeschen.Location = new Point(143, 317);
            btnFutterungLoeschen.Name = "btnFutterungLoeschen";
            btnFutterungLoeschen.Size = new Size(121, 40);
            btnFutterungLoeschen.TabIndex = 31;
            btnFutterungLoeschen.Text = "Löschen";
            btnFutterungLoeschen.UseVisualStyleBackColor = true;
            btnFutterungLoeschen.Click += btnFutterungLoeschen_Click;
            // 
            // btnFutterungSpeichern
            // 
            btnFutterungSpeichern.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFutterungSpeichern.Location = new Point(16, 317);
            btnFutterungSpeichern.Name = "btnFutterungSpeichern";
            btnFutterungSpeichern.Size = new Size(121, 40);
            btnFutterungSpeichern.TabIndex = 30;
            btnFutterungSpeichern.Text = "Speichern";
            btnFutterungSpeichern.UseVisualStyleBackColor = true;
            btnFutterungSpeichern.Click += btnFutterungSpeichern_Click;
            // 
            // cbFutterungFutter
            // 
            cbFutterungFutter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFutterungFutter.FormattingEnabled = true;
            cbFutterungFutter.Location = new Point(146, 43);
            cbFutterungFutter.Name = "cbFutterungFutter";
            cbFutterungFutter.Size = new Size(225, 29);
            cbFutterungFutter.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(7, 46);
            label11.Name = "label11";
            label11.Size = new Size(54, 21);
            label11.TabIndex = 28;
            label11.Text = "Futter";
            // 
            // cbFutterungTiere
            // 
            cbFutterungTiere.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFutterungTiere.FormattingEnabled = true;
            cbFutterungTiere.Location = new Point(145, 3);
            cbFutterungTiere.Name = "cbFutterungTiere";
            cbFutterungTiere.Size = new Size(226, 29);
            cbFutterungTiere.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 6);
            label12.Name = "label12";
            label12.Size = new Size(38, 21);
            label12.TabIndex = 26;
            label12.Text = "Tier";
            // 
            // timePickerFutterung
            // 
            timePickerFutterung.CustomFormat = "HH:mm";
            timePickerFutterung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timePickerFutterung.Format = DateTimePickerFormat.Custom;
            timePickerFutterung.Location = new Point(146, 131);
            timePickerFutterung.Name = "timePickerFutterung";
            timePickerFutterung.ShowUpDown = true;
            timePickerFutterung.Size = new Size(226, 29);
            timePickerFutterung.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(7, 131);
            label13.Name = "label13";
            label13.Size = new Size(62, 21);
            label13.TabIndex = 24;
            label13.Text = "Uhrzeit";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(7, 87);
            label14.Name = "label14";
            label14.Size = new Size(135, 21);
            label14.TabIndex = 23;
            label14.Text = "Menge in gramm";
            // 
            // txtFutterungMenge
            // 
            txtFutterungMenge.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFutterungMenge.Location = new Point(146, 87);
            txtFutterungMenge.Name = "txtFutterungMenge";
            txtFutterungMenge.Size = new Size(225, 29);
            txtFutterungMenge.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 743);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiere).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnKontinentLoeschen;
        private Button btnKontinentSpeichern;
        private Label label1;
        private TextBox txtKontinentBezeichnung;
        private TabPage tabPage2;
        private Label label2;
        private TextBox txtGehegeBezeichnung;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListBox listBoxKontinente;
        private ListBox listBoxGehege;
        private Button btnGehegeLoeschen;
        private Button btnGehegeSpeichern;
        private ComboBox cbGehegeKontinent;
        private Label label3;
        private ListBox listBoxTierart;
        private Button btnTierartLoeschen;
        private Button btnTierartSpeichern;
        private Label label4;
        private TextBox txtTierartBezeichnung;
        private DateTimePicker datePickerTierGb;
        private Label label7;
        private Label label6;
        private TextBox txtTierGewicht;
        private ListBox listBoxTiere;
        private Button btnTierLoeschen;
        private Button btnTierSpeichern;
        private Label label5;
        private TextBox txtTierBezeichnung;
        private ComboBox cbTierGehege;
        private Label label8;
        private DataGridView dgvTiere;
        private DataGridViewTextBoxColumn tiername;
        private DataGridViewTextBoxColumn gewicht;
        private DataGridViewTextBoxColumn geburtsdatum;
        private DataGridViewTextBoxColumn tierart;
        private DataGridViewTextBoxColumn gehege;
        private DataGridViewTextBoxColumn kontinent;
        private ComboBox cbTierTierart;
        private Label label10;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private ListBox listBoxFutter;
        private Button btnFutterLoeschen;
        private Button btnFutterSpeichern;
        private Label label9;
        private TextBox txtFutterName;
        private ListBox listBoxFutterung;
        private Button btnFutterungLoeschen;
        private Button btnFutterungSpeichern;
        private ComboBox cbFutterungFutter;
        private Label label11;
        private ComboBox cbFutterungTiere;
        private Label label12;
        private DateTimePicker timePickerFutterung;
        private Label label13;
        private Label label14;
        private TextBox txtFutterungMenge;
        private Button btnXMLDateiEinlesen;
    }
}
