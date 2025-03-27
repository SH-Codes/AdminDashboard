namespace AdminDashboard
{
    partial class SettingsForm
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
            SettingsLabel = new Label();
            lightModeRadioButton = new RadioButton();
            darkModeRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // SettingsLabel
            // 
            SettingsLabel.AutoSize = true;
            SettingsLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            SettingsLabel.Location = new Point(29, 24);
            SettingsLabel.Name = "SettingsLabel";
            SettingsLabel.Size = new Size(155, 47);
            SettingsLabel.TabIndex = 55;
            SettingsLabel.Text = "Settings";
            // 
            // lightModeRadioButton
            // 
            lightModeRadioButton.AutoSize = true;
            lightModeRadioButton.Checked = true;
            lightModeRadioButton.Location = new Point(55, 418);
            lightModeRadioButton.Name = "lightModeRadioButton";
            lightModeRadioButton.Size = new Size(86, 19);
            lightModeRadioButton.TabIndex = 56;
            lightModeRadioButton.TabStop = true;
            lightModeRadioButton.Text = "Light Mode";
            lightModeRadioButton.UseVisualStyleBackColor = true;
            lightModeRadioButton.CheckedChanged += lightModeRadioButton_CheckedChanged;
            // 
            // darkModeRadioButton
            // 
            darkModeRadioButton.AutoSize = true;
            darkModeRadioButton.Location = new Point(215, 418);
            darkModeRadioButton.Name = "darkModeRadioButton";
            darkModeRadioButton.Size = new Size(83, 19);
            darkModeRadioButton.TabIndex = 57;
            darkModeRadioButton.Text = "Dark Mode";
            darkModeRadioButton.UseVisualStyleBackColor = true;
            darkModeRadioButton.CheckedChanged += darkModeRadioButton_CheckedChanged;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(darkModeRadioButton);
            Controls.Add(lightModeRadioButton);
            Controls.Add(SettingsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SettingsLabel;
        private RadioButton lightModeRadioButton;
        private RadioButton darkModeRadioButton;
    }
}