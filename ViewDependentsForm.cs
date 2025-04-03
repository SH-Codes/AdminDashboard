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
    public partial class ViewDependentsForm : Form
    {
        public MainForm MainForm { get; private set; }
        public ViewDependentsForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void ViewDependentsForm_Load(object sender, EventArgs e)
        {

        }

        private void dependentAddNewButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear(); // Use the public property
            DependentsForm dependentsForm = new DependentsForm(MainForm);
            dependentsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(dependentsForm);
            dependentsForm.Show();
        }
    }
}
