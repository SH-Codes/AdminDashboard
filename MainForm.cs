using System.Drawing.Drawing2D;

namespace AdminDashboard
{
    public partial class MainForm : Form
    {
        //private int cornerRadius = 30; // Adjust this for roundnes

        public Panel SwitchPanel // Public getter property
        {
            get { return switchPanel; }
        }

        public MainForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackColor = Color.White;

            dashboardButton.Paint += new PaintEventHandler(dashboardButton_Paint);
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    using (GraphicsPath path = new GraphicsPath())
        //    {
        //        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
        //        path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
        //        path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        //        path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        //        path.CloseFigure();

        //        this.Region = new Region(path);
        //    }
        //}

        private void dashboardButton_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 16; // Adjust for roundness

            // Enable anti-aliasing for smooth edges
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(dashboardButton.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(dashboardButton.Width - cornerRadius, dashboardButton.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, dashboardButton.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Apply rounded region
                dashboardButton.Region = new Region(path);
            }
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        private void switchPanel_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 16; // Adjust this to change the roundness

            using (GraphicsPath path = new GraphicsPath())
            {
                // Define rounded rectangle path
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(containerPanel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(containerPanel.Width - cornerRadius, containerPanel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, containerPanel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Apply the path as the region of the panel
                containerPanel.Region = new Region(path);
            }
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

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 16; // Adjust this to change the roundness

            using (GraphicsPath path = new GraphicsPath())
            {
                // Define rounded rectangle path
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(containerPanel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(containerPanel.Width - cornerRadius, containerPanel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, containerPanel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Apply the path as the region of the panel
                containerPanel.Region = new Region(path);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; // Adjust this to change the roundness

            using (GraphicsPath path = new GraphicsPath())
            {
                // Define rounded rectangle path
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(containerPanel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(containerPanel.Width - cornerRadius, containerPanel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, containerPanel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Apply the path as the region of the panel
                containerPanel.Region = new Region(path);
            }

        }
    }
}
