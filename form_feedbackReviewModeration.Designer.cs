namespace finalldbproject
{
    partial class form_feedbackReviewModeration
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

        private void InitializeComponent()
        {
            this.flowLayoutPanel_reviews = new System.Windows.Forms.FlowLayoutPanel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_reviews
            // 
            this.flowLayoutPanel_reviews.AutoScroll = true;
            this.flowLayoutPanel_reviews.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_reviews.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanel_reviews.Name = "flowLayoutPanel_reviews";
            this.flowLayoutPanel_reviews.Size = new System.Drawing.Size(760, 350);
            this.flowLayoutPanel_reviews.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(300, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(220, 31);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Manage Reviews";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(670, 410);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(102, 30);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // form_feedbackReviewModeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.flowLayoutPanel_reviews);
            this.Name = "form_feedbackReviewModeration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback Review Moderation";
            this.Load += new System.EventHandler(this.form_feedbackReviewModeration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_reviews;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_back;
    }
}
