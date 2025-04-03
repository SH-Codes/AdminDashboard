namespace AdminDashboard
{
    partial class ViewDependentsForm
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
            dependentAddNewButton = new Button();
            dependentsInfoLabel = new Label();
            dependentsListDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dependentsListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dependentAddNewButton
            // 
            dependentAddNewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dependentAddNewButton.Location = new Point(914, 135);
            dependentAddNewButton.Name = "dependentAddNewButton";
            dependentAddNewButton.Size = new Size(110, 23);
            dependentAddNewButton.TabIndex = 151;
            dependentAddNewButton.Text = "Add New";
            dependentAddNewButton.UseVisualStyleBackColor = true;
            dependentAddNewButton.Click += dependentAddNewButton_Click;
            // 
            // dependentsInfoLabel
            // 
            dependentsInfoLabel.AutoSize = true;
            dependentsInfoLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            dependentsInfoLabel.Location = new Point(29, 56);
            dependentsInfoLabel.Name = "dependentsInfoLabel";
            dependentsInfoLabel.Size = new Size(218, 47);
            dependentsInfoLabel.TabIndex = 136;
            dependentsInfoLabel.Text = "Dependents";
            // 
            // dependentsListDataGridView
            // 
            dependentsListDataGridView.BackgroundColor = Color.WhiteSmoke;
            dependentsListDataGridView.BorderStyle = BorderStyle.None;
            dependentsListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dependentsListDataGridView.Location = new Point(39, 135);
            dependentsListDataGridView.Name = "dependentsListDataGridView";
            dependentsListDataGridView.Size = new Size(823, 339);
            dependentsListDataGridView.TabIndex = 160;
            // 
            // ViewDependentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(dependentsListDataGridView);
            Controls.Add(dependentAddNewButton);
            Controls.Add(dependentsInfoLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewDependentsForm";
            Text = "ViewDependentsForm";
            Load += ViewDependentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dependentsListDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button dependentAddNewButton;
        private Label dependentsInfoLabel;
        private DataGridView dependentsListDataGridView;
    }
}