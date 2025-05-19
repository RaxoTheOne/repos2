namespace Tiere
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTierName = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            listeTiere = new ListBox();
            label4 = new Label();
            buttonLöschen = new Button();
            buttonBeenden = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "Tiername:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 5;
            label3.Text = "Tieralter:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 7;
            label2.Text = "Tierart:";
            // 
            // txtTierName
            // 
            txtTierName.AccessibleDescription = "";
            txtTierName.BackColor = SystemColors.Window;
            txtTierName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTierName.Location = new Point(126, 29);
            txtTierName.Name = "txtTierName";
            txtTierName.PlaceholderText = "Tiername";
            txtTierName.Size = new Size(161, 33);
            txtTierName.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Katze", "Hunde", "Schnecke", "Echse", "Schlange" });
            comboBox1.Location = new Point(126, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 33);
            comboBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(126, 106);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(85, 33);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(30, 166);
            button1.Name = "button1";
            button1.Size = new Size(147, 33);
            button1.TabIndex = 10;
            button1.Text = "Hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(209, 166);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 11;
            button2.Text = "Bearbeiten";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonBearbeiten1_Click;
            // 
            // listeTiere
            // 
            listeTiere.BackColor = Color.PaleGreen;
            listeTiere.FormattingEnabled = true;
            listeTiere.ItemHeight = 15;
            listeTiere.Location = new Point(384, 58);
            listeTiere.Name = "listeTiere";
            listeTiere.Size = new Size(371, 424);
            listeTiere.TabIndex = 12;
            listeTiere.SelectedIndexChanged += listeTiere_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(384, 28);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 13;
            label4.Text = "Tierliste";
            // 
            // buttonLöschen
            // 
            buttonLöschen.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLöschen.Location = new Point(30, 221);
            buttonLöschen.Name = "buttonLöschen";
            buttonLöschen.Size = new Size(147, 33);
            buttonLöschen.TabIndex = 14;
            buttonLöschen.Text = "Löschen";
            buttonLöschen.UseVisualStyleBackColor = true;
            buttonLöschen.Click += buttonLoeschen_Click;
            // 
            // buttonBeenden
            // 
            buttonBeenden.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBeenden.Location = new Point(30, 449);
            buttonBeenden.Name = "buttonBeenden";
            buttonBeenden.Size = new Size(147, 33);
            buttonBeenden.TabIndex = 15;
            buttonBeenden.Text = "Beenden";
            buttonBeenden.UseVisualStyleBackColor = true;
            buttonBeenden.Click += buttonBeenden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(807, 533);
            Controls.Add(buttonBeenden);
            Controls.Add(buttonLöschen);
            Controls.Add(label4);
            Controls.Add(listeTiere);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtTierName);
            MinimumSize = new Size(16, 39);
            Name = "Form1";
            Text = "Tiere";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtTierName;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private ListBox listeTiere;
        private Label label4;
        private Button buttonLöschen;
        private Button buttonBeenden;
    }
}
