namespace AdminDashboard
{
    partial class InventoryForm
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
            viewInventoryButton = new Button();
            itemLoggedDateTimePicker = new DateTimePicker();
            inventoryIdTextBox = new TextBox();
            inventoryDeleteButton = new Button();
            inventoryUpdateButton = new Button();
            inventoryClearButton = new Button();
            inventorySaveButton = new Button();
            itemNameLabel = new Label();
            itemNameTextBox = new TextBox();
            itemQuantityTextBox = new TextBox();
            SuspendLayout();
            // 
            // viewInventoryButton
            // 
            viewInventoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewInventoryButton.Location = new Point(914, 271);
            viewInventoryButton.Name = "viewInventoryButton";
            viewInventoryButton.Size = new Size(110, 23);
            viewInventoryButton.TabIndex = 154;
            viewInventoryButton.Text = "View Inventory";
            viewInventoryButton.UseVisualStyleBackColor = true;
            viewInventoryButton.Click += viewInventoryButton_Click;
            // 
            // itemLoggedDateTimePicker
            // 
            itemLoggedDateTimePicker.Location = new Point(192, 229);
            itemLoggedDateTimePicker.Name = "itemLoggedDateTimePicker";
            itemLoggedDateTimePicker.Size = new Size(225, 23);
            itemLoggedDateTimePicker.TabIndex = 147;
            // 
            // inventoryIdTextBox
            // 
            inventoryIdTextBox.Location = new Point(192, 100);
            inventoryIdTextBox.Name = "inventoryIdTextBox";
            inventoryIdTextBox.ReadOnly = true;
            inventoryIdTextBox.Size = new Size(225, 23);
            inventoryIdTextBox.TabIndex = 142;
            // 
            // inventoryDeleteButton
            // 
            inventoryDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inventoryDeleteButton.Location = new Point(914, 227);
            inventoryDeleteButton.Name = "inventoryDeleteButton";
            inventoryDeleteButton.Size = new Size(110, 23);
            inventoryDeleteButton.TabIndex = 141;
            inventoryDeleteButton.Text = "Delete";
            inventoryDeleteButton.UseVisualStyleBackColor = true;
            // 
            // inventoryUpdateButton
            // 
            inventoryUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inventoryUpdateButton.Location = new Point(914, 183);
            inventoryUpdateButton.Name = "inventoryUpdateButton";
            inventoryUpdateButton.Size = new Size(110, 23);
            inventoryUpdateButton.TabIndex = 140;
            inventoryUpdateButton.Text = "Update";
            inventoryUpdateButton.UseVisualStyleBackColor = true;
            // 
            // inventoryClearButton
            // 
            inventoryClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inventoryClearButton.Location = new Point(914, 140);
            inventoryClearButton.Name = "inventoryClearButton";
            inventoryClearButton.Size = new Size(110, 23);
            inventoryClearButton.TabIndex = 139;
            inventoryClearButton.Text = "Clear";
            inventoryClearButton.UseVisualStyleBackColor = true;
            // 
            // inventorySaveButton
            // 
            inventorySaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inventorySaveButton.Location = new Point(914, 100);
            inventorySaveButton.Name = "inventorySaveButton";
            inventorySaveButton.Size = new Size(110, 23);
            inventorySaveButton.TabIndex = 138;
            inventorySaveButton.Text = "Save";
            inventorySaveButton.UseVisualStyleBackColor = true;
            // 
            // burialDateLabel
            // 
            burialDateLabel.AutoSize = true;
            burialDateLabel.Font = new Font("Segoe UI", 11F);
            burialDateLabel.Location = new Point(34, 233);
            burialDateLabel.Name = "burialDateLabel";
            burialDateLabel.Size = new Size(99, 20);
            burialDateLabel.TabIndex = 135;
            burialDateLabel.Text = "Logged Date:";
            // 
            // dateOfDeathLabel
            // 
            dateOfDeathLabel.AutoSize = true;
            dateOfDeathLabel.Font = new Font("Segoe UI", 11F);
            dateOfDeathLabel.Location = new Point(34, 186);
            dateOfDeathLabel.Name = "dateOfDeathLabel";
            dateOfDeathLabel.Size = new Size(65, 20);
            dateOfDeathLabel.TabIndex = 134;
            dateOfDeathLabel.Text = "Quantity";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Segoe UI", 11F);
            itemNameLabel.Location = new Point(34, 141);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(86, 20);
            itemNameLabel.TabIndex = 133;
            itemNameLabel.Text = "Item Name:";
            // 
            // FileIdLabel
            // 
            FileIdLabel.AutoSize = true;
            FileIdLabel.Font = new Font("Segoe UI", 11F);
            FileIdLabel.Location = new Point(34, 101);
            FileIdLabel.Name = "FileIdLabel";
            FileIdLabel.Size = new Size(92, 20);
            FileIdLabel.TabIndex = 130;
            FileIdLabel.Text = "Inventory ID:";
            // 
            // PaymentLabel
            // 
            PaymentLabel.AutoSize = true;
            PaymentLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            PaymentLabel.Location = new Point(29, 21);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(159, 47);
            PaymentLabel.TabIndex = 129;
            PaymentLabel.Text = "Iventory";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(192, 142);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(225, 23);
            itemNameTextBox.TabIndex = 155;
            // 
            // itemQuantityTextBox
            // 
            itemQuantityTextBox.Location = new Point(192, 187);
            itemQuantityTextBox.Name = "itemQuantityTextBox";
            itemQuantityTextBox.Size = new Size(225, 23);
            itemQuantityTextBox.TabIndex = 156;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 513);
            Controls.Add(itemQuantityTextBox);
            Controls.Add(itemNameTextBox);
            Controls.Add(viewInventoryButton);
            Controls.Add(itemLoggedDateTimePicker);
            Controls.Add(inventoryIdTextBox);
            Controls.Add(inventoryDeleteButton);
            Controls.Add(inventoryUpdateButton);
            Controls.Add(inventoryClearButton);
            Controls.Add(inventorySaveButton);
            Controls.Add(burialDateLabel);
            Controls.Add(dateOfDeathLabel);
            Controls.Add(itemNameLabel);
            Controls.Add(FileIdLabel);
            Controls.Add(PaymentLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            Text = "InventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewInventoryButton;
        private TextBox nextOfKinTextBox;
        private Label nextOfKinLabel;
        private ComboBox receivedViaticumComboBox;
        private Label viaticumLabel;
        private DateTimePicker itemLoggedDateTimePicker;
        private DateTimePicker birthDateTimePicker;
        private TextBox inventoryIdTextBox;
        private Button inventoryDeleteButton;
        private Button inventoryUpdateButton;
        private Button inventoryClearButton;
        private Button inventorySaveButton;
        private Label burialDateLabel;
        private Label dateOfDeathLabel;
        private Label itemNameLabel;
        private Label endOfFileMembershipNumberLabel;
        private TextBox endOfFileMembershipNumberTextBox;
        private Label FileIdLabel;
        private Label PaymentLabel;
        private TextBox itemNameTextBox;
        private TextBox itemQuantityTextBox;
    }
}