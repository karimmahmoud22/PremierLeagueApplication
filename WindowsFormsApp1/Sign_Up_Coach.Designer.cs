namespace WindowsFormsApp1
{
    partial class Sign_Up_Coach
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
            this.label4 = new System.Windows.Forms.Label();
            this.city_Coach = new System.Windows.Forms.TextBox();
            this.Re_Password_Coach = new System.Windows.Forms.TextBox();
            this.password_Coach = new System.Windows.Forms.TextBox();
            this.Nationality_Coach = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DOF_Coach = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Salary_Coach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Minit_Coach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back_Coach = new System.Windows.Forms.Button();
            this.email_Coach = new System.Windows.Forms.TextBox();
            this.submit_Coach = new System.Windows.Forms.Button();
            this.lastName_Coach = new System.Windows.Forms.TextBox();
            this.firstName_Coach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.team_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(139, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 27);
            this.label4.TabIndex = 79;
            this.label4.Text = "City";
            // 
            // city_Coach
            // 
            this.city_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_Coach.Location = new System.Drawing.Point(308, 441);
            this.city_Coach.Name = "city_Coach";
            this.city_Coach.Size = new System.Drawing.Size(231, 21);
            this.city_Coach.TabIndex = 78;
            // 
            // Re_Password_Coach
            // 
            this.Re_Password_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re_Password_Coach.Location = new System.Drawing.Point(308, 329);
            this.Re_Password_Coach.Name = "Re_Password_Coach";
            this.Re_Password_Coach.PasswordChar = '*';
            this.Re_Password_Coach.Size = new System.Drawing.Size(231, 21);
            this.Re_Password_Coach.TabIndex = 77;
            // 
            // password_Coach
            // 
            this.password_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Coach.Location = new System.Drawing.Point(308, 271);
            this.password_Coach.Name = "password_Coach";
            this.password_Coach.PasswordChar = '*';
            this.password_Coach.Size = new System.Drawing.Size(231, 21);
            this.password_Coach.TabIndex = 76;
            // 
            // Nationality_Coach
            // 
            this.Nationality_Coach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nationality_Coach.FormattingEnabled = true;
            this.Nationality_Coach.Items.AddRange(new object[] {
            "Afghan",
            "Albanian",
            "Algerian",
            "Australian",
            "Austrian",
            "Bangladeshi",
            "Belgian",
            "Bolivian",
            "Batswana",
            "Brazilian",
            "Bulgarian",
            "Cambodian",
            "Cameroonian",
            "Canadian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Costa Rican",
            "Croatian",
            "Cuban",
            "Czech",
            "Danish",
            "Dominican",
            "Ecuadorian",
            "Egyptian",
            "Salvadorian",
            "English",
            "Estonian",
            "Ethiopian",
            "Fijian",
            "Finnish",
            "French",
            "German",
            "Ghanaian",
            "Greek",
            "Iraqi",
            "Japanese",
            "Mexican",
            "Moroccan",
            "Portuguese",
            "Russian",
            "Saudi",
            "Swedish",
            "British",
            "Zambian",
            "Zimbabwean"});
            this.Nationality_Coach.Location = new System.Drawing.Point(328, 498);
            this.Nationality_Coach.Name = "Nationality_Coach";
            this.Nationality_Coach.Size = new System.Drawing.Size(162, 21);
            this.Nationality_Coach.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(123, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 27);
            this.label11.TabIndex = 74;
            this.label11.Text = "Re Password";
            // 
            // DOF_Coach
            // 
            this.DOF_Coach.CustomFormat = "yyyy-MM-dd";
            this.DOF_Coach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOF_Coach.Location = new System.Drawing.Point(380, 549);
            this.DOF_Coach.Name = "DOF_Coach";
            this.DOF_Coach.Size = new System.Drawing.Size(98, 20);
            this.DOF_Coach.TabIndex = 73;
            this.DOF_Coach.Value = new System.DateTime(2021, 11, 11, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(127, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 27);
            this.label10.TabIndex = 72;
            this.label10.Text = "Date_Of_Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(153, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 71;
            this.label9.Text = "Salary";
            // 
            // Salary_Coach
            // 
            this.Salary_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_Coach.Location = new System.Drawing.Point(308, 384);
            this.Salary_Coach.Name = "Salary_Coach";
            this.Salary_Coach.Size = new System.Drawing.Size(231, 21);
            this.Salary_Coach.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(131, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 27);
            this.label7.TabIndex = 69;
            this.label7.Text = "Nationality";
            // 
            // Minit_Coach
            // 
            this.Minit_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minit_Coach.Location = new System.Drawing.Point(308, 97);
            this.Minit_Coach.Margin = new System.Windows.Forms.Padding(10);
            this.Minit_Coach.MaxLength = 1;
            this.Minit_Coach.Name = "Minit_Coach";
            this.Minit_Coach.Size = new System.Drawing.Size(231, 21);
            this.Minit_Coach.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(166, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 67;
            this.label5.Text = "Minit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(139, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 66;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(153, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 65;
            this.label2.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(139, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 27);
            this.label6.TabIndex = 64;
            this.label6.Text = "Last Name";
            // 
            // back_Coach
            // 
            this.back_Coach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Coach.Location = new System.Drawing.Point(37, 647);
            this.back_Coach.Name = "back_Coach";
            this.back_Coach.Size = new System.Drawing.Size(99, 47);
            this.back_Coach.TabIndex = 63;
            this.back_Coach.Text = "Back";
            this.back_Coach.UseVisualStyleBackColor = true;
            this.back_Coach.Click += new System.EventHandler(this.back_Coach_Click);
            // 
            // email_Coach
            // 
            this.email_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_Coach.Location = new System.Drawing.Point(308, 213);
            this.email_Coach.MaxLength = 60;
            this.email_Coach.Name = "email_Coach";
            this.email_Coach.Size = new System.Drawing.Size(231, 21);
            this.email_Coach.TabIndex = 58;
            // 
            // submit_Coach
            // 
            this.submit_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_Coach.Location = new System.Drawing.Point(589, 647);
            this.submit_Coach.Name = "submit_Coach";
            this.submit_Coach.Size = new System.Drawing.Size(140, 54);
            this.submit_Coach.TabIndex = 62;
            this.submit_Coach.Text = "Submit";
            this.submit_Coach.UseVisualStyleBackColor = true;
            this.submit_Coach.Click += new System.EventHandler(this.submit_Coach_Click);
            // 
            // lastName_Coach
            // 
            this.lastName_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_Coach.Location = new System.Drawing.Point(308, 156);
            this.lastName_Coach.MaxLength = 60;
            this.lastName_Coach.Name = "lastName_Coach";
            this.lastName_Coach.Size = new System.Drawing.Size(231, 21);
            this.lastName_Coach.TabIndex = 57;
            // 
            // firstName_Coach
            // 
            this.firstName_Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_Coach.Location = new System.Drawing.Point(308, 43);
            this.firstName_Coach.Margin = new System.Windows.Forms.Padding(10);
            this.firstName_Coach.MaxLength = 60;
            this.firstName_Coach.Name = "firstName_Coach";
            this.firstName_Coach.Size = new System.Drawing.Size(231, 21);
            this.firstName_Coach.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "First Name";
            // 
            // team_id
            // 
            this.team_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team_id.FormattingEnabled = true;
            this.team_id.Location = new System.Drawing.Point(308, 599);
            this.team_id.Name = "team_id";
            this.team_id.Size = new System.Drawing.Size(222, 21);
            this.team_id.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(127, 599);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 27);
            this.label8.TabIndex = 81;
            this.label8.Text = "Team_ID";
            // 
            // Sign_Up_Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.team_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.city_Coach);
            this.Controls.Add(this.Re_Password_Coach);
            this.Controls.Add(this.password_Coach);
            this.Controls.Add(this.Nationality_Coach);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DOF_Coach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Salary_Coach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Minit_Coach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_Coach);
            this.Controls.Add(this.email_Coach);
            this.Controls.Add(this.submit_Coach);
            this.Controls.Add(this.lastName_Coach);
            this.Controls.Add(this.firstName_Coach);
            this.Controls.Add(this.label1);
            this.Name = "Sign_Up_Coach";
            this.Text = "Coach";
            this.Load += new System.EventHandler(this.Sign_Up_Coach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox city_Coach;
        private System.Windows.Forms.TextBox Re_Password_Coach;
        private System.Windows.Forms.TextBox password_Coach;
        private System.Windows.Forms.ComboBox Nationality_Coach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DOF_Coach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Salary_Coach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Minit_Coach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_Coach;
        private System.Windows.Forms.TextBox email_Coach;
        private System.Windows.Forms.Button submit_Coach;
        private System.Windows.Forms.TextBox lastName_Coach;
        private System.Windows.Forms.TextBox firstName_Coach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox team_id;
        private System.Windows.Forms.Label label8;
    }
}