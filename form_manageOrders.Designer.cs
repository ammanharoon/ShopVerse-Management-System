namespace finalldbproject
{
    partial class form_manageOrders
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.button_clearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Orders";

            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(17, 60);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(300, 22);
            this.textBox_search.TabIndex = 1;
         //   this.textBox_search.PlaceholderText = "Search by Order ID, Customer, or Product";

            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(330, 55);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 30);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);

            // 
            // button_clearFilters
            // 
            this.button_clearFilters.BackColor = System.Drawing.Color.Gray;
            this.button_clearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_clearFilters.ForeColor = System.Drawing.Color.White;
            this.button_clearFilters.Location = new System.Drawing.Point(450, 55);
            this.button_clearFilters.Name = "button_clearFilters";
            this.button_clearFilters.Size = new System.Drawing.Size(100, 30);
            this.button_clearFilters.TabIndex = 3;
            this.button_clearFilters.Text = "Clear Filters";
            this.button_clearFilters.UseVisualStyleBackColor = false;
            this.button_clearFilters.Click += new System.EventHandler(this.button_clearFilters_Click);

            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.AllowUserToAddRows = false;
            this.dataGridView_orders.AllowUserToDeleteRows = false;
            this.dataGridView_orders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Location = new System.Drawing.Point(17, 100);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.ReadOnly = true;
            this.dataGridView_orders.RowHeadersWidth = 51;
            this.dataGridView_orders.RowTemplate.Height = 24;
            this.dataGridView_orders.Size = new System.Drawing.Size(760, 350);
            this.dataGridView_orders.TabIndex = 4;

            // 
            // form_manageOrders
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dataGridView_orders);
            this.Controls.Add(this.button_clearFilters);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Name = "form_manageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_clearFilters;
        private System.Windows.Forms.DataGridView dataGridView_orders;
    }
}
