using DB_Project;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_orderhistory : Form
    {
        public form_orderhistory()
        {
            InitializeComponent();
            LoadOrderHistory(Session.UserID); // Load order history for the logged-in user
        }

        private void LoadOrderHistory(int customerId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"
                SELECT O.OrderID, O.OrderDate, O.TotalAmount, P.ProductID, P.Name AS ProductName, P.Price, OI.Quantity
                FROM [Order] O
                INNER JOIN OrderItems OI ON O.OrderID = OI.OrderID
                INNER JOIN Product P ON OI.ProductID = P.ProductID
                WHERE O.CustomerID = @CustomerID AND O.OrderStatus = 'Completed'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel_orders.Controls.Clear(); // Clear existing orders

                            while (reader.Read())
                            {
                                // Create a panel for each order
                                Panel orderPanel = new Panel
                                {
                                    Size = new Size(740, 150),
                                    BackColor = Color.White,
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Margin = new Padding(10)
                                };

                                // Add order ID
                                Label orderIdLabel = new Label
                                {
                                    Text = $"Order ID: {reader["OrderID"]}",
                                    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                                    Location = new Point(10, 10),
                                    AutoSize = true
                                };

                                // Add order date
                                Label orderDateLabel = new Label
                                {
                                    Text = $"Order Date: {Convert.ToDateTime(reader["OrderDate"]).ToString("yyyy-MM-dd")}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(10, 40),
                                    AutoSize = true
                                };

                                // Add product name
                                Label productNameLabel = new Label
                                {
                                    Text = $"Product: {reader["ProductName"]}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(10, 70),
                                    AutoSize = true
                                };

                                // Add quantity
                                Label quantityLabel = new Label
                                {
                                    Text = $"Quantity: {reader["Quantity"]}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(10, 100),
                                    AutoSize = true
                                };

                                // Add total price
                                Label totalPriceLabel = new Label
                                {
                                    Text = $"Total Price: ${Convert.ToDecimal(reader["Price"]) * Convert.ToInt32(reader["Quantity"]):F2}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(200, 100),
                                    AutoSize = true
                                };

                                // Add "Review Product" button
                                Button reviewButton = new Button
                                {
                                    Text = "Review",
                                    BackColor = Color.FromArgb(116, 86, 174),
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Location = new Point(600, 50),
                                    Size = new Size(100, 40)
                                };

                                // Attach click event to the review button
                                int productId = Convert.ToInt32(reader["ProductID"]);
                                string productName = reader["ProductName"].ToString();
                                reviewButton.Click += (s, e) => ReviewProduct(productId, productName);

                                // Add controls to the order panel
                                orderPanel.Controls.Add(orderIdLabel);
                                orderPanel.Controls.Add(orderDateLabel);
                                orderPanel.Controls.Add(productNameLabel);
                                orderPanel.Controls.Add(quantityLabel);
                                orderPanel.Controls.Add(totalPriceLabel);
                                orderPanel.Controls.Add(reviewButton);

                                // Add the order panel to the FlowLayoutPanel
                                flowLayoutPanel_orders.Controls.Add(orderPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReviewProduct(int productId, string productName)
        {
            try
            {
                // Open the review form
                form_review reviewForm = new form_review(Session.UserID, productId);
                reviewForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the review form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            form_custportal portalForm = new form_custportal();
            portalForm.Show();
            this.Close();
        }
    }
}
