namespace AdminDashboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void switchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            switchPanel.Controls.Clear();
            DashboardForm overviewForm = new DashboardForm();
            overviewForm.TopLevel = false;
            switchPanel.Controls.Add(overviewForm);
            overviewForm.Show();

        }

        private void financesButton_Click(object sender, EventArgs e)
        {

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void viewMembersButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addMembersButton_Click(object sender, EventArgs e)
        {
            switchPanel.Controls.Clear();
            AddMemberForm addNewMemberForm = new AddMemberForm();
            addNewMemberForm.TopLevel = false;
            switchPanel.Controls.Add(addNewMemberForm);
            addNewMemberForm.Show();
        }
    }
}
