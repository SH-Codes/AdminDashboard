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
    public partial class SpousesForm : Form

    {
        public MainForm MainForm { get; private set; }

        public SpousesForm(MainForm mainFormRef)
        {
            InitializeComponent();
            this.MainForm = mainFormRef;
          
        }

        private void SpousesForm_Load(object sender, EventArgs e)
        {

        }

        private void spousePreviousButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            AddMemberForm addMemberForm = new AddMemberForm(MainForm);
            addMemberForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(addMemberForm);
            addMemberForm.Show();
        }

        private void memberNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            DependentsForm dependentsForm = new DependentsForm(MainForm);
            dependentsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(dependentsForm);
            dependentsForm.Show();
        }
    }
}
