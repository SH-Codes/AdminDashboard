namespace AdminDashboard
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainPanel = new Panel();
            timeDisplayLabel = new Label();
            logoutButton = new Button();
            settingsButton = new Button();
            reportsButton = new Button();
            financesButton = new Button();
            dashboardButton = new Button();
            containerPanel = new Panel();
            switchPanel = new Panel();
            button1 = new Button();
            searchbarTextBox = new TextBox();
            bookingsButton = new Button();
            addMembersButton = new Button();
            viewMembersButton = new Button();
            mainPanel.SuspendLayout();
            containerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = SystemColors.Highlight;
            mainPanel.Controls.Add(timeDisplayLabel);
            mainPanel.Controls.Add(logoutButton);
            mainPanel.Controls.Add(settingsButton);
            mainPanel.Controls.Add(reportsButton);
            mainPanel.Controls.Add(financesButton);
            mainPanel.Controls.Add(dashboardButton);
            mainPanel.Controls.Add(containerPanel);
            mainPanel.Location = new Point(0, -2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1350, 730);
            mainPanel.TabIndex = 0;
            // 
            // timeDisplayLabel
            // 
            timeDisplayLabel.AutoSize = true;
            timeDisplayLabel.Font = new Font("Segoe UI", 18F);
            timeDisplayLabel.ForeColor = Color.White;
            timeDisplayLabel.Location = new Point(229, 31);
            timeDisplayLabel.Name = "timeDisplayLabel";
            timeDisplayLabel.Size = new Size(279, 32);
            timeDisplayLabel.TabIndex = 5;
            timeDisplayLabel.Text = "DDMMMYYY, HH:MM:SS";
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(0, 659);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(229, 45);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            settingsButton.ForeColor = Color.White;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsButton.Location = new Point(0, 585);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(229, 45);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // reportsButton
            // 
            reportsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            reportsButton.BackColor = SystemColors.Highlight;
            reportsButton.Cursor = Cursors.Hand;
            reportsButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            reportsButton.FlatStyle = FlatStyle.Flat;
            reportsButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            reportsButton.ForeColor = Color.White;
            reportsButton.Image = (Image)resources.GetObject("reportsButton.Image");
            reportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            reportsButton.Location = new Point(0, 392);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new Size(229, 45);
            reportsButton.TabIndex = 2;
            reportsButton.Text = "Reports";
            reportsButton.UseVisualStyleBackColor = false;
            reportsButton.Click += reportsButton_Click;
            // 
            // financesButton
            // 
            financesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            financesButton.BackColor = SystemColors.Highlight;
            financesButton.Cursor = Cursors.Hand;
            financesButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            financesButton.FlatStyle = FlatStyle.Flat;
            financesButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            financesButton.ForeColor = Color.White;
            financesButton.Image = (Image)resources.GetObject("financesButton.Image");
            financesButton.ImageAlign = ContentAlignment.MiddleLeft;
            financesButton.Location = new Point(0, 320);
            financesButton.Name = "financesButton";
            financesButton.Size = new Size(229, 45);
            financesButton.TabIndex = 1;
            financesButton.Text = "Finances";
            financesButton.UseVisualStyleBackColor = false;
            financesButton.Click += financesButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dashboardButton.BackColor = SystemColors.Highlight;
            dashboardButton.BackgroundImageLayout = ImageLayout.Center;
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(0, 247);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(229, 45);
            dashboardButton.TabIndex = 0;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // containerPanel
            // 
            containerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            containerPanel.BackColor = Color.WhiteSmoke;
            containerPanel.Controls.Add(switchPanel);
            containerPanel.Controls.Add(button1);
            containerPanel.Controls.Add(searchbarTextBox);
            containerPanel.Controls.Add(bookingsButton);
            containerPanel.Controls.Add(addMembersButton);
            containerPanel.Controls.Add(viewMembersButton);
            containerPanel.Location = new Point(229, 85);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1098, 619);
            containerPanel.TabIndex = 0;
            // 
            // switchPanel
            // 
            switchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            switchPanel.BackColor = Color.White;
            switchPanel.Location = new Point(24, 81);
            switchPanel.Name = "switchPanel";
            switchPanel.Size = new Size(1052, 513);
            switchPanel.TabIndex = 5;
            switchPanel.Paint += switchPanel_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.Snow;
            button1.FlatAppearance.MouseOverBackColor = Color.Snow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1040, 26);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // searchbarTextBox
            // 
            searchbarTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchbarTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchbarTextBox.Font = new Font("Segoe UI", 11F);
            searchbarTextBox.Location = new Point(584, 25);
            searchbarTextBox.Name = "searchbarTextBox";
            searchbarTextBox.PlaceholderText = "  Search by keyword (eg. Name or Member ID)";
            searchbarTextBox.Size = new Size(484, 27);
            searchbarTextBox.TabIndex = 3;
            // 
            // bookingsButton
            // 
            bookingsButton.Cursor = Cursors.Hand;
            bookingsButton.Location = new Point(348, 24);
            bookingsButton.Name = "bookingsButton";
            bookingsButton.Size = new Size(137, 31);
            bookingsButton.TabIndex = 2;
            bookingsButton.Text = "Bookings";
            bookingsButton.UseVisualStyleBackColor = true;
            // 
            // addMembersButton
            // 
            addMembersButton.Cursor = Cursors.Hand;
            addMembersButton.Location = new Point(189, 24);
            addMembersButton.Name = "addMembersButton";
            addMembersButton.Size = new Size(137, 31);
            addMembersButton.TabIndex = 1;
            addMembersButton.Text = "Add Members";
            addMembersButton.UseVisualStyleBackColor = true;
            addMembersButton.Click += addMembersButton_Click;
            // 
            // viewMembersButton
            // 
            viewMembersButton.Cursor = Cursors.Hand;
            viewMembersButton.Location = new Point(24, 24);
            viewMembersButton.Name = "viewMembersButton";
            viewMembersButton.Size = new Size(137, 31);
            viewMembersButton.TabIndex = 0;
            viewMembersButton.Text = "View Members";
            viewMembersButton.UseVisualStyleBackColor = true;
            viewMembersButton.Click += viewMembersButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 727);
            Controls.Add(mainPanel);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1024, 766);
            Name = "MainForm";
            Text = "Admin System";
            WindowState = FormWindowState.Maximized;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            containerPanel.ResumeLayout(false);
            containerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel containerPanel;
        private Button bookingsButton;
        private Button addMembersButton;
        private Button viewMembersButton;
        private TextBox searchbarTextBox;
        private Button button1;
        private Panel switchPanel;
        private Button reportsButton;
        private Button financesButton;
        private Button dashboardButton;
        private Button logoutButton;
        private Button settingsButton;
        private Label timeDisplayLabel;
    }
}
