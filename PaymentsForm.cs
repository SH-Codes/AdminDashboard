using Microsoft.Data.SqlClient;
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
            try
            {
                // Azure SQL Server connection string
                //string connectionString = "Data Source=tcp:admindashboarddbserver.database.windows.net; Authentication = Active Directory Default; Database = AdminDashboard_db; Trust Sever Certificate=True";
                // SenamileNdaba Computer Connection String
                  string connectionString = "Data Source=SenamileNdaba;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";
                // SacredHeart Computer Connection String
                // string connectionString = "Data Source=SACREDHEART\\SQLEXPRESS;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Query to insert data and return the generated dependent_id
                    string query = @"
                INSERT INTO dependents (membership_id, payment_date, account_type, amount_total, amount_tendered,  
                                     change_given, payment_method) 
                VALUES (@membership_id, @payment_date, @account_type, @amount_total, @amount_tendered,  
                                     @change_given, @payment_method);
                SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", paymentsMembershipNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@payment_date", paymentDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@account_type", accountTypeComboBox.Text);
                        cmd.Parameters.AddWithValue("@amount_total", amountTotalTextBox.Text);
                        cmd.Parameters.AddWithValue("@amount_tandered", amountTenderedTextBox.Text);
                        cmd.Parameters.AddWithValue("@change_given", changeTextBox.Text);
                        cmd.Parameters.AddWithValue("@payment_method", paymentMethodComboBox.Text);

                        // Execute query and retrieve the new spouse_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            paymentIdTextBox.Text = result.ToString(); // Set the dependent_id in the textbox
                        }
                    }
                }

                MessageBox.Show("Dependent details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
