namespace WindowsFormsApp1
{
    partial class FitnessDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.passPower_fitness = new System.Windows.Forms.TextBox();
            this.shootPower_fitness = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dribbling_fitness = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.player_salary_fitness = new System.Windows.Forms.TextBox();
            this.update_fitness = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(91, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 102;
            this.label2.Text = "Pass Power";
            // 
            // passPower_fitness
            // 
            this.passPower_fitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passPower_fitness.Location = new System.Drawing.Point(293, 168);
            this.passPower_fitness.Name = "passPower_fitness";
            this.passPower_fitness.Size = new System.Drawing.Size(164, 21);
            this.passPower_fitness.TabIndex = 101;
            // 
            // shootPower_fitness
            // 
            this.shootPower_fitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootPower_fitness.Location = new System.Drawing.Point(293, 98);
            this.shootPower_fitness.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.shootPower_fitness.MaxLength = 60;
            this.shootPower_fitness.Name = "shootPower_fitness";
            this.shootPower_fitness.Size = new System.Drawing.Size(164, 21);
            this.shootPower_fitness.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(91, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 27);
            this.label18.TabIndex = 103;
            this.label18.Text = "Shoot Power";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(108, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 27);
            this.label17.TabIndex = 106;
            this.label17.Text = "Dribbling";
            // 
            // dribbling_fitness
            // 
            this.dribbling_fitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dribbling_fitness.Location = new System.Drawing.Point(293, 235);
            this.dribbling_fitness.MaxLength = 60;
            this.dribbling_fitness.Name = "dribbling_fitness";
            this.dribbling_fitness.Size = new System.Drawing.Size(164, 21);
            this.dribbling_fitness.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(122, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 118;
            this.label5.Text = "Salary";
            // 
            // player_salary_fitness
            // 
            this.player_salary_fitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_salary_fitness.Location = new System.Drawing.Point(293, 308);
            this.player_salary_fitness.Name = "player_salary_fitness";
            this.player_salary_fitness.Size = new System.Drawing.Size(164, 21);
            this.player_salary_fitness.TabIndex = 117;
            // 
            // update_fitness
            // 
            this.update_fitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_fitness.Location = new System.Drawing.Point(209, 402);
            this.update_fitness.Name = "update_fitness";
            this.update_fitness.Size = new System.Drawing.Size(125, 42);
            this.update_fitness.TabIndex = 119;
            this.update_fitness.Text = "Update";
            this.update_fitness.UseVisualStyleBackColor = true;
            this.update_fitness.Click += new System.EventHandler(this.update_fitness_Click);
            // 
            // FitnessDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 579);
            this.Controls.Add(this.update_fitness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.player_salary_fitness);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dribbling_fitness);
            this.Controls.Add(this.shootPower_fitness);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passPower_fitness);
            this.Name = "FitnessDashboard";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passPower_fitness;
        private System.Windows.Forms.TextBox shootPower_fitness;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox dribbling_fitness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox player_salary_fitness;
        private System.Windows.Forms.Button update_fitness;
    }
}