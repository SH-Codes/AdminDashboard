using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // Required for GraphicsPath
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
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackColor = Color.White;

        }

        private int cornerRadius = 16; // Adjust this for roundnes

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

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


        private void memberTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberTitleComboBox.SelectedItem != null)
            {
                string selectedTitle = memberTitleComboBox.SelectedItem?.ToString() ?? string.Empty;

                switch (selectedTitle)
                {
                    case "Mr":
                        memberGenderComboBox.SelectedItem = "Male";
                        break;
                    case "Ms":
                    case "Mrs":
                        memberGenderComboBox.SelectedItem = "Female";
                        break;
                    default:
                        memberGenderComboBox.SelectedIndex = -1; // Reset to unselected
                        break;
                }

                // Force validation after changing the gender
                memberGenderComboBox_Validating(memberGenderComboBox, new System.ComponentModel.CancelEventArgs());
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

        private void memberGenderComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberGenderComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(memberGenderComboBox.Text))
            {
                MessageBox.Show("Please select a gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Only cancel if it's completely empty, avoiding a validation loop
                if (string.IsNullOrEmpty(memberGenderComboBox.Text))
                {
                    e.Cancel = true;
                }
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

        private void memberMaritalStatusComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (memberMaritalStatusComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(memberMaritalStatusComboBox.Text))
            {
                MessageBox.Show("Marital status cannot be empty.", "Invalid Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }


        private void memberEmploymentComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Ensure a valid selection is made
            if (memberEmploymentStatusComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(memberEmploymentStatusComboBox.Text))
            {
                MessageBox.Show("Employment status cannot be empty.", "Invalid Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }



        private void memberOccupationTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string employmentStatus = memberOccupationTextBox.Text.ToString(); // Get selected employment status

            // If employed or self-employed, occupation cannot be null or less than 3 characters
            if ((employmentStatus == "Employed" || employmentStatus == "Self-Employed") &&
                string.IsNullOrWhiteSpace(memberOccupationTextBox.Text))
            {
                MessageBox.Show("Occupation is required for employed or self-employed members and must be at least 3 characters.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
                return;
            }

            // If occupation is entered, ensure it has at least 3 characters
            if (!string.IsNullOrWhiteSpace(memberOccupationTextBox.Text) && memberOccupationTextBox.Text.Length < 3)
            {
                MessageBox.Show("Occupation cannot be less than 3 characters.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }



        private void memberPhoneNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string phoneNumber = memberPhoneNumberTextBox.Text.Trim();

            // Check if the input is exactly 10 digits and contains only numbers
            if (!string.IsNullOrWhiteSpace(phoneNumber) && !Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits and contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void memberMobileNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string mobileNumber = memberMobileNumberTextBox.Text.Trim();

            // Allow empty input, but if a number is provided, it must be exactly 10 digits
            if (!string.IsNullOrWhiteSpace(mobileNumber) && !Regex.IsMatch(mobileNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Mobile number must be exactly 10 digits and contain only numbers.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void memberEmailAddressTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = memberEmailAddressTextBox.Text.Trim();

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

        private void addressLine1TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string address = addressLine1TextBox.Text.Trim(); // Remove spaces before/after input

            if (string.IsNullOrWhiteSpace(address) || address.Length < 3)
            {
                MessageBox.Show("Address Line 1 must be at least 3 characters long.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field until valid input is entered
            }
        }

        private void addressLine2TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string address = addressLine2TextBox.Text.Trim(); // Remove spaces before/after input

            if (string.IsNullOrWhiteSpace(address) || address.Length < 3)
            {
                MessageBox.Show("Address Line 2 must be at least 3 characters long.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field until valid input is entered
            }
        }

        private void zoneAreaTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string zoneArea = addressLine2TextBox.Text.Trim(); // Remove spaces before/after input

            if (string.IsNullOrWhiteSpace(zoneArea) || zoneArea.Length < 3)
            {
                MessageBox.Show("Zone area must be at least 3 characters long.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field until valid input is entered
            }

        }

        private void postalCodeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string postalCode = postalCodeTextBox.Text.Trim();

            // Check if the input is exactly 4 digits and contains only numbers
            if (!Regex.IsMatch(postalCode, @"^\d{4}$"))
            {
                MessageBox.Show("Postal code must be exactly 4 digits and contain only numbers.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void memberStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected value safely
            string selectedStatus = memberStatusComboBox.SelectedItem?.ToString() ?? string.Empty;

            // Change background color based on selection
            switch (selectedStatus)
            {
                case "Active":
                    memberStatusComboBox.BackColor = Color.Green;
                    memberStatusComboBox.ForeColor = Color.White; // Ensure text is visible
                    break;
                case "Inactive":
                    memberStatusComboBox.BackColor = Color.Orange;
                    memberStatusComboBox.ForeColor = Color.Black;
                    break;
                case "Deceased":
                    memberStatusComboBox.BackColor = Color.Red;
                    memberStatusComboBox.ForeColor = Color.White;

                    // Show MessageBox and open End of Life form if OK is clicked
                    DialogResult result = MessageBox.Show("The member is marked as deceased. Please complete the End of Life form.",
                                                          "End of Life Form Required",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        MainForm.SwitchPanel.Controls.Clear(); // Use the public property
                        EndOfFileForm endOfFileForm = new EndOfFileForm(MainForm);
                        endOfFileForm.TopLevel = false;
                        MainForm.SwitchPanel.Controls.Add(endOfFileForm);
                        endOfFileForm.Show();
                    }
                    break;
                default:
                    memberStatusComboBox.BackColor = SystemColors.Window; // Reset to default color
                    memberStatusComboBox.ForeColor = Color.Black;
                    break;
            }
        }

        private void membershipNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public static class MembershipData
        {
            public static string MembershipNumber { get; set; }
        }


        private HashSet<string> existingMembershipNumbers = new HashSet<string>(); // Simulate storage for checking uniqueness
        private void memberSaveButton_Click(object sender, EventArgs e)
        {
            string membershipNumber = GenerateMembershipNumber();

            // Check if membership number already exists
            if (existingMembershipNumbers.Contains(membershipNumber))
            {
                MessageBox.Show("Membership number already exists! Please try again.", "Duplicate Entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save membership number
            membershipNumberTextBox.Text = membershipNumber;
            existingMembershipNumbers.Add(membershipNumber); // Simulate saving to database

            // Store in shared class
            MembershipData.MembershipNumber = membershipNumber;

            MessageBox.Show($"Member saved successfully! Membership Number: {membershipNumber}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open the next form (e.g., SpousesForm)
            //SpousesForm spousesForm = new SpousesForm();
            //spousesForm.Show();
            //this.Hide(); // Hide current form if needed
        }


        private string GenerateMembershipNumber()
        {
            // Get last two digits of the registration year
            string lastTwoYearDigits = registrationDateTimePicker.Value.Year.ToString().Substring(2, 2);

            // Generate gender-based random digit
            Random rand = new Random();
            int genderDigit = 0;
            if (memberGenderComboBox.SelectedItem != null)
            {
                string gender = memberGenderComboBox.SelectedItem.ToString().ToLower();
                genderDigit = (gender == "male") ? rand.Next(5, 10) : rand.Next(0, 5);
            }

            // Get race-based digit (Fixed Null Dereference and Case Issue)
            int raceDigit = 5; // Default to 'Other'
            if (memberRaceComboBox.SelectedItem != null)
            {
                string race = memberRaceComboBox.SelectedItem.ToString().ToLower(); // Ensure it is lowercase
                switch (race)
                {
                    case "black":
                        raceDigit = 1;
                        break;
                    case "white":
                        raceDigit = 2;
                        break;
                    case "coloured":
                        raceDigit = 3;
                        break;
                    case "indian":
                        raceDigit = 4;
                        break;
                    case "other":
                        raceDigit = 5;
                        break;
                }
            }

            // Generate last four random digits
            int lastFourDigits = rand.Next(1000, 10000); // Ensures four-digit number

            // Construct final membership number
            return $"{lastTwoYearDigits}{genderDigit}{raceDigit}{lastFourDigits}";
        }

        private void memberEmploymentStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}