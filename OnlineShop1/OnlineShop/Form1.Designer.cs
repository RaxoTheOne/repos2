namespace OnlineShop
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
            lblBenutzername = new Label();
            lblPasswort = new Label();
            gbLogin = new GroupBox();
            bntRegister = new Button();
            btnLogin = new Button();
            txtPasswort = new TextBox();
            txtBenuztername = new TextBox();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblBenutzername
            // 
            lblBenutzername.AutoSize = true;
            lblBenutzername.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBenutzername.Location = new Point(35, 94);
            lblBenutzername.Name = "lblBenutzername";
            lblBenutzername.Size = new Size(141, 25);
            lblBenutzername.TabIndex = 0;
            lblBenutzername.Text = "Benutzername:";
            // 
            // lblPasswort
            // 
            lblPasswort.AutoSize = true;
            lblPasswort.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswort.Location = new Point(59, 187);
            lblPasswort.Name = "lblPasswort";
            lblPasswort.Size = new Size(93, 25);
            lblPasswort.TabIndex = 1;
            lblPasswort.Text = "Passwort:";
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(bntRegister);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(txtPasswort);
            gbLogin.Controls.Add(txtBenuztername);
            gbLogin.Controls.Add(lblBenutzername);
            gbLogin.Controls.Add(lblPasswort);
            gbLogin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbLogin.Location = new Point(12, 12);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(637, 545);
            gbLogin.TabIndex = 2;
            gbLogin.TabStop = false;
            gbLogin.Text = "Online Shop Login";
            // 
            // bntRegister
            // 
            bntRegister.BackColor = SystemColors.AppWorkspace;
            bntRegister.Location = new Point(207, 323);
            bntRegister.Name = "bntRegister";
            bntRegister.Size = new Size(230, 43);
            bntRegister.TabIndex = 5;
            bntRegister.Text = "Register";
            bntRegister.UseVisualStyleBackColor = false;
            bntRegister.Click += bntRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.AppWorkspace;
            btnLogin.Location = new Point(207, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(230, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPasswort
            // 
            txtPasswort.Location = new Point(207, 180);
            txtPasswort.Name = "txtPasswort";
            txtPasswort.Size = new Size(230, 35);
            txtPasswort.TabIndex = 3;
            // 
            // txtBenuztername
            // 
            txtBenuztername.Location = new Point(207, 87);
            txtBenuztername.Name = "txtBenuztername";
            txtBenuztername.Size = new Size(230, 35);
            txtBenuztername.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 582);
            Controls.Add(gbLogin);
            Name = "Form1";
            Text = "Form1";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBenutzername;
        private Label lblPasswort;
        private GroupBox gbLogin;
        private Button bntRegister;
        private Button btnLogin;
        private TextBox txtPasswort;
        private TextBox txtBenuztername;
    }
}
