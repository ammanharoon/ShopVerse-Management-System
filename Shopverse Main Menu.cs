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
    public partial class form_shopversemaimenu : Form
    {
        public form_shopversemaimenu()
        {
            InitializeComponent();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
     
            new form_adminlogin().Show();
            this.Hide();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            Seller rs = new Seller(); 
            rs.Show();
            this.Hide();
        }

       

        private void button_logistics_Click(object sender, EventArgs e)
        {
            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button_customer_Click_2(object sender, EventArgs e)
        {
            new form_custlogin().Show();
            this.Hide();
        }

        private void form_shopversemaimenu_Load(object sender, EventArgs e)
        {

        }
    }
    }

