using DB_Project;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_wishlist : Form
    {
        public form_wishlist()
        {
            InitializeComponent();
            LoadWishlistItems(Session.UserID); // Load wishlist items when the form is initialized
        }

        private void LoadWishlistItems(int customerId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"
                SELECT W.ProductID, W.ProductName, P.Price
                FROM WishList W
                INNER JOIN Product P ON W.ProductID = P.ProductID
                WHERE W.CustomerID = @CustomerID";

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
                            flowLayoutPanel_wishlist.Controls.Clear(); // Clear existing items

                            while (reader.Read())
                            {
                                int productId = Convert.ToInt32(reader["ProductID"]);
                                string productName = reader["ProductName"].ToString();
                                decimal price = Convert.ToDecimal(reader["Price"]);

                                // Create a panel for each product
                                Panel productPanel = new Panel
                                {
                                    Size = new Size(220, 120),
                                    BackColor = Color.White,
                                    Margin = new Padding(10)
                                };

                                // Add product name
                                Label nameLabel = new Label
                                {
                                    Text = productName,
                                    Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                                    Location = new Point(10, 10),
                                    AutoSize = true
                                };

                                // Add product price
                                Label priceLabel = new Label
                                {
                                    Text = $"Price: ${price:F2}",
                                    Font = new Font("Microsoft Sans Serif", 10),
                                    Location = new Point(10, 40),
                                    AutoSize = true
                                };

                                // Add "Remove" button
                                Button removeButton = new Button
                                {
                                    Text = "Remove",
                                    BackColor = Color.FromArgb(220, 20, 60),
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Location = new Point(10, 70),
                                    Size = new Size(100, 30),
                                    Tag = productId // Attach ProductID to the button
                                };
                                removeButton.Click += RemoveButton_Click;

                                // Add components to the product panel
                                productPanel.Controls.Add(nameLabel);
                                productPanel.Controls.Add(priceLabel);
                                productPanel.Controls.Add(removeButton);

                                // Add the product panel to the FlowLayoutPanel
                                flowLayoutPanel_wishlist.Controls.Add(productPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading wishlist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Button removeButton = (Button)sender;
            int productId = (int)removeButton.Tag;

            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "DELETE FROM WishList WHERE CustomerID = @CustomerID AND ProductID = @ProductID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", Session.UserID);
                        cmd.Parameters.AddWithValue("@ProductID", productId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product removed from Wishlist.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the wishlist
                LoadWishlistItems(Session.UserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
