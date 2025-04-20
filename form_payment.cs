using System.Windows.Forms;
using System;
using System.Transactions;
using System.Data.SqlClient;
using DB_Project;
using System.Collections.Generic;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace finalldbproject
{
    public partial class form_payment : Form
    {
        private OrderDetails _orderDetails;

        public form_payment(OrderDetails orderDetails)
        {
            InitializeComponent();
            _orderDetails = orderDetails;
            DisplayOrderDetails();
        }

        private void DisplayOrderDetails()
        {
            label_orderID.Text = $"Order ID: {_orderDetails.OrderID}";
            label_totalAmount.Text = $"Total Amount: ${_orderDetails.TotalAmount:F2}";
            label_orderDate.Text = $"Order Date: {_orderDetails.OrderDate}";
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            // Open the Shipping Preferences Form
            form_shippingPreferences shippingForm = new form_shippingPreferences(_orderDetails.OrderID);
            shippingForm.ShowDialog(); // Wait for the form to close

            // Continue with payment only after shipping preferences are saved
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string updateOrderStatusQuery = @"
        UPDATE [Order]
        SET OrderStatus = 'Completed'
        WHERE OrderID = @OrderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(updateOrderStatusQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@OrderID", _orderDetails.OrderID);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Payment successful! Order has been marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        new form_custportal().Show();
                        this.Hide();
                    }



                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred while processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}