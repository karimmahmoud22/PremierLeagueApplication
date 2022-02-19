
namespace WindowsFormsApp1
{
    partial class coachControl
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
            this.coachesData = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.employButton = new System.Windows.Forms.Button();
            this.chooseCoach = new System.Windows.Forms.ComboBox();
            this.chooseTeam = new System.Windows.Forms.ComboBox();
            this.coachChoose = new System.Windows.Forms.Label();
            this.teamChoose = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.back_Coach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coachesData)).BeginInit();
            this.SuspendLayout();
            // 
            // coachesData
            // 
            this.coachesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coachesData.Location = new System.Drawing.Point(37, 238);
            this.coachesData.Name = "coachesData";
            this.coachesData.Size = new System.Drawing.Size(418, 344);
            this.coachesData.TabIndex = 21;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(132, 26);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 39);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // employButton
            // 
            this.employButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employButton.Location = new System.Drawing.Point(285, 26);
            this.employButton.Name = "employButton";
            this.employButton.Size = new System.Drawing.Size(108, 41);
            this.employButton.TabIndex = 27;
            this.employButton.Text = "Employ";
            this.employButton.UseVisualStyleBackColor = true;
            this.employButton.Click += new System.EventHandler(this.employButton_Click);
            // 
            // chooseCoach
            // 
            this.chooseCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseCoach.FormattingEnabled = true;
            this.chooseCoach.Location = new System.Drawing.Point(272, 100);
            this.chooseCoach.Name = "chooseCoach";
            this.chooseCoach.Size = new System.Drawing.Size(121, 21);
            this.chooseCoach.TabIndex = 29;
            this.chooseCoach.Visible = false;
            this.chooseCoach.SelectedIndexChanged += new System.EventHandler(this.chooseCoach_SelectedIndexChanged);
            // 
            // chooseTeam
            // 
            this.chooseTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseTeam.FormattingEnabled = true;
            this.chooseTeam.Location = new System.Drawing.Point(272, 153);
            this.chooseTeam.Name = "chooseTeam";
            this.chooseTeam.Size = new System.Drawing.Size(121, 21);
            this.chooseTeam.TabIndex = 30;
            this.chooseTeam.Visible = false;
            this.chooseTeam.SelectedIndexChanged += new System.EventHandler(this.chooseTeam_SelectedIndexChanged);
            // 
            // coachChoose
            // 
            this.coachChoose.AutoSize = true;
            this.coachChoose.Location = new System.Drawing.Point(129, 108);
            this.coachChoose.Name = "coachChoose";
            this.coachChoose.Size = new System.Drawing.Size(77, 13);
            this.coachChoose.TabIndex = 31;
            this.coachChoose.Text = "Choose Coach";
            this.coachChoose.Visible = false;
            // 
            // teamChoose
            // 
            this.teamChoose.AutoSize = true;
            this.teamChoose.Location = new System.Drawing.Point(129, 161);
            this.teamChoose.Name = "teamChoose";
            this.teamChoose.Size = new System.Drawing.Size(73, 13);
            this.teamChoose.TabIndex = 32;
            this.teamChoose.Text = "Choose Team";
            this.teamChoose.Visible = false;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(318, 192);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 34;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // back_Coach
            // 
            this.back_Coach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Coach.Location = new System.Drawing.Point(12, 609);
            this.back_Coach.Name = "back_Coach";
            this.back_Coach.Size = new System.Drawing.Size(99, 47);
            this.back_Coach.TabIndex = 65;
            this.back_Coach.Text = "Log Out";
            this.back_Coach.UseVisualStyleBackColor = true;
            this.back_Coach.Click += new System.EventHandler(this.back_Coach_Click);
            // 
            // coachControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 671);
            this.Controls.Add(this.back_Coach);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.teamChoose);
            this.Controls.Add(this.coachChoose);
            this.Controls.Add(this.employButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.chooseTeam);
            this.Controls.Add(this.chooseCoach);
            this.Controls.Add(this.coachesData);
            this.Name = "coachControl";
            this.Text = "coachControl";
            this.Load += new System.EventHandler(this.coachControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coachesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView coachesData;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button employButton;
        private System.Windows.Forms.ComboBox chooseTeam;
        private System.Windows.Forms.ComboBox chooseCoach;
        private System.Windows.Forms.Label coachChoose;
        private System.Windows.Forms.Label teamChoose;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button back_Coach;
    }
}