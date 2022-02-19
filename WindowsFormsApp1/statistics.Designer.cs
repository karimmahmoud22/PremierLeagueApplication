
namespace WindowsFormsApp1
{
    partial class statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.back_Coach = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.teams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "goals";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(486, 331);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // back_Coach
            // 
            this.back_Coach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Coach.Location = new System.Drawing.Point(-4, 392);
            this.back_Coach.Name = "back_Coach";
            this.back_Coach.Size = new System.Drawing.Size(99, 47);
            this.back_Coach.TabIndex = 64;
            this.back_Coach.Text = "Back";
            this.back_Coach.UseVisualStyleBackColor = true;
            this.back_Coach.Click += new System.EventHandler(this.back_Coach_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(147, 472);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(240, 150);
            this.data.TabIndex = 65;
            // 
            // teams
            // 
            this.teams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teams.FormattingEnabled = true;
            this.teams.Location = new System.Drawing.Point(267, 374);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(231, 21);
            this.teams.TabIndex = 66;
            this.teams.SelectedIndexChanged += new System.EventHandler(this.teams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Choose Team";
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(266, 416);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 23);
            this.draw.TabIndex = 68;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teams);
            this.Controls.Add(this.data);
            this.Controls.Add(this.back_Coach);
            this.Controls.Add(this.chart);
            this.Name = "statistics";
            this.Text = "statistics";
            this.Load += new System.EventHandler(this.statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button back_Coach;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ComboBox teams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button draw;
    }
}