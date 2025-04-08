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
    public partial class SacramentalLifeForm : Form
    {

        public MainForm MainForm { get; private set; }
        public SacramentalLifeForm(MainForm mainFormRef)
        {
            InitializeComponent();
            this.MainForm = mainFormRef;
        }

        private void sacramentalPreviousButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            DependentsForm dependentsForm = new DependentsForm(MainForm);
            dependentsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(dependentsForm);
            dependentsForm.Show();
        }

        private void sacramentalNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            ActivitiesForm activitiesForm = new ActivitiesForm(MainForm);
            activitiesForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(activitiesForm);
            activitiesForm.Show();
        }

        private void isBaptisedcComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(isBaptisedComboBox.Text) && isBaptisedComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid option.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void baptismDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (baptismDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Baptism date cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baptismDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void placeOfBaptismTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = placeOfBaptismTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Place of baptism must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void fathersNameTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = fathersNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Father's names must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void mothersNamesTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = mothersNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Mother's names must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void sponsorsNamesTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = sponsorsNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Mother's names must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void clergysNamesTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = baptismClergyNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Mother's names must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void holyEucharistComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(holyCommunionComboBox.Text) && holyCommunionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid option.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void holyEucharistDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (holyCommunionDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Holy Eucharist date cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                holyCommunionDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void placeOfHolyEucharistTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = placeOfHolyCommunionTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Place of holy eucharist must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void isConfirmedComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(isConfirmedComboBox.Text) && isConfirmedComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid option.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void confirmationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (confirmationDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Holy Eucharist date cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                confirmationDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void placeOfConfirmationTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = placeOfConfirmationTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Place of confirmation must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void confirmationClergysNamesTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = confirmationClergysNamesTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Confirmation clergy's names must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void holyMatrimonyComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(holyMatrimonyComboBox.Text) && holyMatrimonyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid option.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void holyMatrimonyDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (holyMatrimonyDateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Holy Eucharist date cannot be today or a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                holyMatrimonyDateTimePicker.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void placeOfHolyMatrimonyTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = placeOfHolyMatrimonyTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Place of holy matrimony must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void catholicMarriageComboBox_SelectedIndexChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(catholicMarriageComboBox.Text) && catholicMarriageComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid option.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void SacramentalLifeForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MembershipData.MembershipNumber))
            {
                sacramentalMembershipNumberTextBox.Text = MembershipData.MembershipNumber;
            }
        }

        private void placeOfBaptismTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void baptismalNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string isBaptisedText = isBaptisedComboBox.Text.Trim();

            if (!string.IsNullOrEmpty(isBaptisedText) && isBaptisedText.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                if (string.IsNullOrEmpty(baptismalNumberTextBox.Text.Trim()))
                {
                    MessageBox.Show("Baptismal number cannot be empty when baptism is confirmed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void sacramentalSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConnectionConfig.ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Fixed INSERT Query (removed duplicate baptism_date)
                    string query = @"
            INSERT INTO sacramental_life (
                membership_id, is_baptised, baptismal_number, baptism_date, baptism_place,  
                sponsor_name, father_name, mother_name, baptism_clergy_name, received_communion, communion_date,
                communion_place, is_confirmed, date_confirmed, place_confirmed, confirmation_clergy_name, is_married,
                date_married, place_married, catholic_marriage, marriage_clergy_name
            ) 
            VALUES (
                @membership_id, @is_baptised, @baptismal_number, @baptism_date, @baptism_place,  
                @sponsor_name, @father_name, @mother_name, @baptism_clergy_name, @received_communion, @communion_date,
                @communion_place, @is_confirmed, @date_confirmed, @place_confirmed, @confirmation_clergy_name, @is_married,
                @date_married, @place_married, @catholic_marriage, @marriage_clergy_name
            );
            SELECT SCOPE_IDENTITY();"; // Get the last inserted ID

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Convert values to match DB types
                        cmd.Parameters.AddWithValue("@membership_id", sacramentalMembershipNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@is_baptised", isBaptisedComboBox.Text == "Yes" ? 1 : 0); // Convert Yes/No to 1/0
                        cmd.Parameters.AddWithValue("@baptismal_number", baptismalNumberTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@baptism_date", baptismDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@baptism_place", placeOfBaptismTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@sponsor_name", sponsorsNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@father_name", fathersNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@mother_name", mothersNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@baptism_clergy_name", baptismClergyNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@received_communion", holyCommunionComboBox.Text == "Yes" ? 1 : 0);
                        cmd.Parameters.AddWithValue("@communion_date", holyCommunionDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@communion_place", placeOfHolyCommunionTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@is_confirmed", isConfirmedComboBox.Text == "Yes" ? 1 : 0);
                        cmd.Parameters.AddWithValue("@date_confirmed", confirmationDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@place_confirmed", placeOfConfirmationTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@confirmation_clergy_name", confirmationClergysNamesTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@is_married", holyMatrimonyComboBox.Text == "Yes" ? 1 : 0);
                        cmd.Parameters.AddWithValue("@date_married", holyMatrimonyDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@place_married", placeOfHolyMatrimonyTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@catholic_marriage", catholicMarriageComboBox.Text == "Yes" ? 1 : 0);
                        cmd.Parameters.AddWithValue("@marriage_clergy_name", holyMatrimonyClergyNameTextBox.Text.Trim());

                        // Execute query and retrieve the new sacramental_id
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            sacramentalIDTextBox.Text = result.ToString(); // Set the sacramental_id in the textbox
                        }
                    }
                }

                MessageBox.Show("Sacramental details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
