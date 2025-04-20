using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_productManagement : Form
    {
        public form_productManagement()
        {
            InitializeComponent();
            LoadProducts(); // Load products when the form loads
        }

        private void LoadProducts()
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT ProductID, Name, Description, Price, Rating FROM Product";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView_products.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_products.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(dataGridView_products.SelectedRows[0].Cells["ProductID"].Value);

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
                    }

                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts(); // Refresh products
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
