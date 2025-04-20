using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Back1_Click(object sender, EventArgs e)
        {
            Choose ch = new Choose();
            ch.Show();
            this.Hide();
        }

        private void ExitPro_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to exit?", "Confirm Exit",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            SalesReport salesReport = new SalesReport();
            salesReport.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //Revenue
        {
            Revenue revenue = new Revenue();
            revenue.Show();
            this.Hide();
        }
    }
}
