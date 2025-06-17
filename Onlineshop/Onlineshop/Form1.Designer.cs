namespace Onlineshop
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnRegister = new Button();
            btnLogin = new Button();
            txtPasswort = new TextBox();
            txtBenutzername = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 72);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 0;
            label1.Text = "Benutzer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 140);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 1;
            label2.Text = "Passwort:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPasswort);
            groupBox1.Controls.Add(txtBenutzername);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(24, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 375);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Online Shop Login";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(217, 265);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(242, 45);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(217, 211);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(242, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPasswort
            // 
            txtPasswort.Location = new Point(217, 140);
            txtPasswort.Name = "txtPasswort";
            txtPasswort.Size = new Size(248, 34);
            txtPasswort.TabIndex = 3;
            txtPasswort.UseSystemPasswordChar = true;
            // 
            // txtBenutzername
            // 
            txtBenutzername.Location = new Point(217, 72);
            txtBenutzername.Name = "txtBenutzername";
            txtBenutzername.Size = new Size(250, 34);
            txtBenutzername.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 425);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtPasswort;
        private TextBox txtBenutzername;
        private Button btnRegister;
        private Button btnLogin;
    }
}
