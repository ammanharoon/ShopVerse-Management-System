namespace finalldbproject
{
    partial class form_productManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.button_deleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Management";
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AllowUserToAddRows = false;
            this.dataGridView_products.AllowUserToDeleteRows = false;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Location = new System.Drawing.Point(12, 60);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.ReadOnly = true;
            this.dataGridView_products.RowHeadersWidth = 51;
            this.dataGridView_products.RowTemplate.Height = 24;
            this.dataGridView_products.Size = new System.Drawing.Size(776, 300);
            this.dataGridView_products.TabIndex = 1;
            // 
            // button_deleteProduct
            // 
            this.button_deleteProduct.BackColor = System.Drawing.Color.Red;
            this.button_deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_deleteProduct.ForeColor = System.Drawing.Color.White;
            this.button_deleteProduct.Location = new System.Drawing.Point(638, 380);
            this.button_deleteProduct.Name = "button_deleteProduct";
            this.button_deleteProduct.Size = new System.Drawing.Size(150, 40);
            this.button_deleteProduct.TabIndex = 2;
            this.button_deleteProduct.Text = "Delete Selected";
            this.button_deleteProduct.UseVisualStyleBackColor = false;
            this.button_deleteProduct.Click += new System.EventHandler(this.button_deleteProduct_Click);
            // 
            // form_productManagement
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_deleteProduct);
            this.Controls.Add(this.dataGridView_products);
            this.Controls.Add(this.label1);
            this.Name = "form_productManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.Button button_deleteProduct;
    }
}
