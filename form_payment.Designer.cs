using System;
using System.Windows.Forms;

namespace finalldbproject
{
    partial class form_payment
    {
        private System.ComponentModel.IContainer components = null;
        private Label label_orderID;
        private Label label_totalAmount;
        private Label label_orderDate;
        private Button button_pay;

        private void InitializeComponent()
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.label_orderID = new Label();
            this.label_totalAmount = new Label();
            this.label_orderDate = new Label();
            this.button_pay = new Button();
            this.SuspendLayout();

            // Order ID Label
            this.label_orderID.AutoSize = true;
            this.label_orderID.Location = new System.Drawing.Point(50, 30);
            this.label_orderID.Name = "label_orderID";
            this.label_orderID.Size = new System.Drawing.Size(100, 20);
            this.label_orderID.Text = "Order ID: ";

            // Total Amount Label
            this.label_totalAmount.AutoSize = true;
            this.label_totalAmount.Location = new System.Drawing.Point(50, 70);
            this.label_totalAmount.Name = "label_totalAmount";
            this.label_totalAmount.Size = new System.Drawing.Size(120, 20);
            this.label_totalAmount.Text = "Total Amount: ";

            // Order Date Label
            this.label_orderDate.AutoSize = true;
            this.label_orderDate.Location = new System.Drawing.Point(50, 110);
            this.label_orderDate.Name = "label_orderDate";
            this.label_orderDate.Size = new System.Drawing.Size(100, 20);
            this.label_orderDate.Text = "Order Date: ";

            // Pay Button
            this.button_pay.Location = new System.Drawing.Point(50, 150);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(100, 30);
            this.button_pay.Text = "Pay";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new EventHandler(this.button_pay_Click);

            // Payment Form
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label_orderID);
            this.Controls.Add(this.label_totalAmount);
            this.Controls.Add(this.label_orderDate);
            this.Controls.Add(this.button_pay);
            this.Name = "form_payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}