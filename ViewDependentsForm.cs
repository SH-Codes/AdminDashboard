using Microsoft.Data.SqlClient;
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
        string connectionString = ConnectionConfig.ConnectionString;
        public MainForm MainForm { get; private set; }
        public ViewDependentsForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void ViewDependentsForm_Load(object sender, EventArgs e)
        {
            dependentsListDataGridView.DataSource = GetDependentsList();

        }

        private DataTable GetDependentsList()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT
                        dependent_id AS [Dependent ID],
                        first_name AS [First Name],
                        last_name AS [Last Name],
                        gender AS [Gender],
                        in_sunday_school AS [Sunday School],
                        relationship AS [Relationship]
                    FROM dependents";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
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
