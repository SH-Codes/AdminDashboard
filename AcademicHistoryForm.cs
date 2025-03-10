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
    }
}
