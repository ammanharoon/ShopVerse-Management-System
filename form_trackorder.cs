using DB_Project;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_trackorder : Form
    {
        public form_trackorder()
        {
            InitializeComponent();
            LoadOrders(Session.UserID); // Load orders when the form is initialized
        }

        private void LoadOrders(int customerId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"
                SELECT O.OrderID, O.OrderDate, O.TotalAmount, S.Status AS ShippingStatus, S.EstimateDeliveryDate
                FROM [Order] O
                INNER JOIN Shipping S ON O.OrderID = S.OrderID
                WHERE O.CustomerID = @CustomerID AND O.OrderStatus = 'Completed' AND S.Status = 'Pending'";

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

                            dataGridView_orders.DataSource = dataTable;

                            // Format columns (optional)
                            if (dataTable.Columns.Contains("EstimateDeliveryDate"))
                            {
                                foreach (DataGridViewRow row in dataGridView_orders.Rows)
                                {
                                    DateTime estimateDate = Convert.ToDateTime(row.Cells["EstimateDeliveryDate"].Value);
                                    row.Cells["EstimateDeliveryDate"].Value = estimateDate.ToString("yyyy-MM-dd");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
