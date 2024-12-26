namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormStatistics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            StatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)StatisticsChart).BeginInit();
            SuspendLayout();
            // 
            // StatisticsChart
            // 
            StatisticsChart.Location = new Point(10, 10);
            StatisticsChart.Name = "StatisticsChart";
            StatisticsChart.Size = new Size(380, 250);
            StatisticsChart.TabIndex = 0;
            StatisticsChart.Click += StatisticsChart_Click;
            // 
            // FormStatistics
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(StatisticsChart);
            Name = "FormStatistics";
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)StatisticsChart).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart StatisticsChart;
    }
}