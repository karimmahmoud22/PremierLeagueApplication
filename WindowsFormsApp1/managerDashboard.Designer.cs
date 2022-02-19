
namespace WindowsFormsApp1
{
    partial class managerDashboard
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
            this.addPlayer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removePlayer = new System.Windows.Forms.Button();
            this.allPlayers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Transfer_to = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.team_from = new System.Windows.Forms.ComboBox();
            this.transferConfirm = new System.Windows.Forms.Button();
            this.teamPlayers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rcards = new System.Windows.Forms.TextBox();
            this.yCards = new System.Windows.Forms.TextBox();
            this.goalsCount = new System.Windows.Forms.TextBox();
            this.assistsCount = new System.Windows.Forms.TextBox();
            this.allPlayers_update = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.back_Coach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPlayer
            // 
            this.addPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayer.Location = new System.Drawing.Point(498, 76);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(396, 136);
            this.addPlayer.TabIndex = 0;
            this.addPlayer.Text = "Add Player";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removePlayer);
            this.groupBox2.Controls.Add(this.allPlayers);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(38, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 136);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Player";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // removePlayer
            // 
            this.removePlayer.Location = new System.Drawing.Point(79, 91);
            this.removePlayer.Name = "removePlayer";
            this.removePlayer.Size = new System.Drawing.Size(75, 23);
            this.removePlayer.TabIndex = 2;
            this.removePlayer.Text = "Confirm";
            this.removePlayer.UseVisualStyleBackColor = true;
            this.removePlayer.Click += new System.EventHandler(this.removePlayer_Click);
            // 
            // allPlayers
            // 
            this.allPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allPlayers.FormattingEnabled = true;
            this.allPlayers.Location = new System.Drawing.Point(79, 55);
            this.allPlayers.Name = "allPlayers";
            this.allPlayers.Size = new System.Drawing.Size(222, 21);
            this.allPlayers.TabIndex = 1;
            this.allPlayers.SelectedIndexChanged += new System.EventHandler(this.allPlayers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Transfer_to);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.team_from);
            this.groupBox1.Controls.Add(this.transferConfirm);
            this.groupBox1.Controls.Add(this.teamPlayers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 365);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Players";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transfer To";
            // 
            // Transfer_to
            // 
            this.Transfer_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Transfer_to.FormattingEnabled = true;
            this.Transfer_to.Location = new System.Drawing.Point(183, 173);
            this.Transfer_to.Name = "Transfer_to";
            this.Transfer_to.Size = new System.Drawing.Size(222, 21);
            this.Transfer_to.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transfer From";
            // 
            // team_from
            // 
            this.team_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team_from.FormattingEnabled = true;
            this.team_from.Location = new System.Drawing.Point(183, 106);
            this.team_from.Name = "team_from";
            this.team_from.Size = new System.Drawing.Size(222, 21);
            this.team_from.TabIndex = 3;
            // 
            // transferConfirm
            // 
            this.transferConfirm.Location = new System.Drawing.Point(183, 268);
            this.transferConfirm.Name = "transferConfirm";
            this.transferConfirm.Size = new System.Drawing.Size(75, 23);
            this.transferConfirm.TabIndex = 2;
            this.transferConfirm.Text = "Confirm";
            this.transferConfirm.UseVisualStyleBackColor = true;
            this.transferConfirm.Click += new System.EventHandler(this.transferConfirm_Click);
            // 
            // teamPlayers
            // 
            this.teamPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamPlayers.FormattingEnabled = true;
            this.teamPlayers.Location = new System.Drawing.Point(183, 40);
            this.teamPlayers.Name = "teamPlayers";
            this.teamPlayers.Size = new System.Drawing.Size(222, 21);
            this.teamPlayers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Player";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rcards);
            this.groupBox3.Controls.Add(this.yCards);
            this.groupBox3.Controls.Add(this.goalsCount);
            this.groupBox3.Controls.Add(this.assistsCount);
            this.groupBox3.Controls.Add(this.allPlayers_update);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.updateConfirm);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(498, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 365);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Player";
            // 
            // rcards
            // 
            this.rcards.Location = new System.Drawing.Point(140, 271);
            this.rcards.Name = "rcards";
            this.rcards.Size = new System.Drawing.Size(202, 20);
            this.rcards.TabIndex = 68;
            // 
            // yCards
            // 
            this.yCards.Location = new System.Drawing.Point(140, 207);
            this.yCards.Name = "yCards";
            this.yCards.Size = new System.Drawing.Size(202, 20);
            this.yCards.TabIndex = 67;
            // 
            // goalsCount
            // 
            this.goalsCount.Location = new System.Drawing.Point(140, 90);
            this.goalsCount.Name = "goalsCount";
            this.goalsCount.Size = new System.Drawing.Size(202, 20);
            this.goalsCount.TabIndex = 66;
            this.goalsCount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // assistsCount
            // 
            this.assistsCount.Location = new System.Drawing.Point(140, 153);
            this.assistsCount.Name = "assistsCount";
            this.assistsCount.Size = new System.Drawing.Size(202, 20);
            this.assistsCount.TabIndex = 65;
            // 
            // allPlayers_update
            // 
            this.allPlayers_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allPlayers_update.FormattingEnabled = true;
            this.allPlayers_update.Location = new System.Drawing.Point(140, 37);
            this.allPlayers_update.Name = "allPlayers_update";
            this.allPlayers_update.Size = new System.Drawing.Size(202, 21);
            this.allPlayers_update.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Red Cards";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Yellow Cards";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Assists";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Goals";
            // 
            // updateConfirm
            // 
            this.updateConfirm.Location = new System.Drawing.Point(140, 327);
            this.updateConfirm.Name = "updateConfirm";
            this.updateConfirm.Size = new System.Drawing.Size(75, 23);
            this.updateConfirm.TabIndex = 2;
            this.updateConfirm.Text = "Confirm";
            this.updateConfirm.UseVisualStyleBackColor = true;
            this.updateConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(307, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "Welcome to Your Dashboard";
            // 
            // back_Coach
            // 
            this.back_Coach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Coach.Location = new System.Drawing.Point(38, 628);
            this.back_Coach.Name = "back_Coach";
            this.back_Coach.Size = new System.Drawing.Size(99, 47);
            this.back_Coach.TabIndex = 64;
            this.back_Coach.Text = "Log Out";
            this.back_Coach.UseVisualStyleBackColor = true;
            this.back_Coach.Click += new System.EventHandler(this.back_Coach_Click);
            // 
            // managerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 687);
            this.Controls.Add(this.back_Coach);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addPlayer);
            this.Name = "managerDashboard";
            this.Text = "managerDashboard";
            this.Load += new System.EventHandler(this.managerDashboard_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removePlayer;
        private System.Windows.Forms.ComboBox allPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button transferConfirm;
        private System.Windows.Forms.ComboBox teamPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox allPlayers_update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Transfer_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox team_from;
        private System.Windows.Forms.Button back_Coach;
        private System.Windows.Forms.TextBox goalsCount;
        private System.Windows.Forms.TextBox assistsCount;
        private System.Windows.Forms.TextBox yCards;
        private System.Windows.Forms.TextBox rcards;
    }
}