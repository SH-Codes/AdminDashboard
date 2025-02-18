namespace AdminDashboard
{
    partial class DashboardForm
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
            overviewLabel = new Label();
            SuspendLayout();
            // 
            // overviewLabel
            // 
            overviewLabel.AutoSize = true;
            overviewLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            overviewLabel.Location = new Point(26, 27);
            overviewLabel.Name = "overviewLabel";
            overviewLabel.Size = new Size(176, 47);
            overviewLabel.TabIndex = 0;
            overviewLabel.Text = "Overview";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(978, 511);
            Controls.Add(overviewLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label overviewLabel;
    }
}