
namespace WindowsFormsApp1
{
    partial class supervisorAssistantDashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamName = new System.Windows.Forms.TextBox();
            this.aa = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.allTeams = new System.Windows.Forms.ComboBox();
            this.teamBudget = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamBudget);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.teamName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Team";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.allTeams);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.aa);
            this.groupBox2.Location = new System.Drawing.Point(39, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Budget ( in million $ )";
            // 
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(140, 50);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(218, 20);
            this.teamName.TabIndex = 2;
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(30, 43);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(42, 13);
            this.aa.TabIndex = 3;
            this.aa.Text = "choose";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(140, 148);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(141, 106);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome to Your Dashboard";
            // 
            // allTeams
            // 
            this.allTeams.FormattingEnabled = true;
            this.allTeams.Items.AddRange(new object[] {
            "Liverpool",
            "Manchester City"});
            this.allTeams.Location = new System.Drawing.Point(114, 35);
            this.allTeams.Name = "allTeams";
            this.allTeams.Size = new System.Drawing.Size(218, 21);
            this.allTeams.TabIndex = 6;
            // 
            // teamBudget
            // 
            this.teamBudget.Location = new System.Drawing.Point(140, 109);
            this.teamBudget.Name = "teamBudget";
            this.teamBudget.Size = new System.Drawing.Size(218, 20);
            this.teamBudget.TabIndex = 3;
            // 
            // supervisorAssistantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "supervisorAssistantDashboard";
            this.Text = "supervisorAssistantDashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown teamBudget;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox allTeams;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.Label label3;
    }
}