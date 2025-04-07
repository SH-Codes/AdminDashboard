using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AdminDashboard.AddMemberForm;

namespace AdminDashboard
{
    public partial class EndOfFileForm : Form
    {
        public MainForm MainForm { get; private set; }
        public EndOfFileForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void endOfFilePreviousButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            AcademicHistoryForm academicHistoryForm = new AcademicHistoryForm(MainForm);
            academicHistoryForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(academicHistoryForm);
            academicHistoryForm.Show();
        }


        private void dateOfDeathTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateOfDeathTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Date of death cannot be greater than today.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateOfDeathTimePicker.Value = DateTime.Now;
            }
        }

        private void burialDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (burialDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Burial date cannot be greater than today.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                burialDateTimePicker.Value = DateTime.Now;
            }
        }

        private void cemeteryTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cemeteryTextBox.Text.Length < 3)
            {
                MessageBox.Show("Cemetery cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void clergyNameTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (clergyNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Clergy name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void receivedViaticumComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (receivedViaticumComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(receivedViaticumComboBox.Text))
            {
                MessageBox.Show("Please select a race.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void EndOfFileForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MembershipData.MembershipNumber))
            {
                endOfFileMembershipNumberTextBox.Text = MembershipData.MembershipNumber;
            }
        }

        private void endOfLifeSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Azure SQL Server connection string
                //string connectionString = "Data Source=tcp:admindashboarddbserver.database.windows.net; Authentication = Active Directory Default; Database = AdminDashboard_db";
                // SenamileNdaba Computer Connection String
                //string connectionString = "Data Source=SenamileNdaba;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";
                // SacredHeart Computer Connection String
                 string connectionString = "Data Source=SACREDHEART\\SQLEXPRESS;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Query to insert data and return the generated dependent_id
                    string query = @"
                INSERT INTO end_file_file (membership_id, date_of_death, burial_date,
                       burial_place, received_viaticum, next_of_kin, phone_number, burial_clergy_name) 
                VALUES (@membership_id, @date_of_death, @burial_date,
                       @burial_place, @received_viaticum, @next_of_kin, @phone_number, @burial_clergy_name);
                SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", endOfFileMembershipNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_of_death", dateOfDeathTimePicker.Value);
                        cmd.Parameters.AddWithValue("@burial_date", burialDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@burial_place", cemeteryTextBox.Text);
                        cmd.Parameters.AddWithValue("@next_of_kin", nextOfKinTextBox.Text);
                        cmd.Parameters.AddWithValue("@phone_number", phoneNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@burial_clergy_name", clergyNameTextBox.Text);

                        // Execute query and retrieve the new spouse_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            fileIdTextBox.Text = result.ToString(); // Set the dependent_id in the textbox
                        }
                    }
                }

                MessageBox.Show("Academic details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

