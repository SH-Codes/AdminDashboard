using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Required for regex validation
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AdminDashboard
{
    public partial class AddMemberForm : Form

    {
        public MainForm MainForm { get; private set; }

        public AddMemberForm(MainForm MainFormRef)
        {
            InitializeComponent();
            this.MainForm = MainFormRef;

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberRaceComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(memberRaceComboBox.Text))
            {
                MessageBox.Show("Please select a race.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents leaving the ComboBox until a valid selection is made
            }
        }


        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void memberMobileNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string mobileNumber = memberMobileNumberTextBox.Text.Trim();

            // Check if the input is exactly 10 digits and contains only numbers
            if (!Regex.IsMatch(mobileNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Mobile number must be exactly 10 digits and contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void memberOccupationTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberOccupationTextBox.Text.Length < 3)
            {
                MessageBox.Show("Occupation cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void memberNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear(); // Use the public property
            SpousesForm spousesForm = new SpousesForm(MainForm);
            spousesForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(spousesForm);
            spousesForm.Show();
        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear(); // Use the public property
            PaymentsForm paymentsForm = new PaymentsForm(MainForm);
            paymentsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(paymentsForm);
            paymentsForm.Show();
        }

        private void registrationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (registrationDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Registration date cannot be greater than today.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                registrationDateTimePicker.Value = DateTime.Now;
            }
        }

        private void memberFirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberFirstNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("First name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void memberLastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberLastNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Last name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }


        private void birthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (birthDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Birth date cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                birthDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void memberMaritalStatusComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberMaritalStatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Marital status cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            e.Cancel = true;
        }

        private void memberEmploymentComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberEmploymentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Employment status cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void memberGenderComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberGenderComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(memberGenderComboBox.Text))
            {
                MessageBox.Show("Please select a gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void memberRaceComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberRaceComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(memberRaceComboBox.Text))
            {
                MessageBox.Show("Please select a race.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

    }
}