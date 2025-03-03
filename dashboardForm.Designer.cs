namespace AdminDashboard
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            overviewLabel = new Label();
            totalMemberPanel = new Panel();
            totalFundsPanel = new Panel();
            monthlyNewMemberTotalpanel = new Panel();
            SuspendLayout();
            // 
            // overviewLabel
            // 
            overviewLabel.AutoSize = true;
            overviewLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            overviewLabel.Location = new Point(26, 27);
            overviewLabel.Name = "overviewLabel";
            overviewLabel.Size = new Size(176, 47);
            overviewLabel.TabIndex = 0;
            overviewLabel.Text = "Overview";
            // 
            // totalMemberPanel
            // 
            totalMemberPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            totalMemberPanel.BackColor = SystemColors.GradientInactiveCaption;
            totalMemberPanel.Location = new Point(37, 108);
            totalMemberPanel.Name = "totalMemberPanel";
            totalMemberPanel.Size = new Size(309, 141);
            totalMemberPanel.TabIndex = 1;
            // 
            // totalFundsPanel
            // 
            totalFundsPanel.Anchor = AnchorStyles.Top;
            totalFundsPanel.BackColor = Color.FromArgb(192, 255, 192);
            totalFundsPanel.Location = new Point(373, 108);
            totalFundsPanel.Name = "totalFundsPanel";
            totalFundsPanel.Size = new Size(309, 141);
            totalFundsPanel.TabIndex = 2;
            // 
            // monthlyNewMemberTotalpanel
            // 
            monthlyNewMemberTotalpanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthlyNewMemberTotalpanel.BackColor = Color.FromArgb(255, 255, 192);
            monthlyNewMemberTotalpanel.Location = new Point(710, 108);
            monthlyNewMemberTotalpanel.Name = "monthlyNewMemberTotalpanel";
            monthlyNewMemberTotalpanel.Size = new Size(309, 141);
            monthlyNewMemberTotalpanel.TabIndex = 3;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1052, 513);
            Controls.Add(monthlyNewMemberTotalpanel);
            Controls.Add(totalFundsPanel);
            Controls.Add(totalMemberPanel);
            Controls.Add(overviewLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label overviewLabel;
        private Panel totalMemberPanel;
        private Panel totalFundsPanel;
        private Panel monthlyNewMemberTotalpanel;
    }
}