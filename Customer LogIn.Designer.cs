namespace DB_Project
{
    partial class form_custlogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label_signup = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.checkBox_showpass = new System.Windows.Forms.CheckBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox(); // Updated from text_username
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // label_signup
            // 
            this.label_signup.AutoSize = true;
            this.label_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label_signup.Location = new System.Drawing.Point(419, 358);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(68, 20);
            this.label_signup.TabIndex = 21;
            this.label_signup.Text = "Sign Up";
            this.label_signup.Click += new System.EventHandler(this.label_signup_Click);

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(200, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Don't Have an Account?";

            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(294, 272);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(105, 48);
            this.button_login.TabIndex = 19;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);

            // 
            // checkBox_showpass
            // 
            this.checkBox_showpass.AutoSize = true;
            this.checkBox_showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_showpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_showpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_showpass.Location = new System.Drawing.Point(437, 249);
            this.checkBox_showpass.Name = "checkBox_showpass";
            this.checkBox_showpass.Size = new System.Drawing.Size(121, 20);
            this.checkBox_showpass.TabIndex = 18;
            this.checkBox_showpass.Text = "Show Password";
            this.checkBox_showpass.UseVisualStyleBackColor = true;
            this.checkBox_showpass.CheckedChanged += new System.EventHandler(this.checkBox_showpass_CheckedChanged);

            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.text_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.Location = new System.Drawing.Point(133, 194);
            this.text_password.Multiline = true;
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(425, 29);
            this.text_password.TabIndex = 15;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(128, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";

            // 
            // text_email
            // 
            this.text_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.text_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.Location = new System.Drawing.Point(133, 116);
            this.text_email.Multiline = true;
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(425, 29);
            this.text_email.TabIndex = 13;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(128, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29); // Changed text to "Email"
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Log In as Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // form_custlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 435);
            this.Controls.Add(this.label_signup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.checkBox_showpass);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_email); // Updated field name
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_custlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_signup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.CheckBox checkBox_showpass;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_email; // Updated field
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
