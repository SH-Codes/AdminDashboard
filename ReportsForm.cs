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
    public partial class ReportsForm : Form
    {
        public MainForm MainForm { get; private set; }
        public ReportsForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void nonDatedReportsButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            NonDatedReportsForm nonDatedReportsForm = new NonDatedReportsForm(MainForm);
            nonDatedReportsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(nonDatedReportsForm);
            nonDatedReportsForm.Show();
        }
    }
}
