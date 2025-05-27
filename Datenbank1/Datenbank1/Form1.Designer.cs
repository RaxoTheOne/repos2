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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(321, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 319);
            listBox1.TabIndex = 0;
            // 
            // btnEinlesen
            // 
            btnEinlesen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEinlesen.Location = new Point(342, 357);
            btnEinlesen.Name = "btnEinlesen";
            btnEinlesen.Size = new Size(192, 51);
            btnEinlesen.TabIndex = 1;
            btnEinlesen.Text = "Einlesen";
            btnEinlesen.UseVisualStyleBackColor = true;
            btnEinlesen.Click += btnEinlesen_Click;
            // 
            // txtWarengruppe
            // 
            txtWarengruppe.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWarengruppe.Location = new Point(49, 21);
            txtWarengruppe.Name = "txtWarengruppe";
            txtWarengruppe.Size = new Size(197, 33);
            txtWarengruppe.TabIndex = 2;
            txtWarengruppe.Text = "Warengruppe";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpeichern.Location = new Point(74, 89);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(141, 49);
            btnSpeichern.TabIndex = 3;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSpeichern);
            Controls.Add(txtWarengruppe);
            Controls.Add(btnEinlesen);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnEinlesen;
        private TextBox txtWarengruppe;
        private Button btnSpeichern;
    }
}
