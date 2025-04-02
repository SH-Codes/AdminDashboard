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
    }
}
