
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Sign_Up_SuperVisor = new System.Windows.Forms.Button();
            this.Sign_Up_Coach = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.LinkLabel();
            this.Assistant_Supervisor = new System.Windows.Forms.Button();
            this.Sign_Up_Team_Manager = new System.Windows.Forms.Button();
            this.Sign_Up_Doctor = new System.Windows.Forms.Button();
            this.Sign_Up_Fitness_Trainer = new System.Windows.Forms.Button();
            this.players_goals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sign_Up_SuperVisor
            // 
            this.Sign_Up_SuperVisor.BackColor = System.Drawing.Color.LemonChiffon;
            this.Sign_Up_SuperVisor.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_SuperVisor.ForeColor = System.Drawing.Color.Black;
            this.Sign_Up_SuperVisor.Location = new System.Drawing.Point(295, 44);
            this.Sign_Up_SuperVisor.Name = "Sign_Up_SuperVisor";
            this.Sign_Up_SuperVisor.Size = new System.Drawing.Size(296, 126);
            this.Sign_Up_SuperVisor.TabIndex = 0;
            this.Sign_Up_SuperVisor.Text = "Sign Up as SuperVisor";
            this.Sign_Up_SuperVisor.UseVisualStyleBackColor = false;
            this.Sign_Up_SuperVisor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sign_Up_Coach
            // 
            this.Sign_Up_Coach.BackColor = System.Drawing.Color.LemonChiffon;
            this.Sign_Up_Coach.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Coach.ForeColor = System.Drawing.Color.Black;
            this.Sign_Up_Coach.Location = new System.Drawing.Point(827, 215);
            this.Sign_Up_Coach.Name = "Sign_Up_Coach";
            this.Sign_Up_Coach.Size = new System.Drawing.Size(296, 126);
            this.Sign_Up_Coach.TabIndex = 1;
            this.Sign_Up_Coach.Text = "Sign Up as Coach";
            this.Sign_Up_Coach.UseVisualStyleBackColor = false;
            this.Sign_Up_Coach.Click += new System.EventHandler(this.button2_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.register.LinkColor = System.Drawing.Color.SpringGreen;
            this.register.Location = new System.Drawing.Point(495, 564);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(192, 54);
            this.register.TabIndex = 2;
            this.register.TabStop = true;
            this.register.Text = "Login";
            this.register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // Assistant_Supervisor
            // 
            this.Assistant_Supervisor.BackColor = System.Drawing.Color.LemonChiffon;
            this.Assistant_Supervisor.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assistant_Supervisor.ForeColor = System.Drawing.Color.Black;
            this.Assistant_Supervisor.Location = new System.Drawing.Point(395, 204);
            this.Assistant_Supervisor.Name = "Assistant_Supervisor";
            this.Assistant_Supervisor.Size = new System.Drawing.Size(373, 149);
            this.Assistant_Supervisor.TabIndex = 3;
            this.Assistant_Supervisor.Text = "Sign Up as Assistant Supervisor";
            this.Assistant_Supervisor.UseVisualStyleBackColor = false;
            this.Assistant_Supervisor.Click += new System.EventHandler(this.Assistant_Supervisor_Click);
            // 
            // Sign_Up_Team_Manager
            // 
            this.Sign_Up_Team_Manager.BackColor = System.Drawing.Color.LemonChiffon;
            this.Sign_Up_Team_Manager.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Team_Manager.ForeColor = System.Drawing.Color.Black;
            this.Sign_Up_Team_Manager.Location = new System.Drawing.Point(38, 215);
            this.Sign_Up_Team_Manager.Name = "Sign_Up_Team_Manager";
            this.Sign_Up_Team_Manager.Size = new System.Drawing.Size(296, 126);
            this.Sign_Up_Team_Manager.TabIndex = 4;
            this.Sign_Up_Team_Manager.Text = "Sign Up as Team Manager";
            this.Sign_Up_Team_Manager.UseVisualStyleBackColor = false;
            this.Sign_Up_Team_Manager.Click += new System.EventHandler(this.Sign_Up_Team_Manager_Click);
            // 
            // Sign_Up_Doctor
            // 
            this.Sign_Up_Doctor.BackColor = System.Drawing.Color.LemonChiffon;
            this.Sign_Up_Doctor.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Doctor.ForeColor = System.Drawing.Color.Black;
            this.Sign_Up_Doctor.Location = new System.Drawing.Point(216, 407);
            this.Sign_Up_Doctor.Name = "Sign_Up_Doctor";
            this.Sign_Up_Doctor.Size = new System.Drawing.Size(296, 126);
            this.Sign_Up_Doctor.TabIndex = 5;
            this.Sign_Up_Doctor.Text = "Sign Up as Doctor";
            this.Sign_Up_Doctor.UseVisualStyleBackColor = false;
            this.Sign_Up_Doctor.Click += new System.EventHandler(this.Sign_Up_Doctor_Click);
            // 
            // Sign_Up_Fitness_Trainer
            // 
            this.Sign_Up_Fitness_Trainer.BackColor = System.Drawing.Color.LemonChiffon;
            this.Sign_Up_Fitness_Trainer.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Fitness_Trainer.ForeColor = System.Drawing.Color.Black;
            this.Sign_Up_Fitness_Trainer.Location = new System.Drawing.Point(671, 407);
            this.Sign_Up_Fitness_Trainer.Name = "Sign_Up_Fitness_Trainer";
            this.Sign_Up_Fitness_Trainer.Size = new System.Drawing.Size(296, 126);
            this.Sign_Up_Fitness_Trainer.TabIndex = 6;
            this.Sign_Up_Fitness_Trainer.Text = "Sign Up as Fitness Trainer";
            this.Sign_Up_Fitness_Trainer.UseVisualStyleBackColor = false;
            this.Sign_Up_Fitness_Trainer.Click += new System.EventHandler(this.Sign_Up_Fitness_Trainer_Click);
            // 
            // players_goals
            // 
            this.players_goals.BackColor = System.Drawing.Color.LemonChiffon;
            this.players_goals.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players_goals.ForeColor = System.Drawing.Color.Black;
            this.players_goals.Location = new System.Drawing.Point(707, 44);
            this.players_goals.Name = "players_goals";
            this.players_goals.Size = new System.Drawing.Size(296, 126);
            this.players_goals.TabIndex = 8;
            this.players_goals.Text = "Statistics";
            this.players_goals.UseVisualStyleBackColor = false;
            this.players_goals.Click += new System.EventHandler(this.players_goals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Premier_League_Logo_svg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1210, 645);
            this.Controls.Add(this.players_goals);
            this.Controls.Add(this.Sign_Up_Fitness_Trainer);
            this.Controls.Add(this.Sign_Up_Doctor);
            this.Controls.Add(this.Sign_Up_Team_Manager);
            this.Controls.Add(this.Assistant_Supervisor);
            this.Controls.Add(this.register);
            this.Controls.Add(this.Sign_Up_Coach);
            this.Controls.Add(this.Sign_Up_SuperVisor);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sign_Up_SuperVisor;
        private System.Windows.Forms.Button Sign_Up_Coach;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.Button Assistant_Supervisor;
        private System.Windows.Forms.Button Sign_Up_Team_Manager;
        private System.Windows.Forms.Button Sign_Up_Doctor;
        private System.Windows.Forms.Button Sign_Up_Fitness_Trainer;
        private System.Windows.Forms.Button players_goals;
    }
}

