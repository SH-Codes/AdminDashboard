namespace AdminDashboard
{
    partial class ViewMembersForm
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
            viewMembersLabel = new Label();
            membersListDataGridView = new DataGridView();
            memberSortyCategoryComboBox = new ComboBox();
            viewMemberSortByLabel = new Label();
            comboBox1 = new ComboBox();
            viewMemberFiltreButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)membersListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // viewMembersLabel
            // 
            viewMembersLabel.AutoSize = true;
            viewMembersLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            viewMembersLabel.Location = new Point(34, 26);
            viewMembersLabel.Name = "viewMembersLabel";
            viewMembersLabel.Size = new Size(265, 47);
            viewMembersLabel.TabIndex = 1;
            viewMembersLabel.Text = "View Members";
            // 
            // membersListDataGridView
            // 
            membersListDataGridView.BackgroundColor = Color.WhiteSmoke;
            membersListDataGridView.BorderStyle = BorderStyle.None;
            membersListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            membersListDataGridView.Location = new Point(37, 106);
            membersListDataGridView.Name = "membersListDataGridView";
            membersListDataGridView.Size = new Size(974, 383);
            membersListDataGridView.TabIndex = 2;
            // 
            // memberSortyCategoryComboBox
            // 
            memberSortyCategoryComboBox.FormattingEnabled = true;
            memberSortyCategoryComboBox.Location = new Point(375, 49);
            memberSortyCategoryComboBox.Name = "memberSortyCategoryComboBox";
            memberSortyCategoryComboBox.Size = new Size(225, 23);
            memberSortyCategoryComboBox.TabIndex = 3;
            memberSortyCategoryComboBox.Text = "Category";
            // 
            // viewMemberSortByLabel
            // 
            viewMemberSortByLabel.AutoSize = true;
            viewMemberSortByLabel.Location = new Point(322, 53);
            viewMemberSortByLabel.Name = "viewMemberSortByLabel";
            viewMemberSortByLabel.Size = new Size(47, 15);
            viewMemberSortByLabel.TabIndex = 4;
            viewMemberSortByLabel.Text = "Sort by:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(662, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 5;
            // 
            // viewMemberFiltreButton
            // 
            viewMemberFiltreButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            viewMemberFiltreButton.Location = new Point(901, 49);
            viewMemberFiltreButton.Name = "viewMemberFiltreButton";
            viewMemberFiltreButton.Size = new Size(110, 24);
            viewMemberFiltreButton.TabIndex = 163;
            viewMemberFiltreButton.Text = "Apply Filtre";
            viewMemberFiltreButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 54);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 164;
            label1.Text = "Criteria:";
            // 
            // ViewMembersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(label1);
            Controls.Add(viewMemberFiltreButton);
            Controls.Add(comboBox1);
            Controls.Add(viewMemberSortByLabel);
            Controls.Add(memberSortyCategoryComboBox);
            Controls.Add(membersListDataGridView);
            Controls.Add(viewMembersLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMembersForm";
            Text = "ViewMembersForm";
            Load += ViewMembersForm_Load;
            ((System.ComponentModel.ISupportInitialize)membersListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label viewMembersLabel;
        private DataGridView membersListDataGridView;
        private ComboBox memberSortyCategoryComboBox;
        private Label viewMemberSortByLabel;
        private ComboBox comboBox1;
        private Button viewMemberFiltreButton;
        private Label label1;
    }
}