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
    public partial class ActivitiesForm : Form
    {
        public MainForm MainForm { get; private set; }
        public ActivitiesForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void activityPrevButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            SacramentalLifeForm sacramentalLifeForm = new SacramentalLifeForm(MainForm);
            sacramentalLifeForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(sacramentalLifeForm);
            sacramentalLifeForm.Show();
        }

        private void activityNextButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            AcademicHistoryForm academicHistoryForm = new AcademicHistoryForm(MainForm);
            academicHistoryForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(academicHistoryForm);
            academicHistoryForm.Show();
        }
    }
}
