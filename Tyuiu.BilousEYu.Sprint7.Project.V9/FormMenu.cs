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
    public partial class FormMenu : Form
    {
        DataService ds = new DataService();

        private Chart chartGenreMenu_RKN; // График для отображения данных

        public FormMenu()
        {
            InitializeComponent();
            chartGenreMenu_RKN = new Chart(); // Создаем график в конструкторе
            InitializeChart(); // Инициализация графика
            ShowMenu(); // Отображение данных на графике
        }

        private void InitializeChart()
        {
            chartGenreMenu_RKN.Dock = DockStyle.Fill;
            this.Controls.Add(chartGenreMenu_RKN); // Добавление графика на форму

            // Создание области графика
            ChartArea chartArea = new ChartArea();
            chartGenreMenu_RKN.ChartAreas.Add(chartArea);

            // Установка заголовков осей
            chartGenreMenu_RKN.ChartAreas[0].AxisX.Title = "Жанры";
            chartGenreMenu_RKN.ChartAreas[0].AxisY.Title = "Количество фильмов";
        }

        private void ShowMenu()
        {
            chartGenreMenu_RKN.Series.Clear(); // Очистка старых данных

            // Создание и настройка серии
            Series series = new Series("Количество фильмов");
            series.ChartType = SeriesChartType.Column; // Тип графика - столбчатая диаграмма
            chartGenreMenu_RKN.Series.Add(series);

            // Получение статистики по жанрам
            string[] genres = { "Боевик", "Детектив", "Драма", "Исторический фильм", "Комедия", "Мюзикл","Романтика","Триллер", "Хоррор" };
            int[] genreStats = GetGenreStats(); // Получите данные для графика

            // Добавление данных в серию
            for (int i = 0; i < genres.Length; i++)
            {
                series.Points.AddXY(genres[i], genreStats[i]);
            }
        }

        private int[] GetGenreStats()
        {
            return new int[] { 10, 5, 8, 3, 12, 7, 2 }; // Возврат тестовых данных
        }
    }

}
