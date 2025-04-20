using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_adminlogin : Form
    {
        public form_adminlogin()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string adminId = text_adminId.Text.Trim();
            string password = text_password.Text.Trim();

            if (string.IsNullOrEmpty(adminId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT * FROM Admin WHERE AdminID = @AdminID AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AdminID", adminId);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new form_adminportal().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid AdminID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
