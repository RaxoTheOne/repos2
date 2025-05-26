namespace ProdukteUebung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNeueProdukte = new Button();
            listBoxAutos = new ListBox();
            lblGesamtwert = new Label();
            lblGw = new Label();
            lblAutoListe = new Label();
            SuspendLayout();
            // 
            // btnNeueProdukte
            // 
            btnNeueProdukte.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNeueProdukte.Location = new Point(55, 44);
            btnNeueProdukte.Name = "btnNeueProdukte";
            btnNeueProdukte.Size = new Size(159, 48);
            btnNeueProdukte.TabIndex = 0;
            btnNeueProdukte.Text = "Neue Produkte";
            btnNeueProdukte.UseVisualStyleBackColor = true;
            btnNeueProdukte.Click += btnNeueProdukte_Click;
            // 
            // listBoxAutos
            // 
            listBoxAutos.BackColor = Color.LightSkyBlue;
            listBoxAutos.Font = new Font("Segoe UI", 16F);
            listBoxAutos.FormattingEnabled = true;
            listBoxAutos.ItemHeight = 30;
            listBoxAutos.Location = new Point(89, 317);
            listBoxAutos.Name = "listBoxAutos";
            listBoxAutos.Size = new Size(699, 124);
            listBoxAutos.TabIndex = 1;
            // 
            // lblGesamtwert
            // 
            lblGesamtwert.AutoSize = true;
            lblGesamtwert.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGesamtwert.Location = new Point(226, 473);
            lblGesamtwert.Name = "lblGesamtwert";
            lblGesamtwert.Size = new Size(128, 22);
            lblGesamtwert.TabIndex = 2;
            lblGesamtwert.Text = "Gesamtwert:";
            // 
            // lblGw
            // 
            lblGw.AutoSize = true;
            lblGw.BackColor = Color.Green;
            lblGw.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGw.Location = new Point(362, 473);
            lblGw.Name = "lblGw";
            lblGw.Size = new Size(114, 22);
            lblGw.TabIndex = 3;
            lblGw.Text = "Summe Gw";
            // 
            // lblAutoListe
            // 
            lblAutoListe.AutoSize = true;
            lblAutoListe.BackColor = SystemColors.MenuHighlight;
            lblAutoListe.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAutoListe.Location = new Point(379, 280);
            lblAutoListe.Name = "lblAutoListe";
            lblAutoListe.Size = new Size(97, 22);
            lblAutoListe.TabIndex = 4;
            lblAutoListe.Text = "AutoListe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 517);
            Controls.Add(lblAutoListe);
            Controls.Add(lblGw);
            Controls.Add(lblGesamtwert);
            Controls.Add(listBoxAutos);
            Controls.Add(btnNeueProdukte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNeueProdukte;
        private ListBox listBoxAutos;
        private Label lblGesamtwert;
        private Label lblGw;
        private Label lblAutoListe;
    }
}
