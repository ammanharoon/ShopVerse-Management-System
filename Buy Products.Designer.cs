namespace DB_Project
{
    partial class form_buyproducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_category = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_price = new System.Windows.Forms.Label();
            this.comboBox_price = new System.Windows.Forms.ComboBox();
            this.label_rating = new System.Windows.Forms.Label();
            this.comboBox_rating = new System.Windows.Forms.ComboBox();
            this.label_brand = new System.Windows.Forms.Label();
            this.comboBox_brand = new System.Windows.Forms.ComboBox();
            this.checkBox_shipping = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel_products = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(300, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Catalog";
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_search.Location = new System.Drawing.Point(30, 60);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(400, 30);
            this.textBox_search.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(450, 60);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 30);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_category.Location = new System.Drawing.Point(30, 100);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(76, 20);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Category";
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "All Categories",
            "Electronics",
            "Clothing",
            "Books",
            "Home Appliances",
            "Toys"});
            this.comboBox_category.Location = new System.Drawing.Point(30, 130);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(150, 28);
            this.comboBox_category.TabIndex = 4;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_price.Location = new System.Drawing.Point(200, 100);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(48, 20);
            this.label_price.TabIndex = 5;
            this.label_price.Text = "Price";
            // 
            // comboBox_price
            // 
            this.comboBox_price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBox_price.FormattingEnabled = true;
            this.comboBox_price.Items.AddRange(new object[] {
            "All Prices",
            "Under $50",
            "$50-$100",
            "$100-$200",
            "Above $200"});
            this.comboBox_price.Location = new System.Drawing.Point(200, 130);
            this.comboBox_price.Name = "comboBox_price";
            this.comboBox_price.Size = new System.Drawing.Size(150, 28);
            this.comboBox_price.TabIndex = 6;
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_rating.Location = new System.Drawing.Point(370, 100);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(57, 20);
            this.label_rating.TabIndex = 7;
            this.label_rating.Text = "Rating";
            // 
            // comboBox_rating
            // 
            this.comboBox_rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBox_rating.FormattingEnabled = true;
            this.comboBox_rating.Items.AddRange(new object[] {
            "All Ratings",
            "4 Stars & Up",
            "3 Stars & Up",
            "2 Stars & Up",
            "1 Star & Up"});
            this.comboBox_rating.Location = new System.Drawing.Point(370, 130);
            this.comboBox_rating.Name = "comboBox_rating";
            this.comboBox_rating.Size = new System.Drawing.Size(150, 28);
            this.comboBox_rating.TabIndex = 8;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_brand.Location = new System.Drawing.Point(540, 100);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(54, 20);
            this.label_brand.TabIndex = 9;
            this.label_brand.Text = "Brand";
            // 
            // comboBox_brand
            // 
            this.comboBox_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBox_brand.FormattingEnabled = true;
            this.comboBox_brand.Items.AddRange(new object[] {
            "All Brands",
            "Brand A",
            "Brand B",
            "Brand C"});
            this.comboBox_brand.Location = new System.Drawing.Point(540, 130);
            this.comboBox_brand.Name = "comboBox_brand";
            this.comboBox_brand.Size = new System.Drawing.Size(150, 28);
            this.comboBox_brand.TabIndex = 10;
            // 
            // checkBox_shipping
            // 
            this.checkBox_shipping.AutoSize = true;
            this.checkBox_shipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.checkBox_shipping.Location = new System.Drawing.Point(710, 130);
            this.checkBox_shipping.Name = "checkBox_shipping";
            this.checkBox_shipping.Size = new System.Drawing.Size(134, 24);
            this.checkBox_shipping.TabIndex = 11;
            this.checkBox_shipping.Text = "Free Shipping";
            this.checkBox_shipping.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_products
            // 
            this.flowLayoutPanel_products.AutoScroll = true;
            this.flowLayoutPanel_products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel_products.Location = new System.Drawing.Point(30, 180);
            this.flowLayoutPanel_products.Name = "flowLayoutPanel_products";
            this.flowLayoutPanel_products.Size = new System.Drawing.Size(740, 300);
            this.flowLayoutPanel_products.TabIndex = 12;
            this.flowLayoutPanel_products.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_products_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(761, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(776, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_buyproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel_products);
            this.Controls.Add(this.checkBox_shipping);
            this.Controls.Add(this.comboBox_brand);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.comboBox_rating);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.comboBox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Name = "form_buyproducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Products";
           // this.Load += new System.EventHandler(this.form_buyproducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.ComboBox comboBox_price;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.ComboBox comboBox_rating;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.ComboBox comboBox_brand;
        private System.Windows.Forms.CheckBox checkBox_shipping;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_products;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
