namespace finalldbproject
{
    partial class form_adminlogin
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
            this.label_adminLogin = new System.Windows.Forms.Label();
            this.text_adminId = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label_adminId = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_adminLogin
            // 
            this.label_adminLogin.AutoSize = true;
            this.label_adminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label_adminLogin.Location = new System.Drawing.Point(150, 20);
            this.label_adminLogin.Name = "label_adminLogin";
            this.label_adminLogin.Size = new System.Drawing.Size(180, 36);
            this.label_adminLogin.TabIndex = 0;
            this.label_adminLogin.Text = "Admin Login";
            // 
            // text_adminId
            // 
            this.text_adminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_adminId.Location = new System.Drawing.Point(150, 80);
            this.text_adminId.Name = "text_adminId";
            this.text_adminId.Size = new System.Drawing.Size(180, 30);
            this.text_adminId.TabIndex = 1;
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_password.Location = new System.Drawing.Point(150, 140);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(180, 30);
            this.text_password.TabIndex = 2;
            // 
            // label_adminId
            // 
            this.label_adminId.AutoSize = true;
            this.label_adminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_adminId.Location = new System.Drawing.Point(50, 80);
            this.label_adminId.Name = "label_adminId";
            this.label_adminId.Size = new System.Drawing.Size(90, 25);
            this.label_adminId.TabIndex = 3;
            this.label_adminId.Text = "Admin ID:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_password.Location = new System.Drawing.Point(50, 140);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(98, 25);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password:";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(150, 200);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(100, 40);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // form_adminlogin
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_adminId);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_adminId);
            this.Controls.Add(this.label_adminLogin);
            this.Name = "form_adminlogin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_adminLogin;
        private System.Windows.Forms.TextBox text_adminId;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label_adminId;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
    }
}
