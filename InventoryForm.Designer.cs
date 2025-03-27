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
            inventoryIDLabel = new Label();
            itemQuantityLabel = new Label();
            itemLoggedDateLabel = new Label();
            addNewItemLabel = new Label();
            SuspendLayout();
            // 
            // viewInventoryButton
            // 
            viewInventoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewInventoryButton.Location = new Point(909, 272);
            viewInventoryButton.Name = "viewInventoryButton";
            viewInventoryButton.Size = new Size(110, 23);
            viewInventoryButton.TabIndex = 154;
            viewInventoryButton.Text = "View Inventory";
            viewInventoryButton.UseVisualStyleBackColor = true;
            viewInventoryButton.Click += viewInventoryButton_Click;
            // 
            // itemLoggedDateTimePicker
            // 
            itemLoggedDateTimePicker.Location = new Point(139, 230);
            itemLoggedDateTimePicker.Name = "itemLoggedDateTimePicker";
            itemLoggedDateTimePicker.Size = new Size(225, 23);
            itemLoggedDateTimePicker.TabIndex = 147;
            itemLoggedDateTimePicker.ValueChanged += itemLoggedDateTimePicker_ValueChanged;
            // 
            // inventoryIdTextBox
            // 
            inventoryIdTextBox.Location = new Point(139, 101);
            inventoryIdTextBox.Name = "inventoryIdTextBox";
            inventoryIdTextBox.ReadOnly = true;
            inventoryIdTextBox.Size = new Size(225, 23);
            inventoryIdTextBox.TabIndex = 142;
            // 
            // inventoryDeleteButton
            // 
            inventoryDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inventoryDeleteButton.Location = new Point(909, 228);
            inventoryDeleteButton.Name = "inventoryDeleteButton";
            inventoryDeleteButton.Size = new Size(110, 23);
            inventoryDeleteButton.TabIndex = 141;
            inventoryDeleteButton.Text = "Delete";
            inventoryDeleteButton.UseVisualStyleBackColor = true;
            // 
            // inventoryUpdateButton
            // 
            inventoryUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inventoryUpdateButton.Location = new Point(909, 184);
            inventoryUpdateButton.Name = "inventoryUpdateButton";
            inventoryUpdateButton.Size = new Size(110, 23);
            inventoryUpdateButton.TabIndex = 140;
            inventoryUpdateButton.Text = "Update";
            inventoryUpdateButton.UseVisualStyleBackColor = true;
            // 
            // inventoryClearButton
            // 
            inventoryClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inventoryClearButton.Location = new Point(909, 144);
            inventoryClearButton.Name = "inventoryClearButton";
            inventoryClearButton.Size = new Size(110, 23);
            inventoryClearButton.TabIndex = 139;
            inventoryClearButton.Text = "Clear";
            inventoryClearButton.UseVisualStyleBackColor = true;
            // 
            // inventorySaveButton
            // 
            inventorySaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inventorySaveButton.Location = new Point(909, 104);
            inventorySaveButton.Name = "inventorySaveButton";
            inventorySaveButton.Size = new Size(110, 23);
            inventorySaveButton.TabIndex = 138;
            inventorySaveButton.Text = "Save";
            inventorySaveButton.UseVisualStyleBackColor = true;
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
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(139, 143);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(225, 23);
            itemNameTextBox.TabIndex = 155;
            itemNameTextBox.Validating += itemNameTextBox_TextChanged;
            // 
            // itemQuantityTextBox
            // 
            itemQuantityTextBox.Location = new Point(139, 183);
            itemQuantityTextBox.Name = "itemQuantityTextBox";
            itemQuantityTextBox.Size = new Size(225, 23);
            itemQuantityTextBox.TabIndex = 156;
            itemQuantityTextBox.Validating += itemQuantityTextBox_TextChanged;
            // 
            // inventoryIDLabel
            // 
            inventoryIDLabel.AutoSize = true;
            inventoryIDLabel.Font = new Font("Segoe UI", 11F);
            inventoryIDLabel.Location = new Point(34, 103);
            inventoryIDLabel.Name = "inventoryIDLabel";
            inventoryIDLabel.Size = new Size(92, 20);
            inventoryIDLabel.TabIndex = 157;
            inventoryIDLabel.Text = "Inventory ID:";
            // 
            // itemQuantityLabel
            // 
            itemQuantityLabel.AutoSize = true;
            itemQuantityLabel.Font = new Font("Segoe UI", 11F);
            itemQuantityLabel.Location = new Point(34, 185);
            itemQuantityLabel.Name = "itemQuantityLabel";
            itemQuantityLabel.Size = new Size(68, 20);
            itemQuantityLabel.TabIndex = 158;
            itemQuantityLabel.Text = "Quantity:";
            // 
            // itemLoggedDateLabel
            // 
            itemLoggedDateLabel.AutoSize = true;
            itemLoggedDateLabel.Font = new Font("Segoe UI", 11F);
            itemLoggedDateLabel.Location = new Point(34, 232);
            itemLoggedDateLabel.Name = "itemLoggedDateLabel";
            itemLoggedDateLabel.Size = new Size(99, 20);
            itemLoggedDateLabel.TabIndex = 159;
            itemLoggedDateLabel.Text = "Logged Date:";
            // 
            // addNewItemLabel
            // 
            addNewItemLabel.AutoSize = true;
            addNewItemLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            addNewItemLabel.Location = new Point(34, 27);
            addNewItemLabel.Name = "addNewItemLabel";
            addNewItemLabel.Size = new Size(260, 47);
            addNewItemLabel.TabIndex = 160;
            addNewItemLabel.Text = "Add New Item";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(addNewItemLabel);
            Controls.Add(itemLoggedDateLabel);
            Controls.Add(itemQuantityLabel);
            Controls.Add(inventoryIDLabel);
            Controls.Add(itemQuantityTextBox);
            Controls.Add(itemNameTextBox);
            Controls.Add(viewInventoryButton);
            Controls.Add(itemLoggedDateTimePicker);
            Controls.Add(inventoryIdTextBox);
            Controls.Add(inventoryDeleteButton);
            Controls.Add(inventoryUpdateButton);
            Controls.Add(inventoryClearButton);
            Controls.Add(inventorySaveButton);
            Controls.Add(itemNameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            Text = "InventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewInventoryButton;
        private DateTimePicker itemLoggedDateTimePicker;
        private TextBox inventoryIdTextBox;
        private Button inventoryDeleteButton;
        private Button inventoryUpdateButton;
        private Button inventoryClearButton;
        private Button inventorySaveButton;
        private Label itemNameLabel;
        private TextBox itemNameTextBox;
        private TextBox itemQuantityTextBox;
        private Label inventoryIDLabel;
        private Label itemQuantityLabel;
        private Label itemLoggedDateLabel;
        private Label addNewItemLabel;
    }
}