namespace finalldbproject
{
    partial class form_sellerProducts
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
            this.flowLayoutPanel_products = new System.Windows.Forms.FlowLayoutPanel();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_products
            // 
            this.flowLayoutPanel_products.AutoScroll = true;
            this.flowLayoutPanel_products.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_products.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_products.Name = "flowLayoutPanel_products";
            this.flowLayoutPanel_products.Size = new System.Drawing.Size(760, 350);
            this.flowLayoutPanel_products.TabIndex = 0;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Gray;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(320, 375);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 40);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "Back to Dashboard";
            this.button_back.UseVisualStyleBackColor = false;
      //      this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // form_sellerProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.flowLayoutPanel_products);
            this.Name = "form_sellerProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Seller Products";
         //   this.Load += new System.EventHandler(this.form_sellerProducts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_products;
        private System.Windows.Forms.Button button_back;
    }
}
