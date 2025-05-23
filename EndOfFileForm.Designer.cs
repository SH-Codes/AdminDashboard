﻿namespace AdminDashboard
{
    partial class EndOfFileForm
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
            clergyNameTextBox = new TextBox();
            cemeteryTextBox = new TextBox();
            fileIdTextBox = new TextBox();
            endOfFileDeleteButton = new Button();
            endOfFileUpdateButton = new Button();
            endOfFileClearButton = new Button();
            endOfLifeSaveButton = new Button();
            clergyNameLabel = new Label();
            cemeteryLabel = new Label();
            burialDateLabel = new Label();
            dateOfDeathLabel = new Label();
            endOfFileMembershipNumberLabel = new Label();
            endOfFileMembershipNumberTextBox = new TextBox();
            FileIdLabel = new Label();
            PaymentLabel = new Label();
            dateOfDeathTimePicker = new DateTimePicker();
            burialDateTimePicker = new DateTimePicker();
            receivedViaticumComboBox = new ComboBox();
            viaticumLabel = new Label();
            nextOfKinTextBox = new TextBox();
            nextOfKinLabel = new Label();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            endOfFilePreviousButton = new Button();
            SuspendLayout();
            // 
            // clergyNameTextBox
            // 
            clergyNameTextBox.Location = new Point(184, 341);
            clergyNameTextBox.Name = "clergyNameTextBox";
            clergyNameTextBox.Size = new Size(225, 23);
            clergyNameTextBox.TabIndex = 119;
            clergyNameTextBox.Validating += clergyNameTextBox_TextChanged;
            // 
            // cemeteryTextBox
            // 
            cemeteryTextBox.Location = new Point(184, 292);
            cemeteryTextBox.Name = "cemeteryTextBox";
            cemeteryTextBox.Size = new Size(225, 23);
            cemeteryTextBox.TabIndex = 118;
            cemeteryTextBox.Validating += cemeteryTextBox_TextChanged;
            // 
            // fileIdTextBox
            // 
            fileIdTextBox.Location = new Point(184, 110);
            fileIdTextBox.Name = "fileIdTextBox";
            fileIdTextBox.ReadOnly = true;
            fileIdTextBox.Size = new Size(225, 23);
            fileIdTextBox.TabIndex = 114;
            // 
            // endOfFileDeleteButton
            // 
            endOfFileDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            endOfFileDeleteButton.Location = new Point(912, 237);
            endOfFileDeleteButton.Name = "endOfFileDeleteButton";
            endOfFileDeleteButton.Size = new Size(110, 23);
            endOfFileDeleteButton.TabIndex = 113;
            endOfFileDeleteButton.Text = "Delete";
            endOfFileDeleteButton.UseVisualStyleBackColor = true;
            // 
            // endOfFileUpdateButton
            // 
            endOfFileUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            endOfFileUpdateButton.Location = new Point(912, 151);
            endOfFileUpdateButton.Name = "endOfFileUpdateButton";
            endOfFileUpdateButton.Size = new Size(110, 23);
            endOfFileUpdateButton.TabIndex = 112;
            endOfFileUpdateButton.Text = "Update";
            endOfFileUpdateButton.UseVisualStyleBackColor = true;
            // 
            // endOfFileClearButton
            // 
            endOfFileClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            endOfFileClearButton.Location = new Point(912, 196);
            endOfFileClearButton.Name = "endOfFileClearButton";
            endOfFileClearButton.Size = new Size(110, 23);
            endOfFileClearButton.TabIndex = 111;
            endOfFileClearButton.Text = "Clear";
            endOfFileClearButton.UseVisualStyleBackColor = true;
            // 
            // endOfLifeSaveButton
            // 
            endOfLifeSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            endOfLifeSaveButton.Location = new Point(912, 110);
            endOfLifeSaveButton.Name = "endOfLifeSaveButton";
            endOfLifeSaveButton.Size = new Size(110, 23);
            endOfLifeSaveButton.TabIndex = 110;
            endOfLifeSaveButton.Text = "Save";
            endOfLifeSaveButton.UseVisualStyleBackColor = true;
            endOfLifeSaveButton.Click += endOfLifeSaveButton_Click;
            // 
            // clergyNameLabel
            // 
            clergyNameLabel.AutoSize = true;
            clergyNameLabel.Font = new Font("Segoe UI", 11F);
            clergyNameLabel.Location = new Point(29, 340);
            clergyNameLabel.Name = "clergyNameLabel";
            clergyNameLabel.Size = new Size(98, 20);
            clergyNameLabel.TabIndex = 109;
            clergyNameLabel.Text = "Clergy Name:";
            // 
            // cemeteryLabel
            // 
            cemeteryLabel.AutoSize = true;
            cemeteryLabel.Font = new Font("Segoe UI", 11F);
            cemeteryLabel.Location = new Point(29, 293);
            cemeteryLabel.Name = "cemeteryLabel";
            cemeteryLabel.Size = new Size(75, 20);
            cemeteryLabel.TabIndex = 108;
            cemeteryLabel.Text = "Cemetery:";
            // 
            // burialDateLabel
            // 
            burialDateLabel.AutoSize = true;
            burialDateLabel.Font = new Font("Segoe UI", 11F);
            burialDateLabel.Location = new Point(26, 247);
            burialDateLabel.Name = "burialDateLabel";
            burialDateLabel.Size = new Size(86, 20);
            burialDateLabel.TabIndex = 107;
            burialDateLabel.Text = "Burial Date:";
            // 
            // dateOfDeathLabel
            // 
            dateOfDeathLabel.AutoSize = true;
            dateOfDeathLabel.Font = new Font("Segoe UI", 11F);
            dateOfDeathLabel.Location = new Point(26, 200);
            dateOfDeathLabel.Name = "dateOfDeathLabel";
            dateOfDeathLabel.Size = new Size(106, 20);
            dateOfDeathLabel.TabIndex = 106;
            dateOfDeathLabel.Text = "Date of Death:";
            // 
            // endOfFileMembershipNumberLabel
            // 
            endOfFileMembershipNumberLabel.AutoSize = true;
            endOfFileMembershipNumberLabel.Font = new Font("Segoe UI", 11F);
            endOfFileMembershipNumberLabel.Location = new Point(26, 151);
            endOfFileMembershipNumberLabel.Name = "endOfFileMembershipNumberLabel";
            endOfFileMembershipNumberLabel.Size = new Size(153, 20);
            endOfFileMembershipNumberLabel.TabIndex = 104;
            endOfFileMembershipNumberLabel.Text = "Membership Number:";
            // 
            // endOfFileMembershipNumberTextBox
            // 
            endOfFileMembershipNumberTextBox.Location = new Point(184, 148);
            endOfFileMembershipNumberTextBox.Name = "endOfFileMembershipNumberTextBox";
            endOfFileMembershipNumberTextBox.ReadOnly = true;
            endOfFileMembershipNumberTextBox.Size = new Size(225, 23);
            endOfFileMembershipNumberTextBox.TabIndex = 103;
            // 
            // FileIdLabel
            // 
            FileIdLabel.AutoSize = true;
            FileIdLabel.Font = new Font("Segoe UI", 11F);
            FileIdLabel.Location = new Point(26, 111);
            FileIdLabel.Name = "FileIdLabel";
            FileIdLabel.Size = new Size(54, 20);
            FileIdLabel.TabIndex = 102;
            FileIdLabel.Text = "File ID:";
            // 
            // PaymentLabel
            // 
            PaymentLabel.AutoSize = true;
            PaymentLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            PaymentLabel.Location = new Point(21, 31);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(192, 47);
            PaymentLabel.TabIndex = 101;
            PaymentLabel.Text = "End of File";
            // 
            // dateOfDeathTimePicker
            // 
            dateOfDeathTimePicker.Location = new Point(184, 196);
            dateOfDeathTimePicker.Name = "dateOfDeathTimePicker";
            dateOfDeathTimePicker.Size = new Size(225, 23);
            dateOfDeathTimePicker.TabIndex = 120;
            dateOfDeathTimePicker.ValueChanged += dateOfDeathTimePicker_ValueChanged;
            // 
            // burialDateTimePicker
            // 
            burialDateTimePicker.Location = new Point(184, 243);
            burialDateTimePicker.Name = "burialDateTimePicker";
            burialDateTimePicker.Size = new Size(225, 23);
            burialDateTimePicker.TabIndex = 121;
            burialDateTimePicker.ValueChanged += burialDateTimePicker_ValueChanged;
            // 
            // receivedViaticumComboBox
            // 
            receivedViaticumComboBox.FormattingEnabled = true;
            receivedViaticumComboBox.Items.AddRange(new object[] { "", "Yes", "No" });
            receivedViaticumComboBox.Location = new Point(616, 110);
            receivedViaticumComboBox.Name = "receivedViaticumComboBox";
            receivedViaticumComboBox.Size = new Size(225, 23);
            receivedViaticumComboBox.TabIndex = 123;
            receivedViaticumComboBox.Validating += receivedViaticumComboBox_SelectedIndexChanged;
            // 
            // viaticumLabel
            // 
            viaticumLabel.AutoSize = true;
            viaticumLabel.Font = new Font("Segoe UI", 11F);
            viaticumLabel.Location = new Point(458, 111);
            viaticumLabel.Name = "viaticumLabel";
            viaticumLabel.Size = new Size(134, 20);
            viaticumLabel.TabIndex = 122;
            viaticumLabel.Text = "Received Viaticum:";
            // 
            // nextOfKinTextBox
            // 
            nextOfKinTextBox.Location = new Point(616, 150);
            nextOfKinTextBox.Name = "nextOfKinTextBox";
            nextOfKinTextBox.Size = new Size(225, 23);
            nextOfKinTextBox.TabIndex = 125;
            // 
            // nextOfKinLabel
            // 
            nextOfKinLabel.AutoSize = true;
            nextOfKinLabel.Font = new Font("Segoe UI", 11F);
            nextOfKinLabel.Location = new Point(461, 151);
            nextOfKinLabel.Name = "nextOfKinLabel";
            nextOfKinLabel.Size = new Size(86, 20);
            nextOfKinLabel.TabIndex = 124;
            nextOfKinLabel.Text = "Next of Kin:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(616, 195);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(225, 23);
            phoneNumberTextBox.TabIndex = 127;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI", 11F);
            phoneNumberLabel.Location = new Point(461, 196);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(111, 20);
            phoneNumberLabel.TabIndex = 126;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // endOfFilePreviousButton
            // 
            endOfFilePreviousButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            endOfFilePreviousButton.Location = new Point(912, 379);
            endOfFilePreviousButton.Name = "endOfFilePreviousButton";
            endOfFilePreviousButton.Size = new Size(110, 23);
            endOfFilePreviousButton.TabIndex = 128;
            endOfFilePreviousButton.Text = "Previous";
            endOfFilePreviousButton.UseVisualStyleBackColor = true;
            endOfFilePreviousButton.Click += endOfFilePreviousButton_Click;
            // 
            // EndOfFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(endOfFilePreviousButton);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(nextOfKinTextBox);
            Controls.Add(nextOfKinLabel);
            Controls.Add(receivedViaticumComboBox);
            Controls.Add(viaticumLabel);
            Controls.Add(burialDateTimePicker);
            Controls.Add(dateOfDeathTimePicker);
            Controls.Add(clergyNameTextBox);
            Controls.Add(cemeteryTextBox);
            Controls.Add(fileIdTextBox);
            Controls.Add(endOfFileDeleteButton);
            Controls.Add(endOfFileUpdateButton);
            Controls.Add(endOfFileClearButton);
            Controls.Add(endOfLifeSaveButton);
            Controls.Add(clergyNameLabel);
            Controls.Add(cemeteryLabel);
            Controls.Add(burialDateLabel);
            Controls.Add(dateOfDeathLabel);
            Controls.Add(endOfFileMembershipNumberLabel);
            Controls.Add(endOfFileMembershipNumberTextBox);
            Controls.Add(FileIdLabel);
            Controls.Add(PaymentLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EndOfFileForm";
            Text = "EndOfFileForm";
            Load += EndOfFileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clergyNameTextBox;
        private TextBox cemeteryTextBox;
        //private TextBox amountTotalTextBox;
        private TextBox fileIdTextBox;
        private Button endOfFileDeleteButton;
        private Button endOfFileUpdateButton;
        private Button endOfFileClearButton;
        private Button endOfLifeSaveButton;
        private Label clergyNameLabel;
        private Label cemeteryLabel;
        private Label burialDateLabel;
        private Label dateOfDeathLabel;
        private Label endOfFileMembershipNumberLabel;
        private TextBox endOfFileMembershipNumberTextBox;
        private Label FileIdLabel;
        private Label PaymentLabel;
        private DateTimePicker dateOfDeathTimePicker;
        private DateTimePicker burialDateTimePicker;
        private ComboBox receivedViaticumComboBox;
        private Label viaticumLabel;
        private TextBox nextOfKinTextBox;
        private Label nextOfKinLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private Button endOfFilePreviousButton;
    }
}