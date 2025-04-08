using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdminDashboard
{
    public partial class ViewMembersForm : Form
    {
        private const int MembershipIDColumnWidth = 90;
        private const int FirstNameColumnWidth = 165;
        private const int LastNameColumnWidth = 165;
        private const int PhoneNumberColumnWidth = 120;
        private const int ZoneAreaColumnWidth = 160;
        private const int ActivityName1ColumnWidth = 232;

        string connectionString = ConnectionConfig.ConnectionString;

        public ViewMembersForm()
        {
            InitializeComponent();
            membersListDataGridView.CellContentClick += membersListDataGridView_CellContentClick;
        }


        private void ViewMembersForm_Load(object sender, EventArgs e)
        {
            membersListDataGridView.ReadOnly = true;
            membersListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersListDataGridView.DataSource = GetMembersList();
            SetColumnWidths();
        }

        private DataTable GetMembersList()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT
                        m.membership_id AS [Member ID],
                        m.first_name AS [First Name],
                        m.last_name AS [Last Name],
                        m.mobile_number AS [Phone Number],
                        m.zone_area AS [Zone Area],
                        a.activity_name1 AS [Activity Name 1]
                    FROM Members m
                    LEFT JOIN Activities a ON m.membership_id = a.membership_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        private void SetColumnWidths()
        {
            membersListDataGridView.Columns["Member ID"].Width = MembershipIDColumnWidth;
            membersListDataGridView.Columns["First Name"].Width = FirstNameColumnWidth;
            membersListDataGridView.Columns["Last Name"].Width = LastNameColumnWidth;
            membersListDataGridView.Columns["Phone Number"].Width = PhoneNumberColumnWidth;
            membersListDataGridView.Columns["Zone Area"].Width = ZoneAreaColumnWidth;
            membersListDataGridView.Columns["Activity Name 1"].Width = ActivityName1ColumnWidth;
        }

        private void membersListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && membersListDataGridView.Columns[e.ColumnIndex].Name == "Member ID")
            {
                string membershipId = membersListDataGridView.Rows[e.RowIndex].Cells["Member ID"].Value.ToString();

                // Update the AddMemberForm with the selected member's details
                AddMemberForm addMemberForm = new AddMemberForm(membershipId);
                addMemberForm.TopLevel = false;
                MainForm mainForm = (MainForm)this.ParentForm;
                addMemberForm.Show(); // Wait for the form to close before refreshing

                // Refresh the data grid after the form closes
                membersListDataGridView.DataSource = GetMembersList();
            }
        }

    }
}
