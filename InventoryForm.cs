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
    public partial class InventoryForm : Form
    {
        public MainForm MainForm { get; private set; }
        public InventoryForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            ViewInventoryForm viewInventoryForm = new ViewInventoryForm(MainForm); // Pass the required 'mainForm' parameter
            viewInventoryForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(viewInventoryForm);
            viewInventoryForm.Show();
        }
    }
}
