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
            string text = mothersNamesTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Mother's names must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void sponsorsNamesTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = sponsorsNamesTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text) && text.Length < 3)
            {
                MessageBox.Show("Mother's names must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void clergysNamesTextBox_TextChanged(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = clergysNamesTextBox.Text.Trim();
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
    }
}
