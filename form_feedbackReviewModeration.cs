using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_feedbackReviewModeration : Form
    {
        public form_feedbackReviewModeration()
        {
            InitializeComponent();
        }

        private void form_feedbackReviewModeration_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews()
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT ReviewID, ProductID, CustomerID, Rating, Comment, ReviewDate FROM Review";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel_reviews.Controls.Clear();

                        while (reader.Read())
                        {
                            Panel reviewPanel = new Panel
                            {
                                Size = new Size(740, 100),
                                BackColor = Color.White,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(10)
                            };

                            Label reviewDetails = new Label
                            {
                                Text = $"ProductID: {reader["ProductID"]}, CustomerID: {reader["CustomerID"]}\n" +
                                       $"Rating: {reader["Rating"]}, Comment: {reader["Comment"]}\n" +
                                       $"Date: {Convert.ToDateTime(reader["ReviewDate"]).ToString("yyyy-MM-dd")}",
                                Font = new Font("Microsoft Sans Serif", 9),
                                Location = new Point(10, 10),
                                AutoSize = true
                            };

                            Button deleteButton = new Button
                            {
                                Text = "Mark Inappropriate",
                                BackColor = Color.Red,
                                ForeColor = Color.White,
                                FlatStyle = FlatStyle.Flat,
                                Location = new Point(600, 30),
                                Size = new Size(120, 30),
                                Tag = reader["ReviewID"] // Store the ReviewID in the button's tag
                            };

                            deleteButton.Click += (s, ev) => DeleteReview(Convert.ToInt32(deleteButton.Tag));

                            reviewPanel.Controls.Add(reviewDetails);
                            reviewPanel.Controls.Add(deleteButton);
                            flowLayoutPanel_reviews.Controls.Add(reviewPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteReview(int reviewId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "DELETE FROM Review WHERE ReviewID = @ReviewID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReviewID", reviewId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Review marked as inappropriate and removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReviews(); // Refresh the reviews
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            form_adminportal adminPortal = new form_adminportal();
            adminPortal.Show();
            this.Close();
        }
    }
}
