namespace AdminDashboard
{
    partial class PaymentsForm
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
            viewStatementButton = new Button();
            paymentsClearButton = new Button();
            paymentsSaveButton = new Button();
            amountTenderdLabel = new Label();
            amountTotalLabel = new Label();
            accountTypeLabel = new Label();
            paymentDateLabel = new Label();
            membershipNumberLabel = new Label();
            paymentsMembershipNumberTextBox = new TextBox();
            paymentIdLabel = new Label();
            PaymentLabel = new Label();
            paymentIdTextBox = new TextBox();
            paymentDateTimePicker = new DateTimePicker();
            accountTypeComboBox = new ComboBox();
            amountTotalTextBox = new TextBox();
            amountTenderedTextBox = new TextBox();
            memberRaceLabel = new Label();
            changeTextBox = new TextBox();
            paymentsUpdateButton = new Button();
            paymentMethodLabel = new Label();
            paymentMethodComboBox = new ComboBox();
            SuspendLayout();
            // 
            // viewStatementButton
            // 
            viewStatementButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewStatementButton.Location = new Point(909, 231);
            viewStatementButton.Name = "viewStatementButton";
            viewStatementButton.Size = new Size(110, 23);
            viewStatementButton.TabIndex = 91;
            viewStatementButton.Text = "View Statements";
            viewStatementButton.UseVisualStyleBackColor = true;
            // 
            // paymentsClearButton
            // 
            paymentsClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            paymentsClearButton.Location = new Point(909, 141);
            paymentsClearButton.Name = "paymentsClearButton";
            paymentsClearButton.Size = new Size(110, 23);
            paymentsClearButton.TabIndex = 87;
            paymentsClearButton.Text = "Clear";
            paymentsClearButton.UseVisualStyleBackColor = true;
            // 
            // paymentsSaveButton
            // 
            paymentsSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            paymentsSaveButton.Location = new Point(909, 103);
            paymentsSaveButton.Name = "paymentsSaveButton";
            paymentsSaveButton.Size = new Size(110, 23);
            paymentsSaveButton.TabIndex = 86;
            paymentsSaveButton.Text = "Save";
            paymentsSaveButton.UseVisualStyleBackColor = true;
            paymentsSaveButton.Click += paymentsSaveButton_Click;
            // 
            // amountTenderdLabel
            // 
            amountTenderdLabel.AutoSize = true;
            amountTenderdLabel.Font = new Font("Segoe UI", 11F);
            amountTenderdLabel.Location = new Point(37, 327);
            amountTenderdLabel.Name = "amountTenderdLabel";
            amountTenderdLabel.Size = new Size(131, 20);
            amountTenderdLabel.TabIndex = 63;
            amountTenderdLabel.Text = "Amount Tendered:";
            // 
            // amountTotalLabel
            // 
            amountTotalLabel.AutoSize = true;
            amountTotalLabel.Font = new Font("Segoe UI", 11F);
            amountTotalLabel.Location = new Point(34, 281);
            amountTotalLabel.Name = "amountTotalLabel";
            amountTotalLabel.Size = new Size(102, 20);
            amountTotalLabel.TabIndex = 61;
            amountTotalLabel.Text = "Amount Total:";
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Font = new Font("Segoe UI", 11F);
            accountTypeLabel.Location = new Point(34, 234);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new Size(101, 20);
            accountTypeLabel.TabIndex = 58;
            accountTypeLabel.Text = "Account Type:";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.Font = new Font("Segoe UI", 11F);
            paymentDateLabel.Location = new Point(34, 189);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new Size(104, 20);
            paymentDateLabel.TabIndex = 56;
            paymentDateLabel.Text = "Payment Date:";
            // 
            // membershipNumberLabel
            // 
            membershipNumberLabel.AutoSize = true;
            membershipNumberLabel.Font = new Font("Segoe UI", 11F);
            membershipNumberLabel.Location = new Point(34, 144);
            membershipNumberLabel.Name = "membershipNumberLabel";
            membershipNumberLabel.Size = new Size(153, 20);
            membershipNumberLabel.TabIndex = 55;
            membershipNumberLabel.Text = "Membership Number:";
            // 
            // paymentsMembershipNumberTextBox
            // 
            paymentsMembershipNumberTextBox.Location = new Point(192, 143);
            paymentsMembershipNumberTextBox.Name = "paymentsMembershipNumberTextBox";
            paymentsMembershipNumberTextBox.ReadOnly = true;
            paymentsMembershipNumberTextBox.Size = new Size(225, 23);
            paymentsMembershipNumberTextBox.TabIndex = 53;
            // 
            // paymentIdLabel
            // 
            paymentIdLabel.AutoSize = true;
            paymentIdLabel.Font = new Font("Segoe UI", 11F);
            paymentIdLabel.Location = new Point(34, 106);
            paymentIdLabel.Name = "paymentIdLabel";
            paymentIdLabel.Size = new Size(87, 20);
            paymentIdLabel.TabIndex = 52;
            paymentIdLabel.Text = "Payment ID:";
            // 
            // PaymentLabel
            // 
            PaymentLabel.AutoSize = true;
            PaymentLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            PaymentLabel.Location = new Point(29, 26);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(180, 47);
            PaymentLabel.TabIndex = 51;
            PaymentLabel.Text = "Payments";
            // 
            // paymentIdTextBox
            // 
            paymentIdTextBox.Location = new Point(192, 105);
            paymentIdTextBox.Name = "paymentIdTextBox";
            paymentIdTextBox.ReadOnly = true;
            paymentIdTextBox.Size = new Size(225, 23);
            paymentIdTextBox.TabIndex = 95;
            // 
            // paymentDateTimePicker
            // 
            paymentDateTimePicker.Location = new Point(192, 189);
            paymentDateTimePicker.Name = "paymentDateTimePicker";
            paymentDateTimePicker.Size = new Size(225, 23);
            paymentDateTimePicker.TabIndex = 96;
            paymentDateTimePicker.ValueChanged += paymentDateTimePicker_ValueChanged;
            // 
            // accountTypeComboBox
            // 
            accountTypeComboBox.FormattingEnabled = true;
            accountTypeComboBox.Items.AddRange(new object[] { "", "Clergy Birthday", "Donations", "Maintainance", "Oblations", "Offatory", "Repository Sales", "Stole Fees", "Tithe" });
            accountTypeComboBox.Location = new Point(192, 233);
            accountTypeComboBox.Name = "accountTypeComboBox";
            accountTypeComboBox.Size = new Size(225, 23);
            accountTypeComboBox.TabIndex = 97;
            accountTypeComboBox.Validating += accountTypeComboBox_SelectedIndexChanged;
            // 
            // amountTotalTextBox
            // 
            amountTotalTextBox.Location = new Point(192, 278);
            amountTotalTextBox.Name = "amountTotalTextBox";
            amountTotalTextBox.Size = new Size(225, 23);
            amountTotalTextBox.TabIndex = 98;
            amountTotalTextBox.Validating += amountTotalTextBox_TextChanged;
            // 
            // amountTenderedTextBox
            // 
            amountTenderedTextBox.Location = new Point(192, 326);
            amountTenderedTextBox.Name = "amountTenderedTextBox";
            amountTenderedTextBox.Size = new Size(225, 23);
            amountTenderedTextBox.TabIndex = 99;
            amountTenderedTextBox.Validating += amountTenderedTextBox_TextChanged;
            // 
            // memberRaceLabel
            // 
            memberRaceLabel.AutoSize = true;
            memberRaceLabel.Font = new Font("Segoe UI", 11F);
            memberRaceLabel.Location = new Point(37, 374);
            memberRaceLabel.Name = "memberRaceLabel";
            memberRaceLabel.Size = new Size(62, 20);
            memberRaceLabel.TabIndex = 65;
            memberRaceLabel.Text = "Change:";
            // 
            // changeTextBox
            // 
            changeTextBox.Location = new Point(192, 375);
            changeTextBox.Name = "changeTextBox";
            changeTextBox.Size = new Size(225, 23);
            changeTextBox.TabIndex = 100;
            changeTextBox.TextChanged += changeTextBox_TextChanged;
            // 
            // paymentsUpdateButton
            // 
            paymentsUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            paymentsUpdateButton.Location = new Point(909, 186);
            paymentsUpdateButton.Name = "paymentsUpdateButton";
            paymentsUpdateButton.Size = new Size(110, 23);
            paymentsUpdateButton.TabIndex = 88;
            paymentsUpdateButton.Text = "Delete";
            paymentsUpdateButton.UseVisualStyleBackColor = true;
            // 
            // paymentMethodLabel
            // 
            paymentMethodLabel.AutoSize = true;
            paymentMethodLabel.Font = new Font("Segoe UI", 11F);
            paymentMethodLabel.Location = new Point(37, 425);
            paymentMethodLabel.Name = "paymentMethodLabel";
            paymentMethodLabel.Size = new Size(124, 20);
            paymentMethodLabel.TabIndex = 101;
            paymentMethodLabel.Text = "Payment Method:";
            // 
            // paymentMethodComboBox
            // 
            paymentMethodComboBox.FormattingEnabled = true;
            paymentMethodComboBox.Items.AddRange(new object[] { "Cash", "Bank Transfer" });
            paymentMethodComboBox.Location = new Point(192, 422);
            paymentMethodComboBox.Name = "paymentMethodComboBox";
            paymentMethodComboBox.Size = new Size(225, 23);
            paymentMethodComboBox.TabIndex = 102;
            paymentMethodComboBox.SelectedIndexChanged += paymentMethodComboBox_SelectedIndexChanged;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(paymentMethodComboBox);
            Controls.Add(paymentMethodLabel);
            Controls.Add(changeTextBox);
            Controls.Add(amountTenderedTextBox);
            Controls.Add(amountTotalTextBox);
            Controls.Add(accountTypeComboBox);
            Controls.Add(paymentDateTimePicker);
            Controls.Add(paymentIdTextBox);
            Controls.Add(viewStatementButton);
            Controls.Add(paymentsUpdateButton);
            Controls.Add(paymentsClearButton);
            Controls.Add(paymentsSaveButton);
            Controls.Add(memberRaceLabel);
            Controls.Add(amountTenderdLabel);
            Controls.Add(amountTotalLabel);
            Controls.Add(accountTypeLabel);
            Controls.Add(paymentDateLabel);
            Controls.Add(membershipNumberLabel);
            Controls.Add(paymentsMembershipNumberTextBox);
            Controls.Add(paymentIdLabel);
            Controls.Add(PaymentLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentsForm";
            Text = "PaymentsForm";
            Load += PaymentsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button viewStatementButton;
        private Button paymentsClearButton;
        private Button paymentsSaveButton;
        private Label amountTenderdLabel;
        private Label amountTotalLabel;
        private Label accountTypeLabel;
        private Label paymentDateLabel;
        private Label membershipNumberLabel;
        private TextBox paymentsMembershipNumberTextBox;
        private Label paymentIdLabel;
        private Label PaymentLabel;
        private TextBox paymentIdTextBox;
        private DateTimePicker paymentDateTimePicker;
        private ComboBox accountTypeComboBox;
        private TextBox amountTotalTextBox;
        private TextBox amountTenderedTextBox;
        private Label memberRaceLabel;
        private TextBox changeTextBox;
        private Button paymentsUpdateButton;
        private Label paymentMethodLabel;
        private ComboBox paymentMethodComboBox;
    }
}