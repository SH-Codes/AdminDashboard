﻿using System;
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
    public partial class NonDatedReportsForm : Form
    {
        public MainForm MainForm { get; private set; }
        public NonDatedReportsForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        //public NonDatedReportsForm()
        //{
       
        //}

        private void datedReportsButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            ReportsForm reportsForm = new ReportsForm(MainForm);
            reportsForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(reportsForm);
            reportsForm.Show();
        }
    }
}
