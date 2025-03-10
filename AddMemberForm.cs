using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void memberLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (memberLastNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Last name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberRaceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Selection cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void memberFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (memberFirstNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("First name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void memberLastNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (memberLastNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Last name cannot be less than 3 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void memberMaritalStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberMaritalStatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Marital status cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void memberEmploymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberEmploymentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Employment status cannot be empty.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}