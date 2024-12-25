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
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DataSet.csv");

        private void buttonManagement_GAM_Click(object sender, EventArgs e)
        {
            FormManual formmanual = new FormManual();
            formmanual.ShowDialog();
        }

        private void buttonAbout_GAM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void BuildChart(int categoryIndex, string title, Color color)
        {
            pictureBoxWait_GAM.Visible = false;
            chartGraph_GAM.Titles.Clear();
            chartGraph_GAM.Series.Clear();

            string[,] matrix = ds.LoadDataSet(path);
            if (matrix == null)
            {
                MessageBox.Show("Не удалось загрузить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rows = matrix.GetLength(0);
            List<string> category = new List<string>();

            for (int i = 1; i < rows; i++)
            {
                category.Add(matrix[i, categoryIndex]);
            }

            Dictionary<string, int> countByElement = category.GroupBy(e => e)
                                                             .ToDictionary(g => g.Key, g => g.Count());

            Series series = new Series { Color = color, BackGradientStyle = GradientStyle.DiagonalLeft };

            foreach (var kvp in countByElement)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            chartGraph_GAM.Series.Add(series);
            chartGraph_GAM.Invalidate();
            chartGraph_GAM.Legends.Clear();
            chartGraph_GAM.Titles.Add(title);
            chartGraph_GAM.ChartAreas[0].AxisX.Title = "Значение";
            chartGraph_GAM.ChartAreas[0].AxisY.Title = "Количество";
        }

        private void форматВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildChart(3, "Формат", Color.DarkCyan);
        }

        private void категорияВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildChart(6, "Категория", Color.Indigo);
        }

        private void весВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildChart(5, "Вес", Color.RoyalBlue);
        }

        private void длительностьВидеоклипаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BuildChart(2, "Длительность", Color.DarkSlateGray);
        }

        private void buttonBack_GAM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateMinMaxAverage(int categoryIndex, bool isMax)
        {
            string[,] matrix = ds.LoadDataSet(path);
            if (matrix == null)
            {
                MessageBox.Show("Не удалось загрузить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rows = matrix.GetLength(0);
            List<string> values = new List<string>();

            for (int i = 1; i < rows; i++)
            {
                values.Add(matrix[i, categoryIndex]);
            }

            double[] doubleValues = new double[values.Count];

            for (int v = 0; v < values.Count; v++)
            {
                if (double.TryParse(values[v], out double parsedValue))
                {
                    doubleValues[v] = parsedValue;
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при парсинге значений.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            double result = isMax ? doubleValues.Max() : doubleValues.Min();
            textBoxOutPutMinMax_GAM.Text = Convert.ToString(result);
        }

        private void весВидеоклипаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalculateMinMaxAverage(5, false);
        }

        private void длительностьВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateMinMaxAverage(2, false);
        }

        private void весВидеоклипаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CalculateMinMaxAverage(5, true);
        }

        private void длительностьВидеоклипаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalculateMinMaxAverage(2, true);
        }

        private void весВидеоклипаToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CalculateMinMaxAverage(5, false);
        }

        private void длительностьВидеоклипаToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CalculateMinMaxAverage(2, false);
        }

        private void buttonBack_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonBack_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonBack_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonBack_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonBack_GAM.BackColor = Color.DarkTurquoise;
            buttonBack_GAM.ForeColor = Color.Black;
        }

        private void buttonManagement_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonManagement_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonManagement_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonManagement_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonManagement_GAM.BackColor = Color.DarkTurquoise;
            buttonManagement_GAM.ForeColor = Color.Black;
        }

        private void buttonAbout_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonAbout_GAM.BackColor = Color.DarkTurquoise;
            buttonAbout_GAM.ForeColor = Color.Black;
        }

        private void buttonAbout_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonAbout_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonAbout_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBoxWait_GAM_Click(object sender, EventArgs e)
        {
            
        }

        private void panelUpperGraph_GAM_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void chartGraph_GAM_Click(object sender, EventArgs e)
        {

        }
    }
}
