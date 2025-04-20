using finalldbproject;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class form_custlogin : Form
    {
        public form_custlogin()
        {
            InitializeComponent();
        }

        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            return;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
         
    

            string email = text_email.Text.Trim();
            string password = text_password.Text.Trim();


            // Validate input fields
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            MessageBox.Show($"Email: {email}\nPassword: {password}", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            bool isAuthenticated = AuthenticateUser(email, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateShippingStatus();
                new form_custportal().Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool AuthenticateUser(string email, string password)
        {
            // Connection string for your database
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

           
            string query = "SELECT CustomerID FROM Customer WHERE Email = @Email AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;

                        
                        object result = cmd.ExecuteScalar();

                      
                        if (result != null && result != DBNull.Value)
                        {
                            int customerID = Convert.ToInt32(result); 
                            Session.UserID = Convert.ToInt32(result);
                            
                            return true; // Authentication successful
                        }
                        else
                        {
                            return false; // Authentication failed
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                Console.WriteLine($"Error: {ex.Message}");

                // Show user-friendly error message
                MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        private void label_signup_Click(object sender, EventArgs e)
        {
           
            new signup().Show(); 
            this.Hide(); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateShippingStatus()
        {
            string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";
            string updateQuery = @"
        UPDATE Shipping
        SET Status = 'Delivered', DeliveryDate = GETDATE()
        WHERE Status = 'Pending' AND EstimateDeliveryDate <= CAST(GETDATE() AS DATE);";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsUpdated} rows updated to 'Delivered' status.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating shipping statuses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
