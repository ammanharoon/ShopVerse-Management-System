namespace finalldbproject
{
    partial class form_categoryManagement
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
            this.dataGridView_categories = new System.Windows.Forms.DataGridView();
            this.label_categoryName = new System.Windows.Forms.Label();
            this.textBox_categoryName = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.button_addCategory = new System.Windows.Forms.Button();
            this.button_deleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Management";
            // 
            // dataGridView_categories
            // 
            this.dataGridView_categories.AllowUserToAddRows = false;
            this.dataGridView_categories.AllowUserToDeleteRows = false;
            this.dataGridView_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_categories.Location = new System.Drawing.Point(12, 60);
            this.dataGridView_categories.Name = "dataGridView_categories";
            this.dataGridView_categories.ReadOnly = true;
            this.dataGridView_categories.RowHeadersWidth = 51;
            this.dataGridView_categories.RowTemplate.Height = 24;
            this.dataGridView_categories.Size = new System.Drawing.Size(776, 250);
            this.dataGridView_categories.TabIndex = 1;
            this.dataGridView_categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_categories_CellContentClick);
            // 
            // label_categoryName
            // 
            this.label_categoryName.AutoSize = true;
            this.label_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_categoryName.Location = new System.Drawing.Point(12, 340);
            this.label_categoryName.Name = "label_categoryName";
            this.label_categoryName.Size = new System.Drawing.Size(130, 20);
            this.label_categoryName.TabIndex = 2;
            this.label_categoryName.Text = "Category Name:";
            // 
            // textBox_categoryName
            // 
            this.textBox_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_categoryName.Location = new System.Drawing.Point(150, 337);
            this.textBox_categoryName.Name = "textBox_categoryName";
            this.textBox_categoryName.Size = new System.Drawing.Size(250, 26);
            this.textBox_categoryName.TabIndex = 3;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_description.Location = new System.Drawing.Point(12, 380);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(100, 20);
            this.label_description.TabIndex = 4;
            this.label_description.Text = "Description:";
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_description.Location = new System.Drawing.Point(150, 377);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(250, 60);
            this.textBox_description.TabIndex = 5;
            // 
            // button_addCategory
            // 
            this.button_addCategory.BackColor = System.Drawing.Color.Green;
            this.button_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_addCategory.ForeColor = System.Drawing.Color.White;
            this.button_addCategory.Location = new System.Drawing.Point(420, 377);
            this.button_addCategory.Name = "button_addCategory";
            this.button_addCategory.Size = new System.Drawing.Size(150, 40);
            this.button_addCategory.TabIndex = 6;
            this.button_addCategory.Text = "Add Category";
            this.button_addCategory.UseVisualStyleBackColor = false;
            this.button_addCategory.Click += new System.EventHandler(this.button_addCategory_Click);
            // 
            // button_deleteCategory
            // 
            this.button_deleteCategory.BackColor = System.Drawing.Color.Red;
            this.button_deleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_deleteCategory.ForeColor = System.Drawing.Color.White;
            this.button_deleteCategory.Location = new System.Drawing.Point(620, 377);
            this.button_deleteCategory.Name = "button_deleteCategory";
            this.button_deleteCategory.Size = new System.Drawing.Size(150, 40);
            this.button_deleteCategory.TabIndex = 7;
            this.button_deleteCategory.Text = "Delete Selected";
            this.button_deleteCategory.UseVisualStyleBackColor = false;
            this.button_deleteCategory.Click += new System.EventHandler(this.button_deleteCategory_Click);
            // 
            // form_categoryManagement
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_deleteCategory);
            this.Controls.Add(this.button_addCategory);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.textBox_categoryName);
            this.Controls.Add(this.label_categoryName);
            this.Controls.Add(this.dataGridView_categories);
            this.Controls.Add(this.label1);
            this.Name = "form_categoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.Load += new System.EventHandler(this.form_categoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_categories;
        private System.Windows.Forms.Label label_categoryName;
        private System.Windows.Forms.TextBox textBox_categoryName;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Button button_addCategory;
        private System.Windows.Forms.Button button_deleteCategory;
    }
}
