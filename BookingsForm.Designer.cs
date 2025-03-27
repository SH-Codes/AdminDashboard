namespace AdminDashboard
{
    partial class BookingsForm
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
            viewFileButton = new Button();
            memberDeleteButton = new Button();
            memberUpdateButton = new Button();
            memberClearButton = new Button();
            memberSaveButton = new Button();
            bookingsLabel = new Label();
            SuspendLayout();
            // 
            // viewFileButton
            // 
            viewFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewFileButton.Location = new Point(914, 287);
            viewFileButton.Name = "viewFileButton";
            viewFileButton.Size = new Size(110, 23);
            viewFileButton.TabIndex = 85;
            viewFileButton.Text = "View File";
            viewFileButton.UseVisualStyleBackColor = true;
            // 
            // memberDeleteButton
            // 
            memberDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberDeleteButton.Location = new Point(914, 240);
            memberDeleteButton.Name = "memberDeleteButton";
            memberDeleteButton.Size = new Size(110, 23);
            memberDeleteButton.TabIndex = 84;
            memberDeleteButton.Text = "Delete";
            memberDeleteButton.UseVisualStyleBackColor = true;
            // 
            // memberUpdateButton
            // 
            memberUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            memberUpdateButton.Location = new Point(914, 195);
            memberUpdateButton.Name = "memberUpdateButton";
            memberUpdateButton.Size = new Size(110, 23);
            memberUpdateButton.TabIndex = 83;
            memberUpdateButton.Text = "Update";
            memberUpdateButton.UseVisualStyleBackColor = true;
            // 
            // memberClearButton
            // 
            memberClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            memberClearButton.Location = new Point(914, 152);
            memberClearButton.Name = "memberClearButton";
            memberClearButton.Size = new Size(110, 23);
            memberClearButton.TabIndex = 82;
            memberClearButton.Text = "Clear";
            memberClearButton.UseVisualStyleBackColor = true;
            // 
            // memberSaveButton
            // 
            memberSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            memberSaveButton.Location = new Point(914, 114);
            memberSaveButton.Name = "memberSaveButton";
            memberSaveButton.Size = new Size(110, 23);
            memberSaveButton.TabIndex = 81;
            memberSaveButton.Text = "Save";
            memberSaveButton.UseVisualStyleBackColor = true;
            // 
            // bookingsLabel
            // 
            bookingsLabel.AutoSize = true;
            bookingsLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            bookingsLabel.Location = new Point(29, 33);
            bookingsLabel.Name = "bookingsLabel";
            bookingsLabel.Size = new Size(172, 47);
            bookingsLabel.TabIndex = 55;
            bookingsLabel.Text = "Bookings";
            // 
            // BookingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 530);
            Controls.Add(viewFileButton);
            Controls.Add(memberDeleteButton);
            Controls.Add(memberUpdateButton);
            Controls.Add(memberClearButton);
            Controls.Add(memberSaveButton);
            Controls.Add(bookingsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingsForm";
            Text = "BookingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewFileButton;
        private Button memberDeleteButton;
        private Button memberUpdateButton;
        private Button memberClearButton;
        private Button memberSaveButton;
        private Label bookingsLabel;
    }
}