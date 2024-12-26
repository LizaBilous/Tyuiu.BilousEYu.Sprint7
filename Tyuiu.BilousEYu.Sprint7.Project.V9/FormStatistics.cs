using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.BilousEYu.Sprint7.Project.V9.Lib;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            // Пример: Получаем данные для графика
            double[] data = GetStatisticsData();

            // Настройка графика
            chartStatistics.Series.Clear();
            Series series = new Series("Статистика")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Blue
            };

            // Заполнение графика данными
            for (int i = 0; i < data.Length; i++)
            {
                series.Points.AddXY(i + 1, data[i]);
            }

            chartStatistics.Series.Add(series);
            chartStatistics.ChartAreas[0].AxisX.Title = "Период";
            chartStatistics.ChartAreas[0].AxisY.Title = "Значение";
        }

        private double[] GetStatisticsData()
        {
            // Здесь должна быть логика получения данных. Например, откуда-то из базы данных.
            // Для примера возвращаем фиксированные данные
            return new double[] { 10, 20, 15, 30, 25, 40 };
        }

        private void StatisticsChart_Click(object sender, EventArgs e)
        {
            // Обработка клика на графике, если это необходимо
            MessageBox.Show("Вы нажали на график!");
        }
    }
}
