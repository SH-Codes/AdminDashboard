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
    public partial class AcademicHistoryForm : Form
    {
        public MainForm MainForm { get; private set; }
        public AcademicHistoryForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void memberNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            EndOfFileForm endOfFileForm = new EndOfFileForm(MainForm);
            endOfFileForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(endOfFileForm);
            endOfFileForm.Show();
        }

        private void academicPreviousButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            ActivitiesForm activitiesForm = new ActivitiesForm(MainForm);
            activitiesForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(activitiesForm);
            activitiesForm.Show();
        }

        private void highestGradePassedCombox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (highestGradePassedCombox.SelectedItem == null || string.IsNullOrWhiteSpace(highestGradePassedCombox.Text))
            {
                MessageBox.Show("Please select a gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Only cancel if it's completely empty, avoiding a validation loop
                if (string.IsNullOrEmpty(highestGradePassedCombox.Text))
                {
                    e.Cancel = true;
                }
            }
        }

        private void academicYearObtainedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (academicYearObtainedDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Academic year obtained date cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                academicYearObtainedDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void subjectPassedCheckedListBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int selectedCount = subjectPassedCheckedListBox.CheckedItems.Count;

            // If no items are selected or fewer than 4, show a warning and cancel validation
            if (selectedCount < 3)
            {
                MessageBox.Show("Please select at least 3 subjects.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents moving to the next field
            }
        }

        private void academicFieldOfStudyTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(academicFieldOfStudyTextBox.Text) && academicFieldOfStudyTextBox.Text.Length < 3)
            {
                MessageBox.Show("Field of study cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }

        private void AcademicHistoryForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MembershipData.MembershipNumber))
            {
                academicHistoryMembershipNumberTextBox.Text = MembershipData.MembershipNumber;
            }
        }

        private void academicSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Azure SQL Server connection string
                // string connectionString = "Data Source=tcp:admindashboarddbserver.database.windows.net; Authentication = Active Directory Default; Database = AdminDashboard_db";
                // SenamileNdaba Computer Connection String
                //   string connectionString = "Data Source=SenamileNdaba;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";
                // SacredHeart Computer Connection String
                 string connectionString = "Data Source=SACREDHEART\\SQLEXPRESS;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Query to insert data and return the generated dependent_id
                    string query = @"
                INSERT INTO academic_history (membership_id, highest_qualification, year_obtained,
                                        subjects_passed, field_of_study) 
                VALUES (@membership_id, @highest_qualification, @year_obtained,
                        @subjects_passed, @field_of_study);
                SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", academicHistoryMembershipNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@highest_qualification", highestGradePassedCombox.Text);
                        cmd.Parameters.AddWithValue("@year_obtained", academicYearObtainedDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@subjects_passed", subjectPassedCheckedListBox.Text);
                        cmd.Parameters.AddWithValue("@field_of_study", academicFieldOfStudyTextBox.Text);

                        // Execute query and retrieve the new spouse_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            academicIDTextBox.Text = result.ToString(); // Set the dependent_id in the textbox
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
