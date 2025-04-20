using DB_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace finalldbproject
{
    public partial class viewcart : Form
    {
        public viewcart()
        {
            InitializeComponent();
        }

        private void viewcart_Load(object sender, EventArgs e)
        {
            LoadCartItems(Session.UserID); // Load cart items when the form is initialized
        }

        private void LoadCartItems(int customerId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

            string query = @"
        SELECT P.ProductID, P.Name, P.Price, C.Quantity, (P.Price * C.Quantity) AS Total
        FROM Cart C
        INNER JOIN Product P ON C.ProductID = P.ProductID
        WHERE C.CustomerID = @CustomerID";

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
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridView_cart.DataSource = dataTable;

                            // Hide the ProductID column
                            if (dataGridView_cart.Columns.Contains("ProductID"))
                            {
                                dataGridView_cart.Columns["ProductID"].Visible = false;
                            }

                            // Calculate total price
                            decimal totalPrice = 0;
                            foreach (DataRow row in dataTable.Rows)
                            {
                                totalPrice += Convert.ToDecimal(row["Total"]);
                            }

                            label_total.Text = $"Total: ${totalPrice:F2}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading cart items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_cart.SelectedRows.Count > 0)
            {
                string productName = dataGridView_cart.SelectedRows[0].Cells["Name"].Value.ToString();

                string query = @"
                    DELETE FROM Cart
                    WHERE CustomerID = @CustomerID AND ProductID = 
                        (SELECT ProductID FROM Product WHERE Name = @ProductName)";

                string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", Session.UserID);
                            cmd.Parameters.AddWithValue("@ProductName", productName);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Item removed from cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadCartItems(Session.UserID); // Refresh cart
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_checkout_Click(object sender, EventArgs e)
        {
            try
            {
                var cartItems = GetCartItems();

                if (cartItems.Count == 0)
                {
                    MessageBox.Show("Your cart is empty. Please add items to checkout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var orderDetails = CreateOrder(Session.UserID, cartItems);
                if (orderDetails != null)
                {
                    form_payment paymentForm = new form_payment(orderDetails);
                    paymentForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            // Navigate back to the product screen
            form_buyproducts productScreen = new form_buyproducts();
            productScreen.Show();
            this.Close(); // Close the current form
        }

        private void button_addToWishlist_Click(object sender, EventArgs e)
        {
            if (dataGridView_cart.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_cart.SelectedRows[0];

                if (selectedRow.Cells["ProductID"] != null && int.TryParse(selectedRow.Cells["ProductID"].Value?.ToString(), out int productId))
                {
                    string productName = selectedRow.Cells["Name"]?.Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(productName))
                    {
                        string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
                        string query = "INSERT INTO WishList (ProductID, ProductName, CustomerID, DateCreated) VALUES (@ProductID, @ProductName, @CustomerID, @DateCreated)";

                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                conn.Open();

                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@ProductID", productId);
                                    cmd.Parameters.AddWithValue("@ProductName", productName);
                                    cmd.Parameters.AddWithValue("@CustomerID", Session.UserID); // Replace with session logic
                                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Product added to Wishlist successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product Name is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Product ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private List<CartItem> GetCartItems()
        {
            var cartItems = new List<CartItem>();

            foreach (DataGridViewRow row in dataGridView_cart.Rows)
            {
                if (row.Cells["ProductID"].Value != null)
                {
                    cartItems.Add(new CartItem
                    {
                        ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                        ProductName = row.Cells["Name"].Value.ToString(),
                        Price = Convert.ToDecimal(row.Cells["Price"].Value),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                        TotalPrice = Convert.ToDecimal(row.Cells["Total"].Value)
                    });
                }
            }

            return cartItems;
        }




        private OrderDetails CreateOrder(int customerId, List<CartItem> cartItems)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            OrderDetails orderDetails = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert order
                    string insertOrderQuery = @"
                INSERT INTO [Order] (CustomerID, OrderDate, TotalAmount, OrderStatus)
                OUTPUT INSERTED.OrderID
                VALUES (@CustomerID, @OrderDate, @TotalAmount, 'Pending')";

                    int orderId;
                    using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TotalAmount", cartItems.Sum(x => x.TotalPrice));

                        orderId = (int)cmd.ExecuteScalar();
                    }

                    // Insert order items
                    string insertOrderItemQuery = @"
                INSERT INTO OrderItems (OrderID, ProductID, Quantity, TotalPrice)
                VALUES (@OrderID, @ProductID, @Quantity, @TotalPrice)";

                    foreach (var item in cartItems)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertOrderItemQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@OrderID", orderId);
                            cmd.Parameters.AddWithValue("@ProductID", item.ProductID);
                            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            cmd.Parameters.AddWithValue("@TotalPrice", item.TotalPrice);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    orderDetails = new OrderDetails
                    {
                        OrderID = orderId,
                        TotalAmount = cartItems.Sum(x => x.TotalPrice),
                        OrderDate = DateTime.Now
                    };

                    MessageBox.Show("Order created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }

            return orderDetails;
        }





        private void dataGridView_cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}

