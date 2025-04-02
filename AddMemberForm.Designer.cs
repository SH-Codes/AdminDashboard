namespace AdminDashboard
{
    partial class AddMemberForm
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
            memberFirstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            membershipNumberLabel = new Label();
            registrationDateTimePicker = new DateTimePicker();
            membershipNumberTextBox = new TextBox();
            registrationDateLabel = new Label();
            AddNewMemberLabel = new Label();
            memberLastNameLabel = new Label();
            memberGenderComboBox = new ComboBox();
            birthDateLabel = new Label();
            birthDateTimePicker = new DateTimePicker();
            memberGenderLabel = new Label();
            memberRaceComboBox = new ComboBox();
            memberRaceLabel = new Label();
            memberMaritalStatusLabel = new Label();
            memberMaritalStatusComboBox = new ComboBox();
            membershipSatusLabel = new Label();
            memberStatusComboBox = new ComboBox();
            memberOccupationLabel = new Label();
            memberOccupationTextBox = new TextBox();
            memberPhoneNumberTextBox = new TextBox();
            memberPhoneNumberLabel = new Label();
            memberMobileNumberTextBox = new TextBox();
            memberMobileNumberLabel = new Label();
            memberEmailAddressTextBox = new TextBox();
            memberEmailAddressLabel = new Label();
            addressLine1TextBox = new TextBox();
            addressLine1Label = new Label();
            addressLine2TextBox = new TextBox();
            addressLine2Label = new Label();
            zoneAreaTextBox = new TextBox();
            zoneAreaLabel = new Label();
            postalCodeTextBox = new TextBox();
            postalCodeLabel = new Label();
            memberSaveButton = new Button();
            memberClearButton = new Button();
            memberUpdateButton = new Button();
            memberDeleteButton = new Button();
            viewFileButton = new Button();
            makePaymentButton = new Button();
            memberNextButton = new Button();
            memberTitleComboBox = new ComboBox();
            memberTitleLabel = new Label();
            memberLastNameTextBox = new TextBox();
            memberEmploymentStatusComboBox = new ComboBox();
            memberEmploymentStatusLabel = new Label();
            SuspendLayout();
            // 
            // memberFirstNameTextBox
            // 
            memberFirstNameTextBox.Location = new Point(187, 226);
            memberFirstNameTextBox.Name = "memberFirstNameTextBox";
            memberFirstNameTextBox.Size = new Size(225, 23);
            memberFirstNameTextBox.TabIndex = 13;
            memberFirstNameTextBox.Validating += memberFirstNameTextBox_Validating;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 11F);
            firstNameLabel.Location = new Point(29, 227);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(99, 20);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name(s):";
            // 
            // membershipNumberLabel
            // 
            membershipNumberLabel.AutoSize = true;
            membershipNumberLabel.Font = new Font("Segoe UI", 11F);
            membershipNumberLabel.Location = new Point(29, 139);
            membershipNumberLabel.Name = "membershipNumberLabel";
            membershipNumberLabel.Size = new Size(153, 20);
            membershipNumberLabel.TabIndex = 11;
            membershipNumberLabel.Text = "Membership Number:";
            // 
            // registrationDateTimePicker
            // 
            registrationDateTimePicker.Location = new Point(187, 100);
            registrationDateTimePicker.Name = "registrationDateTimePicker";
            registrationDateTimePicker.Size = new Size(225, 23);
            registrationDateTimePicker.TabIndex = 10;
            registrationDateTimePicker.ValueChanged += registrationDateTimePicker_ValueChanged;
            // 
            // membershipNumberTextBox
            // 
            membershipNumberTextBox.Location = new Point(187, 138);
            membershipNumberTextBox.Name = "membershipNumberTextBox";
            membershipNumberTextBox.ReadOnly = true;
            membershipNumberTextBox.Size = new Size(225, 23);
            membershipNumberTextBox.TabIndex = 9;
            membershipNumberTextBox.TextChanged += membershipNumberTextBox_TextChanged;
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Font = new Font("Segoe UI", 11F);
            registrationDateLabel.Location = new Point(29, 101);
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new Size(128, 20);
            registrationDateLabel.TabIndex = 8;
            registrationDateLabel.Text = "Registration Date:";
            // 
            // AddNewMemberLabel
            // 
            AddNewMemberLabel.AutoSize = true;
            AddNewMemberLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            AddNewMemberLabel.Location = new Point(24, 21);
            AddNewMemberLabel.Name = "AddNewMemberLabel";
            AddNewMemberLabel.Size = new Size(367, 47);
            AddNewMemberLabel.TabIndex = 7;
            AddNewMemberLabel.Text = "Member Information";
            // 
            // memberLastNameLabel
            // 
            memberLastNameLabel.AutoSize = true;
            memberLastNameLabel.Font = new Font("Segoe UI", 11F);
            memberLastNameLabel.Location = new Point(29, 272);
            memberLastNameLabel.Name = "memberLastNameLabel";
            memberLastNameLabel.Size = new Size(82, 20);
            memberLastNameLabel.TabIndex = 14;
            memberLastNameLabel.Text = "Last Name:";
            // 
            // memberGenderComboBox
            // 
            memberGenderComboBox.FormattingEnabled = true;
            memberGenderComboBox.Items.AddRange(new object[] { "", "Male", "Female" });
            memberGenderComboBox.Location = new Point(187, 364);
            memberGenderComboBox.Name = "memberGenderComboBox";
            memberGenderComboBox.Size = new Size(225, 23);
            memberGenderComboBox.TabIndex = 16;
            memberGenderComboBox.Validating += memberGenderComboBox_Validating;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new Font("Segoe UI", 11F);
            birthDateLabel.Location = new Point(29, 319);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(79, 20);
            birthDateLabel.TabIndex = 17;
            birthDateLabel.Text = "Birth Date:";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(187, 318);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(225, 23);
            birthDateTimePicker.TabIndex = 18;
            birthDateTimePicker.ValueChanged += birthDateTimePicker_ValueChanged;
            // 
            // memberGenderLabel
            // 
            memberGenderLabel.AutoSize = true;
            memberGenderLabel.Font = new Font("Segoe UI", 11F);
            memberGenderLabel.Location = new Point(29, 365);
            memberGenderLabel.Name = "memberGenderLabel";
            memberGenderLabel.Size = new Size(60, 20);
            memberGenderLabel.TabIndex = 19;
            memberGenderLabel.Text = "Gender:";
            // 
            // memberRaceComboBox
            // 
            memberRaceComboBox.FormattingEnabled = true;
            memberRaceComboBox.Items.AddRange(new object[] { "", "Black", "Colour", "Indian", "White", "Other" });
            memberRaceComboBox.Location = new Point(187, 411);
            memberRaceComboBox.Name = "memberRaceComboBox";
            memberRaceComboBox.Size = new Size(225, 23);
            memberRaceComboBox.TabIndex = 20;
            memberRaceComboBox.Validating += memberRaceComboBox_Validating;
            // 
            // memberRaceLabel
            // 
            memberRaceLabel.AutoSize = true;
            memberRaceLabel.Font = new Font("Segoe UI", 11F);
            memberRaceLabel.Location = new Point(29, 412);
            memberRaceLabel.Name = "memberRaceLabel";
            memberRaceLabel.Size = new Size(41, 20);
            memberRaceLabel.TabIndex = 21;
            memberRaceLabel.Text = "Race";
            // 
            // memberMaritalStatusLabel
            // 
            memberMaritalStatusLabel.AutoSize = true;
            memberMaritalStatusLabel.Font = new Font("Segoe UI", 11F);
            memberMaritalStatusLabel.Location = new Point(29, 460);
            memberMaritalStatusLabel.Name = "memberMaritalStatusLabel";
            memberMaritalStatusLabel.Size = new Size(103, 20);
            memberMaritalStatusLabel.TabIndex = 22;
            memberMaritalStatusLabel.Text = "Marital Status:";
            // 
            // memberMaritalStatusComboBox
            // 
            memberMaritalStatusComboBox.FormattingEnabled = true;
            memberMaritalStatusComboBox.Items.AddRange(new object[] { "", "Single", "Married", "Devorced", "Separated", "Widowed" });
            memberMaritalStatusComboBox.Location = new Point(187, 459);
            memberMaritalStatusComboBox.Name = "memberMaritalStatusComboBox";
            memberMaritalStatusComboBox.Size = new Size(225, 23);
            memberMaritalStatusComboBox.TabIndex = 23;
            memberMaritalStatusComboBox.Validating += memberMaritalStatusComboBox_Validating;
            // 
            // membershipSatusLabel
            // 
            membershipSatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            membershipSatusLabel.AutoSize = true;
            membershipSatusLabel.Font = new Font("Segoe UI", 11F);
            membershipSatusLabel.Location = new Point(699, 44);
            membershipSatusLabel.Name = "membershipSatusLabel";
            membershipSatusLabel.Size = new Size(139, 20);
            membershipSatusLabel.TabIndex = 24;
            membershipSatusLabel.Text = "Membership Status:";
            // 
            // memberStatusComboBox
            // 
            memberStatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberStatusComboBox.FormattingEnabled = true;
            memberStatusComboBox.Items.AddRange(new object[] { "Active", "Inactive", "Deceased" });
            memberStatusComboBox.Location = new Point(844, 44);
            memberStatusComboBox.Name = "memberStatusComboBox";
            memberStatusComboBox.Size = new Size(175, 23);
            memberStatusComboBox.TabIndex = 25;
            memberStatusComboBox.SelectedIndexChanged += memberStatusComboBox_SelectedIndexChanged;
            // 
            // memberOccupationLabel
            // 
            memberOccupationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberOccupationLabel.AutoSize = true;
            memberOccupationLabel.Font = new Font("Segoe UI", 11F);
            memberOccupationLabel.Location = new Point(509, 148);
            memberOccupationLabel.Name = "memberOccupationLabel";
            memberOccupationLabel.Size = new Size(88, 20);
            memberOccupationLabel.TabIndex = 26;
            memberOccupationLabel.Text = "Occupation:";
            // 
            // memberOccupationTextBox
            // 
            memberOccupationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberOccupationTextBox.Location = new Point(657, 145);
            memberOccupationTextBox.Name = "memberOccupationTextBox";
            memberOccupationTextBox.Size = new Size(225, 23);
            memberOccupationTextBox.TabIndex = 27;
            memberOccupationTextBox.Validating += memberOccupationTextBox_Validating;
            // 
            // memberPhoneNumberTextBox
            // 
            memberPhoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberPhoneNumberTextBox.Location = new Point(657, 183);
            memberPhoneNumberTextBox.Name = "memberPhoneNumberTextBox";
            memberPhoneNumberTextBox.Size = new Size(225, 23);
            memberPhoneNumberTextBox.TabIndex = 28;
            memberPhoneNumberTextBox.Validating += memberPhoneNumberTextBox_Validating;
            // 
            // memberPhoneNumberLabel
            // 
            memberPhoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberPhoneNumberLabel.AutoSize = true;
            memberPhoneNumberLabel.Font = new Font("Segoe UI", 11F);
            memberPhoneNumberLabel.Location = new Point(509, 184);
            memberPhoneNumberLabel.Name = "memberPhoneNumberLabel";
            memberPhoneNumberLabel.Size = new Size(111, 20);
            memberPhoneNumberLabel.TabIndex = 29;
            memberPhoneNumberLabel.Text = "Phone Number:";
            // 
            // memberMobileNumberTextBox
            // 
            memberMobileNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberMobileNumberTextBox.Location = new Point(657, 228);
            memberMobileNumberTextBox.Name = "memberMobileNumberTextBox";
            memberMobileNumberTextBox.Size = new Size(225, 23);
            memberMobileNumberTextBox.TabIndex = 30;
            memberMobileNumberTextBox.Validating += memberMobileNumberTextBox_Validating;
            // 
            // memberMobileNumberLabel
            // 
            memberMobileNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberMobileNumberLabel.AutoSize = true;
            memberMobileNumberLabel.Font = new Font("Segoe UI", 11F);
            memberMobileNumberLabel.Location = new Point(509, 229);
            memberMobileNumberLabel.Name = "memberMobileNumberLabel";
            memberMobileNumberLabel.Size = new Size(117, 20);
            memberMobileNumberLabel.TabIndex = 31;
            memberMobileNumberLabel.Text = "Mobile Number:";
            // 
            // memberEmailAddressTextBox
            // 
            memberEmailAddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberEmailAddressTextBox.Location = new Point(657, 273);
            memberEmailAddressTextBox.Name = "memberEmailAddressTextBox";
            memberEmailAddressTextBox.Size = new Size(225, 23);
            memberEmailAddressTextBox.TabIndex = 32;
            memberEmailAddressTextBox.Validating += memberEmailAddressTextBox_Validating;
            // 
            // memberEmailAddressLabel
            // 
            memberEmailAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberEmailAddressLabel.AutoSize = true;
            memberEmailAddressLabel.Font = new Font("Segoe UI", 11F);
            memberEmailAddressLabel.Location = new Point(509, 274);
            memberEmailAddressLabel.Name = "memberEmailAddressLabel";
            memberEmailAddressLabel.Size = new Size(106, 20);
            memberEmailAddressLabel.TabIndex = 33;
            memberEmailAddressLabel.Text = "Email Address:";
            // 
            // addressLine1TextBox
            // 
            addressLine1TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressLine1TextBox.Location = new Point(657, 320);
            addressLine1TextBox.Name = "addressLine1TextBox";
            addressLine1TextBox.Size = new Size(225, 23);
            addressLine1TextBox.TabIndex = 34;
            addressLine1TextBox.Validating += addressLine1TextBox_Validating;
            // 
            // addressLine1Label
            // 
            addressLine1Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressLine1Label.AutoSize = true;
            addressLine1Label.Font = new Font("Segoe UI", 11F);
            addressLine1Label.Location = new Point(509, 321);
            addressLine1Label.Name = "addressLine1Label";
            addressLine1Label.Size = new Size(108, 20);
            addressLine1Label.TabIndex = 35;
            addressLine1Label.Text = "Address Line 1:";
            // 
            // addressLine2TextBox
            // 
            addressLine2TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressLine2TextBox.Location = new Point(657, 366);
            addressLine2TextBox.Name = "addressLine2TextBox";
            addressLine2TextBox.Size = new Size(225, 23);
            addressLine2TextBox.TabIndex = 36;
            addressLine2TextBox.Validating += addressLine2TextBox_Validating;
            // 
            // addressLine2Label
            // 
            addressLine2Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressLine2Label.AutoSize = true;
            addressLine2Label.Font = new Font("Segoe UI", 11F);
            addressLine2Label.Location = new Point(509, 367);
            addressLine2Label.Name = "addressLine2Label";
            addressLine2Label.Size = new Size(108, 20);
            addressLine2Label.TabIndex = 37;
            addressLine2Label.Text = "Address Line 2:";
            // 
            // zoneAreaTextBox
            // 
            zoneAreaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            zoneAreaTextBox.Location = new Point(657, 415);
            zoneAreaTextBox.Name = "zoneAreaTextBox";
            zoneAreaTextBox.Size = new Size(225, 23);
            zoneAreaTextBox.TabIndex = 38;
            zoneAreaTextBox.Validating += addressLine2TextBox_Validating;
            // 
            // zoneAreaLabel
            // 
            zoneAreaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            zoneAreaLabel.AutoSize = true;
            zoneAreaLabel.Font = new Font("Segoe UI", 11F);
            zoneAreaLabel.Location = new Point(509, 416);
            zoneAreaLabel.Name = "zoneAreaLabel";
            zoneAreaLabel.Size = new Size(81, 20);
            zoneAreaLabel.TabIndex = 39;
            zoneAreaLabel.Text = "Zone Area:";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            postalCodeTextBox.Location = new Point(657, 463);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(225, 23);
            postalCodeTextBox.TabIndex = 40;
            postalCodeTextBox.Validating += postalCodeTextBox_Validating;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new Font("Segoe UI", 11F);
            postalCodeLabel.Location = new Point(509, 463);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(90, 20);
            postalCodeLabel.TabIndex = 41;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // memberSaveButton
            // 
            memberSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            memberSaveButton.Location = new Point(909, 102);
            memberSaveButton.Name = "memberSaveButton";
            memberSaveButton.Size = new Size(110, 23);
            memberSaveButton.TabIndex = 42;
            memberSaveButton.Text = "Save";
            memberSaveButton.UseVisualStyleBackColor = true;
            memberSaveButton.Click += memberSaveButton_Click;
            // 
            // memberClearButton
            // 
            memberClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            memberClearButton.Location = new Point(909, 140);
            memberClearButton.Name = "memberClearButton";
            memberClearButton.Size = new Size(110, 23);
            memberClearButton.TabIndex = 43;
            memberClearButton.Text = "Clear";
            memberClearButton.UseVisualStyleBackColor = true;
            // 
            // memberUpdateButton
            // 
            memberUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberUpdateButton.Location = new Point(909, 183);
            memberUpdateButton.Name = "memberUpdateButton";
            memberUpdateButton.Size = new Size(110, 23);
            memberUpdateButton.TabIndex = 44;
            memberUpdateButton.Text = "Update";
            memberUpdateButton.UseVisualStyleBackColor = true;
            // 
            // memberDeleteButton
            // 
            memberDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberDeleteButton.Location = new Point(909, 228);
            memberDeleteButton.Name = "memberDeleteButton";
            memberDeleteButton.Size = new Size(110, 23);
            memberDeleteButton.TabIndex = 45;
            memberDeleteButton.Text = "Delete";
            memberDeleteButton.UseVisualStyleBackColor = true;
            // 
            // viewFileButton
            // 
            viewFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewFileButton.Location = new Point(909, 275);
            viewFileButton.Name = "viewFileButton";
            viewFileButton.Size = new Size(110, 23);
            viewFileButton.TabIndex = 46;
            viewFileButton.Text = "View File";
            viewFileButton.UseVisualStyleBackColor = true;
            // 
            // makePaymentButton
            // 
            makePaymentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            makePaymentButton.Location = new Point(909, 321);
            makePaymentButton.Name = "makePaymentButton";
            makePaymentButton.Size = new Size(110, 23);
            makePaymentButton.TabIndex = 47;
            makePaymentButton.Text = "Make Payment";
            makePaymentButton.UseVisualStyleBackColor = true;
            makePaymentButton.Click += makePaymentButton_Click;
            // 
            // memberNextButton
            // 
            memberNextButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberNextButton.Location = new Point(909, 463);
            memberNextButton.Name = "memberNextButton";
            memberNextButton.Size = new Size(110, 23);
            memberNextButton.TabIndex = 48;
            memberNextButton.Text = "Next";
            memberNextButton.UseVisualStyleBackColor = true;
            memberNextButton.Click += memberNextButton_Click;
            // 
            // memberTitleComboBox
            // 
            memberTitleComboBox.FormattingEnabled = true;
            memberTitleComboBox.Items.AddRange(new object[] { "", "Mr", "Ms", "Mrs", "Dr", "Adv" });
            memberTitleComboBox.Location = new Point(187, 183);
            memberTitleComboBox.Name = "memberTitleComboBox";
            memberTitleComboBox.Size = new Size(225, 23);
            memberTitleComboBox.TabIndex = 50;
            memberTitleComboBox.Validating += memberTitleComboBox_SelectedIndexChanged;
            // 
            // memberTitleLabel
            // 
            memberTitleLabel.AutoSize = true;
            memberTitleLabel.Font = new Font("Segoe UI", 11F);
            memberTitleLabel.Location = new Point(29, 183);
            memberTitleLabel.Name = "memberTitleLabel";
            memberTitleLabel.Size = new Size(41, 20);
            memberTitleLabel.TabIndex = 49;
            memberTitleLabel.Text = "Title:";
            // 
            // memberLastNameTextBox
            // 
            memberLastNameTextBox.Location = new Point(187, 271);
            memberLastNameTextBox.Name = "memberLastNameTextBox";
            memberLastNameTextBox.Size = new Size(225, 23);
            memberLastNameTextBox.TabIndex = 52;
            memberLastNameTextBox.Validating += memberLastNameTextBox_Validating;
            // 
            // memberEmploymentStatusComboBox
            // 
            memberEmploymentStatusComboBox.FormattingEnabled = true;
            memberEmploymentStatusComboBox.Items.AddRange(new object[] { "", "Unemployed", "Employed", "Self-Employed", "Pensioner", "Student" });
            memberEmploymentStatusComboBox.Location = new Point(657, 102);
            memberEmploymentStatusComboBox.Name = "memberEmploymentStatusComboBox";
            memberEmploymentStatusComboBox.Size = new Size(225, 23);
            memberEmploymentStatusComboBox.TabIndex = 54;
            // 
            // memberEmploymentStatusLabel
            // 
            memberEmploymentStatusLabel.AutoSize = true;
            memberEmploymentStatusLabel.Font = new Font("Segoe UI", 11F);
            memberEmploymentStatusLabel.Location = new Point(509, 103);
            memberEmploymentStatusLabel.Name = "memberEmploymentStatusLabel";
            memberEmploymentStatusLabel.Size = new Size(140, 20);
            memberEmploymentStatusLabel.TabIndex = 53;
            memberEmploymentStatusLabel.Text = "Employment Status:";
            memberEmploymentStatusLabel.Click += memberEmploymentStatusLabel_Click;
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 513);
            Controls.Add(memberEmploymentStatusComboBox);
            Controls.Add(memberEmploymentStatusLabel);
            Controls.Add(memberLastNameTextBox);
            Controls.Add(memberTitleComboBox);
            Controls.Add(memberTitleLabel);
            Controls.Add(memberNextButton);
            Controls.Add(makePaymentButton);
            Controls.Add(viewFileButton);
            Controls.Add(memberDeleteButton);
            Controls.Add(memberUpdateButton);
            Controls.Add(memberClearButton);
            Controls.Add(memberSaveButton);
            Controls.Add(postalCodeLabel);
            Controls.Add(postalCodeTextBox);
            Controls.Add(zoneAreaLabel);
            Controls.Add(zoneAreaTextBox);
            Controls.Add(addressLine2Label);
            Controls.Add(addressLine2TextBox);
            Controls.Add(addressLine1Label);
            Controls.Add(addressLine1TextBox);
            Controls.Add(memberEmailAddressLabel);
            Controls.Add(memberEmailAddressTextBox);
            Controls.Add(memberMobileNumberLabel);
            Controls.Add(memberMobileNumberTextBox);
            Controls.Add(memberPhoneNumberLabel);
            Controls.Add(memberPhoneNumberTextBox);
            Controls.Add(memberOccupationTextBox);
            Controls.Add(memberOccupationLabel);
            Controls.Add(memberStatusComboBox);
            Controls.Add(membershipSatusLabel);
            Controls.Add(memberMaritalStatusComboBox);
            Controls.Add(memberMaritalStatusLabel);
            Controls.Add(memberRaceLabel);
            Controls.Add(memberRaceComboBox);
            Controls.Add(memberGenderLabel);
            Controls.Add(birthDateTimePicker);
            Controls.Add(birthDateLabel);
            Controls.Add(memberGenderComboBox);
            Controls.Add(memberLastNameLabel);
            Controls.Add(memberFirstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(membershipNumberLabel);
            Controls.Add(registrationDateTimePicker);
            Controls.Add(membershipNumberTextBox);
            Controls.Add(registrationDateLabel);
            Controls.Add(AddNewMemberLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMemberForm";
            Text = "AddMemberForm";
            Load += AddMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox memberFirstNameTextBox;
        private Label firstNameLabel;
        private Label membershipNumberLabel;
        private DateTimePicker registrationDateTimePicker;
        private TextBox membershipNumberTextBox;
        private Label registrationDateLabel;
        private Label AddNewMemberLabel;
        private Label memberLastNameLabel;
        private ComboBox memberGenderComboBox;
        private Label birthDateLabel;
        private DateTimePicker birthDateTimePicker;
        private Label memberGenderLabel;
        private ComboBox memberRaceComboBox;
        private Label memberRaceLabel;
        private Label memberMaritalStatusLabel;
        private ComboBox memberMaritalStatusComboBox;
        private Label membershipSatusLabel;
        private ComboBox memberStatusComboBox;
        private Label memberOccupationLabel;
        private TextBox memberOccupationTextBox;
        private TextBox memberPhoneNumberTextBox;
        private Label memberPhoneNumberLabel;
        private TextBox memberMobileNumberTextBox;
        private Label memberMobileNumberLabel;
        private TextBox memberEmailAddressTextBox;
        private Label memberEmailAddressLabel;
        private TextBox addressLine1TextBox;
        private Label addressLine1Label;
        private TextBox addressLine2TextBox;
        private Label addressLine2Label;
        private TextBox zoneAreaTextBox;
        private Label zoneAreaLabel;
        private TextBox postalCodeTextBox;
        private Label postalCodeLabel;
        private Button memberSaveButton;
        private Button memberClearButton;
        private Button memberUpdateButton;
        private Button memberDeleteButton;
        private Button viewFileButton;
        private Button makePaymentButton;
        private Button memberNextButton;
        private ComboBox memberTitleComboBox;
        private Label memberTitleLabel;
        private TextBox memberLastNameTextBox;
        private ComboBox memberEmploymentStatusComboBox;
        private Label memberEmploymentStatusLabel;
    }
}