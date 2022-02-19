
namespace WindowsFormsApp1
{
    partial class adminHome
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
            this.adminControl = new System.Windows.Forms.Button();
            this.teamControl = new System.Windows.Forms.Button();
            this.coachControl = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminControl
            // 
            this.adminControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminControl.Location = new System.Drawing.Point(269, 95);
            this.adminControl.Name = "adminControl";
            this.adminControl.Size = new System.Drawing.Size(245, 77);
            this.adminControl.TabIndex = 0;
            this.adminControl.Text = "Assistants Control";
            this.adminControl.UseVisualStyleBackColor = true;
            this.adminControl.Click += new System.EventHandler(this.adminControl_Click);
            // 
            // teamControl
            // 
            this.teamControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamControl.Location = new System.Drawing.Point(269, 332);
            this.teamControl.Name = "teamControl";
            this.teamControl.Size = new System.Drawing.Size(245, 77);
            this.teamControl.TabIndex = 1;
            this.teamControl.Text = "Team Control";
            this.teamControl.UseVisualStyleBackColor = true;
            this.teamControl.Click += new System.EventHandler(this.teamControl_Click);
            // 
            // coachControl
            // 
            this.coachControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachControl.Location = new System.Drawing.Point(269, 215);
            this.coachControl.Name = "coachControl";
            this.coachControl.Size = new System.Drawing.Size(245, 77);
            this.coachControl.TabIndex = 2;
            this.coachControl.Text = "Coach Control";
            this.coachControl.UseVisualStyleBackColor = true;
            this.coachControl.Click += new System.EventHandler(this.coachControl_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(12, 405);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(101, 33);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Log out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to your Dashboard";
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.coachControl);
            this.Controls.Add(this.teamControl);
            this.Controls.Add(this.adminControl);
            this.Name = "adminHome";
            this.Text = "firstAdmin";
            this.Load += new System.EventHandler(this.adminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminControl;
        private System.Windows.Forms.Button teamControl;
        private System.Windows.Forms.Button coachControl;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label1;
    }
}