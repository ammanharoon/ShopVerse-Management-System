using finalldbproject;
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
    public partial class form_custportal : Form
    {
        public form_custportal()
        {
            InitializeComponent();
        }

        private void button_buy_Click(object sender, EventArgs e)
        {
            new form_buyproducts().Show();
            this.Close();
        }

        private void trackorder_Click(object sender, EventArgs e)
        {
            form_trackorder trackOrderForm = new form_trackorder();
            trackOrderForm.Show();
            this.Hide(); 
        }


        private void button_manageprofile_Click(object sender, EventArgs e)
        {

        }

        private void orderhistory_Click(object sender, EventArgs e)
        {
            form_orderhistory orderHistoryForm = new form_orderhistory();
            orderHistoryForm.Show();
            this.Hide(); 
        }


        private void button_wishlist_Click(object sender, EventArgs e)
        {
            form_wishlist wishlistForm = new form_wishlist();
            wishlistForm.Show();
            this.Hide(); 
        }


    }
}
