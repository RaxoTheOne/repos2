namespace Rechner
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
            lblEingabe = new Label();
            txtEingabe = new TextBox();
            btnBerechneFormel = new Button();
            lblErgebnis = new Label();
            lblAnzeigeErgebnis = new Label();
            listBoxVerlauf = new ListBox();
            btnVerlaufLoeschen = new Button();
            SuspendLayout();
            // 
            // lblEingabe
            // 
            lblEingabe.AutoSize = true;
            lblEingabe.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEingabe.Location = new Point(56, 79);
            lblEingabe.Name = "lblEingabe";
            lblEingabe.Size = new Size(79, 22);
            lblEingabe.TabIndex = 0;
            lblEingabe.Text = "Formel:";
            // 
            // txtEingabe
            // 
            txtEingabe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEingabe.Location = new Point(172, 74);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(100, 33);
            txtEingabe.TabIndex = 1;
            // 
            // btnBerechneFormel
            // 
            btnBerechneFormel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBerechneFormel.Location = new Point(336, 73);
            btnBerechneFormel.Name = "btnBerechneFormel";
            btnBerechneFormel.Size = new Size(114, 36);
            btnBerechneFormel.TabIndex = 2;
            btnBerechneFormel.Text = "Berechnen";
            btnBerechneFormel.UseVisualStyleBackColor = true;
            btnBerechneFormel.Click += btnBerechneFormel_Click;
            // 
            // lblErgebnis
            // 
            lblErgebnis.AutoSize = true;
            lblErgebnis.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErgebnis.Location = new Point(56, 150);
            lblErgebnis.Name = "lblErgebnis";
            lblErgebnis.Size = new Size(101, 22);
            lblErgebnis.TabIndex = 3;
            lblErgebnis.Text = "Ergebnis:";
            // 
            // lblAnzeigeErgebnis
            // 
            lblAnzeigeErgebnis.AutoSize = true;
            lblAnzeigeErgebnis.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnzeigeErgebnis.Location = new Point(183, 153);
            lblAnzeigeErgebnis.Name = "lblAnzeigeErgebnis";
            lblAnzeigeErgebnis.Size = new Size(31, 18);
            lblAnzeigeErgebnis.TabIndex = 4;
            lblAnzeigeErgebnis.Text = "AE";
            // 
            // listBoxVerlauf
            // 
            listBoxVerlauf.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxVerlauf.FormattingEnabled = true;
            listBoxVerlauf.ItemHeight = 20;
            listBoxVerlauf.Location = new Point(56, 198);
            listBoxVerlauf.Name = "listBoxVerlauf";
            listBoxVerlauf.Size = new Size(233, 184);
            listBoxVerlauf.TabIndex = 5;
            listBoxVerlauf.DoubleClick += listBoxVerlauf_DoubleClick;
            // 
            // btnVerlaufLoeschen
            // 
            btnVerlaufLoeschen.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerlaufLoeschen.Location = new Point(336, 260);
            btnVerlaufLoeschen.Name = "btnVerlaufLoeschen";
            btnVerlaufLoeschen.Size = new Size(114, 65);
            btnVerlaufLoeschen.TabIndex = 6;
            btnVerlaufLoeschen.Text = "Verlauf Löschen";
            btnVerlaufLoeschen.UseVisualStyleBackColor = true;
            btnVerlaufLoeschen.Click += btnVerlaufLoeschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(508, 433);
            Controls.Add(btnVerlaufLoeschen);
            Controls.Add(listBoxVerlauf);
            Controls.Add(lblAnzeigeErgebnis);
            Controls.Add(lblErgebnis);
            Controls.Add(btnBerechneFormel);
            Controls.Add(txtEingabe);
            Controls.Add(lblEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEingabe;
        private TextBox txtEingabe;
        private Button btnBerechneFormel;
        private Label lblErgebnis;
        private Label lblAnzeigeErgebnis;
        private ListBox listBoxVerlauf;
        private Button btnVerlaufLoeschen;
    }
}
