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
    public partial class SpousesForm : Form

    {
        public MainForm MainForm { get; private set; }

        public SpousesForm(MainForm mainFormRef)
        {
            InitializeComponent();
            this.MainForm = mainFormRef;

        }

        private void SpousesForm_Load(object sender, EventArgs e)
        {

        }

        private void spousePreviousButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            AddMemberForm addMemberForm = new AddMemberForm(MainForm);
            addMemberForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(addMemberForm);
            addMemberForm.Show();
        }

        private void memberNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            DependentsForm dependentsForm = new DependentsForm(MainForm);
            dependentsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(dependentsForm);
            dependentsForm.Show();
        }

        private void spouseFirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spouseFirstNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("First name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void spouseMaidenNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spouseMaidenNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Maiden name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void spouseLastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spouseLastNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Last name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void spouseBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (spouseBirthDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Birth date cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spouseBirthDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void spouseGenderComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spouseGenderComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(spouseGenderComboBox.Text))
            {
                MessageBox.Show("Please select a gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;

            }
        }

        private void spouseRaceComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spouseRaceComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(spouseRaceComboBox.Text))
            {
                MessageBox.Show("Please select a race.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseEmploymentStatusComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spouseEmploymentStatusComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(spouseEmploymentStatusComboBox.Text))
            {
                MessageBox.Show("Please select employment status.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Only cancel if it's completely empty, avoiding a validation loop
                if (string.IsNullOrEmpty(spouseEmploymentStatusComboBox.Text))
                {
                    e.Cancel = true;
                }
            }
        }

        private void spouseOccupationtextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string spouseEmploymentStatus = spouseEmploymentStatusComboBox.SelectedIndex.ToString(); // Get selected employment status

            // If employed or self-employed, occupation cannot be null or less than 3 characters
            if ((spouseEmploymentStatus == "Employed" || spouseEmploymentStatus == "Self-Employed") &&
                string.IsNullOrWhiteSpace(spouseOccupationTextBox.Text))
            {
                MessageBox.Show("Occupation is required for employed or self-employed members and must be at least 3 characters.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
                return;
            }

            // If occupation is entered, ensure it has at least 3 characters
            if (!string.IsNullOrWhiteSpace(spouseOccupationTextBox.Text) && spouseOccupationTextBox.Text.Length < 3)
            {
                MessageBox.Show("Occupation cannot be less than 3 characters.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }

        }

        private void spousePhoneNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string spousePhoneNumber = spousePhoneNumberTextBox.Text.Trim();

            // Check if the input is exactly 10 digits and contains only numbers
            if (!string.IsNullOrWhiteSpace(spousePhoneNumber) && !Regex.IsMatch(spousePhoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits and contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void spouseMobileNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string spouseMobileNumber = spouseMobileNumberTextBox.Text.Trim();

            // Check if the input is exactly 10 digits and contains only numbers
            if (!string.IsNullOrWhiteSpace(spouseMobileNumber) && !Regex.IsMatch(spouseMobileNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits and contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void spouseEmailAddressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = spouseEmailAddressTextBox.Text.Trim();

            // Regular expression for validating an email address
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Allow empty input, but if an email is provided, it must be valid
            if (!string.IsNullOrWhiteSpace(email) && !Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field until a valid email is entered
            }
        }

        private void spouseReligionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spouseReligionTextBox.Text.Length < 3)
            {
                MessageBox.Show("First name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void spouseSaveButton_Click(object sender, EventArgs e)
        {
            // Validate all controls
            if (!ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop the save process if validation fails
            }

            // Proceed with saving the data (replace with actual saving logic)
            MessageBox.Show("Spouse details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
