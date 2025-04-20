using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Registerbut_Click(object sender, EventArgs e)
        {
            SaveSellerData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSellerData();
        }

        private void SaveSellerData()
        {
            // Retrieve values from input fields
            string name = Namete.Text.Trim();
            string storeName = StoNamete.Text.Trim();
            string email = Emailte.Text.Trim();
            string password = Passte.Text.Trim();
            string phone = Phonete.Text.Trim();
            string address = AddreTe.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(storeName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Connection string to connect to the database
                string connectionString = "Data Source=LAPTOP-NBF902DT\\SQLEXPRESS;Initial Catalog=ShopVerse;Integrated Security=True;TrustServerCertificate=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to insert seller data into the database
                    string query = "INSERT INTO Seller (Name, StoreName, Email, Password, Phone, Address, RegistrationDate) " +
                                   "VALUES (@Name, @StoreName, @Email, @Password, @Phone, @Address, @RegistrationDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@StoreName", storeName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Seller account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Namete_TextChanged(object sender, EventArgs e)
        {
        }

        private void StoNamete_TextChanged(object sender, EventArgs e)
        {
        }

        private void Emailte_TextChanged(object sender, EventArgs e)
        {
        }

        private void Passte_TextChanged(object sender, EventArgs e)
        {
        }

        private void Phonete_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddreTe_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
