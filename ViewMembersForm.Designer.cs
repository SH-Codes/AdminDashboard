namespace AdminDashboard
{
    partial class ViewMembersForm
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
            viewMembersLabel = new Label();
            SuspendLayout();
            // 
            // viewMembersLabel
            // 
            viewMembersLabel.AutoSize = true;
            viewMembersLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            viewMembersLabel.Location = new Point(34, 26);
            viewMembersLabel.Name = "viewMembersLabel";
            viewMembersLabel.Size = new Size(265, 47);
            viewMembersLabel.TabIndex = 1;
            viewMembersLabel.Text = "View Members";
            // 
            // ViewMembersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 513);
            Controls.Add(viewMembersLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMembersForm";
            Text = "ViewMembersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label viewMembersLabel;
    }
}