namespace finalldbproject
{
    partial class form_trackorder
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
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.label_title = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.AllowUserToAddRows = false;
            this.dataGridView_orders.AllowUserToDeleteRows = false;
            this.dataGridView_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_orders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Location = new System.Drawing.Point(12, 70);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.ReadOnly = true;
            this.dataGridView_orders.RowHeadersWidth = 51;
            this.dataGridView_orders.RowTemplate.Height = 24;
            this.dataGridView_orders.Size = new System.Drawing.Size(776, 350);
            this.dataGridView_orders.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(182, 33);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Track Orders";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_back.Location = new System.Drawing.Point(648, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(140, 40);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // form_trackorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.dataGridView_orders);
            this.Name = "form_trackorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_back;
    }
}
