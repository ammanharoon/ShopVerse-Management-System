using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;

namespace finalldbproject
{
    public partial class Inventory : Form
    {
        // A class to represent an inventory item
        private class InventoryItem
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Category} - ${Price:F2}";
            }
        }

        // A list to store the inventory items
        private List<InventoryItem> items = new List<InventoryItem>();

        public Inventory()
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

        private void button1_Click(object sender, EventArgs e) // Add
        {
            string name = textBox1.Text;
            string category = textBox2.Text;
            if (decimal.TryParse(textBox3.Text, out decimal price))
            {
                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(category))
                {
                    var newItem = new InventoryItem { Name = name, Category = category, Price = price };
                    items.Add(newItem);
                    MessageBox.Show("Item added successfully!", "Success");
                    UpdateInventoryList();
                }
                else
                {
                    MessageBox.Show("Name and Category cannot be empty.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid price entered.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Edit
        {/*
            if (listBox1.SelectedIndex >= 0)
            {
                var selectedItem = items[listBox1.SelectedIndex];
                selectedItem.Name = textBox1.Text;
                selectedItem.Category = textBox2.Text;
                if (decimal.TryParse(textBox3.Text, out decimal price))
                {
                    selectedItem.Price = price;
                    MessageBox.Show("Item updated successfully!", "Success");
                    UpdateInventoryList();
                }
                else
                {
                    MessageBox.Show("Invalid price entered.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Error");
            }*/
        }

        private void button4_Click(object sender, EventArgs e) // Delete
        {/*
            if (listBox1.SelectedIndex >= 0)
            {
                items.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Item deleted successfully!", "Success");
                UpdateInventoryList();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Error");
            }*/
        }

        private void UpdateInventoryList()
        {/*
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                listBox1.Items.Add(item.ToString());
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Name
        {
            // Handle text changed event if needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Category
        {
            // Handle text changed event if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Price
        {
            // Handle text changed event if needed
        }
    }
}
