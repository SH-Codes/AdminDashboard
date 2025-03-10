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
    }
}
