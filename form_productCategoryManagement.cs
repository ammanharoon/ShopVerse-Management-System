using System;
using System.Windows.Forms;


namespace finalldbproject
{
    public partial class form_productCategoryManagement : Form
    {
        public form_productCategoryManagement()
        {
            InitializeComponent();
        }

        private void button_manageCategories_Click(object sender, EventArgs e)
        {
            // Navigate to the Manage Categories form
            using (form_categoryManagement manageCategoriesForm = new form_categoryManagement())
            {
                this.Hide(); // Hide the current form
                manageCategoriesForm.ShowDialog(); // Show the new form as a dialog
                this.Show(); // Show the current form again after the dialog is closed
            }
        }

        private void button_manageProducts_Click(object sender, EventArgs e)
        {
            // Navigate to the Manage Products form
            using (form_productManagement manageProductsForm = new form_productManagement())
            {
                this.Hide(); // Hide the current form
                manageProductsForm.ShowDialog(); // Show the new form as a dialog
                this.Show(); // Show the current form again after the dialog is closed
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
