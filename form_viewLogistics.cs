using System.Drawing;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace finalldbproject
{
    public partial class form_viewLogistics : Form
    {
        public form_viewLogistics()
        {
            InitializeComponent();
        }

        private void form_viewLogistics_Load(object sender, EventArgs e)
        {
            LoadPendingShipments();
        }

        private void LoadPendingShipments()
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

            string query = @"
                SELECT O.OrderID, O.OrderDate, S.Status, S.TrackingID, S.Provider, S.EstimateDeliveryDate
                FROM [Order] O
                INNER JOIN Shipping S ON O.OrderID = S.OrderID
                WHERE S.Status = 'Pending'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel_logistics.Controls.Clear(); // Clear existing orders

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

                                // Add shipment status
                                Label statusLabel = new Label
                                {
                                    Text = $"Status: {reader["Status"]}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(10, 70),
                                    AutoSize = true
                                };

                                // Add tracking ID
                                Label trackingIdLabel = new Label
                                {
                                    Text = $"Tracking ID: {reader["TrackingID"]}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(10, 100),
                                    AutoSize = true
                                };

                                // Add provider
                                Label providerLabel = new Label
                                {
                                    Text = $"Provider: {reader["Provider"]}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(200, 100),
                                    AutoSize = true
                                };

                                // Add estimated delivery date
                                Label estimateDeliveryDateLabel = new Label
                                {
                                    Text = $"Estimate Delivery: {Convert.ToDateTime(reader["EstimateDeliveryDate"]).ToString("yyyy-MM-dd")}",
                                    Font = new Font("Microsoft Sans Serif", 9),
                                    Location = new Point(200, 130),
                                    AutoSize = true
                                };

                                // Add Update Status button
                                Button updateStatusButton = new Button
                                {
                                    Text = "Update Status",
                                    BackColor = Color.FromArgb(116, 86, 174),
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Location = new Point(600, 50),
                                    Size = new Size(120, 40)
                                };
                                updateStatusButton.Click += (sender, e) => UpdateShippingStatus(Convert.ToInt32(reader["OrderID"]));

                                // Add components to the order panel
                                orderPanel.Controls.Add(orderIdLabel);
                                orderPanel.Controls.Add(orderDateLabel);
                                orderPanel.Controls.Add(statusLabel);
                                orderPanel.Controls.Add(trackingIdLabel);
                                orderPanel.Controls.Add(providerLabel);
                                orderPanel.Controls.Add(estimateDeliveryDateLabel);
                                orderPanel.Controls.Add(updateStatusButton);

                                // Add the order panel to the FlowLayoutPanel
                                flowLayoutPanel_logistics.Controls.Add(orderPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading pending shipments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update the shipment status
        private void UpdateShippingStatus(int orderId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

            string query = "UPDATE Shipping SET Status = 'Shipped', DeliveryDate = @DeliveryDate WHERE OrderID = @OrderID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.Parameters.AddWithValue("@DeliveryDate", DateTime.Now);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Shipment status updated to 'Shipped'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPendingShipments(); // Refresh the list
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the shipment status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the shipment status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back to admin portal
        private void button_back_Click(object sender, EventArgs e)
        {
            form_adminportal adminPortalForm = new form_adminportal();
            adminPortalForm.Show();
            this.Close();
        }

        private void flowLayoutPanel_logistics_Paint(object sender, PaintEventArgs e)
        {

        }

        internal class show
        {
            public show()
            {
            }
        }
    }
}
