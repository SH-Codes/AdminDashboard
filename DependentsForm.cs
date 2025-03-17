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
    }
}
