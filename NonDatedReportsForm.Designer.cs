namespace AdminDashboard
{
    partial class NonDatedReportsForm
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
            datedReportsButton = new Button();
            reportPrintButton = new Button();
            reportFiltreButton = new Button();
            label1 = new Label();
            reportTpyeComboBox = new ComboBox();
            reportsDataGridView = new DataGridView();
            ReportsLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)reportsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // datedReportsButton
            // 
            datedReportsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            datedReportsButton.Cursor = Cursors.Hand;
            datedReportsButton.Location = new Point(357, 47);
            datedReportsButton.Name = "datedReportsButton";
            datedReportsButton.Size = new Size(124, 23);
            datedReportsButton.TabIndex = 124;
            datedReportsButton.Text = "Dated Reports";
            datedReportsButton.UseVisualStyleBackColor = true;
            datedReportsButton.Click += datedReportsButton_Click;
            // 
            // reportPrintButton
            // 
            reportPrintButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reportPrintButton.Location = new Point(935, 100);
            reportPrintButton.Name = "reportPrintButton";
            reportPrintButton.Size = new Size(82, 23);
            reportPrintButton.TabIndex = 123;
            reportPrintButton.Text = "Print";
            reportPrintButton.UseVisualStyleBackColor = true;
            // 
            // reportFiltreButton
            // 
            reportFiltreButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            reportFiltreButton.Location = new Point(830, 100);
            reportFiltreButton.Name = "reportFiltreButton";
            reportFiltreButton.Size = new Size(82, 23);
            reportFiltreButton.TabIndex = 122;
            reportFiltreButton.Text = "Flitre";
            reportFiltreButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 103);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 117;
            label1.Text = "Departments:";
            // 
            // reportTpyeComboBox
            // 
            reportTpyeComboBox.FormattingEnabled = true;
            reportTpyeComboBox.Items.AddRange(new object[] { "", "Administration", "Formation", "Liturgical", "Maintenance", "Pastoral", "Social", "Sodalities", "Other" });
            reportTpyeComboBox.Location = new Point(123, 99);
            reportTpyeComboBox.Name = "reportTpyeComboBox";
            reportTpyeComboBox.Size = new Size(136, 23);
            reportTpyeComboBox.TabIndex = 116;
            // 
            // reportsDataGridView
            // 
            reportsDataGridView.BackgroundColor = Color.WhiteSmoke;
            reportsDataGridView.BorderStyle = BorderStyle.None;
            reportsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportsDataGridView.Location = new Point(46, 146);
            reportsDataGridView.Name = "reportsDataGridView";
            reportsDataGridView.Size = new Size(971, 347);
            reportsDataGridView.TabIndex = 115;
            // 
            // ReportsLabel
            // 
            ReportsLabel.AutoSize = true;
            ReportsLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            ReportsLabel.Location = new Point(35, 27);
            ReportsLabel.Name = "ReportsLabel";
            ReportsLabel.Size = new Size(148, 47);
            ReportsLabel.TabIndex = 114;
            ReportsLabel.Text = "Reports";
            ReportsLabel.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 103);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 126;
            label2.Text = "Sodalities:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(618, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 128;
            label3.Text = "Age Group:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "12 - 18 Years", "19 - 29 Years", "30 - 39 Years", "40 - 49 Years", "50 - 59 Years", "60 - 69 Years", "70 - 79 Years", "80+ Years" });
            comboBox2.Location = new Point(685, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(115, 23);
            comboBox2.TabIndex = 127;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Catholic Nurses Guild", "Catholic Women's League", "Catholic Women's Union", "Daughters of St. Anne's", "Holy Childhood", "Knights of de Gama", "Sacred Heart Sodality", "Sodality of Mary", "St. Anne's Sodality", "St. Dominic's Sodality", "St. Francis", "St. Joseph's Sodality", "St. Vincent de Paul", "Udodana - Young Men Sodality" });
            comboBox1.Location = new Point(357, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 129;
            // 
            // NonDatedReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(datedReportsButton);
            Controls.Add(reportPrintButton);
            Controls.Add(reportFiltreButton);
            Controls.Add(label1);
            Controls.Add(reportTpyeComboBox);
            Controls.Add(reportsDataGridView);
            Controls.Add(ReportsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NonDatedReportsForm";
            Text = "NoneDatedReportsForm";
            ((System.ComponentModel.ISupportInitialize)reportsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button datedReportsButton;
        private Button reportPrintButton;
        private Button reportFiltreButton;
        private Label label1;
        private ComboBox reportTpyeComboBox;
        private DataGridView reportsDataGridView;
        private Label ReportsLabel;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}