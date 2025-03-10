namespace AdminDashboard
{
    partial class DependentsForm
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
            dependentIDTextBox = new TextBox();
            dependentRelationshipLabel = new Label();
            dependentNextButton = new Button();
            dependentPreviousButton = new Button();
            dependentUpdateButton = new Button();
            memberUpdateButton = new Button();
            dependentSaveButton = new Button();
            dependentAddNewButton = new Button();
            dependentRelationshipTextBox = new TextBox();
            memberRaceLabel = new Label();
            attendingSundaySchoolComboBox = new ComboBox();
            dependentGenderLabel = new Label();
            dependentBirthDateTimePicker = new DateTimePicker();
            dependentBirthDateLabel = new Label();
            dependentGenderComboBox = new ComboBox();
            dependentLastNameTextBox = new TextBox();
            dependentLastNameLabel = new Label();
            dependentFirstNameTextBox = new TextBox();
            dependentFirstNameLabel = new Label();
            dependentMembershipNumberLabel = new Label();
            dependentMembershipNumberTextBox = new TextBox();
            dependentIDLabel = new Label();
            dependentsInfoLabel = new Label();
            dependentDeleteButton = new Button();
            SuspendLayout();
            // 
            // dependentIDTextBox
            // 
            dependentIDTextBox.Location = new Point(203, 105);
            dependentIDTextBox.Name = "dependentIDTextBox";
            dependentIDTextBox.Size = new Size(225, 23);
            dependentIDTextBox.TabIndex = 130;
            // 
            // dependentRelationshipLabel
            // 
            dependentRelationshipLabel.AutoSize = true;
            dependentRelationshipLabel.Font = new Font("Segoe UI", 11F);
            dependentRelationshipLabel.Location = new Point(37, 422);
            dependentRelationshipLabel.Name = "dependentRelationshipLabel";
            dependentRelationshipLabel.Size = new Size(94, 20);
            dependentRelationshipLabel.TabIndex = 128;
            dependentRelationshipLabel.Text = "Relationship:";
            // 
            // dependentNextButton
            // 
            dependentNextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dependentNextButton.Location = new Point(914, 421);
            dependentNextButton.Name = "dependentNextButton";
            dependentNextButton.Size = new Size(110, 23);
            dependentNextButton.TabIndex = 127;
            dependentNextButton.Text = "Next";
            dependentNextButton.UseVisualStyleBackColor = true;
            dependentNextButton.Click += dependentNextButton_Click;
            // 
            // dependentPreviousButton
            // 
            dependentPreviousButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dependentPreviousButton.Location = new Point(914, 375);
            dependentPreviousButton.Name = "dependentPreviousButton";
            dependentPreviousButton.Size = new Size(110, 23);
            dependentPreviousButton.TabIndex = 126;
            dependentPreviousButton.Text = "Previous";
            dependentPreviousButton.UseVisualStyleBackColor = true;
            dependentPreviousButton.Click += dependentPreviousButton_Click;
            // 
            // dependentUpdateButton
            // 
            dependentUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dependentUpdateButton.Location = new Point(914, 233);
            dependentUpdateButton.Name = "dependentUpdateButton";
            dependentUpdateButton.Size = new Size(110, 23);
            dependentUpdateButton.TabIndex = 125;
            dependentUpdateButton.Text = "Update";
            dependentUpdateButton.UseVisualStyleBackColor = true;
            // 
            // memberUpdateButton
            // 
            memberUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberUpdateButton.Location = new Point(914, 188);
            memberUpdateButton.Name = "memberUpdateButton";
            memberUpdateButton.Size = new Size(110, 23);
            memberUpdateButton.TabIndex = 124;
            memberUpdateButton.Text = "Clear";
            memberUpdateButton.UseVisualStyleBackColor = true;
            // 
            // dependentSaveButton
            // 
            dependentSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dependentSaveButton.Location = new Point(914, 145);
            dependentSaveButton.Name = "dependentSaveButton";
            dependentSaveButton.Size = new Size(110, 23);
            dependentSaveButton.TabIndex = 123;
            dependentSaveButton.Text = "Save";
            dependentSaveButton.UseVisualStyleBackColor = true;
            // 
            // dependentAddNewButton
            // 
            dependentAddNewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dependentAddNewButton.Location = new Point(914, 107);
            dependentAddNewButton.Name = "dependentAddNewButton";
            dependentAddNewButton.Size = new Size(110, 23);
            dependentAddNewButton.TabIndex = 122;
            dependentAddNewButton.Text = "Add New";
            dependentAddNewButton.UseVisualStyleBackColor = true;
            // 
            // dependentRelationshipTextBox
            // 
            dependentRelationshipTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dependentRelationshipTextBox.Location = new Point(203, 419);
            dependentRelationshipTextBox.Name = "dependentRelationshipTextBox";
            dependentRelationshipTextBox.Size = new Size(225, 23);
            dependentRelationshipTextBox.TabIndex = 113;
            // 
            // memberRaceLabel
            // 
            memberRaceLabel.AutoSize = true;
            memberRaceLabel.Font = new Font("Segoe UI", 11F);
            memberRaceLabel.Location = new Point(37, 375);
            memberRaceLabel.Name = "memberRaceLabel";
            memberRaceLabel.Size = new Size(162, 20);
            memberRaceLabel.TabIndex = 111;
            memberRaceLabel.Text = "Attending Sun. School?";
            // 
            // attendingSundaySchoolComboBox
            // 
            attendingSundaySchoolComboBox.FormattingEnabled = true;
            attendingSundaySchoolComboBox.Items.AddRange(new object[] { "", "Yes", "No" });
            attendingSundaySchoolComboBox.Location = new Point(203, 374);
            attendingSundaySchoolComboBox.Name = "attendingSundaySchoolComboBox";
            attendingSundaySchoolComboBox.Size = new Size(225, 23);
            attendingSundaySchoolComboBox.TabIndex = 110;
            // 
            // dependentGenderLabel
            // 
            dependentGenderLabel.AutoSize = true;
            dependentGenderLabel.Font = new Font("Segoe UI", 11F);
            dependentGenderLabel.Location = new Point(37, 328);
            dependentGenderLabel.Name = "dependentGenderLabel";
            dependentGenderLabel.Size = new Size(60, 20);
            dependentGenderLabel.TabIndex = 109;
            dependentGenderLabel.Text = "Gender:";
            // 
            // dependentBirthDateTimePicker
            // 
            dependentBirthDateTimePicker.Location = new Point(203, 281);
            dependentBirthDateTimePicker.Name = "dependentBirthDateTimePicker";
            dependentBirthDateTimePicker.Size = new Size(225, 23);
            dependentBirthDateTimePicker.TabIndex = 108;
            // 
            // dependentBirthDateLabel
            // 
            dependentBirthDateLabel.AutoSize = true;
            dependentBirthDateLabel.Font = new Font("Segoe UI", 11F);
            dependentBirthDateLabel.Location = new Point(34, 282);
            dependentBirthDateLabel.Name = "dependentBirthDateLabel";
            dependentBirthDateLabel.Size = new Size(79, 20);
            dependentBirthDateLabel.TabIndex = 107;
            dependentBirthDateLabel.Text = "Birth Date:";
            // 
            // dependentGenderComboBox
            // 
            dependentGenderComboBox.FormattingEnabled = true;
            dependentGenderComboBox.Items.AddRange(new object[] { "", "Male", "Female" });
            dependentGenderComboBox.Location = new Point(203, 327);
            dependentGenderComboBox.Name = "dependentGenderComboBox";
            dependentGenderComboBox.Size = new Size(225, 23);
            dependentGenderComboBox.TabIndex = 106;
            // 
            // dependentLastNameTextBox
            // 
            dependentLastNameTextBox.Location = new Point(203, 233);
            dependentLastNameTextBox.Name = "dependentLastNameTextBox";
            dependentLastNameTextBox.Size = new Size(225, 23);
            dependentLastNameTextBox.TabIndex = 105;
            // 
            // dependentLastNameLabel
            // 
            dependentLastNameLabel.AutoSize = true;
            dependentLastNameLabel.Font = new Font("Segoe UI", 11F);
            dependentLastNameLabel.Location = new Point(34, 234);
            dependentLastNameLabel.Name = "dependentLastNameLabel";
            dependentLastNameLabel.Size = new Size(82, 20);
            dependentLastNameLabel.TabIndex = 104;
            dependentLastNameLabel.Text = "Last Name:";
            // 
            // dependentFirstNameTextBox
            // 
            dependentFirstNameTextBox.Location = new Point(203, 188);
            dependentFirstNameTextBox.Name = "dependentFirstNameTextBox";
            dependentFirstNameTextBox.Size = new Size(225, 23);
            dependentFirstNameTextBox.TabIndex = 103;
            // 
            // dependentFirstNameLabel
            // 
            dependentFirstNameLabel.AutoSize = true;
            dependentFirstNameLabel.Font = new Font("Segoe UI", 11F);
            dependentFirstNameLabel.Location = new Point(34, 189);
            dependentFirstNameLabel.Name = "dependentFirstNameLabel";
            dependentFirstNameLabel.Size = new Size(99, 20);
            dependentFirstNameLabel.TabIndex = 102;
            dependentFirstNameLabel.Text = "First Name(s):";
            // 
            // dependentMembershipNumberLabel
            // 
            dependentMembershipNumberLabel.AutoSize = true;
            dependentMembershipNumberLabel.Font = new Font("Segoe UI", 11F);
            dependentMembershipNumberLabel.Location = new Point(34, 144);
            dependentMembershipNumberLabel.Name = "dependentMembershipNumberLabel";
            dependentMembershipNumberLabel.Size = new Size(153, 20);
            dependentMembershipNumberLabel.TabIndex = 101;
            dependentMembershipNumberLabel.Text = "Membership Number:";
            // 
            // dependentMembershipNumberTextBox
            // 
            dependentMembershipNumberTextBox.Location = new Point(203, 143);
            dependentMembershipNumberTextBox.Name = "dependentMembershipNumberTextBox";
            dependentMembershipNumberTextBox.Size = new Size(225, 23);
            dependentMembershipNumberTextBox.TabIndex = 100;
            // 
            // dependentIDLabel
            // 
            dependentIDLabel.AutoSize = true;
            dependentIDLabel.Font = new Font("Segoe UI", 11F);
            dependentIDLabel.Location = new Point(34, 106);
            dependentIDLabel.Name = "dependentIDLabel";
            dependentIDLabel.Size = new Size(105, 20);
            dependentIDLabel.TabIndex = 99;
            dependentIDLabel.Text = "Dependent ID:";
            // 
            // dependentsInfoLabel
            // 
            dependentsInfoLabel.AutoSize = true;
            dependentsInfoLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            dependentsInfoLabel.Location = new Point(29, 26);
            dependentsInfoLabel.Name = "dependentsInfoLabel";
            dependentsInfoLabel.Size = new Size(425, 47);
            dependentsInfoLabel.TabIndex = 98;
            dependentsInfoLabel.Text = "Dependents Information";
            // 
            // dependentDeleteButton
            // 
            dependentDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dependentDeleteButton.Location = new Point(914, 279);
            dependentDeleteButton.Name = "dependentDeleteButton";
            dependentDeleteButton.Size = new Size(110, 23);
            dependentDeleteButton.TabIndex = 131;
            dependentDeleteButton.Text = "Delete";
            dependentDeleteButton.UseVisualStyleBackColor = true;
            // 
            // DependentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 513);
            Controls.Add(dependentDeleteButton);
            Controls.Add(dependentIDTextBox);
            Controls.Add(dependentRelationshipLabel);
            Controls.Add(dependentNextButton);
            Controls.Add(dependentPreviousButton);
            Controls.Add(dependentUpdateButton);
            Controls.Add(memberUpdateButton);
            Controls.Add(dependentSaveButton);
            Controls.Add(dependentAddNewButton);
            Controls.Add(dependentRelationshipTextBox);
            Controls.Add(memberRaceLabel);
            Controls.Add(attendingSundaySchoolComboBox);
            Controls.Add(dependentGenderLabel);
            Controls.Add(dependentBirthDateTimePicker);
            Controls.Add(dependentBirthDateLabel);
            Controls.Add(dependentGenderComboBox);
            Controls.Add(dependentLastNameTextBox);
            Controls.Add(dependentLastNameLabel);
            Controls.Add(dependentFirstNameTextBox);
            Controls.Add(dependentFirstNameLabel);
            Controls.Add(dependentMembershipNumberLabel);
            Controls.Add(dependentMembershipNumberTextBox);
            Controls.Add(dependentIDLabel);
            Controls.Add(dependentsInfoLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DependentsForm";
            Text = "DependentsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox dependentIDTextBox;
        private Label dependentRelationshipLabel;
        private Button dependentNextButton;
        private Button dependentPreviousButton;
        private Button dependentUpdateButton;
        private Button memberUpdateButton;
        private Button dependentSaveButton;
        private Button dependentAddNewButton;
        private TextBox dependentRelationshipTextBox;
        private Label memberRaceLabel;
        private ComboBox attendingSundaySchoolComboBox;
        private Label dependentGenderLabel;
        private DateTimePicker dependentBirthDateTimePicker;
        private Label dependentBirthDateLabel;
        private ComboBox dependentGenderComboBox;
        private TextBox dependentLastNameTextBox;
        private Label dependentLastNameLabel;
        private TextBox dependentFirstNameTextBox;
        private Label dependentFirstNameLabel;
        private Label dependentMembershipNumberLabel;
        private TextBox dependentMembershipNumberTextBox;
        private Label dependentIDLabel;
        private Label dependentsInfoLabel;
        private Button dependentDeleteButton;
    }
}