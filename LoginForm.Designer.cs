namespace AdminDashboard
{
    partial class LoginForm
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
            label1 = new Label();
            userNameLoginTextBox = new TextBox();
            userNamePasswordTextBox = new TextBox();
            LoginPanel = new Panel();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(686, 130);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // userNameLoginTextBox
            // 
            userNameLoginTextBox.Font = new Font("Segoe UI", 14F);
            userNameLoginTextBox.Location = new Point(599, 198);
            userNameLoginTextBox.Name = "userNameLoginTextBox";
            userNameLoginTextBox.Size = new Size(244, 32);
            userNameLoginTextBox.TabIndex = 1;
            // 
            // userNamePasswordTextBox
            // 
            userNamePasswordTextBox.Font = new Font("Segoe UI", 14F);
            userNamePasswordTextBox.Location = new Point(599, 255);
            userNamePasswordTextBox.MaxLength = 32;
            userNamePasswordTextBox.Name = "userNamePasswordTextBox";
            userNamePasswordTextBox.Size = new Size(244, 32);
            userNamePasswordTextBox.TabIndex = 2;
            userNamePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = SystemColors.Highlight;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(366, 515);
            LoginPanel.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.Highlight;
            LoginButton.BackgroundImageLayout = ImageLayout.None;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(599, 333);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(244, 32);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1052, 513);
            Controls.Add(LoginButton);
            Controls.Add(LoginPanel);
            Controls.Add(userNamePasswordTextBox);
            Controls.Add(userNameLoginTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameLoginTextBox;
        private TextBox userNamePasswordTextBox;
        private Panel LoginPanel;
        private Button LoginButton;
    }
}