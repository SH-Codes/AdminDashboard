using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (academicFieldOfStudyTextBox.Text.Length < 3)
            {
                MessageBox.Show("Last name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Prevents the user from leaving the textbox
            }
        }
    }
}
