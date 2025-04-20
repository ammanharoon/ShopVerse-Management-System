using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_sellerProducts : Form
    {
        public form_sellerProducts()
        {
            InitializeComponent();
            LoadSellerProducts(SellerSession.SellerID); // Load products for the currently logged-in seller
        }

        private void LoadSellerProducts(int sellerId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT ProductID, Name, Description, Price FROM Product WHERE SellerID = @SellerID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SellerID", sellerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel_products.Controls.Clear(); // Clear existing products

                            while (reader.Read())
                            {
                                int productId = (int)reader["ProductID"];
                                string productName = reader["Name"].ToString();
                                string productDescription = reader["Description"].ToString();
                                decimal productPrice = (decimal)reader["Price"];

                                // Create a panel for each product
                                Panel productPanel = new Panel
                                {
                                    Size = new Size(220, 150),
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

                                // Add product description
                                Label descriptionLabel = new Label
                                {
                                    Text = productDescription,
                                    Font = new Font("Microsoft Sans Serif", 8),
                                    Location = new Point(10, 30),
                                    AutoSize = true
                                };

                                // Add product price
                                Label priceLabel = new Label
                                {
                                    Text = $"Price: ${productPrice:F2}",
                                    Font = new Font("Microsoft Sans Serif", 10),
                                    Location = new Point(10, 50),
                                    AutoSize = true
                                };

                                // Add "Remove Product" button
                                Button removeButton = new Button
                                {
                                    Text = "Remove Product",
                                    BackColor = Color.Red,
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Location = new Point(10, 80),
                                    Size = new Size(100, 30)
                                };

                                // Add event for removing the product
                                removeButton.Click += (sender, e) => RemoveProduct(productId);

                                // Add components to the product panel
                                productPanel.Controls.Add(nameLabel);
                                productPanel.Controls.Add(descriptionLabel);
                                productPanel.Controls.Add(priceLabel);
                                productPanel.Controls.Add(removeButton);

                                // Add the product panel to the FlowLayoutPanel
                                flowLayoutPanel_products.Controls.Add(productPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading seller products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveProduct(int productId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "DELETE FROM Product WHERE ProductID = @ProductID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload products after removal
                        LoadSellerProducts(Session.UserID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void button_back_Click(object sender, EventArgs e)
        //{
        //    form_sellerportal sellerPortal = new form_sellerportal();
        //    sellerPortal.Show();
        //    this.Close();
        //}
    }
}
