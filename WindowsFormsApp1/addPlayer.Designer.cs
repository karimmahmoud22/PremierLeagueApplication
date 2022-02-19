
namespace WindowsFormsApp1
{
    partial class addPlayer
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
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.ComboBox();
            this.DOF = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Minit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passPower = new System.Windows.Forms.TextBox();
            this.injured = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dribbling = new System.Windows.Forms.TextBox();
            this.shootPower = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.player_salary = new System.Windows.Forms.TextBox();
            this.back_Coach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.team_id = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(411, 550);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 42);
            this.addButton.TabIndex = 77;
            this.addButton.Text = "Confirm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(494, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 97;
            this.label4.Text = "Price";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(695, 380);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(164, 21);
            this.price.TabIndex = 96;
            // 
            // Nationality
            // 
            this.Nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nationality.FormattingEnabled = true;
            this.Nationality.Items.AddRange(new object[] {
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
            this.Nationality.Location = new System.Drawing.Point(229, 208);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(164, 21);
            this.Nationality.TabIndex = 93;
            // 
            // DOF
            // 
            this.DOF.CustomFormat = "yyyy-MM-dd";
            this.DOF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOF.Location = new System.Drawing.Point(228, 271);
            this.DOF.Name = "DOF";
            this.DOF.Size = new System.Drawing.Size(164, 20);
            this.DOF.TabIndex = 91;
            this.DOF.Value = new System.DateTime(2021, 11, 11, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(60, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 27);
            this.label10.TabIndex = 90;
            this.label10.Text = "Date Of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(60, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 27);
            this.label9.TabIndex = 89;
            this.label9.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(60, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 27);
            this.label7.TabIndex = 87;
            this.label7.Text = "Nationality";
            // 
            // Minit
            // 
            this.Minit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minit.Location = new System.Drawing.Point(229, 87);
            this.Minit.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Minit.MaxLength = 1;
            this.Minit.Name = "Minit";
            this.Minit.Size = new System.Drawing.Size(164, 21);
            this.Minit.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(64, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 85;
            this.label1.Text = "Minit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(61, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 27);
            this.label8.TabIndex = 82;
            this.label8.Text = "Last Name";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(229, 146);
            this.lastName.MaxLength = 60;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(164, 21);
            this.lastName.TabIndex = 80;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(229, 33);
            this.firstName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.firstName.MaxLength = 60;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(164, 21);
            this.firstName.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(61, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 27);
            this.label12.TabIndex = 78;
            this.label12.Text = "First Name";
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "GK",
            "CF",
            "RB",
            "LB",
            "CMF",
            "AMF",
            "DMF",
            "SS",
            "FW",
            "LWF",
            "RWF"});
            this.position.Location = new System.Drawing.Point(228, 337);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(164, 21);
            this.position.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(60, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 100;
            this.label2.Text = "Pass Power";
            // 
            // passPower
            // 
            this.passPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passPower.Location = new System.Drawing.Point(228, 403);
            this.passPower.Name = "passPower";
            this.passPower.Size = new System.Drawing.Size(164, 21);
            this.passPower.TabIndex = 99;
            // 
            // injured
            // 
            this.injured.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.injured.FormattingEnabled = true;
            this.injured.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.injured.Location = new System.Drawing.Point(696, 201);
            this.injured.Name = "injured";
            this.injured.Size = new System.Drawing.Size(164, 21);
            this.injured.TabIndex = 111;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(493, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 27);
            this.label13.TabIndex = 109;
            this.label13.Text = "Height (m)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(493, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 27);
            this.label15.TabIndex = 107;
            this.label15.Text = "Injured";
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(696, 87);
            this.number.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.number.MaxLength = 60;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(164, 21);
            this.number.TabIndex = 106;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(493, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 27);
            this.label16.TabIndex = 105;
            this.label16.Text = "T-Shirt Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(494, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 27);
            this.label17.TabIndex = 104;
            this.label17.Text = "Dribbling";
            // 
            // dribbling
            // 
            this.dribbling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dribbling.Location = new System.Drawing.Point(696, 155);
            this.dribbling.MaxLength = 60;
            this.dribbling.Name = "dribbling";
            this.dribbling.Size = new System.Drawing.Size(164, 21);
            this.dribbling.TabIndex = 103;
            // 
            // shootPower
            // 
            this.shootPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootPower.Location = new System.Drawing.Point(696, 33);
            this.shootPower.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.shootPower.MaxLength = 60;
            this.shootPower.Name = "shootPower";
            this.shootPower.Size = new System.Drawing.Size(164, 21);
            this.shootPower.TabIndex = 102;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(494, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 27);
            this.label18.TabIndex = 101;
            this.label18.Text = "Shoot Power";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(695, 267);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(164, 21);
            this.height.TabIndex = 112;
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(695, 329);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(164, 21);
            this.weight.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(493, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 27);
            this.label3.TabIndex = 113;
            this.label3.Text = "Weight (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(494, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 116;
            this.label5.Text = "Salary";
            // 
            // player_salary
            // 
            this.player_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_salary.Location = new System.Drawing.Point(695, 433);
            this.player_salary.Name = "player_salary";
            this.player_salary.Size = new System.Drawing.Size(164, 21);
            this.player_salary.TabIndex = 115;
            // 
            // back_Coach
            // 
            this.back_Coach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Coach.Location = new System.Drawing.Point(37, 545);
            this.back_Coach.Name = "back_Coach";
            this.back_Coach.Size = new System.Drawing.Size(99, 47);
            this.back_Coach.TabIndex = 117;
            this.back_Coach.Text = "Log Out";
            this.back_Coach.UseVisualStyleBackColor = true;
            this.back_Coach.Click += new System.EventHandler(this.back_Coach_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(32, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 27);
            this.label6.TabIndex = 119;
            this.label6.Text = "Team_Name";
            // 
            // team_id
            // 
            this.team_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team_id.FormattingEnabled = true;
            this.team_id.Location = new System.Drawing.Point(213, 478);
            this.team_id.Name = "team_id";
            this.team_id.Size = new System.Drawing.Size(222, 21);
            this.team_id.TabIndex = 118;
            // 
            // addPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 615);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.team_id);
            this.Controls.Add(this.back_Coach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.player_salary);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.height);
            this.Controls.Add(this.injured);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dribbling);
            this.Controls.Add(this.shootPower);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passPower);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.DOF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Minit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addButton);
            this.Name = "addPlayer";
            this.Text = "addPlayer";
            this.Load += new System.EventHandler(this.addPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ComboBox Nationality;
        private System.Windows.Forms.DateTimePicker DOF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Minit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox injured;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox dribbling;
        private System.Windows.Forms.TextBox shootPower;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox player_salary;
        private System.Windows.Forms.Button back_Coach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox team_id;
        private System.Windows.Forms.TextBox passPower;
    }
}