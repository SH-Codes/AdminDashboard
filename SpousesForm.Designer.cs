namespace AdminDashboard
{
    partial class SpousesForm
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
            spouseEmploymentStatusComboBox = new ComboBox();
            memberEmploymentLabel = new Label();
            spousesNextButton = new Button();
            spousePreviousButton = new Button();
            memberDeleteButton = new Button();
            memberUpdateButton = new Button();
            memberClearButton = new Button();
            spouseSaveButton = new Button();
            spouseReligionLabel = new Label();
            spouseReligionTextBox = new TextBox();
            spouseEmailAddressLabel = new Label();
            spouseEmailAddressTextBox = new TextBox();
            spouseMobileNumberLabel = new Label();
            spouseMobileNumberTextBox = new TextBox();
            spousePhoneNumberLabel = new Label();
            spousePhoneNumberTextBox = new TextBox();
            spouseOccupationTextBox = new TextBox();
            spouseOccupationLabel = new Label();
            memberRaceLabel = new Label();
            spouseRaceComboBox = new ComboBox();
            spouseGenderLabel = new Label();
            spouseBirthDateTimePicker = new DateTimePicker();
            spouseBirthDateLabel = new Label();
            spouseGenderComboBox = new ComboBox();
            spouseMaidenNameTextBox = new TextBox();
            spouseMaidenNameLabel = new Label();
            spouseFirstNameTextBox = new TextBox();
            spouseFirstNameLabel = new Label();
            spouseMembershipNumberLabel = new Label();
            spouseMembershipNumberTextBox = new TextBox();
            spouseIDLabel = new Label();
            spouseInfoLabel = new Label();
            spouseIDTextBox = new TextBox();
            spouseLastNameTextBox = new TextBox();
            spouseLastNameLabel = new Label();
            SuspendLayout();
            // 
            // spouseEmploymentStatusComboBox
            // 
            spouseEmploymentStatusComboBox.FormattingEnabled = true;
            spouseEmploymentStatusComboBox.Items.AddRange(new object[] { "", "Unemployed", "Employed", "Self-Employed", "Pensioner", "Student" });
            spouseEmploymentStatusComboBox.Location = new Point(192, 463);
            spouseEmploymentStatusComboBox.Name = "spouseEmploymentStatusComboBox";
            spouseEmploymentStatusComboBox.Size = new Size(225, 23);
            spouseEmploymentStatusComboBox.TabIndex = 94;
            spouseEmploymentStatusComboBox.Validating += spouseEmploymentStatusComboBox_Validating;
            // 
            // memberEmploymentLabel
            // 
            memberEmploymentLabel.AutoSize = true;
            memberEmploymentLabel.Font = new Font("Segoe UI", 11F);
            memberEmploymentLabel.Location = new Point(37, 464);
            memberEmploymentLabel.Name = "memberEmploymentLabel";
            memberEmploymentLabel.Size = new Size(140, 20);
            memberEmploymentLabel.TabIndex = 93;
            memberEmploymentLabel.Text = "Employment Status:";
            // 
            // spousesNextButton
            // 
            spousesNextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spousesNextButton.Location = new Point(914, 461);
            spousesNextButton.Name = "spousesNextButton";
            spousesNextButton.Size = new Size(110, 23);
            spousesNextButton.TabIndex = 92;
            spousesNextButton.Text = "Next";
            spousesNextButton.UseVisualStyleBackColor = true;
            spousesNextButton.Click += memberNextButton_Click;
            // 
            // spousePreviousButton
            // 
            spousePreviousButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spousePreviousButton.Location = new Point(914, 415);
            spousePreviousButton.Name = "spousePreviousButton";
            spousePreviousButton.Size = new Size(110, 23);
            spousePreviousButton.TabIndex = 91;
            spousePreviousButton.Text = "Previous";
            spousePreviousButton.UseVisualStyleBackColor = true;
            spousePreviousButton.Click += spousePreviousButton_Click;
            // 
            // memberDeleteButton
            // 
            memberDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberDeleteButton.Location = new Point(914, 233);
            memberDeleteButton.Name = "memberDeleteButton";
            memberDeleteButton.Size = new Size(110, 23);
            memberDeleteButton.TabIndex = 89;
            memberDeleteButton.Text = "Delete";
            memberDeleteButton.UseVisualStyleBackColor = true;
            // 
            // memberUpdateButton
            // 
            memberUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberUpdateButton.Location = new Point(914, 188);
            memberUpdateButton.Name = "memberUpdateButton";
            memberUpdateButton.Size = new Size(110, 23);
            memberUpdateButton.TabIndex = 88;
            memberUpdateButton.Text = "Update";
            memberUpdateButton.UseVisualStyleBackColor = true;
            // 
            // memberClearButton
            // 
            memberClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            memberClearButton.Location = new Point(914, 145);
            memberClearButton.Name = "memberClearButton";
            memberClearButton.Size = new Size(110, 23);
            memberClearButton.TabIndex = 87;
            memberClearButton.Text = "Clear";
            memberClearButton.UseVisualStyleBackColor = true;
            // 
            // spouseSaveButton
            // 
            spouseSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            spouseSaveButton.Location = new Point(914, 107);
            spouseSaveButton.Name = "spouseSaveButton";
            spouseSaveButton.Size = new Size(110, 23);
            spouseSaveButton.TabIndex = 86;
            spouseSaveButton.Text = "Save";
            spouseSaveButton.UseVisualStyleBackColor = true;
            spouseSaveButton.Click += spouseSaveButton_Click;
            // 
            // spouseReligionLabel
            // 
            spouseReligionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseReligionLabel.AutoSize = true;
            spouseReligionLabel.Font = new Font("Segoe UI", 11F);
            spouseReligionLabel.Location = new Point(533, 281);
            spouseReligionLabel.Name = "spouseReligionLabel";
            spouseReligionLabel.Size = new Size(119, 20);
            spouseReligionLabel.TabIndex = 79;
            spouseReligionLabel.Text = "Spouse Religion:";
            // 
            // spouseReligionTextBox
            // 
            spouseReligionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseReligionTextBox.Location = new Point(654, 280);
            spouseReligionTextBox.Name = "spouseReligionTextBox";
            spouseReligionTextBox.Size = new Size(225, 23);
            spouseReligionTextBox.TabIndex = 78;
            spouseReligionTextBox.Validating += spouseReligionTextBox_Validating;
            // 
            // spouseEmailAddressLabel
            // 
            spouseEmailAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseEmailAddressLabel.AutoSize = true;
            spouseEmailAddressLabel.Font = new Font("Segoe UI", 11F);
            spouseEmailAddressLabel.Location = new Point(533, 234);
            spouseEmailAddressLabel.Name = "spouseEmailAddressLabel";
            spouseEmailAddressLabel.Size = new Size(106, 20);
            spouseEmailAddressLabel.TabIndex = 77;
            spouseEmailAddressLabel.Text = "Email Address:";
            // 
            // spouseEmailAddressTextBox
            // 
            spouseEmailAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseEmailAddressTextBox.Location = new Point(654, 233);
            spouseEmailAddressTextBox.Name = "spouseEmailAddressTextBox";
            spouseEmailAddressTextBox.Size = new Size(225, 23);
            spouseEmailAddressTextBox.TabIndex = 76;
            spouseEmailAddressTextBox.Validating += spouseEmailAddressTextBox_Validating;
            // 
            // spouseMobileNumberLabel
            // 
            spouseMobileNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseMobileNumberLabel.AutoSize = true;
            spouseMobileNumberLabel.Font = new Font("Segoe UI", 11F);
            spouseMobileNumberLabel.Location = new Point(528, 189);
            spouseMobileNumberLabel.Name = "spouseMobileNumberLabel";
            spouseMobileNumberLabel.Size = new Size(117, 20);
            spouseMobileNumberLabel.TabIndex = 75;
            spouseMobileNumberLabel.Text = "Mobile Number:";
            // 
            // spouseMobileNumberTextBox
            // 
            spouseMobileNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseMobileNumberTextBox.Location = new Point(654, 188);
            spouseMobileNumberTextBox.Name = "spouseMobileNumberTextBox";
            spouseMobileNumberTextBox.Size = new Size(225, 23);
            spouseMobileNumberTextBox.TabIndex = 74;
            spouseMobileNumberTextBox.Validating += spouseMobileNumberTextBox_Validating;
            // 
            // spousePhoneNumberLabel
            // 
            spousePhoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spousePhoneNumberLabel.AutoSize = true;
            spousePhoneNumberLabel.Font = new Font("Segoe UI", 11F);
            spousePhoneNumberLabel.Location = new Point(528, 144);
            spousePhoneNumberLabel.Name = "spousePhoneNumberLabel";
            spousePhoneNumberLabel.Size = new Size(111, 20);
            spousePhoneNumberLabel.TabIndex = 73;
            spousePhoneNumberLabel.Text = "Phone Number:";
            // 
            // spousePhoneNumberTextBox
            // 
            spousePhoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spousePhoneNumberTextBox.Location = new Point(654, 143);
            spousePhoneNumberTextBox.Name = "spousePhoneNumberTextBox";
            spousePhoneNumberTextBox.Size = new Size(225, 23);
            spousePhoneNumberTextBox.TabIndex = 72;
            spousePhoneNumberTextBox.Validating += spousePhoneNumberTextBox_Validating;
            // 
            // spouseOccupationTextBox
            // 
            spouseOccupationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseOccupationTextBox.Location = new Point(654, 105);
            spouseOccupationTextBox.Name = "spouseOccupationTextBox";
            spouseOccupationTextBox.Size = new Size(225, 23);
            spouseOccupationTextBox.TabIndex = 71;
            spouseOccupationTextBox.Validating += spouseOccupationtextBox_Validating;
            // 
            // spouseOccupationLabel
            // 
            spouseOccupationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spouseOccupationLabel.AutoSize = true;
            spouseOccupationLabel.Font = new Font("Segoe UI", 11F);
            spouseOccupationLabel.Location = new Point(528, 106);
            spouseOccupationLabel.Name = "spouseOccupationLabel";
            spouseOccupationLabel.Size = new Size(88, 20);
            spouseOccupationLabel.TabIndex = 70;
            spouseOccupationLabel.Text = "Occupation:";
            // 
            // memberRaceLabel
            // 
            memberRaceLabel.AutoSize = true;
            memberRaceLabel.Font = new Font("Segoe UI", 11F);
            memberRaceLabel.Location = new Point(37, 417);
            memberRaceLabel.Name = "memberRaceLabel";
            memberRaceLabel.Size = new Size(41, 20);
            memberRaceLabel.TabIndex = 65;
            memberRaceLabel.Text = "Race";
            // 
            // spouseRaceComboBox
            // 
            spouseRaceComboBox.FormattingEnabled = true;
            spouseRaceComboBox.Items.AddRange(new object[] { "", "Black", "Colour", "Indian", "White", "Other" });
            spouseRaceComboBox.Location = new Point(192, 416);
            spouseRaceComboBox.Name = "spouseRaceComboBox";
            spouseRaceComboBox.Size = new Size(225, 23);
            spouseRaceComboBox.TabIndex = 64;
            spouseRaceComboBox.Validating += spouseRaceComboBox_Validating;
            // 
            // spouseGenderLabel
            // 
            spouseGenderLabel.AutoSize = true;
            spouseGenderLabel.Font = new Font("Segoe UI", 11F);
            spouseGenderLabel.Location = new Point(37, 370);
            spouseGenderLabel.Name = "spouseGenderLabel";
            spouseGenderLabel.Size = new Size(60, 20);
            spouseGenderLabel.TabIndex = 63;
            spouseGenderLabel.Text = "Gender:";
            // 
            // spouseBirthDateTimePicker
            // 
            spouseBirthDateTimePicker.Location = new Point(192, 323);
            spouseBirthDateTimePicker.Name = "spouseBirthDateTimePicker";
            spouseBirthDateTimePicker.Size = new Size(225, 23);
            spouseBirthDateTimePicker.TabIndex = 62;
            spouseBirthDateTimePicker.ValueChanged += spouseBirthDateTimePicker_ValueChanged;
            // 
            // spouseBirthDateLabel
            // 
            spouseBirthDateLabel.AutoSize = true;
            spouseBirthDateLabel.Font = new Font("Segoe UI", 11F);
            spouseBirthDateLabel.Location = new Point(34, 324);
            spouseBirthDateLabel.Name = "spouseBirthDateLabel";
            spouseBirthDateLabel.Size = new Size(79, 20);
            spouseBirthDateLabel.TabIndex = 61;
            spouseBirthDateLabel.Text = "Birth Date:";
            // 
            // spouseGenderComboBox
            // 
            spouseGenderComboBox.FormattingEnabled = true;
            spouseGenderComboBox.Items.AddRange(new object[] { "", "Male", "Female" });
            spouseGenderComboBox.Location = new Point(192, 369);
            spouseGenderComboBox.Name = "spouseGenderComboBox";
            spouseGenderComboBox.Size = new Size(225, 23);
            spouseGenderComboBox.TabIndex = 60;
            spouseGenderComboBox.Validating += spouseLastNameTextBox_Validating;
            // 
            // spouseMaidenNameTextBox
            // 
            spouseMaidenNameTextBox.Location = new Point(192, 233);
            spouseMaidenNameTextBox.Name = "spouseMaidenNameTextBox";
            spouseMaidenNameTextBox.Size = new Size(225, 23);
            spouseMaidenNameTextBox.TabIndex = 59;
            spouseMaidenNameTextBox.Validating += spouseMaidenNameTextBox_Validating;
            // 
            // spouseMaidenNameLabel
            // 
            spouseMaidenNameLabel.AutoSize = true;
            spouseMaidenNameLabel.Font = new Font("Segoe UI", 11F);
            spouseMaidenNameLabel.Location = new Point(34, 234);
            spouseMaidenNameLabel.Name = "spouseMaidenNameLabel";
            spouseMaidenNameLabel.Size = new Size(106, 20);
            spouseMaidenNameLabel.TabIndex = 58;
            spouseMaidenNameLabel.Text = "Maiden Name:";
            // 
            // spouseFirstNameTextBox
            // 
            spouseFirstNameTextBox.Location = new Point(192, 188);
            spouseFirstNameTextBox.Name = "spouseFirstNameTextBox";
            spouseFirstNameTextBox.Size = new Size(225, 23);
            spouseFirstNameTextBox.TabIndex = 57;
            spouseFirstNameTextBox.Validating += spouseFirstNameTextBox_Validating;
            // 
            // spouseFirstNameLabel
            // 
            spouseFirstNameLabel.AutoSize = true;
            spouseFirstNameLabel.Font = new Font("Segoe UI", 11F);
            spouseFirstNameLabel.Location = new Point(34, 189);
            spouseFirstNameLabel.Name = "spouseFirstNameLabel";
            spouseFirstNameLabel.Size = new Size(99, 20);
            spouseFirstNameLabel.TabIndex = 56;
            spouseFirstNameLabel.Text = "First Name(s):";
            // 
            // spouseMembershipNumberLabel
            // 
            spouseMembershipNumberLabel.AutoSize = true;
            spouseMembershipNumberLabel.Font = new Font("Segoe UI", 11F);
            spouseMembershipNumberLabel.Location = new Point(34, 144);
            spouseMembershipNumberLabel.Name = "spouseMembershipNumberLabel";
            spouseMembershipNumberLabel.Size = new Size(153, 20);
            spouseMembershipNumberLabel.TabIndex = 55;
            spouseMembershipNumberLabel.Text = "Membership Number:";
            // 
            // spouseMembershipNumberTextBox
            // 
            spouseMembershipNumberTextBox.Location = new Point(192, 143);
            spouseMembershipNumberTextBox.Name = "spouseMembershipNumberTextBox";
            spouseMembershipNumberTextBox.ReadOnly = true;
            spouseMembershipNumberTextBox.Size = new Size(225, 23);
            spouseMembershipNumberTextBox.TabIndex = 53;
            // 
            // spouseIDLabel
            // 
            spouseIDLabel.AutoSize = true;
            spouseIDLabel.Font = new Font("Segoe UI", 11F);
            spouseIDLabel.Location = new Point(34, 106);
            spouseIDLabel.Name = "spouseIDLabel";
            spouseIDLabel.Size = new Size(79, 20);
            spouseIDLabel.TabIndex = 52;
            spouseIDLabel.Text = "Spouse ID:";
            // 
            // spouseInfoLabel
            // 
            spouseInfoLabel.AutoSize = true;
            spouseInfoLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            spouseInfoLabel.Location = new Point(29, 26);
            spouseInfoLabel.Name = "spouseInfoLabel";
            spouseInfoLabel.Size = new Size(355, 47);
            spouseInfoLabel.TabIndex = 51;
            spouseInfoLabel.Text = "Spousal Information";
            // 
            // spouseIDTextBox
            // 
            spouseIDTextBox.Location = new Point(192, 105);
            spouseIDTextBox.Name = "spouseIDTextBox";
            spouseIDTextBox.ReadOnly = true;
            spouseIDTextBox.Size = new Size(225, 23);
            spouseIDTextBox.TabIndex = 95;
            // 
            // spouseLastNameTextBox
            // 
            spouseLastNameTextBox.Location = new Point(192, 280);
            spouseLastNameTextBox.Name = "spouseLastNameTextBox";
            spouseLastNameTextBox.Size = new Size(225, 23);
            spouseLastNameTextBox.TabIndex = 97;
            spouseLastNameTextBox.Validating += spouseLastNameTextBox_Validating;
            // 
            // spouseLastNameLabel
            // 
            spouseLastNameLabel.AutoSize = true;
            spouseLastNameLabel.Font = new Font("Segoe UI", 11F);
            spouseLastNameLabel.Location = new Point(34, 281);
            spouseLastNameLabel.Name = "spouseLastNameLabel";
            spouseLastNameLabel.Size = new Size(82, 20);
            spouseLastNameLabel.TabIndex = 96;
            spouseLastNameLabel.Text = "Last Name:";
            // 
            // SpousesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 513);
            Controls.Add(spouseLastNameTextBox);
            Controls.Add(spouseLastNameLabel);
            Controls.Add(spouseIDTextBox);
            Controls.Add(spouseEmploymentStatusComboBox);
            Controls.Add(memberEmploymentLabel);
            Controls.Add(spousesNextButton);
            Controls.Add(spousePreviousButton);
            Controls.Add(memberDeleteButton);
            Controls.Add(memberUpdateButton);
            Controls.Add(memberClearButton);
            Controls.Add(spouseSaveButton);
            Controls.Add(spouseReligionLabel);
            Controls.Add(spouseReligionTextBox);
            Controls.Add(spouseEmailAddressLabel);
            Controls.Add(spouseEmailAddressTextBox);
            Controls.Add(spouseMobileNumberLabel);
            Controls.Add(spouseMobileNumberTextBox);
            Controls.Add(spousePhoneNumberLabel);
            Controls.Add(spousePhoneNumberTextBox);
            Controls.Add(spouseOccupationTextBox);
            Controls.Add(spouseOccupationLabel);
            Controls.Add(memberRaceLabel);
            Controls.Add(spouseRaceComboBox);
            Controls.Add(spouseGenderLabel);
            Controls.Add(spouseBirthDateTimePicker);
            Controls.Add(spouseBirthDateLabel);
            Controls.Add(spouseGenderComboBox);
            Controls.Add(spouseMaidenNameTextBox);
            Controls.Add(spouseMaidenNameLabel);
            Controls.Add(spouseFirstNameTextBox);
            Controls.Add(spouseFirstNameLabel);
            Controls.Add(spouseMembershipNumberLabel);
            Controls.Add(spouseMembershipNumberTextBox);
            Controls.Add(spouseIDLabel);
            Controls.Add(spouseInfoLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SpousesForm";
            Text = "SpousesForm";
            Load += SpousesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox spouseEmploymentStatusComboBox;
        private Label memberEmploymentLabel;
        private Button spousesNextButton;
        private Button spousePreviousButton;
        private Button memberDeleteButton;
        private Button memberUpdateButton;
        private Button memberClearButton;
        private Button spouseSaveButton;
        private Label spouseReligionLabel;
        private TextBox spouseReligionTextBox;
        private Label spouseEmailAddressLabel;
        private TextBox spouseEmailAddressTextBox;
        private Label spouseMobileNumberLabel;
        private TextBox spouseMobileNumberTextBox;
        private Label spousePhoneNumberLabel;
        private TextBox spousePhoneNumberTextBox;
        private TextBox spouseOccupationTextBox;
        private Label spouseOccupationLabel;
        private Label memberRaceLabel;
        private ComboBox spouseRaceComboBox;
        private Label spouseGenderLabel;
        private DateTimePicker spouseBirthDateTimePicker;
        private Label spouseBirthDateLabel;
        private ComboBox spouseGenderComboBox;
        private TextBox spouseMaidenNameTextBox;
        private Label spouseMaidenNameLabel;
        private TextBox spouseFirstNameTextBox;
        private Label spouseFirstNameLabel;
        private Label spouseMembershipNumberLabel;
        private TextBox spouseMembershipNumberTextBox;
        private Label spouseIDLabel;
        private Label spouseInfoLabel;
        private TextBox spouseIDTextBox;
        private TextBox spouseLastNameTextBox;
        private Label spouseLastNameLabel;
    }
}