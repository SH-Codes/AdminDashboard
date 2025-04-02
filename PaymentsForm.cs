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
using static AdminDashboard.AddMemberForm;

namespace AdminDashboard
{
    public partial class PaymentsForm : Form
    {
        public MainForm MainForm { get; private set; }
        public PaymentsForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MembershipData.MembershipNumber))
            {
                paymentsMembershipNumberTextBox.Text = MembershipData.MembershipNumber;
            }
        }

        private void accountTypeComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(accountTypeComboBox.Text) && accountTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid account type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void paymentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (paymentDateTimePicker.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date jo cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                paymentDateTimePicker.Value = DateTime.Now;
            }
        }

        private void amountTotalTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string amountTotal = amountTotalTextBox.Text.Trim();

            // Check if the input contains only numbers
            if (!Regex.IsMatch(amountTotal, @"^\d*$"))
            {
                MessageBox.Show("Amount total must contain only numbers.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void amountTenderedTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string amountTendered = amountTotalTextBox.Text.Trim();

            // Check if the input contains only numbers
            if (!Regex.IsMatch(amountTendered, @"^\d*$"))
            {
                MessageBox.Show("Amount tendered must contain only numbers.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void changeTextBox_TextChanged(object sender, EventArgs e)
        {
            string amountTotal = amountTotalTextBox.Text.Trim();
            string amountTendered = amountTotalTextBox.Text.Trim();
            string change = changeTextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(amountTotal) && !string.IsNullOrWhiteSpace(amountTendered))
            {
                int total = int.Parse(amountTotal);
                int tendered = int.Parse(amountTendered);
                int changeAmount = tendered - total;
                changeTextBox.Text = changeAmount.ToString();
            }

        }

        private void paymentMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentMethodComboBox.SelectedItem == null)
            {
                MessageBox.Show("Payment method cannot be null. Please select a valid payment method.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void paymentsSaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
