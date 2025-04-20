namespace finalldbproject
{
    partial class form_review
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_rating = new System.Windows.Forms.Label();
            this.comboBox_rating = new System.Windows.Forms.ComboBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(210, 31);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Write a Review";
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Location = new System.Drawing.Point(14, 60);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(49, 16);
            this.label_rating.TabIndex = 1;
            this.label_rating.Text = "Rating:";
            // 
            // comboBox_rating
            // 
            this.comboBox_rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rating.FormattingEnabled = true;
            this.comboBox_rating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_rating.Location = new System.Drawing.Point(76, 57);
            this.comboBox_rating.Name = "comboBox_rating";
            this.comboBox_rating.Size = new System.Drawing.Size(121, 24);
            this.comboBox_rating.TabIndex = 2;
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(14, 100);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(67, 16);
            this.label_comment.TabIndex = 3;
            this.label_comment.Text = "Comment:";
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(17, 120);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(350, 150);
            this.textBox_comment.TabIndex = 4;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_submit.Location = new System.Drawing.Point(130, 290);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(120, 40);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // form_review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.comboBox_rating);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.label_title);
            this.Name = "form_review";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Product";
            this.Load += new System.EventHandler(this.form_review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.ComboBox comboBox_rating;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Button button_submit;
    }
}
