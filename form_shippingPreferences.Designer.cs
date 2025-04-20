namespace finalldbproject
{
    partial class form_shippingPreferences
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
            this.label_provider = new System.Windows.Forms.Label();
            this.comboBox_provider = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_estimate = new System.Windows.Forms.Label();
            this.dateTimePicker_estimate = new System.Windows.Forms.DateTimePicker();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(120, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(321, 36);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Shipping Preferences";
            // 
            // label_provider
            // 
            this.label_provider.AutoSize = true;
            this.label_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_provider.Location = new System.Drawing.Point(50, 80);
            this.label_provider.Name = "label_provider";
            this.label_provider.Size = new System.Drawing.Size(140, 20);
            this.label_provider.TabIndex = 1;
            this.label_provider.Text = "Shipping Provider";
            // 
            // comboBox_provider
            // 
            this.comboBox_provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_provider.FormattingEnabled = true;
            this.comboBox_provider.Items.AddRange(new object[] {
            "FedEx",
            "UPS",
            "DHL",
            "USPS"});
            this.comboBox_provider.Location = new System.Drawing.Point(200, 77);
            this.comboBox_provider.Name = "comboBox_provider";
            this.comboBox_provider.Size = new System.Drawing.Size(250, 28);
            this.comboBox_provider.TabIndex = 2;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(50, 130);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(114, 20);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Shipping Type";
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Standard",
            "Expedited",
            "Overnight"});
            this.comboBox_type.Location = new System.Drawing.Point(200, 127);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(250, 28);
            this.comboBox_type.TabIndex = 4;
            // 
            // label_estimate
            // 
            this.label_estimate.AutoSize = true;
            this.label_estimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estimate.Location = new System.Drawing.Point(50, 180);
            this.label_estimate.Name = "label_estimate";
            this.label_estimate.Size = new System.Drawing.Size(150, 20);
            this.label_estimate.TabIndex = 5;
            this.label_estimate.Text = "Estimated Delivery";
            // 
            // dateTimePicker_estimate
            // 
            this.dateTimePicker_estimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_estimate.Location = new System.Drawing.Point(200, 177);
            this.dateTimePicker_estimate.Name = "dateTimePicker_estimate";
            this.dateTimePicker_estimate.Size = new System.Drawing.Size(250, 26);
            this.dateTimePicker_estimate.TabIndex = 6;
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_confirm.ForeColor = System.Drawing.Color.White;
            this.button_confirm.Location = new System.Drawing.Point(175, 250);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 40);
            this.button_confirm.TabIndex = 7;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // form_shippingPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 320);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.dateTimePicker_estimate);
            this.Controls.Add(this.label_estimate);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.comboBox_provider);
            this.Controls.Add(this.label_provider);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_shippingPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_provider;
        private System.Windows.Forms.ComboBox comboBox_provider;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_estimate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_estimate;
        private System.Windows.Forms.Button button_confirm;
    }
}
