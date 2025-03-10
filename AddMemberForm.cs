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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}