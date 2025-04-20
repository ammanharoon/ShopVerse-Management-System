namespace finalldbproject
{
    partial class Choose
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
            this.ExitPro = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.Inten = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitPro
            // 
            this.ExitPro.Location = new System.Drawing.Point(697, 417);
            this.ExitPro.Name = "ExitPro";
            this.ExitPro.Size = new System.Drawing.Size(91, 23);
            this.ExitPro.TabIndex = 10;
            this.ExitPro.Text = "Exit";
            this.ExitPro.UseVisualStyleBackColor = true;
            this.ExitPro.Click += new System.EventHandler(this.ExitPro_Click);
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.Silver;
            this.Orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Orders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Orders.Location = new System.Drawing.Point(210, 295);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(384, 47);
            this.Orders.TabIndex = 9;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = false;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Inten
            // 
            this.Inten.BackColor = System.Drawing.Color.Silver;
            this.Inten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Inten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Inten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Inten.Location = new System.Drawing.Point(208, 204);
            this.Inten.Name = "Inten";
            this.Inten.Size = new System.Drawing.Size(384, 47);
            this.Inten.TabIndex = 8;
            this.Inten.Text = "Inventory";
            this.Inten.UseVisualStyleBackColor = false;
            this.Inten.Click += new System.EventHandler(this.Inten_Click);
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.Silver;
            this.Reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Reports.Location = new System.Drawing.Point(210, 112);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(384, 47);
            this.Reports.TabIndex = 7;
            this.Reports.Text = "Reports and Analytics";
            this.Reports.UseVisualStyleBackColor = false;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ShopVerse";
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitPro);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.Inten);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.label1);
            this.Name = "Choose";
            this.Text = "Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitPro;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Inten;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Label label1;
    }
}