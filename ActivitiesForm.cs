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
    public partial class ActivitiesForm : Form
    {
        public MainForm MainForm { get; private set; }
        public ActivitiesForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void activityPrevButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            SacramentalLifeForm sacramentalLifeForm = new SacramentalLifeForm(MainForm);
            sacramentalLifeForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(sacramentalLifeForm);
            sacramentalLifeForm.Show();
        }

        private void activityNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            AcademicHistoryForm academicHistoryForm = new AcademicHistoryForm(MainForm);
            academicHistoryForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(academicHistoryForm);
            academicHistoryForm.Show();
        }

        private void yearJoinedDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (yearJoinedDateTimePicker1.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date joined cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearJoinedDateTimePicker1.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void yearJoinedDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (yearJoinedDateTimePicker2.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date joined cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearJoinedDateTimePicker2.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void yearJoinedDateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (yearJoinedDateTimePicker3.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date joined cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearJoinedDateTimePicker3.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void departmentName1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items
            activityName1ComboBox.Items.Clear();

            // Get the selected department
            string selectedDepartment = departmentName1ComboBox.SelectedItem?.ToString() ?? string.Empty;

            // Define activities based on department
            Dictionary<string, List<string>> departmentActivities = new Dictionary<string, List<string>>()
        {
             { "Social", new List<string> { " ", "Social Functions", "Catering/Cooking", "Photography/Publicity" }},
             { "Administration", new List<string> { " ", "Secreterial Skills", "Office Reception", "Collection Counting"
                , "Typing and Translating", "Newsletter ans Website Team"}},
             { "Maintenance", new List<string> { "", "Audio Visual/Electrical Equipment", "Building, Painting, Electrical and Plumbing",
                 "Cleaning", "Church Gardens", "Sewing and Dressing Making" }},
             { "Pastoral", new List<string> { " ", "Visiting of the Sick", "Visiting and Caring for the Elderly", "Hospital and Hospice Ministry",
               "Care for the Poor", "Support Group for Widows", "Care of Seminarians and Priests"}},
             { "Liturgical", new List<string> { " ", "Lector", "Music - Instrument Player", "Floral Arrangement", "Sacristan", "Ushers/ Ministers Hospitality",
               "Audio and Projection Team", "Social Media Team", "Altar Server"}},
             { "Formation", new List<string> { " ", "Good Shepherd Prohramme", "Primary Phase Catechism", "Secondary Phase Catechism", "Junior Youth (8 - 15)",
               "Mid-Youth (16 - 19)", "Young Adults (29 - 15)", "RCIA Team", "Resource Centre and Library"}},
             { "Sodalities", new List<string> { " ","Catholic Nurses Guild", "Catholic Women;s League", "Catholic Women's Union", "Daughters of St. Anne's", "Sacred Heart Sodality",
               "Sodality of Mary", "Holy Childhood", "Knights of de Gama",  "St. Anne's Sodality",  "St. Dominic's Sodality ", "St. Francis Sodality", "St. Joseph's Sodality", "St. Vincent de Paul", "Daughters of St. Anne's", "Udodana" } }
            // Add more departments and activities as needed
        };

            // Check if the selected department exists in the dictionary
            if (departmentActivities.ContainsKey(selectedDepartment))
            {
                // Add corresponding activities to the combo box
                activityName1ComboBox.Items.AddRange(departmentActivities[selectedDepartment].ToArray());
            }

            // Optionally select the first item
            if (activityName1ComboBox.Items.Count > 0)
            {
                activityName1ComboBox.SelectedIndex = 0;
            }
        }


        private void activityName1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departmentName2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // Clear existing items
                activityName2ComboBox.Items.Clear();

                // Get the selected department
                string selectedDepartment = departmentName2ComboBox.SelectedItem?.ToString() ?? string.Empty;

                // Define activities based on department
                Dictionary<string, List<string>> departmentActivities = new Dictionary<string, List<string>>()
        {
             { "Social", new List<string> { " ", "Social Functions", "Catering/Cooking", "Photography/Publicity" }},
             { "Administration", new List<string> { " ", "Secreterial Skills", "Office Reception", "Collection Counting"
                , "Typing and Translating", "Newsletter ans Website Team"}},
             { "Maintenance", new List<string> { "", "Audio Visual/Electrical Equipment", "Building, Painting, Electrical and Plumbing",
                 "Cleaning", "Church Gardens", "Sewing and Dressing Making" }},
             { "Pastoral", new List<string> { " ", "Visiting of the Sick", "Visiting and Caring for the Elderly", "Hospital and Hospice Ministry",
               "Care for the Poor", "Support Group for Widows", "Care of Seminarians and Priests"}},
             { "Liturgical", new List<string> { " ", "Lector", "Music - Instrument Player", "Floral Arrangement", "Sacristan", "Ushers/ Ministers Hospitality",
               "Audio and Projection Team", "Social Media Team", "Altar Server"}},
             { "Formation", new List<string> { " ", "Good Shepherd Prohramme", "Primary Phase Catechism", "Secondary Phase Catechism", "Junior Youth (8 - 15)",
               "Mid-Youth (16 - 19)", "Young Adults (29 - 15)", "RCIA Team", "Resource Centre and Library"}},
             { "Sodalities", new List<string> { " ","Catholic Nurses Guild", "Catholic Women;s League", "Catholic Women's Union", "Daughters of St. Anne's", "Sacred Heart Sodality",
               "Sodality of Mary", "Holy Childhood", "Knights of de Gama",  "St. Anne's Sodality",  "St. Dominic's Sodality ", "St. Francis Sodality", "St. Joseph's Sodality", "St. Vincent de Paul", "Daughters of St. Anne's", "Udodana" } }
            // Add more departments and activities as needed
        };

                // Check if the selected department exists in the dictionary
                if (departmentActivities.ContainsKey(selectedDepartment))
                {
                    // Add corresponding activities to the combo box
                    activityName2ComboBox.Items.AddRange(departmentActivities[selectedDepartment].ToArray());
                }

                // Optionally select the first item
                if (activityName2ComboBox.Items.Count > 0)
                {
                    activityName2ComboBox.SelectedIndex = 0;
                }
            }
        }

        private void activityName2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departmentName3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // Clear existing items
                activityName3ComboBox.Items.Clear();

                // Get the selected department
                string selectedDepartment = departmentName3ComboBox.SelectedItem?.ToString() ?? string.Empty;

                // Define activities based on department
                Dictionary<string, List<string>> departmentActivities = new Dictionary<string, List<string>>()
        {
             { "Social", new List<string> { " ", "Social Functions", "Catering/Cooking", "Photography/Publicity" }},
             { "Administration", new List<string> { " ", "Secreterial Skills", "Office Reception", "Collection Counting"
                , "Typing and Translating", "Newsletter ans Website Team"}},
             { "Maintenance", new List<string> { "", "Audio Visual/Electrical Equipment", "Building, Painting, Electrical and Plumbing",
                 "Cleaning", "Church Gardens", "Sewing and Dressing Making" }},
             { "Pastoral", new List<string> { " ", "Visiting of the Sick", "Visiting and Caring for the Elderly", "Hospital and Hospice Ministry",
               "Care for the Poor", "Support Group for Widows", "Care of Seminarians and Priests"}},
             { "Liturgical", new List<string> { " ", "Lector", "Music - Instrument Player", "Floral Arrangement", "Sacristan", "Ushers/ Ministers Hospitality",
               "Audio and Projection Team", "Social Media Team", "Altar Server"}},
             { "Formation", new List<string> { " ", "Good Shepherd Prohramme", "Primary Phase Catechism", "Secondary Phase Catechism", "Junior Youth (8 - 15)",
               "Mid-Youth (16 - 19)", "Young Adults (29 - 15)", "RCIA Team", "Resource Centre and Library"}},
             { "Sodalities", new List<string> { " ","Catholic Nurses Guild", "Catholic Women;s League", "Catholic Women's Union", "Daughters of St. Anne's", "Sacred Heart Sodality",
               "Sodality of Mary", "Holy Childhood", "Knights of de Gama",  "St. Anne's Sodality",  "St. Dominic's Sodality ", "St. Francis Sodality", "St. Joseph's Sodality", "St. Vincent de Paul", "Daughters of St. Anne's", "Udodana" } }
            // Add more departments and activities as needed
        };

                // Check if the selected department exists in the dictionary
                if (departmentActivities.ContainsKey(selectedDepartment))
                {
                    // Add corresponding activities to the combo box
                    activityName3ComboBox.Items.AddRange(departmentActivities[selectedDepartment].ToArray());
                }

                // Optionally select the first item
                if (activityName3ComboBox.Items.Count > 0)
                {
                    activityName3ComboBox.SelectedIndex = 0;
                }
            }
        }

        private void activityName3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void previousExcoRoleDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (previousExcoRoleDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date joined cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearJoinedDateTimePicker3.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void ActivitiesForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MembershipData.MembershipNumber))
            {
                activityMembershipNumberTextBox.Text = MembershipData.MembershipNumber;
            }
        }

        private void activitySaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Azure SQL Server connection string
                // string connectionString = "tcp:admindashboarddbserver.database.windows.net; Authentication = Active Directory Default; Database = AdminDashboard_db";
                // SenamileNdaba Computer Connection String
                 string connectionString = "Data Source=SenamileNdaba;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";
                // SacredHeart Computer Connection String
                //string connectionString = "Data Source=SACREDHEART\\SQLEXPRESS;Initial Catalog=ChurchAdminSys;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Fixed INSERT Query (removed duplicate baptism_date)
                    string query = @"
            INSERT INTO activities (
                membership_id, department_name1, activity_name1, activity1_year_joined, activity1_role,  
                department_name2, activity_name2, activity2_year_joined, activity2_role, department_name3, activity_name3,
                activity3_role, activity3_year_joined, previous_role_is_exco, previous_role, year_of_previous_role
            ) 
            VALUES (
                @membership_id, @department_name1, @activity_name1, @activity1_year_joined, @activity1_role,  
                @department_name2, @activity_name2, @activity2_year_joined, @activity2_role, @department_name3, @activity_name3,
                @activity3_role, @activity3_year_joined, @previous_role_is_exco, @previous_role, @year_of_previous_role
            );
            SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Convert values to match DB types
                        cmd.Parameters.AddWithValue("@membership_id", activityMembershipNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@department_name1", departmentName1ComboBox.Text.Trim() );
                        cmd.Parameters.AddWithValue("@activity_name1", activityName1ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@activity1_year_joined", yearJoinedDateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@activity1_role", activityRole1ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@department_name2", departmentName2ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@activity_name2", activityName2ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@activity2_year_joined", yearJoinedDateTimePicker2.Value);
                        cmd.Parameters.AddWithValue("@activity2_role", activityRole2ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@department_name3", departmentName3ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@activity_name3", activityName3ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@activity3_year_joined", yearJoinedDateTimePicker3.Value);
                        cmd.Parameters.AddWithValue("@activity3_role", activityRole3ComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("previous_role", previousExcoComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@previous_role_is_exco", isPreviousExcoComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@year_of_previous_role", previousExcoRoleDateTimePicker.Value);

                        // Execute query and retrieve the new sacramental_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            activityIDTextBox.Text = result.ToString(); // Set the activity_id in the textbox
                        }
                    }
                }

                MessageBox.Show("Activity details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
