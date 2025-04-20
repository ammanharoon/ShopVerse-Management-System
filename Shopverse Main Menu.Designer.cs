namespace DB_Project
{
    partial class form_shopversemaimenu
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
            this.button_customer = new System.Windows.Forms.Button();
            this.button_seller = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_customer
            // 
            this.button_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.button_customer.FlatAppearance.BorderSize = 0;
            this.button_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_customer.ForeColor = System.Drawing.Color.White;
            this.button_customer.Location = new System.Drawing.Point(300, 344);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(220, 50);
            this.button_customer.TabIndex = 8;
            this.button_customer.Text = "Customer";
            this.button_customer.UseVisualStyleBackColor = false;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click_2);
            // 
            // button_seller
            // 
            this.button_seller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.button_seller.FlatAppearance.BorderSize = 0;
            this.button_seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_seller.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_seller.ForeColor = System.Drawing.Color.White;
            this.button_seller.Location = new System.Drawing.Point(300, 232);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(220, 50);
            this.button_seller.TabIndex = 7;
            this.button_seller.Text = "Seller";
            this.button_seller.UseVisualStyleBackColor = false;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // button_admin
            // 
            this.button_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(48)))));
            this.button_admin.FlatAppearance.BorderSize = 0;
            this.button_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_admin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_admin.ForeColor = System.Drawing.Color.White;
            this.button_admin.Location = new System.Drawing.Point(300, 119);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(220, 50);
            this.button_admin.TabIndex = 6;
            this.button_admin.Text = "Admin";
            this.button_admin.UseVisualStyleBackColor = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shop Verse";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // form_shopversemaimenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_customer);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.label1);
            this.Name = "form_shopversemaimenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopverse Main Menu";
            this.Load += new System.EventHandler(this.form_shopversemaimenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        // Custom Paint Event Handler for Gradient and Faded Background



        #endregion
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.Label label1;
    }
}