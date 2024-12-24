using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BilousEYu.Sprint7.Project.V9.Lib;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DataSet.csv");
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;

        private SaveFileDialog saveFileDialogMain_GAM;

        public FormMain()
        {
            InitializeComponent();


            // Инициализация диалогов для открытия и сохранения файлов
            saveFileDialogMain_GAM = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Сохранить файл как..."
            };

            openFileDialogMain_GAM = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Выберите файл для загрузки"
            };

            FormMenu formmenu = new FormMenu();
            formmenu.TopMost = true;
            formmenu.Show();
        }

        private void buttonLoad_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogMain_GAM.ShowDialog() == DialogResult.OK)
                {
                    openFile = openFileDialogMain_GAM.FileName;

                    if (string.IsNullOrEmpty(openFile))
                    {
                        MessageBox.Show("Выберите файл для загрузки.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    matrix = ds.LoadDataSet(openFile);
                    rows = matrix.GetLength(0);
                    columns = matrix.GetLength(1);

                    dataGridViewBase_GAM.RowCount = rows;
                    dataGridViewBase_GAM.ColumnCount = columns;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridViewBase_GAM.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                    }

                    // Установка ширины столбцов
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewBase_GAM.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    buttonReset_GAM.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла проблема с открытием файла: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_GAM.FileName = "OutPutFileTask7.csv";
                saveFileDialogMain_GAM.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialogMain_GAM.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialogMain_GAM.FileName;

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    int rowCount = dataGridViewBase_GAM.RowCount;
                    int colCount = dataGridViewBase_GAM.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < colCount; j++)
                        {
                            strBuilder.Append(dataGridViewBase_GAM.Rows[i].Cells[j].Value?.ToString() ?? "");
                            if (j != colCount - 1)
                            {
                                strBuilder.Append(";");
                            }
                        }
                        strBuilder.AppendLine();
                    }

                    File.WriteAllText(path, strBuilder.ToString(), Encoding.UTF8);
                    MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сохранить файл. Ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_GAM_Click(object sender, EventArgs e)
        {
            dataGridViewBase_GAM.ClearSelection();
            if (string.IsNullOrWhiteSpace(textBoxSearch_GAM.Text))
            {
                MessageBox.Show("Введите критерий для поиска", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string searchValue = textBoxSearch_GAM.Text.ToLower();
            bool found = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j].ToLower().Contains(searchValue))
                    {
                        dataGridViewBase_GAM.Rows[i].Selected = true;
                        found = true;
                        break; // Прерываем цикл, если нашли совпадение
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Совпадения не найдены.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_GAM_Click(object sender, EventArgs e)
        {
            dataGridViewBase_GAM.Rows.Clear();

            // Проверка существования данных перед обновлением
            if (matrix != null)
            {
                matrix = ds.LoadDataSet(path); // Используем начальный путь
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewBase_GAM.RowCount = rows;
                dataGridViewBase_GAM.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewBase_GAM.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                // Убедитесь, что кнопка сброса больше не активна
                buttonReset_GAM.Enabled = false;
            }
            else
            {
                MessageBox.Show("Нет данных для сброса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAbout_GAM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonGraph_GAM_Click(object sender, EventArgs e)
        {
            FormGraph fg = new FormGraph();
            fg.Show();
        }

        private void pictureBoxLeft_GAM_Click(object sender, EventArgs e)
        {
            if (dataGridViewBase_GAM.HorizontalScrollingOffset >= 10)
            {
                dataGridViewBase_GAM.HorizontalScrollingOffset -= 10;
            }
            else
            {
                dataGridViewBase_GAM.HorizontalScrollingOffset = 0;
            }
        }

        private void dataGridViewBase_GAM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработчик события, если понадобится
        }

        private void dataGridViewBase_GAM_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

