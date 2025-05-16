namespace Personen
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
            lbvorname = new Label();
            lbnachname = new Label();
            txtVorname = new TextBox();
            txtNachname = new TextBox();
            btnInsert = new Button();
            listPerson = new ListBox();
            label1 = new Label();
            Bearbeiten = new Button();
            SuspendLayout();
            // 
            // lbvorname
            // 
            lbvorname.AutoSize = true;
            lbvorname.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbvorname.Location = new Point(135, 70);
            lbvorname.Name = "lbvorname";
            lbvorname.Size = new Size(112, 30);
            lbvorname.TabIndex = 0;
            lbvorname.Text = "Vorname:";
            lbvorname.Click += label1_Click;
            // 
            // lbnachname
            // 
            lbnachname.AutoSize = true;
            lbnachname.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbnachname.Location = new Point(135, 127);
            lbnachname.Name = "lbnachname";
            lbnachname.Size = new Size(129, 30);
            lbnachname.TabIndex = 1;
            lbnachname.Text = "Nachname:";
            lbnachname.Click += label2_Click;
            // 
            // txtVorname
            // 
            txtVorname.Location = new Point(276, 73);
            txtVorname.Name = "txtVorname";
            txtVorname.PlaceholderText = "Vorname";
            txtVorname.Size = new Size(172, 23);
            txtVorname.TabIndex = 2;
            // 
            // txtNachname
            // 
            txtNachname.Location = new Point(276, 127);
            txtNachname.Name = "txtNachname";
            txtNachname.PlaceholderText = "Nachname";
            txtNachname.Size = new Size(172, 23);
            txtNachname.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnInsert.Location = new Point(276, 180);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(172, 44);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Hinzufuegen";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click;
            // 
            // listPerson
            // 
            listPerson.FormattingEnabled = true;
            listPerson.ItemHeight = 15;
            listPerson.Location = new Point(536, 70);
            listPerson.Name = "listPerson";
            listPerson.Size = new Size(239, 244);
            listPerson.TabIndex = 5;
            listPerson.SelectedIndexChanged += listPerson_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(536, 36);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 6;
            label1.Text = "Personen-Liste";
            // 
            // Bearbeiten
            // 
            Bearbeiten.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Bearbeiten.Location = new Point(276, 247);
            Bearbeiten.Name = "Bearbeiten";
            Bearbeiten.Size = new Size(157, 49);
            Bearbeiten.TabIndex = 7;
            Bearbeiten.Text = "Bearbeiten";
            Bearbeiten.UseVisualStyleBackColor = true;
            Bearbeiten.Click += Bearbeiten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bearbeiten);
            Controls.Add(label1);
            Controls.Add(listPerson);
            Controls.Add(btnInsert);
            Controls.Add(txtNachname);
            Controls.Add(txtVorname);
            Controls.Add(lbnachname);
            Controls.Add(lbvorname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbvorname;
        private Label lbnachname;
        private TextBox txtVorname;
        private TextBox txtNachname;
        private Button btnInsert;
        private ListBox listPerson;
        private Label label1;
        private Button Bearbeiten;
    }
}
