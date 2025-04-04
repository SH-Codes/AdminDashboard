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
    public partial class DependentsForm : Form
    {
        public MainForm MainForm { get; private set; }
        public DependentsForm(MainForm mainFormRef)
        {
            InitializeComponent();
            this.MainForm = mainFormRef;
        }

        private void memberEmploymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dependentPreviousButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            SpousesForm spousesForm = new SpousesForm(MainForm);
            spousesForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(spousesForm);
            spousesForm.Show();
        }

        private void dependentNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            SacramentalLifeForm sacramentalLifeForm = new SacramentalLifeForm(MainForm);
            sacramentalLifeForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(sacramentalLifeForm);
            sacramentalLifeForm.Show();

        }

        private void dependentFirstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = dependentFirstNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("First name must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void dependentLastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = dependentLastNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Last name must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void dependentGenderComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dependentGenderComboBox.Text) && dependentGenderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void attendingSundaySchoolComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(attendingSundaySchoolComboBox.Text) && attendingSundaySchoolComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void DependentsForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MembershipData.MembershipNumber))
            {
                dependentMembershipNumberTextBox.Text = MembershipData.MembershipNumber;
            }
        }

        private void viewDependentsButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear(); // Use the public property
            ViewDependentsForm viewDependentsForm = new ViewDependentsForm(MainForm);
            viewDependentsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(viewDependentsForm);
            viewDependentsForm.Show();
        }

        private void dependentSaveButton_Click(object sender, EventArgs e)
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

                    // Query to insert data and return the generated dependent_id
                    string query = @"
                INSERT INTO dependents (membership_id, first_name, last_name, gender, birth_date,  
                                     school_grade, in_sunday_school, relationship) 
                VALUES (@membership_id, @first_name, @last_name, @gender, @birth_date, 
                        @school_grade, @in_sunday_school, @relationship);
                SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", dependentMembershipNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@first_name", dependentFirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@last_name", dependentLastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@gender", dependentGenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@birth_date", dependentBirthDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@school_grade", dependentGenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@in_sunday_school", attendingSundaySchoolComboBox.Text);
                        cmd.Parameters.AddWithValue("@relationship", dependentRelationshipTextBox.Text);

                        // Execute query and retrieve the new spouse_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            dependentIDTextBox.Text = result.ToString(); // Set the dependent_id in the textbox
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

