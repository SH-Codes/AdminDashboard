namespace AdminDashboard
{
    public partial class MainForm : Form
    {

        public Panel SwitchPanel // Public getter property
        {
            get { return switchPanel; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

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
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Closes the entire application
            }
        }

        private void viewMembersButton_Click(object sender, EventArgs e)
        {
            switchPanel.Controls.Clear();
            ViewMembersForm ViewMembers = new ViewMembersForm();
            ViewMembers.TopLevel = false;
            switchPanel.Controls.Add(ViewMembers);
            ViewMembers.Show();
        }

        private void addMembersButton_Click(object sender, EventArgs e)
        {
            switchPanel.Controls.Clear();
            AddMemberForm addNewMember = new AddMemberForm(this);
            addNewMember.TopLevel = false;
            switchPanel.Controls.Add(addNewMember);
            addNewMember.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTimeAndGreeting();
            mainFormTimer.Start();
        }

        internal void LoadForm(SpousesForm spousesForm)
        {
            throw new NotImplementedException();
        }

        private void mainFormTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeAndGreeting();
        }

        private void UpdateTimeAndGreeting()
        {
            DateTime now = DateTime.Now;
            string greeting;

            if (now.Hour >= 0 && now.Hour < 12)
            {
                greeting = "Good Morning";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }
            timeDisplayLabel.Text = $"{greeting}, {now:dddd, dd MMM yyyy, HH:mm:ss}";
        }
    }
}
