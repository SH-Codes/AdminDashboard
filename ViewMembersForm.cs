﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace AdminDashboard
{
    public partial class ViewMembersForm : Form
    {
        public ViewMembersForm()
        {
            InitializeComponent();
        }

        public void viewList()
        {
            con.open();

        }
    }
}
