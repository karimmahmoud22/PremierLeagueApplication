
namespace WindowsFormsApp1
{
    partial class firstAdminSpecialGUI
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
            this.Assistants_data = new System.Windows.Forms.DataGridView();
            this.confirmEmploy = new System.Windows.Forms.Button();
            this.adminEmail = new System.Windows.Forms.Label();
            this.employButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.emailEmployed = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.removedEmail = new System.Windows.Forms.TextBox();
            this.removedAdminEmail = new System.Windows.Forms.Label();
            this.confirmRemove = new System.Windows.Forms.Button();
            this.back_Coach = new System.Windows.Forms.Button();
            this.supervisor_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Assistants_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Assistants_data
            // 
            this.Assistants_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Assistants_data.Location = new System.Drawing.Point(52, 280);
            this.Assistants_data.Name = "Assistants_data";
            this.Assistants_data.Size = new System.Drawing.Size(626, 290);
            this.Assistants_data.TabIndex = 35;
            // 
            // confirmEmploy
            // 
            this.confirmEmploy.Location = new System.Drawing.Point(369, 240);
            this.confirmEmploy.Name = "confirmEmploy";
            this.confirmEmploy.Size = new System.Drawing.Size(75, 23);
            this.confirmEmploy.TabIndex = 43;
            this.confirmEmploy.Text = "Confirm";
            this.confirmEmploy.UseVisualStyleBackColor = true;
            this.confirmEmploy.Visible = false;
            this.confirmEmploy.Click += new System.EventHandler(this.confirm_Click);
            // 
            // adminEmail
            // 
            this.adminEmail.AutoSize = true;
            this.adminEmail.Location = new System.Drawing.Point(222, 178);
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(35, 13);
            this.adminEmail.TabIndex = 41;
            this.adminEmail.Text = "E-mail";
            this.adminEmail.Visible = false;
            // 
            // employButton
            // 
            this.employButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employButton.Location = new System.Drawing.Point(225, 30);
            this.employButton.Name = "employButton";
            this.employButton.Size = new System.Drawing.Size(81, 41);
            this.employButton.TabIndex = 37;
            this.employButton.Text = "Employ";
            this.employButton.UseVisualStyleBackColor = true;
            this.employButton.Click += new System.EventHandler(this.employButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(333, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 41);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // emailEmployed
            // 
            this.emailEmployed.Location = new System.Drawing.Point(369, 171);
            this.emailEmployed.Name = "emailEmployed";
            this.emailEmployed.Size = new System.Drawing.Size(231, 20);
            this.emailEmployed.TabIndex = 44;
            this.emailEmployed.Visible = false;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(435, 30);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 41);
            this.delete.TabIndex = 45;
            this.delete.Text = "Remove";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // removedEmail
            // 
            this.removedEmail.Location = new System.Drawing.Point(369, 132);
            this.removedEmail.Name = "removedEmail";
            this.removedEmail.Size = new System.Drawing.Size(231, 20);
            this.removedEmail.TabIndex = 47;
            this.removedEmail.Visible = false;
            this.removedEmail.TextChanged += new System.EventHandler(this.removedEmail_TextChanged);
            // 
            // removedAdminEmail
            // 
            this.removedAdminEmail.AutoSize = true;
            this.removedAdminEmail.Location = new System.Drawing.Point(222, 139);
            this.removedAdminEmail.Name = "removedAdminEmail";
            this.removedAdminEmail.Size = new System.Drawing.Size(35, 13);
            this.removedAdminEmail.TabIndex = 46;
            this.removedAdminEmail.Text = "E-mail";
            this.removedAdminEmail.Visible = false;
            // 
            // confirmRemove
            // 
            this.confirmRemove.Location = new System.Drawing.Point(369, 168);
            this.confirmRemove.Name = "confirmRemove";
            this.confirmRemove.Size = new System.Drawing.Size(75, 23);
            this.confirmRemove.TabIndex = 48;
            this.confirmRemove.Text = "Confirm";
            this.confirmRemove.UseVisualStyleBackColor = true;
            this.confirmRemove.Visible = false;
            this.confirmRemove.Click += new System.EventHandler(this.confirmRemove_Click);
            // 
            // back_Coach
            // 
            this.back_Coach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Coach.Location = new System.Drawing.Point(21, 576);
            this.back_Coach.Name = "back_Coach";
            this.back_Coach.Size = new System.Drawing.Size(99, 47);
            this.back_Coach.TabIndex = 65;
            this.back_Coach.Text = "Log Out";
            this.back_Coach.UseVisualStyleBackColor = true;
            this.back_Coach.Click += new System.EventHandler(this.back_Coach_Click);
            // 
            // supervisor_id
            // 
            this.supervisor_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supervisor_id.FormattingEnabled = true;
            this.supervisor_id.Items.AddRange(new object[] {
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
            this.supervisor_id.Location = new System.Drawing.Point(369, 213);
            this.supervisor_id.Name = "supervisor_id";
            this.supervisor_id.Size = new System.Drawing.Size(231, 21);
            this.supervisor_id.TabIndex = 81;
            this.supervisor_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Supervisor ID";
            this.label1.Visible = false;
            // 
            // firstAdminSpecialGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supervisor_id);
            this.Controls.Add(this.back_Coach);
            this.Controls.Add(this.confirmRemove);
            this.Controls.Add(this.removedEmail);
            this.Controls.Add(this.removedAdminEmail);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.emailEmployed);
            this.Controls.Add(this.Assistants_data);
            this.Controls.Add(this.confirmEmploy);
            this.Controls.Add(this.adminEmail);
            this.Controls.Add(this.employButton);
            this.Controls.Add(this.addButton);
            this.Name = "firstAdminSpecialGUI";
            this.Text = "firstAdminSpecialGUI";
            this.Load += new System.EventHandler(this.firstAdminSpecialGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Assistants_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Assistants_data;
        private System.Windows.Forms.Button confirmEmploy;
        private System.Windows.Forms.Label adminEmail;
        private System.Windows.Forms.Button employButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox emailEmployed;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox removedEmail;
        private System.Windows.Forms.Label removedAdminEmail;
        private System.Windows.Forms.Button confirmRemove;
        private System.Windows.Forms.Button back_Coach;
        private System.Windows.Forms.ComboBox supervisor_id;
        private System.Windows.Forms.Label label1;
    }
}