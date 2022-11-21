namespace FCI_
{
    partial class StaffLogin
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StaffLoginLabel = new System.Windows.Forms.Label();
            this.StaffIdLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.StaffIdtxtBox = new System.Windows.Forms.TextBox();
            this.PasswordtxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(183, 306);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(284, 306);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 29);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(27, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // StaffLoginLabel
            // 
            this.StaffLoginLabel.AutoSize = true;
            this.StaffLoginLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StaffLoginLabel.Location = new System.Drawing.Point(93, 76);
            this.StaffLoginLabel.Name = "StaffLoginLabel";
            this.StaffLoginLabel.Size = new System.Drawing.Size(212, 50);
            this.StaffLoginLabel.TabIndex = 3;
            this.StaffLoginLabel.Text = "Staff Login";
            // 
            // StaffIdLabel
            // 
            this.StaffIdLabel.AutoSize = true;
            this.StaffIdLabel.Location = new System.Drawing.Point(71, 204);
            this.StaffIdLabel.Name = "StaffIdLabel";
            this.StaffIdLabel.Size = new System.Drawing.Size(59, 20);
            this.StaffIdLabel.TabIndex = 4;
            this.StaffIdLabel.Text = "Staff ID";
            this.StaffIdLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(71, 258);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 20);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label3_Click);
            // 
            // StaffIdtxtBox
            // 
            this.StaffIdtxtBox.Location = new System.Drawing.Point(209, 201);
            this.StaffIdtxtBox.Name = "StaffIdtxtBox";
            this.StaffIdtxtBox.Size = new System.Drawing.Size(169, 27);
            this.StaffIdtxtBox.TabIndex = 6;
            // 
            // PasswordtxtBox
            // 
            this.PasswordtxtBox.Location = new System.Drawing.Point(209, 255);
            this.PasswordtxtBox.Name = "PasswordtxtBox";
            this.PasswordtxtBox.Size = new System.Drawing.Size(169, 27);
            this.PasswordtxtBox.TabIndex = 7;
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.PasswordtxtBox);
            this.Controls.Add(this.StaffIdtxtBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.StaffIdLabel);
            this.Controls.Add(this.StaffLoginLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ClearButton);
            this.Name = "StaffLogin";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ClearButton;
        private Button LoginButton;
        private Button ExitButton;
        private Label StaffLoginLabel;
        private Label StaffIdLabel;
        private Label password;
        private TextBox StaffIdtxtBox;
        private TextBox PasswordtxtBox;
    }
}