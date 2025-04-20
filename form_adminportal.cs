using System;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class form_adminportal : Form
    {
        public form_adminportal()
        {
            InitializeComponent();
        }

        private void button_userSellerManagement_Click(object sender, EventArgs e)
        {

            using (form_userSellerManagement manageCategoriesForm = new form_userSellerManagement())
            {
                this.Hide(); // Hide the current form
                manageCategoriesForm.ShowDialog(); 
                this.Show(); 
            }

           
        }

        private void button_productCategoryManagement_Click(object sender, EventArgs e)
        {

            new form_productCategoryManagement().Show();
            this.Hide();
        }

        private void button_orderOversight_Click(object sender, EventArgs e)
        {
            // Navigate to the Manage Orders form
            using (form_manageOrders manageOrdersForm = new form_manageOrders())
            {
                this.Hide(); 
                manageOrdersForm.ShowDialog(); 
                this.Show(); 
            }
        }


        private void button_reportsAnalytics_Click(object sender, EventArgs e)
        {
       //     new form_reportsAnalytics().Show();
        }
        private void button_feedbackReviewModeration_Click(object sender, EventArgs e)
        {
            using (form_feedbackReviewModeration feedbackReviewForm = new form_feedbackReviewModeration())
            {
                this.Hide(); 
                feedbackReviewForm.ShowDialog(); 
                this.Show();
            }
        }


        private void button_viewLogistics_Click(object sender, EventArgs e)
        {
            new form_viewLogistics().Show();
            this.Hide();
        }

        private void button_platformSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Platform Settings functionality is not implemented yet.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new form_adminlogin().Show();
            this.Close();
        }
    }
}
