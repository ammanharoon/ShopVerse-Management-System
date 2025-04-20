using DB_Project;
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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void signup_Load_1(object sender, EventArgs e)
        {

        }


        private void button_signup_Click(object sender, EventArgs e)
        {
           


        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void button_signup_Click_1(object sender, EventArgs e)
        {

            // Retrieve values from input fields
            string name = text_name.Text.Trim();
            string address = text_address.Text.Trim();
            string email = text_email.Text.Trim();
            string password = text_password.Text.Trim();
            string confirmPassword = text_confirmPassword.Text.Trim();
            string phoneNumber = text_phoneNumber.Text.Trim();
            string paymentPreference = text_paymentPreference.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            try
            {
                string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Customer (Name, Address, Email, Password, PhoneNumber, PaymentPreference, RegistrationDate, AdminID) " +
                                   "VALUES (@Name, @Address, @Email, @Password, @PhoneNumber, @PaymentPreference, @RegistrationDate, NULL)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@PaymentPreference", paymentPreference);
                        cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label_backToLogin_Click(object sender, EventArgs e)
        {
            new form_custlogin().Show();
            this.Close();
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
