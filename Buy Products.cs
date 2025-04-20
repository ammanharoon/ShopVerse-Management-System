using finalldbproject;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class form_buyproducts : Form
    {
        public form_buyproducts()
        {
            InitializeComponent();
            LoadProducts(); // Load products when the form is initialized
        }

        private void LoadProducts()
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

            // Base query
            string query = "SELECT ProductID, Name, Description, Price, Rating, Brand FROM Product WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(textBox_search.Text))
            {
                string input = textBox_search.Text.Trim();
                int productId;

                // Check if input is numeric (ProductID)
                if (int.TryParse(input, out productId))
                {
                    query += " AND ProductID = @ProductID";
                }
                else
                {
                    // Check for brand or keyword
                    query += " AND (Brand = @Brand OR Name LIKE @Keyword OR Description LIKE @Keyword)";
                }
            }

            // Category-based search
            if (comboBox_category.SelectedIndex > 0) // Assuming first option is "All Categories"
            {
                query += " AND CategoryID = @CategoryID";
            }

            // Price range filtering
            if (comboBox_price.SelectedIndex > 0) // Assuming first option is "All Prices"
            {
                switch (comboBox_price.SelectedItem.ToString())
                {
                    case "Under $50":
                        query += " AND Price < 50";
                        break;
                    case "$50-$100":
                        query += " AND Price BETWEEN 50 AND 100";
                        break;
                    case "$100-$200":
                        query += " AND Price BETWEEN 100 AND 200";
                        break;
                    case "Above $200":
                        query += " AND Price > 200";
                        break;
                }
            }

            // Rating-based filtering
            if (comboBox_rating.SelectedIndex > 0) // Assuming first option is "All Ratings"
            {
                switch (comboBox_rating.SelectedItem.ToString())
                {
                    case "4 Stars & Up":
                        query += " AND Rating >= 4";
                        break;
                    case "3 Stars & Up":
                        query += " AND Rating >= 3";
                        break;
                    case "2 Stars & Up":
                        query += " AND Rating >= 2";
                        break;
                    case "1 Star & Up":
                        query += " AND Rating >= 1";
                        break;
                }
            }

            // Brand filtering
            if (comboBox_brand.SelectedIndex > 0) // Assuming first option is "All Brands"
            {
                query += " AND Brand = @Brand";
            }

            // Free shipping filter
            if (checkBox_shipping.Checked)
            {
                query += " AND FreeShipping = 1";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       

                        if (!string.IsNullOrWhiteSpace(textBox_search.Text))
                        {
                            string input = textBox_search.Text.Trim();
                            int productId;

                            // Check if the input is a number (ProductID)
                            if (int.TryParse(input, out productId))
                            {
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                query += " AND ProductID = @ProductID";
                            }
                            else
                            {
                                // Assume it's a brand if it's a single word and matches a known brand
                                query += " AND (Brand = @Brand OR Name LIKE @Keyword OR Description LIKE @Keyword)";
                                cmd.Parameters.AddWithValue("@Brand", input); // Treat input as brand
                                cmd.Parameters.AddWithValue("@Keyword", "%" + input + "%"); // Treat input as keyword
                            }
                        }


                        // Add parameters for category
                        if (comboBox_category.SelectedIndex > 0)
                        {
                            cmd.Parameters.AddWithValue("@CategoryID", comboBox_category.SelectedIndex); // Adjust based on category mapping
                        }

                        // Add parameters for brand
                        if (comboBox_brand.SelectedIndex > 0)
                        {
                            cmd.Parameters.AddWithValue("@Brand", comboBox_brand.SelectedItem.ToString());
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel_products.Controls.Clear(); // Clear existing products

                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No products match your search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            while (reader.Read())
                            {
                                string productName = reader["Name"].ToString();
                                string productDescription = reader["Description"].ToString();
                                decimal productPrice = (decimal)reader["Price"];
                                decimal rating = (decimal)reader["Rating"];
                                string brand = reader["Brand"].ToString();
                                int productId = (int)reader["ProductID"]; // Retrieve ProductID

                                // Create a panel for each product
                                Panel productPanel = new Panel
                                {
                                    Size = new Size(220, 170),
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

                                // Add product rating
                                Label ratingLabel = new Label
                                {
                                    Text = $"Rating: {rating}★",
                                    Font = new Font("Microsoft Sans Serif", 8),
                                    Location = new Point(10, 70),
                                    AutoSize = true
                                };

                                // Add brand
                                Label brandLabel = new Label
                                {
                                    Text = $"Brand: {brand}",
                                    Font = new Font("Microsoft Sans Serif", 8),
                                    Location = new Point(10, 90),
                                    AutoSize = true
                                };

                                // Add "Add to Cart" button
                                Button addToCartButton = new Button
                                {
                                    Text = "Add to Cart",
                                    BackColor = Color.FromArgb(255,0,0),
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Location = new Point(10, 110),
                                    Size = new Size(100, 30)
                                };


                                addToCartButton.Click += (s, e) => AddToCart(productId, Session.UserID);

                                // Add components to the product panel
                                productPanel.Controls.Add(nameLabel);
                                productPanel.Controls.Add(descriptionLabel);
                                productPanel.Controls.Add(priceLabel);
                                productPanel.Controls.Add(ratingLabel);
                                productPanel.Controls.Add(brandLabel);
                                productPanel.Controls.Add(addToCartButton);

                                // Add the product panel to the FlowLayoutPanel
                                flowLayoutPanel_products.Controls.Add(productPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
                

            new viewcart().Show();
            this.Hide();

        }

        private void flowLayoutPanel_products_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AddToCart(int productId, int customerId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the product is already in the cart
                    string queryCheck = "SELECT COUNT(*) FROM Cart WHERE CustomerID = @CustomerID AND ProductID = @ProductID";
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@CustomerID", customerId);
                        cmdCheck.Parameters.AddWithValue("@ProductID", productId);

                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            // Update quantity if already in the cart
                            string queryUpdate = "UPDATE Cart SET Quantity = Quantity + 1 WHERE CustomerID = @CustomerID AND ProductID = @ProductID";
                            using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@CustomerID", customerId);
                                cmdUpdate.Parameters.AddWithValue("@ProductID", productId);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert new item into the cart
                            string queryInsert = "INSERT INTO Cart (CustomerID, ProductID, Quantity) VALUES (@CustomerID, @ProductID, @Quantity)";
                            using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@CustomerID", customerId);
                                cmdInsert.Parameters.AddWithValue("@ProductID", productId);
                                cmdInsert.Parameters.AddWithValue("@Quantity", 1); // Default quantity is 1
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Item added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new form_custportal().Show();
            this.Hide();

        }
    }
}
