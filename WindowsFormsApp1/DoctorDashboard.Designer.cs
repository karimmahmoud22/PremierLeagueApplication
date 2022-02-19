namespace WindowsFormsApp1
{
    partial class DoctorDashboard
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.injured_duration = new System.Windows.Forms.NumericUpDown();
            this.allPlayers_INJURED = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.doctorConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.injures_or_not_only = new System.Windows.Forms.ComboBox();
            this.report_about_injury = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injured_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.report_about_injury);
            this.groupBox3.Controls.Add(this.injures_or_not_only);
            this.groupBox3.Controls.Add(this.injured_duration);
            this.groupBox3.Controls.Add(this.allPlayers_INJURED);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.doctorConfirm);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(56, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 365);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player Injury";
            // 
            // injured_duration
            // 
            this.injured_duration.Location = new System.Drawing.Point(140, 153);
            this.injured_duration.Name = "injured_duration";
            this.injured_duration.Size = new System.Drawing.Size(202, 20);
            this.injured_duration.TabIndex = 20;
            // 
            // allPlayers_INJURED
            // 
            this.allPlayers_INJURED.FormattingEnabled = true;
            this.allPlayers_INJURED.Items.AddRange(new object[] {
            "A",
            "B"});
            this.allPlayers_INJURED.Location = new System.Drawing.Point(140, 37);
            this.allPlayers_INJURED.Name = "allPlayers_INJURED";
            this.allPlayers_INJURED.Size = new System.Drawing.Size(202, 21);
            this.allPlayers_INJURED.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Report about the Injury";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Injured Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Case Specification";
            // 
            // doctorConfirm
            // 
            this.doctorConfirm.Location = new System.Drawing.Point(140, 327);
            this.doctorConfirm.Name = "doctorConfirm";
            this.doctorConfirm.Size = new System.Drawing.Size(75, 23);
            this.doctorConfirm.TabIndex = 2;
            this.doctorConfirm.Text = "Confirm";
            this.doctorConfirm.UseVisualStyleBackColor = true;
            this.doctorConfirm.Click += new System.EventHandler(this.doctorConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose Player";
            // 
            // injures_or_not_only
            // 
            this.injures_or_not_only.FormattingEnabled = true;
            this.injures_or_not_only.Items.AddRange(new object[] {
            "A",
            "B"});
            this.injures_or_not_only.Location = new System.Drawing.Point(140, 94);
            this.injures_or_not_only.Name = "injures_or_not_only";
            this.injures_or_not_only.Size = new System.Drawing.Size(202, 21);
            this.injures_or_not_only.TabIndex = 23;
            // 
            // report_about_injury
            // 
            this.report_about_injury.Location = new System.Drawing.Point(140, 211);
            this.report_about_injury.Multiline = true;
            this.report_about_injury.Name = "report_about_injury";
            this.report_about_injury.Size = new System.Drawing.Size(202, 93);
            this.report_about_injury.TabIndex = 24;
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "DoctorDashboard";
            this.Text = "Form2";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injured_duration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown injured_duration;
        private System.Windows.Forms.ComboBox allPlayers_INJURED;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button doctorConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox injures_or_not_only;
        private System.Windows.Forms.TextBox report_about_injury;
    }
}