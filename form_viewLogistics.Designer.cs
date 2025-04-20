namespace finalldbproject
{
    partial class form_viewLogistics
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
            this.flowLayoutPanel_logistics = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_logistics
            // 
            this.flowLayoutPanel_logistics.AutoScroll = true;
            this.flowLayoutPanel_logistics.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_logistics.Location = new System.Drawing.Point(12, 61);
            this.flowLayoutPanel_logistics.Name = "flowLayoutPanel_logistics";
            this.flowLayoutPanel_logistics.Size = new System.Drawing.Size(760, 350);
            this.flowLayoutPanel_logistics.TabIndex = 0;
            this.flowLayoutPanel_logistics.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_logistics_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pending Shipments List";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(12, 420);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(150, 40);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Back to Admin Portal";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // form_viewLogistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel_logistics);
            this.Name = "form_viewLogistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Pending Shipments";
            this.Load += new System.EventHandler(this.form_viewLogistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_logistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
    }
}
