namespace DB_Project
{
    partial class form_custportal
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
            this.button_buy = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.button_wishlist = new System.Windows.Forms.Button();
            this.button_orderhistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Portal";
            // 
            // button_buy
            // 
            this.button_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buy.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buy.ForeColor = System.Drawing.Color.White;
            this.button_buy.Location = new System.Drawing.Point(299, 97);
            this.button_buy.Name = "button_buy";
            this.button_buy.Size = new System.Drawing.Size(210, 45);
            this.button_buy.TabIndex = 1;
            this.button_buy.Text = "Buy Products";
            this.button_buy.UseVisualStyleBackColor = false;
            this.button_buy.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // button_cart
            // 
            this.button_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cart.ForeColor = System.Drawing.Color.White;
            this.button_cart.Location = new System.Drawing.Point(299, 175);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(210, 45);
            this.button_cart.TabIndex = 2;
            this.button_cart.Text = "Track Order";
            this.button_cart.UseVisualStyleBackColor = false;
            this.button_cart.Click += new System.EventHandler(this.trackorder_Click);
            // 
            // button_wishlist
            // 
            this.button_wishlist.BackColor = System.Drawing.Color.Blue;
            this.button_wishlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_wishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wishlist.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_wishlist.ForeColor = System.Drawing.Color.White;
            this.button_wishlist.Location = new System.Drawing.Point(299, 324);
            this.button_wishlist.Name = "button_wishlist";
            this.button_wishlist.Size = new System.Drawing.Size(210, 44);
            this.button_wishlist.TabIndex = 3;
            this.button_wishlist.Text = "Wishlist";
            this.button_wishlist.UseVisualStyleBackColor = false;
            this.button_wishlist.Click += new System.EventHandler(this.button_wishlist_Click);
            // 
            // button_orderhistory
            // 
            this.button_orderhistory.BackColor = System.Drawing.Color.Navy;
            this.button_orderhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_orderhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_orderhistory.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_orderhistory.ForeColor = System.Drawing.Color.White;
            this.button_orderhistory.Location = new System.Drawing.Point(299, 394);
            this.button_orderhistory.Name = "button_orderhistory";
            this.button_orderhistory.Size = new System.Drawing.Size(210, 44);
            this.button_orderhistory.TabIndex = 4;
            this.button_orderhistory.Text = "Manage Profile";
            this.button_orderhistory.UseVisualStyleBackColor = false;
            this.button_orderhistory.Click += new System.EventHandler(this.button_manageprofile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(299, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Order History";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.orderhistory_Click);
            // 
            // form_custportal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_orderhistory);
            this.Controls.Add(this.button_wishlist);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.button_buy);
            this.Controls.Add(this.label1);
            this.Name = "form_custportal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_buy;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_wishlist;
        private System.Windows.Forms.Button button_orderhistory;
        private System.Windows.Forms.Button button1;
    }
}