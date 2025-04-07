namespace AdminDashboard
{
    partial class ViewInventoryForm
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
            inventoryAddNewButton = new Button();
            PaymentLabel = new Label();
            inventoryDataGridView = new DataGridView();
            printButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inventoryAddNewButton
            // 
            inventoryAddNewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inventoryAddNewButton.Location = new Point(911, 105);
            inventoryAddNewButton.Name = "inventoryAddNewButton";
            inventoryAddNewButton.Size = new Size(110, 23);
            inventoryAddNewButton.TabIndex = 162;
            inventoryAddNewButton.Text = "Add New";
            inventoryAddNewButton.UseVisualStyleBackColor = true;
            inventoryAddNewButton.Click += inventoryAddNewButton_Click;
            // 
            // PaymentLabel
            // 
            PaymentLabel.AutoSize = true;
            PaymentLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            PaymentLabel.Location = new Point(21, 26);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(159, 47);
            PaymentLabel.TabIndex = 157;
            PaymentLabel.Text = "Iventory";
            // 
            // inventoryDataGridView
            // 
            inventoryDataGridView.BackgroundColor = Color.WhiteSmoke;
            inventoryDataGridView.BorderStyle = BorderStyle.None;
            inventoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryDataGridView.Location = new Point(31, 105);
            inventoryDataGridView.Name = "inventoryDataGridView";
            inventoryDataGridView.Size = new Size(847, 385);
            inventoryDataGridView.TabIndex = 164;
            // 
            // printButton
            // 
            printButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            printButton.Location = new Point(911, 148);
            printButton.Name = "printButton";
            printButton.Size = new Size(110, 23);
            printButton.TabIndex = 165;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            // 
            // ViewInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(printButton);
            Controls.Add(inventoryDataGridView);
            Controls.Add(inventoryAddNewButton);
            Controls.Add(PaymentLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewInventoryForm";
            Text = "ViewInventoryForm";
            ((System.ComponentModel.ISupportInitialize)inventoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button inventoryAddNewButton;
        private Label PaymentLabel;
        private DataGridView inventoryDataGridView;
        private Button printButton;
    }
}