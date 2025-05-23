namespace ProdukteUebung
{
    partial class Hinzufuegen
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
            lblModellname = new Label();
            lblMarke = new Label();
            txtModellname = new TextBox();
            comboBoxMarke = new ComboBox();
            lblPreis = new Label();
            txtPreis = new TextBox();
            groupBoxAutoArt = new GroupBox();
            rbtnDiesel = new RadioButton();
            rbtnBenzin = new RadioButton();
            lblExtras = new Label();
            checkBoxKlimaAnlage = new CheckBox();
            checkBoxSitzHeizung = new CheckBox();
            btnHinzufuegen = new Button();
            btnAbbrechen = new Button();
            pictureBoxLogo = new PictureBox();
            groupBoxAutoArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblModellname
            // 
            lblModellname.AutoSize = true;
            lblModellname.Font = new Font("Segoe UI", 14F);
            lblModellname.Location = new Point(37, 55);
            lblModellname.Name = "lblModellname";
            lblModellname.Size = new Size(122, 25);
            lblModellname.TabIndex = 0;
            lblModellname.Text = "Modellname:";
            // 
            // lblMarke
            // 
            lblMarke.AutoSize = true;
            lblMarke.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarke.Location = new Point(37, 125);
            lblMarke.Name = "lblMarke";
            lblMarke.Size = new Size(69, 25);
            lblMarke.TabIndex = 1;
            lblMarke.Text = "Marke:";
            // 
            // txtModellname
            // 
            txtModellname.Font = new Font("Segoe UI", 14F);
            txtModellname.Location = new Point(183, 52);
            txtModellname.Name = "txtModellname";
            txtModellname.Size = new Size(144, 32);
            txtModellname.TabIndex = 2;
            // 
            // comboBoxMarke
            // 
            comboBoxMarke.Font = new Font("Segoe UI", 14F);
            comboBoxMarke.FormattingEnabled = true;
            comboBoxMarke.Items.AddRange(new object[] { "Audi", "BMW", "Mercedes", "Cupra", "Seat", "Nissan", "Ford", "Volkswagen", "Hyundai", "Toyota", "Daihatsu", "Landrover", "Rangerover", "Porsche", "Suzuki", "Opel", "Mazda", "Lamborghini", "Ferrari", "Aston Martin", "Caddilac", "Chevrolet" });
            comboBoxMarke.Location = new Point(183, 117);
            comboBoxMarke.Name = "comboBoxMarke";
            comboBoxMarke.Size = new Size(144, 33);
            comboBoxMarke.TabIndex = 3;
            comboBoxMarke.SelectedIndexChanged += comboBoxMarke_SelectedIndexChanged;
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Font = new Font("Segoe UI", 14F);
            lblPreis.Location = new Point(37, 198);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(57, 25);
            lblPreis.TabIndex = 4;
            lblPreis.Text = "Preis:";
            // 
            // txtPreis
            // 
            txtPreis.Font = new Font("Segoe UI", 14F);
            txtPreis.Location = new Point(183, 198);
            txtPreis.Name = "txtPreis";
            txtPreis.Size = new Size(144, 32);
            txtPreis.TabIndex = 6;
            // 
            // groupBoxAutoArt
            // 
            groupBoxAutoArt.Controls.Add(rbtnDiesel);
            groupBoxAutoArt.Controls.Add(rbtnBenzin);
            groupBoxAutoArt.Font = new Font("Segoe UI", 14F);
            groupBoxAutoArt.Location = new Point(37, 252);
            groupBoxAutoArt.Name = "groupBoxAutoArt";
            groupBoxAutoArt.Size = new Size(290, 99);
            groupBoxAutoArt.TabIndex = 7;
            groupBoxAutoArt.TabStop = false;
            groupBoxAutoArt.Text = "Auto-Art:";
            // 
            // rbtnDiesel
            // 
            rbtnDiesel.AutoSize = true;
            rbtnDiesel.Location = new Point(57, 66);
            rbtnDiesel.Name = "rbtnDiesel";
            rbtnDiesel.Size = new Size(81, 29);
            rbtnDiesel.TabIndex = 1;
            rbtnDiesel.TabStop = true;
            rbtnDiesel.Text = "Diesel";
            rbtnDiesel.UseVisualStyleBackColor = true;
            // 
            // rbtnBenzin
            // 
            rbtnBenzin.AutoSize = true;
            rbtnBenzin.Location = new Point(57, 31);
            rbtnBenzin.Name = "rbtnBenzin";
            rbtnBenzin.Size = new Size(87, 29);
            rbtnBenzin.TabIndex = 0;
            rbtnBenzin.TabStop = true;
            rbtnBenzin.Text = "Benzin";
            rbtnBenzin.UseVisualStyleBackColor = true;
            // 
            // lblExtras
            // 
            lblExtras.AutoSize = true;
            lblExtras.Font = new Font("Segoe UI", 14F);
            lblExtras.Location = new Point(37, 366);
            lblExtras.Name = "lblExtras";
            lblExtras.Size = new Size(66, 25);
            lblExtras.TabIndex = 8;
            lblExtras.Text = "Extras:";
            // 
            // checkBoxKlimaAnlage
            // 
            checkBoxKlimaAnlage.AutoSize = true;
            checkBoxKlimaAnlage.Font = new Font("Segoe UI", 12F);
            checkBoxKlimaAnlage.Location = new Point(45, 399);
            checkBoxKlimaAnlage.Name = "checkBoxKlimaAnlage";
            checkBoxKlimaAnlage.Size = new Size(114, 25);
            checkBoxKlimaAnlage.TabIndex = 9;
            checkBoxKlimaAnlage.Text = "Klimaanlage";
            checkBoxKlimaAnlage.UseVisualStyleBackColor = true;
            // 
            // checkBoxSitzHeizung
            // 
            checkBoxSitzHeizung.AutoSize = true;
            checkBoxSitzHeizung.Font = new Font("Segoe UI", 12F);
            checkBoxSitzHeizung.Location = new Point(165, 399);
            checkBoxSitzHeizung.Name = "checkBoxSitzHeizung";
            checkBoxSitzHeizung.Size = new Size(109, 25);
            checkBoxSitzHeizung.TabIndex = 10;
            checkBoxSitzHeizung.Text = "Sitzheizung";
            checkBoxSitzHeizung.UseVisualStyleBackColor = true;
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Font = new Font("Segoe UI", 15F);
            btnHinzufuegen.Location = new Point(408, 386);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(137, 45);
            btnHinzufuegen.TabIndex = 11;
            btnHinzufuegen.Text = "Hinzufügen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // btnAbbrechen
            // 
            btnAbbrechen.Font = new Font("Segoe UI", 15F);
            btnAbbrechen.Location = new Point(562, 386);
            btnAbbrechen.Name = "btnAbbrechen";
            btnAbbrechen.Size = new Size(137, 45);
            btnAbbrechen.TabIndex = 12;
            btnAbbrechen.Text = "Abbrechen";
            btnAbbrechen.UseVisualStyleBackColor = true;
            btnAbbrechen.Click += btnAbbrechen_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(375, 52);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(345, 299);
            pictureBoxLogo.TabIndex = 13;
            pictureBoxLogo.TabStop = false;
            // 
            // Hinzufuegen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnAbbrechen);
            Controls.Add(btnHinzufuegen);
            Controls.Add(checkBoxSitzHeizung);
            Controls.Add(checkBoxKlimaAnlage);
            Controls.Add(lblExtras);
            Controls.Add(groupBoxAutoArt);
            Controls.Add(txtPreis);
            Controls.Add(lblPreis);
            Controls.Add(comboBoxMarke);
            Controls.Add(txtModellname);
            Controls.Add(lblMarke);
            Controls.Add(lblModellname);
            Name = "Hinzufuegen";
            Text = "Hinzufuegen";
            groupBoxAutoArt.ResumeLayout(false);
            groupBoxAutoArt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModellname;
        private Label lblMarke;
        private TextBox txtModellname;
        private ComboBox comboBoxMarke;
        private Label lblPreis;
        private TextBox txtPreis;
        private GroupBox groupBoxAutoArt;
        private RadioButton rbtnBenzin;
        private RadioButton rbtnDiesel;
        private Label lblExtras;
        private CheckBox checkBoxKlimaAnlage;
        private CheckBox checkBoxSitzHeizung;
        private Button btnHinzufuegen;
        private Button btnAbbrechen;
        private PictureBox pictureBoxLogo;
    }
}