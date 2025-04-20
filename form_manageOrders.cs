using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_manageOrders : Form
    {
        public form_manageOrders()
        {
            InitializeComponent();
            LoadOrders(); 
        }

        private void LoadOrders(string searchKeyword = null)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"
                SELECT 
                    O.OrderID, 
                    O.OrderDate, 
                    O.TotalAmount, 
                    C.Name AS CustomerName, 
                    P.Name AS ProductName, 
                    OI.Quantity
                FROM [Order] O
                INNER JOIN Customer C ON O.CustomerID = C.CustomerID
                INNER JOIN OrderItems OI ON O.OrderID = OI.OrderID
                INNER JOIN Product P ON OI.ProductID = P.ProductID
                WHERE 1=1";

            // Add filtering logic
            if (!string.IsNullOrWhiteSpace(searchKeyword))
            {
                query += " AND (O.OrderID = @SearchKeyword OR C.Name LIKE @SearchKeyword OR P.Name LIKE @SearchKeyword)";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchKeyword))
                        {
                            cmd.Parameters.AddWithValue("@SearchKeyword", $"%{searchKeyword}%");
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable ordersTable = new DataTable();
                            adapter.Fill(ordersTable);
                            dataGridView_orders.DataSource = ordersTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            LoadOrders(textBox_search.Text.Trim());
        }

        private void button_clearFilters_Click(object sender, EventArgs e)
        {
            textBox_search.Clear();
            LoadOrders(); // Reload all orders without filters
        }
    }
}
