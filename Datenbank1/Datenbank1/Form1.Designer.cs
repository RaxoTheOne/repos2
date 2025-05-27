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
            tabControl1.SuspendLayout();
            tbpWarengruppe.SuspendLayout();
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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(482, 415);
            tabControl1.TabIndex = 4;
            // 
            // tbpWarengruppe
            // 
            tbpWarengruppe.Controls.Add(listBox1);
            tbpWarengruppe.Controls.Add(btnSpeichern);
            tbpWarengruppe.Controls.Add(btnEinlesen);
            tbpWarengruppe.Controls.Add(txtWarengruppe);
            tbpWarengruppe.Location = new Point(4, 24);
            tbpWarengruppe.Name = "tbpWarengruppe";
            tbpWarengruppe.Padding = new Padding(3);
            tbpWarengruppe.Size = new Size(474, 387);
            tbpWarengruppe.TabIndex = 0;
            tbpWarengruppe.Text = "Warengruppe";
            tbpWarengruppe.UseVisualStyleBackColor = true;
            // 
            // tbpArtikel
            // 
            tbpArtikel.Location = new Point(4, 24);
            tbpArtikel.Name = "tbpArtikel";
            tbpArtikel.Padding = new Padding(3);
            tbpArtikel.Size = new Size(474, 387);
            tbpArtikel.TabIndex = 1;
            tbpArtikel.Text = "Artikel";
            tbpArtikel.UseVisualStyleBackColor = true;
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
    }
}
