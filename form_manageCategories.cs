using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_categoryManagement : Form
    {
        public form_categoryManagement()
        {
            InitializeComponent();
            LoadCategories(); 
        }

        private void LoadCategories()
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT CategoryID, CategoryName, Description FROM Category";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView_categories.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_addCategory_Click(object sender, EventArgs e)
        {
            string categoryName = textBox_categoryName.Text.Trim();
            string description = textBox_description.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "INSERT INTO Category (CategoryName, Description) VALUES (@CategoryName, @Description)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.Parameters.AddWithValue("@Description", description);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories(); // Refresh categories
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView_categories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = Convert.ToInt32(dataGridView_categories.SelectedRows[0].Cells["CategoryID"].Value);

            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "DELETE FROM Category WHERE CategoryID = @CategoryID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories(); // Refresh categories
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_categoryManagement_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
