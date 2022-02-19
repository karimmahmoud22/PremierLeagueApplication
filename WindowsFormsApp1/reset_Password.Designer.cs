
namespace WindowsFormsApp1
{
    partial class Password
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
            this.button1 = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.jobs = new System.Windows.Forms.ComboBox();
            this.email = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(318, 145);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(231, 20);
            this.emailBox.TabIndex = 1;
            // 
            // jobs
            // 
            this.jobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobs.FormattingEnabled = true;
            this.jobs.Items.AddRange(new object[] {
            "supervisor",
            "supervisor_assistant",
            "doctor",
            "coach",
            "Manager",
            "fitness_trainer"});
            this.jobs.Location = new System.Drawing.Point(318, 180);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(231, 21);
            this.jobs.TabIndex = 27;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(208, 148);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 13);
            this.email.TabIndex = 28;
            this.email.Text = "Your E-mail";
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Location = new System.Drawing.Point(208, 188);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(49, 13);
            this.job.TabIndex = 29;
            this.job.Text = "Your Job";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Location = new System.Drawing.Point(208, 236);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(78, 13);
            this.newLabel.TabIndex = 30;
            this.newLabel.Text = "New Password";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(318, 229);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(231, 20);
            this.newPassword.TabIndex = 31;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.job);
            this.Controls.Add(this.email);
            this.Controls.Add(this.jobs);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.button1);
            this.Name = "Password";
            this.Text = "resetPassword";
            this.Load += new System.EventHandler(this.Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.ComboBox jobs;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label job;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.TextBox newPassword;
    }
}