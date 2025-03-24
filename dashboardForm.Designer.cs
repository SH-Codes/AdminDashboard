﻿namespace AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            overviewLabel = new Label();
            totalMemberPanel = new Panel();
            totalMembersText = new Label();
            TotalMemberLabel = new Label();
            totalMembersPictureBox = new PictureBox();
            totalFundsPanel = new Panel();
            totalIncomeText = new Label();
            totalIncomeLabel = new Label();
            financeIconPictureBox = new PictureBox();
            monthlyNewMemberTotalpanel = new Panel();
            monthlyMembersText = new Label();
            monthlyMembersLabel = new Label();
            monthlyMembersPictureBox = new PictureBox();
            totalMemberPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalMembersPictureBox).BeginInit();
            totalFundsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)financeIconPictureBox).BeginInit();
            monthlyNewMemberTotalpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monthlyMembersPictureBox).BeginInit();
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
            totalMemberPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            totalMemberPanel.BackColor = SystemColors.GradientInactiveCaption;
            totalMemberPanel.BackgroundImageLayout = ImageLayout.Center;
            totalMemberPanel.Controls.Add(totalMembersText);
            totalMemberPanel.Controls.Add(TotalMemberLabel);
            totalMemberPanel.Controls.Add(totalMembersPictureBox);
            totalMemberPanel.Location = new Point(37, 108);
            totalMemberPanel.Name = "totalMemberPanel";
            totalMemberPanel.Padding = new Padding(15, 0, 0, 0);
            totalMemberPanel.Size = new Size(309, 141);
            totalMemberPanel.TabIndex = 1;
            totalMemberPanel.Paint += totalMemberPanel_Paint;
            // 
            // totalMembersText
            // 
            totalMembersText.AutoSize = true;
            totalMembersText.BackColor = Color.Transparent;
            totalMembersText.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            totalMembersText.Location = new Point(11, 26);
            totalMembersText.Name = "totalMembersText";
            totalMembersText.Size = new Size(105, 62);
            totalMembersText.TabIndex = 4;
            totalMembersText.Text = "000";
            totalMembersText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TotalMemberLabel
            // 
            TotalMemberLabel.AutoSize = true;
            TotalMemberLabel.Font = new Font("Segoe UI", 11F);
            TotalMemberLabel.Location = new Point(18, 96);
            TotalMemberLabel.Name = "TotalMemberLabel";
            TotalMemberLabel.Size = new Size(108, 20);
            TotalMemberLabel.TabIndex = 4;
            TotalMemberLabel.Text = "Total Members";
            // 
            // totalMembersPictureBox
            // 
            totalMembersPictureBox.Image = (Image)resources.GetObject("totalMembersPictureBox.Image");
            totalMembersPictureBox.Location = new Point(170, 8);
            totalMembersPictureBox.Name = "totalMembersPictureBox";
            totalMembersPictureBox.Size = new Size(128, 128);
            totalMembersPictureBox.TabIndex = 0;
            totalMembersPictureBox.TabStop = false;
            // 
            // totalFundsPanel
            // 
            totalFundsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalFundsPanel.BackColor = Color.FromArgb(192, 255, 192);
            totalFundsPanel.Controls.Add(totalIncomeText);
            totalFundsPanel.Controls.Add(totalIncomeLabel);
            totalFundsPanel.Controls.Add(financeIconPictureBox);
            totalFundsPanel.Location = new Point(373, 108);
            totalFundsPanel.Name = "totalFundsPanel";
            totalFundsPanel.Size = new Size(309, 141);
            totalFundsPanel.TabIndex = 2;
            totalFundsPanel.Paint += totalFundsPanel_Paint;
            // 
            // totalIncomeText
            // 
            totalIncomeText.AutoSize = true;
            totalIncomeText.BackColor = Color.Transparent;
            totalIncomeText.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            totalIncomeText.Location = new Point(10, 26);
            totalIncomeText.Name = "totalIncomeText";
            totalIncomeText.Size = new Size(105, 62);
            totalIncomeText.TabIndex = 5;
            totalIncomeText.Text = "000";
            totalIncomeText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalIncomeLabel
            // 
            totalIncomeLabel.AutoSize = true;
            totalIncomeLabel.Font = new Font("Segoe UI", 11F);
            totalIncomeLabel.Location = new Point(18, 96);
            totalIncomeLabel.Name = "totalIncomeLabel";
            totalIncomeLabel.Size = new Size(95, 20);
            totalIncomeLabel.TabIndex = 5;
            totalIncomeLabel.Text = "Total Income";
            // 
            // financeIconPictureBox
            // 
            financeIconPictureBox.Image = (Image)resources.GetObject("financeIconPictureBox.Image");
            financeIconPictureBox.Location = new Point(172, 13);
            financeIconPictureBox.Name = "financeIconPictureBox";
            financeIconPictureBox.Size = new Size(128, 115);
            financeIconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            financeIconPictureBox.TabIndex = 5;
            financeIconPictureBox.TabStop = false;
            // 
            // monthlyNewMemberTotalpanel
            // 
            monthlyNewMemberTotalpanel.BackColor = Color.FromArgb(255, 255, 192);
            monthlyNewMemberTotalpanel.BackgroundImageLayout = ImageLayout.Center;
            monthlyNewMemberTotalpanel.Controls.Add(monthlyMembersText);
            monthlyNewMemberTotalpanel.Controls.Add(monthlyMembersLabel);
            monthlyNewMemberTotalpanel.Controls.Add(monthlyMembersPictureBox);
            monthlyNewMemberTotalpanel.Location = new Point(710, 108);
            monthlyNewMemberTotalpanel.Name = "monthlyNewMemberTotalpanel";
            monthlyNewMemberTotalpanel.Size = new Size(309, 141);
            monthlyNewMemberTotalpanel.TabIndex = 3;
            // 
            // monthlyMembersText
            // 
            monthlyMembersText.AutoSize = true;
            monthlyMembersText.BackColor = Color.Transparent;
            monthlyMembersText.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            monthlyMembersText.Location = new Point(14, 26);
            monthlyMembersText.Name = "monthlyMembersText";
            monthlyMembersText.Size = new Size(105, 62);
            monthlyMembersText.TabIndex = 5;
            monthlyMembersText.Text = "000";
            monthlyMembersText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // monthlyMembersLabel
            // 
            monthlyMembersLabel.AutoSize = true;
            monthlyMembersLabel.Font = new Font("Segoe UI", 11F);
            monthlyMembersLabel.Location = new Point(22, 96);
            monthlyMembersLabel.Name = "monthlyMembersLabel";
            monthlyMembersLabel.Size = new Size(129, 20);
            monthlyMembersLabel.TabIndex = 6;
            monthlyMembersLabel.Text = "Monthly Members";
            // 
            // monthlyMembersPictureBox
            // 
            monthlyMembersPictureBox.Image = (Image)resources.GetObject("monthlyMembersPictureBox.Image");
            monthlyMembersPictureBox.Location = new Point(169, 8);
            monthlyMembersPictureBox.Name = "monthlyMembersPictureBox";
            monthlyMembersPictureBox.Size = new Size(128, 128);
            monthlyMembersPictureBox.TabIndex = 5;
            monthlyMembersPictureBox.TabStop = false;
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
            totalMemberPanel.ResumeLayout(false);
            totalMemberPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalMembersPictureBox).EndInit();
            totalFundsPanel.ResumeLayout(false);
            totalFundsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)financeIconPictureBox).EndInit();
            monthlyNewMemberTotalpanel.ResumeLayout(false);
            monthlyNewMemberTotalpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)monthlyMembersPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label overviewLabel;
        private Panel totalMemberPanel;
        private Panel totalFundsPanel;
        private Panel monthlyNewMemberTotalpanel;
        private PictureBox totalMembersPictureBox;
        private Label TotalMemberLabel;
        private Label totalMembersText;
        private PictureBox financeIconPictureBox;
        private Label totalIncomeLabel;
        private Label totalIncomeText;
        private Label monthlyMembersText;
        private Label monthlyMembersLabel;
        private PictureBox monthlyMembersPictureBox;
    }
}