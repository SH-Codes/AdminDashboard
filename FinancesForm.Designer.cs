namespace AdminDashboard
{
    partial class FinancesForm
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
            FinancesLabel = new Label();
            SuspendLayout();
            // 
            // FinancesLabel
            // 
            FinancesLabel.AutoSize = true;
            FinancesLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            FinancesLabel.Location = new Point(29, 24);
            FinancesLabel.Name = "FinancesLabel";
            FinancesLabel.Size = new Size(160, 47);
            FinancesLabel.TabIndex = 55;
            FinancesLabel.Text = "Finances";
            // 
            // FinancesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 513);
            Controls.Add(FinancesLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FinancesForm";
            Text = "FinancesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FinancesLabel;
    }
}