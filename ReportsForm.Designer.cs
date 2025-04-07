namespace AdminDashboard
{
    partial class ReportsForm
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
            ReportsLabel = new Label();
            reportsDataGridView = new DataGridView();
            reportTpyeComboBox = new ComboBox();
            label1 = new Label();
            reportFromDateTimePicker = new DateTimePicker();
            label2 = new Label();
            reportToDateTimePicker = new DateTimePicker();
            label3 = new Label();
            reportFiltreButton = new Button();
            reportPrintButton = new Button();
            nonDatedReportsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)reportsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReportsLabel
            // 
            ReportsLabel.AutoSize = true;
            ReportsLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            ReportsLabel.Location = new Point(29, 24);
            ReportsLabel.Name = "ReportsLabel";
            ReportsLabel.Size = new Size(148, 47);
            ReportsLabel.TabIndex = 55;
            ReportsLabel.Text = "Reports";
            ReportsLabel.UseMnemonic = false;
            // 
            // reportsDataGridView
            // 
            reportsDataGridView.BackgroundColor = Color.WhiteSmoke;
            reportsDataGridView.BorderStyle = BorderStyle.None;
            reportsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportsDataGridView.Location = new Point(40, 143);
            reportsDataGridView.Name = "reportsDataGridView";
            reportsDataGridView.Size = new Size(971, 347);
            reportsDataGridView.TabIndex = 56;
            // 
            // reportTpyeComboBox
            // 
            reportTpyeComboBox.FormattingEnabled = true;
            reportTpyeComboBox.Items.AddRange(new object[] { "", "Baptism", "Communion", "Confirmation", "Death", "Donation", "Financial", "Inventory", "Marriage", "Tithe" });
            reportTpyeComboBox.Location = new Point(118, 97);
            reportTpyeComboBox.Name = "reportTpyeComboBox";
            reportTpyeComboBox.Size = new Size(164, 23);
            reportTpyeComboBox.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 101);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 58;
            label1.Text = "Report Type:";
            // 
            // reportFromDateTimePicker
            // 
            reportFromDateTimePicker.Location = new Point(351, 97);
            reportFromDateTimePicker.Name = "reportFromDateTimePicker";
            reportFromDateTimePicker.Size = new Size(200, 23);
            reportFromDateTimePicker.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 101);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 60;
            label2.Text = "From:";
            // 
            // reportToDateTimePicker
            // 
            reportToDateTimePicker.Location = new Point(598, 97);
            reportToDateTimePicker.Name = "reportToDateTimePicker";
            reportToDateTimePicker.Size = new Size(200, 23);
            reportToDateTimePicker.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(569, 101);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 62;
            label3.Text = "To:";
            // 
            // reportFiltreButton
            // 
            reportFiltreButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reportFiltreButton.Location = new Point(824, 97);
            reportFiltreButton.Name = "reportFiltreButton";
            reportFiltreButton.Size = new Size(82, 23);
            reportFiltreButton.TabIndex = 111;
            reportFiltreButton.Text = "Flitre";
            reportFiltreButton.UseVisualStyleBackColor = true;
            // 
            // reportPrintButton
            // 
            reportPrintButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reportPrintButton.Location = new Point(929, 97);
            reportPrintButton.Name = "reportPrintButton";
            reportPrintButton.Size = new Size(82, 23);
            reportPrintButton.TabIndex = 112;
            reportPrintButton.Text = "Print";
            reportPrintButton.UseVisualStyleBackColor = true;
            // 
            // nonDatedReportsButton
            // 
            nonDatedReportsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nonDatedReportsButton.Cursor = Cursors.Hand;
            nonDatedReportsButton.Location = new Point(351, 44);
            nonDatedReportsButton.Name = "nonDatedReportsButton";
            nonDatedReportsButton.Size = new Size(124, 23);
            nonDatedReportsButton.TabIndex = 113;
            nonDatedReportsButton.Text = "Non-Dated Reports";
            nonDatedReportsButton.UseVisualStyleBackColor = true;
            nonDatedReportsButton.Click += nonDatedReportsButton_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(nonDatedReportsButton);
            Controls.Add(reportPrintButton);
            Controls.Add(reportFiltreButton);
            Controls.Add(label3);
            Controls.Add(reportToDateTimePicker);
            Controls.Add(label2);
            Controls.Add(reportFromDateTimePicker);
            Controls.Add(label1);
            Controls.Add(reportTpyeComboBox);
            Controls.Add(reportsDataGridView);
            Controls.Add(ReportsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsForm";
            Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)reportsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReportsLabel;
        private DataGridView reportsDataGridView;
        private ComboBox reportTpyeComboBox;
        private Label label1;
        private DateTimePicker reportFromDateTimePicker;
        private Label label2;
        private DateTimePicker reportToDateTimePicker;
        private Label label3;
        private Button reportFiltreButton;
        private Button reportPrintButton;
        private Button nonDatedReportsButton;
    }
}