namespace finalldbproject
{
    partial class Reports
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
            this.Back1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitPro
            // 
            this.ExitPro.Location = new System.Drawing.Point(697, 417);
            this.ExitPro.Name = "ExitPro";
            this.ExitPro.Size = new System.Drawing.Size(91, 23);
            this.ExitPro.TabIndex = 9;
            this.ExitPro.Text = "Exit";
            this.ExitPro.UseVisualStyleBackColor = true;
            this.ExitPro.Click += new System.EventHandler(this.ExitPro_Click);
            // 
            // Back1
            // 
            this.Back1.Location = new System.Drawing.Point(13, 417);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(124, 23);
            this.Back1.TabIndex = 8;
            this.Back1.Text = "Go Back";
            this.Back1.UseVisualStyleBackColor = true;
            this.Back1.Click += new System.EventHandler(this.Back1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(248, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reports and Analytics";
            // 
            // Sales
            // 
            this.Sales.Location = new System.Drawing.Point(64, 111);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(254, 42);
            this.Sales.TabIndex = 10;
            this.Sales.Text = "Sales Performance Report";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sales Performance Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.ExitPro);
            this.Controls.Add(this.Back1);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitPro;
        private System.Windows.Forms.Button Back1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button button1;
    }
}