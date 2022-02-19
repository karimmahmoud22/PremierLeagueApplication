
namespace WindowsFormsApp1
{
    partial class teamControl
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
            this.addTeam = new System.Windows.Forms.RadioButton();
            this.removeTeam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamName = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.playersCountLabel = new System.Windows.Forms.Label();
            this.teamsData = new System.Windows.Forms.DataGridView();
            this.submit = new System.Windows.Forms.Button();
            this.chooseTeam = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.choosePlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.budgetError = new System.Windows.Forms.Label();
            this.countError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.TextBox();
            this.playersCount = new System.Windows.Forms.TextBox();
            this.logOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsData)).BeginInit();
            this.SuspendLayout();
            // 
            // addTeam
            // 
            this.addTeam.AutoSize = true;
            this.addTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addTeam.Location = new System.Drawing.Point(6, 19);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(99, 21);
            this.addTeam.TabIndex = 0;
            this.addTeam.TabStop = true;
            this.addTeam.Text = "Add Team";
            this.addTeam.UseVisualStyleBackColor = true;
            this.addTeam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // removeTeam
            // 
            this.removeTeam.AutoSize = true;
            this.removeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTeam.Location = new System.Drawing.Point(6, 62);
            this.removeTeam.Name = "removeTeam";
            this.removeTeam.Size = new System.Drawing.Size(129, 21);
            this.removeTeam.TabIndex = 1;
            this.removeTeam.TabStop = true;
            this.removeTeam.Text = "Remove Team";
            this.removeTeam.UseVisualStyleBackColor = true;
            this.removeTeam.CheckedChanged += new System.EventHandler(this.removeTeam_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addTeam);
            this.groupBox1.Controls.Add(this.removeTeam);
            this.groupBox1.Location = new System.Drawing.Point(33, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add | Remove";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(481, 67);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(213, 20);
            this.teamName.TabIndex = 3;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(374, 67);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(65, 13);
            this.teamNameLabel.TabIndex = 6;
            this.teamNameLabel.Text = "Team Name";
            this.teamNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(367, 141);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(104, 13);
            this.budgetLabel.TabIndex = 7;
            this.budgetLabel.Text = "Budget ( in million $ )";
            this.budgetLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // playersCountLabel
            // 
            this.playersCountLabel.AutoSize = true;
            this.playersCountLabel.Location = new System.Drawing.Point(367, 206);
            this.playersCountLabel.Name = "playersCountLabel";
            this.playersCountLabel.Size = new System.Drawing.Size(72, 13);
            this.playersCountLabel.TabIndex = 8;
            this.playersCountLabel.Text = "Players Count";
            // 
            // teamsData
            // 
            this.teamsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsData.Location = new System.Drawing.Point(39, 295);
            this.teamsData.Name = "teamsData";
            this.teamsData.Size = new System.Drawing.Size(655, 258);
            this.teamsData.TabIndex = 9;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(481, 243);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // chooseTeam
            // 
            this.chooseTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseTeam.FormattingEnabled = true;
            this.chooseTeam.Location = new System.Drawing.Point(370, 93);
            this.chooseTeam.Name = "chooseTeam";
            this.chooseTeam.Size = new System.Drawing.Size(121, 21);
            this.chooseTeam.TabIndex = 11;
            this.chooseTeam.Visible = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(370, 169);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "Confirm";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // choosePlayer
            // 
            this.choosePlayer.AutoSize = true;
            this.choosePlayer.Location = new System.Drawing.Point(269, 96);
            this.choosePlayer.Name = "choosePlayer";
            this.choosePlayer.Size = new System.Drawing.Size(73, 13);
            this.choosePlayer.TabIndex = 13;
            this.choosePlayer.Text = "Choose Team";
            this.choosePlayer.Visible = false;
            this.choosePlayer.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Welcome to Your Dashboard";
            // 
            // budgetError
            // 
            this.budgetError.AutoSize = true;
            this.budgetError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetError.ForeColor = System.Drawing.Color.Red;
            this.budgetError.Location = new System.Drawing.Point(481, 162);
            this.budgetError.Name = "budgetError";
            this.budgetError.Size = new System.Drawing.Size(89, 13);
            this.budgetError.TabIndex = 16;
            this.budgetError.Text = "Invalid Budget";
            this.budgetError.Visible = false;
            // 
            // countError
            // 
            this.countError.AutoSize = true;
            this.countError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countError.ForeColor = System.Drawing.Color.Red;
            this.countError.Location = new System.Drawing.Point(481, 227);
            this.countError.Name = "countError";
            this.countError.Size = new System.Drawing.Size(182, 13);
            this.countError.TabIndex = 17;
            this.countError.Text = "Invalid Number ( Minimum :15 )";
            this.countError.Visible = false;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(481, 90);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(85, 13);
            this.nameError.TabIndex = 18;
            this.nameError.Text = "Invalid Name ";
            this.nameError.Visible = false;
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(484, 134);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(213, 20);
            this.budget.TabIndex = 19;
            // 
            // playersCount
            // 
            this.playersCount.Location = new System.Drawing.Point(481, 199);
            this.playersCount.Name = "playersCount";
            this.playersCount.Size = new System.Drawing.Size(213, 20);
            this.playersCount.TabIndex = 20;
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(39, 581);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(101, 33);
            this.logOut.TabIndex = 21;
            this.logOut.Text = "Log out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // teamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 637);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.playersCount);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.countError);
            this.Controls.Add(this.budgetError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choosePlayer);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.chooseTeam);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.teamsData);
            this.Controls.Add(this.playersCountLabel);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.groupBox1);
            this.Name = "teamControl";
            this.Text = "teamControl";
            this.Load += new System.EventHandler(this.teamControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addTeam;
        private System.Windows.Forms.RadioButton removeTeam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label playersCountLabel;
        private System.Windows.Forms.DataGridView teamsData;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox chooseTeam;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label choosePlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label budgetError;
        private System.Windows.Forms.Label countError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.TextBox budget;
        private System.Windows.Forms.TextBox playersCount;
        private System.Windows.Forms.Button logOut;
    }
}