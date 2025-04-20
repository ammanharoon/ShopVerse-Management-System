using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();

            // Validate inputs (ensure they are not empty)
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email and password match a seller in the database
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT SellerID, Name, StoreName, Email, AccountStatus FROM Seller WHERE Email = @Email AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // You can hash the password in production

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read(); // Read the result
                                int sellerId = reader.GetInt32(0);
                                SellerSession.SellerID= sellerId; 
                                string storeName = reader.GetString(2);
                                string accountStatus = reader.GetString(4);

                                if (accountStatus == "Approved")
                                {
                                    // Seller is successfully logged in
                                    MessageBox.Show($"Welcome back {storeName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    new form_sellerProducts().Show();
                                    this.Hide();
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Your account is not approved yet. Please contact the admin.", "Account Pending", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Register rs = new Register();
            rs.Show();
            this.Hide();
        }
    }
}
