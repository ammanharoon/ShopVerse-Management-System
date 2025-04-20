namespace finalldbproject
{
    partial class viewcart
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.dataGridView_cart = new System.Windows.Forms.DataGridView();
            this.button_checkout = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_addToWishlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cart
            // 
            this.dataGridView_cart.AllowUserToAddRows = false;
            this.dataGridView_cart.AllowUserToDeleteRows = false;
            this.dataGridView_cart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cart.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_cart.Name = "dataGridView_cart";
            this.dataGridView_cart.ReadOnly = true;
            this.dataGridView_cart.RowHeadersWidth = 51;
            this.dataGridView_cart.RowTemplate.Height = 24;
            this.dataGridView_cart.Size = new System.Drawing.Size(776, 350);
            this.dataGridView_cart.TabIndex = 0;
            this.dataGridView_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_cart_CellContentClick);
            // 
            // button_checkout
            // 
            this.button_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_checkout.ForeColor = System.Drawing.Color.White;
            this.button_checkout.Location = new System.Drawing.Point(12, 400);
            this.button_checkout.Name = "button_checkout";
            this.button_checkout.Size = new System.Drawing.Size(150, 38);
            this.button_checkout.TabIndex = 1;
            this.button_checkout.Text = "Checkout";
            this.button_checkout.UseVisualStyleBackColor = false;
            this.button_checkout.Click += new System.EventHandler(this.button_checkout_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_total.Location = new System.Drawing.Point(630, 370);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(108, 20);
            this.label_total.TabIndex = 2;
            this.label_total.Text = "Total: $0.00";
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_remove.ForeColor = System.Drawing.Color.White;
            this.button_remove.Location = new System.Drawing.Point(638, 400);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(150, 38);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "Remove Item";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(330, 400);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 38);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back to Products";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_addToWishlist
            // 
            this.button_addToWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.button_addToWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addToWishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_addToWishlist.ForeColor = System.Drawing.Color.White;
            this.button_addToWishlist.Location = new System.Drawing.Point(168, 400);
            this.button_addToWishlist.Name = "button_addToWishlist";
            this.button_addToWishlist.Size = new System.Drawing.Size(150, 38);
            this.button_addToWishlist.TabIndex = 5;
            this.button_addToWishlist.Text = "Add to Wishlist";
            this.button_addToWishlist.UseVisualStyleBackColor = false;
            this.button_addToWishlist.Click += new System.EventHandler(this.button_addToWishlist_Click);
            // 
            // viewcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_addToWishlist);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.button_checkout);
            this.Controls.Add(this.dataGridView_cart);
            this.Name = "viewcart";
            this.Text = "View Cart";
            this.Load += new System.EventHandler(this.viewcart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cart;
        private System.Windows.Forms.Button button_checkout;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_addToWishlist;
    }
}
