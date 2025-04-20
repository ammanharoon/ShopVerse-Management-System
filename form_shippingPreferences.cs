using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_shippingPreferences : Form
    {
        private int _orderId;

        public form_shippingPreferences(int orderId)
        {
            InitializeComponent();
            _orderId = orderId; // Pass the order ID for which shipping preferences are being set
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adjust delivery date based on shipping type
            switch (comboBox_type.SelectedItem?.ToString())
            {
                case "Standard":
                    dateTimePicker_estimate.Value = DateTime.Now.AddDays(4);
                    break;

                case "Expedited":
                    dateTimePicker_estimate.Value = DateTime.Now.AddDays(2);
                    break;

                case "Overnight":
                    dateTimePicker_estimate.Value = DateTime.Now.AddDays(1);
                    break;

                default:
                    dateTimePicker_estimate.Value = DateTime.Now; // Default to today
                    break;
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
                // Retrieve shipping preferences from the form
                string provider = comboBox_provider.SelectedItem?.ToString();
                string type = comboBox_type.SelectedItem?.ToString();
                DateTime estimateDeliveryDate;

                if (string.IsNullOrEmpty(provider) || string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Please select both a shipping provider and type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate EstimateDeliveryDate based on the shipping type
                switch (type)
                {
                    case "Standard":
                        estimateDeliveryDate = DateTime.Now.AddDays(4);
                        break;
                    case "Expedited":
                        estimateDeliveryDate = DateTime.Now.AddDays(2);
                        break;
                    case "Overnight":
                        estimateDeliveryDate = DateTime.Now.AddDays(1);
                        break;
                    default:
                        estimateDeliveryDate = DateTime.Now; // Default to today if type is unknown
                        break;
                }

                string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
                string insertQuery = @"
        INSERT INTO Shipping (OrderID, Provider, Type, EstimateDeliveryDate, Status)
        VALUES (@OrderID, @Provider, @Type, @EstimateDeliveryDate, 'Pending')";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@OrderID", _orderId);
                            cmd.Parameters.AddWithValue("@Provider", provider);
                            cmd.Parameters.AddWithValue("@Type", type);
                            cmd.Parameters.AddWithValue("@EstimateDeliveryDate", estimateDeliveryDate);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Shipping preferences saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving shipping preferences: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

