namespace finalldbproject
{
    partial class form_productCategoryManagement
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
            this.label_title = new System.Windows.Forms.Label();
            this.button_manageCategories = new System.Windows.Forms.Button();
            this.button_manageProducts = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(31, 24);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(546, 34);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Product and Category Management";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_manageCategories
            // 
            this.button_manageCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_manageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_manageCategories.ForeColor = System.Drawing.Color.White;
            this.button_manageCategories.Location = new System.Drawing.Point(200, 100);
            this.button_manageCategories.Name = "button_manageCategories";
            this.button_manageCategories.Size = new System.Drawing.Size(248, 50);
            this.button_manageCategories.TabIndex = 1;
            this.button_manageCategories.Text = "Manage Categories";
            this.button_manageCategories.UseVisualStyleBackColor = false;
            this.button_manageCategories.Click += new System.EventHandler(this.button_manageCategories_Click);
            // 
            // button_manageProducts
            // 
            this.button_manageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_manageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_manageProducts.ForeColor = System.Drawing.Color.White;
            this.button_manageProducts.Location = new System.Drawing.Point(200, 180);
            this.button_manageProducts.Name = "button_manageProducts";
            this.button_manageProducts.Size = new System.Drawing.Size(248, 50);
            this.button_manageProducts.TabIndex = 2;
            this.button_manageProducts.Text = "Manage Products";
            this.button_manageProducts.UseVisualStyleBackColor = false;
            this.button_manageProducts.Click += new System.EventHandler(this.button_manageProducts_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Gray;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(20, 300);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 40);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // form_productCategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_manageProducts);
            this.Controls.Add(this.button_manageCategories);
            this.Controls.Add(this.label_title);
            this.Name = "form_productCategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product and Category Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_manageCategories;
        private System.Windows.Forms.Button button_manageProducts;
        private System.Windows.Forms.Button button_back;
    }
}
