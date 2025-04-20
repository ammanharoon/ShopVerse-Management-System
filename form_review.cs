using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_review : Form
    {
        private int _customerId;
        private int _productId;

        public form_review(int customerId, int productId)
        {
            InitializeComponent();
            _customerId = customerId;
            _productId = productId;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int? rating = null;
            if (comboBox_rating.SelectedIndex >= 0)
            {
                rating = Convert.ToInt32(comboBox_rating.SelectedItem);
            }

            string comment = textBox_comment.Text.Trim();

            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"
                INSERT INTO Review (CustomerID, ProductID, Rating, Comment, ReviewDate)
                VALUES (@CustomerID, @ProductID, @Rating, @Comment, GETDATE())";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", _customerId);
                        cmd.Parameters.AddWithValue("@ProductID", _productId);
                        cmd.Parameters.AddWithValue("@Rating", (object)rating ?? DBNull.Value); // Handle null for rating
                        cmd.Parameters.AddWithValue("@Comment", string.IsNullOrWhiteSpace(comment) ? DBNull.Value : (object)comment);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Review submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting the review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_review_Load(object sender, EventArgs e)
        {

        }
    }
}
