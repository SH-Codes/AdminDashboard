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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainPanel = new Panel();
            reportsButton = new Button();
            dashboardButton = new Button();
            timeDisplayLabel = new Label();
            inventoryButton = new Button();
            financesButton = new Button();
            containerPanel = new Panel();
            switchPanel = new Panel();
            searchbarRunButton = new Button();
            searchbarTextBox = new TextBox();
            bookingsButton = new Button();
            addMembersButton = new Button();
            viewMembersButton = new Button();
            logoutButton = new Button();
            settingsButton = new Button();
            mainFormTimer = new System.Windows.Forms.Timer(components);
            mainPanel.SuspendLayout();
            containerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = SystemColors.Highlight;
            mainPanel.Controls.Add(reportsButton);
            mainPanel.Controls.Add(dashboardButton);
            mainPanel.Controls.Add(timeDisplayLabel);
            mainPanel.Controls.Add(inventoryButton);
            mainPanel.Controls.Add(financesButton);
            mainPanel.Controls.Add(containerPanel);
            mainPanel.Controls.Add(logoutButton);
            mainPanel.Controls.Add(settingsButton);
            mainPanel.Location = new Point(0, -2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1350, 747);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // reportsButton
            // 
            reportsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            reportsButton.BackColor = SystemColors.Highlight;
            reportsButton.Cursor = Cursors.Hand;
            reportsButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            reportsButton.FlatAppearance.CheckedBackColor = Color.White;
            reportsButton.FlatStyle = FlatStyle.Flat;
            reportsButton.Font = new Font("Segoe UI", 11F);
            reportsButton.ForeColor = Color.White;
            reportsButton.Image = (Image)resources.GetObject("reportsButton.Image");
            reportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            reportsButton.Location = new Point(8, 413);
            reportsButton.Name = "reportsButton";
            reportsButton.Padding = new Padding(15, 0, 0, 0);
            reportsButton.Size = new Size(214, 45);
            reportsButton.TabIndex = 6;
            reportsButton.Tag = "reports";
            reportsButton.Text = "Reports";
            reportsButton.UseVisualStyleBackColor = false;
            reportsButton.Click += reportsButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dashboardButton.BackColor = SystemColors.Highlight;
            dashboardButton.BackgroundImageLayout = ImageLayout.Center;
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            dashboardButton.FlatAppearance.CheckedBackColor = Color.White;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI", 11F);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(8, 195);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(15, 0, 0, 0);
            dashboardButton.Size = new Size(214, 45);
            dashboardButton.TabIndex = 0;
            dashboardButton.Tag = "dashboard";
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // timeDisplayLabel
            // 
            timeDisplayLabel.AutoSize = true;
            timeDisplayLabel.Font = new Font("Segoe UI", 16F);
            timeDisplayLabel.ForeColor = Color.White;
            timeDisplayLabel.Location = new Point(229, 31);
            timeDisplayLabel.Name = "timeDisplayLabel";
            timeDisplayLabel.Size = new Size(256, 30);
            timeDisplayLabel.TabIndex = 5;
            timeDisplayLabel.Text = "DDMMMYYY, HH:MM:SS";
            // 
            // inventoryButton
            // 
            inventoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inventoryButton.BackColor = SystemColors.Highlight;
            inventoryButton.Cursor = Cursors.Hand;
            inventoryButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            inventoryButton.FlatAppearance.CheckedBackColor = Color.White;
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI", 11F);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Image = (Image)resources.GetObject("inventoryButton.Image");
            inventoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryButton.Location = new Point(8, 340);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Padding = new Padding(15, 0, 0, 0);
            inventoryButton.Size = new Size(214, 45);
            inventoryButton.TabIndex = 2;
            inventoryButton.Tag = "inventory";
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // financesButton
            // 
            financesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            financesButton.BackColor = SystemColors.Highlight;
            financesButton.Cursor = Cursors.Hand;
            financesButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            financesButton.FlatAppearance.CheckedBackColor = Color.White;
            financesButton.FlatStyle = FlatStyle.Flat;
            financesButton.Font = new Font("Segoe UI", 11F);
            financesButton.ForeColor = Color.White;
            financesButton.Image = (Image)resources.GetObject("financesButton.Image");
            financesButton.ImageAlign = ContentAlignment.MiddleLeft;
            financesButton.Location = new Point(8, 268);
            financesButton.Name = "financesButton";
            financesButton.Padding = new Padding(15, 0, 0, 0);
            financesButton.Size = new Size(214, 45);
            financesButton.TabIndex = 1;
            financesButton.Tag = "finances";
            financesButton.Text = "Finances";
            financesButton.UseVisualStyleBackColor = false;
            financesButton.Click += financesButton_Click;
            // 
            // containerPanel
            // 
            containerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            containerPanel.BackColor = Color.WhiteSmoke;
            containerPanel.Controls.Add(switchPanel);
            containerPanel.Controls.Add(searchbarRunButton);
            containerPanel.Controls.Add(searchbarTextBox);
            containerPanel.Controls.Add(bookingsButton);
            containerPanel.Controls.Add(addMembersButton);
            containerPanel.Controls.Add(viewMembersButton);
            containerPanel.Location = new Point(229, 85);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1098, 636);
            containerPanel.TabIndex = 0;
            containerPanel.Paint += containerPanel_Paint;
            // 
            // switchPanel
            // 
            switchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            switchPanel.BackColor = Color.White;
            switchPanel.Location = new Point(24, 81);
            switchPanel.Name = "switchPanel";
            switchPanel.Size = new Size(1052, 530);
            switchPanel.TabIndex = 5;
            switchPanel.Paint += switchPanel_Paint;
            // 
            // searchbarRunButton
            // 
            searchbarRunButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchbarRunButton.BackColor = Color.White;
            searchbarRunButton.BackgroundImage = (Image)resources.GetObject("searchbarRunButton.BackgroundImage");
            searchbarRunButton.BackgroundImageLayout = ImageLayout.Center;
            searchbarRunButton.Cursor = Cursors.Hand;
            searchbarRunButton.FlatAppearance.BorderColor = Color.White;
            searchbarRunButton.FlatAppearance.MouseDownBackColor = Color.Snow;
            searchbarRunButton.FlatAppearance.MouseOverBackColor = Color.Snow;
            searchbarRunButton.FlatStyle = FlatStyle.Flat;
            searchbarRunButton.Location = new Point(1040, 26);
            searchbarRunButton.Name = "searchbarRunButton";
            searchbarRunButton.Size = new Size(25, 25);
            searchbarRunButton.TabIndex = 4;
            searchbarRunButton.UseVisualStyleBackColor = false;
            // 
            // searchbarTextBox
            // 
            searchbarTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchbarTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchbarTextBox.Font = new Font("Segoe UI", 11F);
            searchbarTextBox.Location = new Point(592, 25);
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
            bookingsButton.Click += bookingsButton_Click;
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
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logoutButton.BackColor = SystemColors.Highlight;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 11F);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(8, 672);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(15, 0, 0, 0);
            logoutButton.Size = new Size(214, 45);
            logoutButton.TabIndex = 4;
            logoutButton.Tag = "logout";
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            settingsButton.BackColor = SystemColors.Highlight;
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            settingsButton.FlatAppearance.CheckedBackColor = Color.White;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 11F);
            settingsButton.ForeColor = Color.White;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsButton.Location = new Point(8, 598);
            settingsButton.Name = "settingsButton";
            settingsButton.Padding = new Padding(15, 0, 0, 0);
            settingsButton.Size = new Size(214, 45);
            settingsButton.TabIndex = 3;
            settingsButton.Tag = "settings";
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // mainFormTimer
            // 
            mainFormTimer.Tick += mainFormTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1350, 745);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1024, 766);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin System";
            Load += MainForm_Load;
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
        private Button searchbarRunButton;
        private Panel switchPanel;
        private Button inventoryButton;
        private Button financesButton;
        private Button dashboardButton;
        private Button logoutButton;
        private Button settingsButton;
        private Label timeDisplayLabel;
        private System.Windows.Forms.Timer mainFormTimer;
        private Button reportsButton;
    }
}
