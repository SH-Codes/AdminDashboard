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
    public partial class ViewInventoryForm : Form
    {
        public MainForm MainForm { get; private set; }
        public ViewInventoryForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void inventoryAddNewButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            InventoryForm inventoryForm = new InventoryForm(MainForm);
            inventoryForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(inventoryForm);
            inventoryForm.Show();
        }

        private void inventoryBackButton_Click(object sender, EventArgs e)
        {
            MainForm.SwitchPanel.Controls.Clear();
            InventoryForm inventoryForm = new InventoryForm(MainForm);
            inventoryForm.TopLevel = false;
            MainForm.SwitchPanel.Controls.Add(inventoryForm);
            inventoryForm.Show();
        }
    }
}
