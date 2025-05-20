namespace AutoV04
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
            comboMarke = new ComboBox();
            txtModell = new TextBox();
            numBaujahr = new NumericUpDown();
            txtPreis = new TextBox();
            listAutos = new ListBox();
            btnHinzufuegen = new Button();
            btnBearbeiten = new Button();
            btnLoeschen = new Button();
            lblAnzahl = new Label();
            lblDurchschnitt = new Label();
            ((System.ComponentModel.ISupportInitialize)numBaujahr).BeginInit();
            SuspendLayout();
            // 
            // comboMarke
            // 
            comboMarke.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            comboMarke.FormattingEnabled = true;
            comboMarke.Location = new Point(93, 96);
            comboMarke.Name = "comboMarke";
            comboMarke.Size = new Size(121, 29);
            comboMarke.TabIndex = 0;
            comboMarke.Text = "Marke";
            // 
            // txtModell
            // 
            txtModell.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtModell.Location = new Point(241, 95);
            txtModell.Name = "txtModell";
            txtModell.Size = new Size(100, 29);
            txtModell.TabIndex = 1;
            txtModell.Text = "Modellname";
            // 
            // numBaujahr
            // 
            numBaujahr.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            numBaujahr.Location = new Point(443, 96);
            numBaujahr.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numBaujahr.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numBaujahr.Name = "numBaujahr";
            numBaujahr.Size = new Size(120, 29);
            numBaujahr.TabIndex = 2;
            numBaujahr.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // txtPreis
            // 
            txtPreis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPreis.Location = new Point(241, 150);
            txtPreis.Name = "txtPreis";
            txtPreis.Size = new Size(100, 29);
            txtPreis.TabIndex = 3;
            txtPreis.Text = "Preis";
            // 
            // listAutos
            // 
            listAutos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listAutos.FormattingEnabled = true;
            listAutos.ItemHeight = 21;
            listAutos.Location = new Point(62, 254);
            listAutos.Name = "listAutos";
            listAutos.Size = new Size(120, 88);
            listAutos.TabIndex = 4;
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHinzufuegen.Location = new Point(390, 265);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(134, 35);
            btnHinzufuegen.TabIndex = 5;
            btnHinzufuegen.Text = "Hinzufuegen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            // 
            // btnBearbeiten
            // 
            btnBearbeiten.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBearbeiten.Location = new Point(548, 265);
            btnBearbeiten.Name = "btnBearbeiten";
            btnBearbeiten.Size = new Size(134, 35);
            btnBearbeiten.TabIndex = 6;
            btnBearbeiten.Text = "Bearbeiten";
            btnBearbeiten.UseVisualStyleBackColor = true;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLoeschen.Location = new Point(229, 265);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(134, 35);
            btnLoeschen.TabIndex = 7;
            btnLoeschen.Text = "Loeschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            // 
            // lblAnzahl
            // 
            lblAnzahl.AutoSize = true;
            lblAnzahl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAnzahl.Location = new Point(49, 165);
            lblAnzahl.Name = "lblAnzahl";
            lblAnzahl.Size = new Size(67, 21);
            lblAnzahl.TabIndex = 8;
            lblAnzahl.Text = "Anzahl:";
            // 
            // lblDurchschnitt
            // 
            lblDurchschnitt.AutoSize = true;
            lblDurchschnitt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDurchschnitt.Location = new Point(44, 217);
            lblDurchschnitt.Name = "lblDurchschnitt";
            lblDurchschnitt.Size = new Size(112, 21);
            lblDurchschnitt.TabIndex = 9;
            lblDurchschnitt.Text = "Durchschnitt:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurchschnitt);
            Controls.Add(lblAnzahl);
            Controls.Add(btnLoeschen);
            Controls.Add(btnBearbeiten);
            Controls.Add(btnHinzufuegen);
            Controls.Add(listAutos);
            Controls.Add(txtPreis);
            Controls.Add(numBaujahr);
            Controls.Add(txtModell);
            Controls.Add(comboMarke);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numBaujahr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboMarke;
        private TextBox txtModell;
        private NumericUpDown numBaujahr;
        private TextBox txtPreis;
        private ListBox listAutos;
        private Button btnHinzufuegen;
        private Button btnBearbeiten;
        private Button btnLoeschen;
        private Label lblAnzahl;
        private Label lblDurchschnitt;
    }
}
