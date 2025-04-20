using DB_Project;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_userSellerManagement : Form
    {
        //public form_userSellerManagement()
        //{
        //    InitializeComponent();
        //    LoadUsers(); // Load all users initially
        //}

        private void button_search_Click(object sender, EventArgs e)
        {
            string keyword = textBox_search.Text.Trim();
            LoadUsers(keyword); // Load users based on the search keyword
        }

        private void LoadUsers(string keyword = "")
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = @"
                SELECT CustomerID, Name, Email
                FROM Customer
                WHERE (@Keyword = '' OR 
                       Name LIKE @Keyword OR 
                       Email LIKE @Keyword OR 
                       CAST(CustomerID AS NVARCHAR) LIKE @Keyword)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel_users.Controls.Clear(); // Clear existing users

                            while (reader.Read())
                            {
                                // Create a panel for each user
                                Panel userPanel = new Panel
                                {
                                    Size = new Size(580, 100),
                                    BackColor = Color.White,
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Margin = new Padding(10)
                                };

                                // Add user information
                                Label userLabel = new Label
                                {
                                    Text = $"ID: {reader["CustomerID"]}\nName: {reader["Name"]}\nEmail: {reader["Email"]}",
                                    Font = new Font("Microsoft Sans Serif", 10),
                                    Location = new Point(10, 10),
                                    AutoSize = true
                                };

                                // Add "Delete" button
                                Button deleteButton = new Button
                                {
                                    Text = "Delete",
                                    BackColor = Color.Red,
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Location = new Point(450, 30),
                                    Size = new Size(100, 30),
                                    Tag = reader["CustomerID"]
                                };
                                deleteButton.Click += (s, args) => DeleteUser((int)deleteButton.Tag);

                                // Add controls to the user panel
                                userPanel.Controls.Add(userLabel);
                                userPanel.Controls.Add(deleteButton);

                                // Add the user panel to the FlowLayoutPanel
                                flowLayoutPanel_users.Controls.Add(userPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser(int customerId)
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers(); // Refresh the list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
