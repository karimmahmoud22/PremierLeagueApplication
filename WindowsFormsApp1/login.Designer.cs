
namespace WindowsFormsApp1
{
    partial class login
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
            this.Back_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Log_in_button = new System.Windows.Forms.Button();
            this.jobs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.resetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(32, 544);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(99, 56);
            this.Back_Button.TabIndex = 18;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(251, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 46);
            this.label2.TabIndex = 22;
            this.label2.Text = "E-mail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(409, 157);
            this.email_box.MaxLength = 60;
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(231, 21);
            this.email_box.TabIndex = 21;
            this.email_box.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(409, 237);
            this.password_box.MaxLength = 60;
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(231, 21);
            this.password_box.TabIndex = 23;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // Log_in_button
            // 
            this.Log_in_button.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_in_button.Location = new System.Drawing.Point(409, 433);
            this.Log_in_button.Name = "Log_in_button";
            this.Log_in_button.Size = new System.Drawing.Size(99, 56);
            this.Log_in_button.TabIndex = 25;
            this.Log_in_button.Text = "Log in";
            this.Log_in_button.UseVisualStyleBackColor = true;
            this.Log_in_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // jobs
            // 
            this.jobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobs.FormattingEnabled = true;
            this.jobs.Items.AddRange(new object[] {
            "Supervisor",
            "Supervisoer Assistant",
            "Doctor",
            "Coach",
            "Statistician",
            "Fitness Trainer"});
            this.jobs.Location = new System.Drawing.Point(409, 317);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(231, 21);
            this.jobs.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 46);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select Your Job";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(241, 45);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(410, 31);
            this.error.TabIndex = 28;
            this.error.Text = "Email or Password is Incorrect";
            this.error.Visible = false;
            // 
            // resetPassword
            // 
            this.resetPassword.AutoSize = true;
            this.resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword.LinkColor = System.Drawing.Color.Red;
            this.resetPassword.Location = new System.Drawing.Point(405, 369);
            this.resetPassword.Name = "resetPassword";
            this.resetPassword.Size = new System.Drawing.Size(159, 24);
            this.resetPassword.TabIndex = 30;
            this.resetPassword.TabStop = true;
            this.resetPassword.Text = "Reset Password";
            this.resetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetPassword_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(893, 625);
            this.Controls.Add(this.resetPassword);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobs);
            this.Controls.Add(this.Log_in_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.Back_Button);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "login";
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log_in_button;
        private System.Windows.Forms.ComboBox jobs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.LinkLabel resetPassword;
    }
}