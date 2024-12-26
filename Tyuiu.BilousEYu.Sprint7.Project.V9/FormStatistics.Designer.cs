namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormStatistics
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;

        private void InitializeComponent()
        {
            chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(chartStatistics)).BeginInit();

            SuspendLayout();

            // 
            // chartStatistics
            // 
            chartStatistics.Location = new Point(12, 12);
            chartStatistics.Name = "chartStatistics";
            chartStatistics.Size = new Size(460, 300);
            chartStatistics.TabIndex = 0;
            chartStatistics.Text = "Статистика";
            chartStatistics.Click += StatisticsChart_Click;

            // 
            // FormStatistics
            // 
            ClientSize = new Size(484, 321);
            Controls.Add(chartStatistics);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(chartStatistics)).EndInit();
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}