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

        private MainForm parentForm;
        public AddMemberForm(MainForm parent)
        {
            InitializeComponent();
            parentForm = parent;
            
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
            //parentForm.switchPanel.Controls.Clear();
            //SpousesForm spousesForm = new SpousesForm(this);
            //spousesForm.TopLevel = false;
            //parentForm.switchPanel.Controls.Add(spousesForm);
            //spousesForm.Show();
        }
    }
}