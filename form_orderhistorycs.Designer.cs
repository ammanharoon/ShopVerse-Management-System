namespace finalldbproject
{
    partial class form_orderhistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            this.flowLayoutPanel_orders = new System.Windows.Forms.FlowLayoutPanel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_orders
            // 
            this.flowLayoutPanel_orders.AutoScroll = true;
            this.flowLayoutPanel_orders.Location = new System.Drawing.Point(12, 70);
            this.flowLayoutPanel_orders.Name = "flowLayoutPanel_orders";
            this.flowLayoutPanel_orders.Size = new System.Drawing.Size(776, 350);
            this.flowLayoutPanel_orders.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(197, 33);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Order History";
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
            // form_orderhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.flowLayoutPanel_orders);
            this.Name = "form_orderhistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order History";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_orders;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_back;
    }
}
