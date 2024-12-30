namespace Library
{
    partial class loginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.panel_Register = new System.Windows.Forms.Panel();
            this.lbl_ConfirmNewPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_NewUsername = new System.Windows.Forms.Label();
            this.btn_RegisterAccount = new System.Windows.Forms.Button();
            this.txtBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtBox_NewPassword = new System.Windows.Forms.TextBox();
            this.txtBox_NewUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.panel_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Library App";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(262, 160);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(227, 22);
            this.txtBox_Username.TabIndex = 1;
            this.txtBox_Username.Tag = "";
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(262, 211);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(227, 22);
            this.txtBox_Password.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(329, 319);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(85, 30);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(329, 283);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(85, 30);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // panel_Register
            // 
            this.panel_Register.Controls.Add(this.lbl_ConfirmNewPassword);
            this.panel_Register.Controls.Add(this.lbl_NewPassword);
            this.panel_Register.Controls.Add(this.lbl_NewUsername);
            this.panel_Register.Controls.Add(this.btn_RegisterAccount);
            this.panel_Register.Controls.Add(this.txtBox_ConfirmPassword);
            this.panel_Register.Controls.Add(this.txtBox_NewPassword);
            this.panel_Register.Controls.Add(this.txtBox_NewUsername);
            this.panel_Register.Controls.Add(this.label2);
            this.panel_Register.Location = new System.Drawing.Point(-2, 0);
            this.panel_Register.Name = "panel_Register";
            this.panel_Register.Size = new System.Drawing.Size(801, 449);
            this.panel_Register.TabIndex = 5;
            // 
            // lbl_ConfirmNewPassword
            // 
            this.lbl_ConfirmNewPassword.AutoSize = true;
            this.lbl_ConfirmNewPassword.Location = new System.Drawing.Point(261, 245);
            this.lbl_ConfirmNewPassword.Name = "lbl_ConfirmNewPassword";
            this.lbl_ConfirmNewPassword.Size = new System.Drawing.Size(148, 16);
            this.lbl_ConfirmNewPassword.TabIndex = 8;
            this.lbl_ConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(261, 192);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(100, 16);
            this.lbl_NewPassword.TabIndex = 7;
            this.lbl_NewPassword.Text = "New Password:";
            // 
            // lbl_NewUsername
            // 
            this.lbl_NewUsername.AutoSize = true;
            this.lbl_NewUsername.Location = new System.Drawing.Point(261, 137);
            this.lbl_NewUsername.Name = "lbl_NewUsername";
            this.lbl_NewUsername.Size = new System.Drawing.Size(103, 16);
            this.lbl_NewUsername.TabIndex = 6;
            this.lbl_NewUsername.Text = "New Username:";
            // 
            // btn_RegisterAccount
            // 
            this.btn_RegisterAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterAccount.Location = new System.Drawing.Point(328, 319);
            this.btn_RegisterAccount.Name = "btn_RegisterAccount";
            this.btn_RegisterAccount.Size = new System.Drawing.Size(85, 30);
            this.btn_RegisterAccount.TabIndex = 5;
            this.btn_RegisterAccount.Text = "Register";
            this.btn_RegisterAccount.UseVisualStyleBackColor = true;
            this.btn_RegisterAccount.Click += new System.EventHandler(this.btn_RegisterAccount_Click);
            // 
            // txtBox_ConfirmPassword
            // 
            this.txtBox_ConfirmPassword.Location = new System.Drawing.Point(261, 264);
            this.txtBox_ConfirmPassword.Name = "txtBox_ConfirmPassword";
            this.txtBox_ConfirmPassword.PasswordChar = '*';
            this.txtBox_ConfirmPassword.Size = new System.Drawing.Size(227, 22);
            this.txtBox_ConfirmPassword.TabIndex = 4;
            this.txtBox_ConfirmPassword.Tag = "";
            this.txtBox_ConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_ConfirmPassword_KeyDown);
            // 
            // txtBox_NewPassword
            // 
            this.txtBox_NewPassword.Location = new System.Drawing.Point(261, 211);
            this.txtBox_NewPassword.Name = "txtBox_NewPassword";
            this.txtBox_NewPassword.PasswordChar = '*';
            this.txtBox_NewPassword.Size = new System.Drawing.Size(227, 22);
            this.txtBox_NewPassword.TabIndex = 3;
            this.txtBox_NewPassword.Tag = "";
            // 
            // txtBox_NewUsername
            // 
            this.txtBox_NewUsername.Location = new System.Drawing.Point(261, 159);
            this.txtBox_NewUsername.Name = "txtBox_NewUsername";
            this.txtBox_NewUsername.Size = new System.Drawing.Size(227, 22);
            this.txtBox_NewUsername.TabIndex = 2;
            this.txtBox_NewUsername.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register Account";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(259, 137);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(73, 16);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(259, 192);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(70, 16);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password:";
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Register);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.loginPage_Load);
            this.panel_Register.ResumeLayout(false);
            this.panel_Register.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Panel panel_Register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RegisterAccount;
        private System.Windows.Forms.TextBox txtBox_ConfirmPassword;
        private System.Windows.Forms.TextBox txtBox_NewPassword;
        private System.Windows.Forms.TextBox txtBox_NewUsername;
        private System.Windows.Forms.Label lbl_ConfirmNewPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_NewUsername;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
    }
}

