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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
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

        private void Back1_Click(object sender, EventArgs e)
        {
            Choose ch = new Choose();
            ch.Show();
            this.Hide();
        }
    }
}
