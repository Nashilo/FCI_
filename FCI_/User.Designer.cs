namespace FCI_
{
    partial class User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowStudentForm = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.ShowStaffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowStudentForm
            // 
            this.ShowStudentForm.Location = new System.Drawing.Point(116, 228);
            this.ShowStudentForm.Name = "ShowStudentForm";
            this.ShowStudentForm.Size = new System.Drawing.Size(116, 29);
            this.ShowStudentForm.TabIndex = 0;
            this.ShowStudentForm.Text = "Student";
            this.ShowStudentForm.UseVisualStyleBackColor = true;
            this.ShowStudentForm.Click += new System.EventHandler(this.ShowStudentForm_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Welcome.Location = new System.Drawing.Point(106, 93);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(152, 38);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "WELCOME";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // ShowStaffButton
            // 
            this.ShowStaffButton.Location = new System.Drawing.Point(116, 294);
            this.ShowStaffButton.Name = "ShowStaffButton";
            this.ShowStaffButton.Size = new System.Drawing.Size(116, 29);
            this.ShowStaffButton.TabIndex = 4;
            this.ShowStaffButton.Text = "Staff";
            this.ShowStaffButton.UseVisualStyleBackColor = true;
            this.ShowStaffButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 436);
            this.Controls.Add(this.ShowStaffButton);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.ShowStudentForm);
            this.Name = "User";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ShowStudentForm;
        private Label Welcome;
        private Button ShowStaffButton;
    }
}