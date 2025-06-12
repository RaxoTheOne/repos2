namespace LernenXML
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
            btnXMLLesen = new Button();
            lbXmlDatei = new ListBox();
            btnXMLSpeichern = new Button();
            SuspendLayout();
            // 
            // btnXMLLesen
            // 
            btnXMLLesen.Location = new Point(12, 382);
            btnXMLLesen.Name = "btnXMLLesen";
            btnXMLLesen.Size = new Size(160, 43);
            btnXMLLesen.TabIndex = 0;
            btnXMLLesen.Text = "XML Lesen";
            btnXMLLesen.UseVisualStyleBackColor = true;
            btnXMLLesen.Click += btnXMLLesen_Click;
            // 
            // lbXmlDatei
            // 
            lbXmlDatei.FormattingEnabled = true;
            lbXmlDatei.ItemHeight = 15;
            lbXmlDatei.Location = new Point(12, 12);
            lbXmlDatei.Name = "lbXmlDatei";
            lbXmlDatei.Size = new Size(532, 349);
            lbXmlDatei.TabIndex = 1;
            // 
            // btnXMLSpeichern
            // 
            btnXMLSpeichern.Enabled = false;
            btnXMLSpeichern.Location = new Point(202, 384);
            btnXMLSpeichern.Name = "btnXMLSpeichern";
            btnXMLSpeichern.Size = new Size(104, 41);
            btnXMLSpeichern.TabIndex = 2;
            btnXMLSpeichern.Text = "XML Speichern";
            btnXMLSpeichern.UseVisualStyleBackColor = true;
            btnXMLSpeichern.Click += btnXMLSpeichern_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXMLSpeichern);
            Controls.Add(lbXmlDatei);
            Controls.Add(btnXMLLesen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnXMLLesen;
        private ListBox lbXmlDatei;
        private Button btnXMLSpeichern;
    }
}
