
namespace WindowsFormsApp1
{
    partial class coachDashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.employe_statistian = new System.Windows.Forms.ComboBox();
            this.employManager = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.removeManager = new System.Windows.Forms.Button();
            this.allManagers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addManager = new System.Windows.Forms.Button();
            this.back_Coach = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome to Your Dashboard";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.employe_statistian);
            this.groupBox4.Controls.Add(this.employManager);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(424, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 145);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employ Statistician";
            // 
            // employe_statistian
            // 
            this.employe_statistian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employe_statistian.FormattingEnabled = true;
            this.employe_statistian.Location = new System.Drawing.Point(81, 34);
            this.employe_statistian.Name = "employe_statistian";
            this.employe_statistian.Size = new System.Drawing.Size(222, 21);
            this.employe_statistian.TabIndex = 9;
            // 
            // employManager
            // 
            this.employManager.Location = new System.Drawing.Point(81, 75);
            this.employManager.Name = "employManager";
            this.employManager.Size = new System.Drawing.Size(75, 23);
            this.employManager.TabIndex = 8;
            this.employManager.Text = "Confirm";
            this.employManager.UseVisualStyleBackColor = true;
            this.employManager.Click += new System.EventHandler(this.employManager_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-mail";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.removeManager);
            this.groupBox5.Controls.Add(this.allManagers);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(34, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 151);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remove Statistician";
            // 
            // removeManager
            // 
            this.removeManager.Location = new System.Drawing.Point(79, 91);
            this.removeManager.Name = "removeManager";
            this.removeManager.Size = new System.Drawing.Size(75, 23);
            this.removeManager.TabIndex = 3;
            this.removeManager.Text = "Confirm";
            this.removeManager.UseVisualStyleBackColor = true;
            this.removeManager.Click += new System.EventHandler(this.removeManager_Click);
            // 
            // allManagers
            // 
            this.allManagers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allManagers.FormattingEnabled = true;
            this.allManagers.Location = new System.Drawing.Point(79, 45);
            this.allManagers.Name = "allManagers";
            this.allManagers.Size = new System.Drawing.Size(222, 21);
            this.allManagers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose";
            // 
            // addManager
            // 
            this.addManager.Location = new System.Drawing.Point(315, 259);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(184, 65);
            this.addManager.TabIndex = 11;
            this.addManager.Text = "Add a new Manager";
            this.addManager.UseVisualStyleBackColor = true;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // back_Coach
            // 
            this.back_Coach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Coach.Location = new System.Drawing.Point(34, 296);
            this.back_Coach.Name = "back_Coach";
            this.back_Coach.Size = new System.Drawing.Size(99, 47);
            this.back_Coach.TabIndex = 66;
            this.back_Coach.Text = "Log Out";
            this.back_Coach.UseVisualStyleBackColor = true;
            this.back_Coach.Click += new System.EventHandler(this.back_Coach_Click);
            // 
            // coachDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 355);
            this.Controls.Add(this.back_Coach);
            this.Controls.Add(this.addManager);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label3);
            this.Name = "coachDashboard";
            this.Text = "coachDashboard";
            this.Load += new System.EventHandler(this.coachDashboard_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button employManager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeManager;
        private System.Windows.Forms.ComboBox allManagers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.ComboBox employe_statistian;
        private System.Windows.Forms.Button back_Coach;
    }
}