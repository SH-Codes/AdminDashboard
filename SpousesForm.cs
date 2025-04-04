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
            if (!string.IsNullOrEmpty(MembershipData.MembershipNumber))
            {
                spouseMembershipNumberTextBox.Text = MembershipData.MembershipNumber;
            }

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
            string text = spouseFirstNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("First name must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseLastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = spouseLastNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Last name must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
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
            if (!string.IsNullOrWhiteSpace(spouseGenderComboBox.Text) && spouseGenderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseRaceComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(spouseRaceComboBox.Text) && spouseRaceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid race.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseEmploymentStatusComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(spouseEmploymentStatusComboBox.Text) && spouseEmploymentStatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid employment status.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseOccupationTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string employmentStatus = spouseEmploymentStatusComboBox.SelectedItem?.ToString() ?? "";

            // If employed or self-employed, occupation cannot be empty and must be at least 3 characters
            if ((employmentStatus == "Employed" || employmentStatus == "Self-Employed") &&
                string.IsNullOrWhiteSpace(spouseOccupationTextBox.Text))
            {
                MessageBox.Show("Occupation is required for employed or self-employed individuals and must be at least 3 characters.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            // If an occupation is entered, it must be at least 3 characters long
            if (!string.IsNullOrWhiteSpace(spouseOccupationTextBox.Text) && spouseOccupationTextBox.Text.Length < 3)
            {
                MessageBox.Show("Occupation cannot be less than 3 characters.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spousePhoneNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string phoneNumber = spousePhoneNumberTextBox.Text.Trim();

            // If entered, phone number must be exactly 10 digits
            if (!string.IsNullOrWhiteSpace(phoneNumber) && !Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits and contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseMobileNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string mobileNumber = spouseMobileNumberTextBox.Text.Trim();

            // If entered, mobile number must be exactly 10 digits
            if (!string.IsNullOrWhiteSpace(mobileNumber) && !Regex.IsMatch(mobileNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Mobile number must be exactly 10 digits and contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseEmailAddressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = spouseEmailAddressTextBox.Text.Trim();
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Allow empty email, but if entered, it must be valid
            if (!string.IsNullOrWhiteSpace(email) && !Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void spouseReligionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string religion = spouseReligionTextBox.Text.Trim();

            // Allow empty input, but if entered, it must be at least 3 characters long
            if (!string.IsNullOrWhiteSpace(religion) && religion.Length < 3)
            {
                MessageBox.Show("Religion must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }


        private void spouseSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Azure SQL Server connection string
                // string connectionString = "tcp:admindashboarddbserver.database.windows.net; Authentication = Active Directory Default; Database = AdminDashboard_db";
                // SenamileNdaba Computer Connection String
                string connectionString = "Data Source=SenamileNdaba;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";
                // SacredHeart Computer Connection String
                // string connectionString = "Data Source=SACREDHEART\\SQLEXPRESS;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Query to insert data and return the generated spouse_id
                    string query = @"
                INSERT INTO spouses (membership_id, first_name, last_name, gender, birth_date, race, 
                                     employment_status, occupation, phone_number, 
                                     mobile_number, email_address, spouse_religion) 
                VALUES (@membership_id, @first_name, @last_name, @gender, @birth_date, 
                        @race, @employment_status, @occupation, @phone_number, 
                        @mobile_number, @email_address, @spouse_religion);
                SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", spouseMembershipNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@first_name", spouseFirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@last_name", spouseLastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@gender", spouseGenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@birth_date", spouseBirthDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@race", spouseRaceComboBox.Text);
                        cmd.Parameters.AddWithValue("@employment_status", spouseEmploymentStatusComboBox.Text);
                        cmd.Parameters.AddWithValue("@occupation", spouseOccupationTextBox.Text);
                        cmd.Parameters.AddWithValue("@phone_number", spousePhoneNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@mobile_number", spouseMobileNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@email_address", spouseEmailAddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@spouse_religion", spouseReligionTextBox.Text);

                        // Execute query and retrieve the new spouse_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            spouseIDTextBox.Text = result.ToString(); // Set the spouse_id in the textbox
                        }
                    }
                }

                MessageBox.Show("Spouse details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
