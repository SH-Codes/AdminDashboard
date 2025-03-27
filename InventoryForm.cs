using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashboard
{
    public partial class InventoryForm : Form
    {
        public MainForm MainForm { get; private set; }
        public InventoryForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            ViewInventoryForm viewInventoryForm = new ViewInventoryForm(MainForm);
            viewInventoryForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(viewInventoryForm);
            viewInventoryForm.Show();
        }

        private void itemNameTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (itemNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Item name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void itemQuantityTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string itemQuantity = itemQuantityTextBox.Text.Trim();

            // Check if the input contains only digits
            if (!Regex.IsMatch(itemQuantity, @"^\d+$"))
            {
                MessageBox.Show("Item quantity must contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void itemLoggedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (itemLoggedDateTimePicker.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Logged date cannot be a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                itemLoggedDateTimePicker.Value = DateTime.Now.Date;
            }
        }
    }
}
