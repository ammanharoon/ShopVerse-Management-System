using System;
using System.Drawing;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_userSellerManagement : Form
    {
        public form_userSellerManagement()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.Form_userSellerManagement_Load);

            this.label_title = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.flowLayoutPanel_users = new System.Windows.Forms.FlowLayoutPanel();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("MS UI Gothic", 19.8F);
            this.label_title.Location = new System.Drawing.Point(280, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(305, 33);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "User and Seller Management";
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.textBox_search.Location = new System.Drawing.Point(80, 80);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(480, 27);
            this.textBox_search.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(580, 80);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 30);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // flowLayoutPanel_users
            // 
            this.flowLayoutPanel_users.AutoScroll = true;
            this.flowLayoutPanel_users.Location = new System.Drawing.Point(80, 130);
            this.flowLayoutPanel_users.Name = "flowLayoutPanel_users";
            this.flowLayoutPanel_users.Size = new System.Drawing.Size(600, 300);
            this.flowLayoutPanel_users.TabIndex = 3;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Gray;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(80, 450);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 30);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // form_userSellerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.flowLayoutPanel_users);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_title);
            this.Name = "form_userSellerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User and Seller Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label label_title;
        private TextBox textBox_search;
        private Button button_search;
        private FlowLayoutPanel flowLayoutPanel_users;
        private Button button_back;


        private void Form_userSellerManagement_Load(object sender, EventArgs e)
        {
            LoadUsers(); // Call LoadUsers when the form loads
        }

    }




}
