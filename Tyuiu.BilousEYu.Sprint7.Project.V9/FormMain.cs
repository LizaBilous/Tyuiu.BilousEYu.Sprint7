using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BilousEYu.Sprint7.Project.V9.Lib;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        private string[,] matrix;
        private int rows;
        private int columns;

        public FormMain()
        {
            InitializeComponent();
        }

        private void LoadData(string filePath)
        {
            try
            {
                // Предполагаем, что ds.LoadDataSet(filePath) возвращает двумерный массив
                DataService ds = new DataService();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData(string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        sb.Append(matrix[i, j]);
                        if (j < columns - 1)
                        {
                            sb.Append(",");
                        }
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(filePath, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoad_GAM_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain_GAM.ShowDialog() == DialogResult.OK)
            {
                LoadData(openFileDialogMain_GAM.FileName);
            }
        }

        private void buttonSave_GAM_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMain_GAM.ShowDialog() == DialogResult.OK)
            {
                SaveData(saveFileDialogMain_GAM.FileName);
            }
        }

        private void SaveData(object fileName)
        {
            throw new NotImplementedException();
        }

        private void buttonSearch_GAM_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch_GAM.Text;

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Введите ключевое слово для поиска.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j].Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridViewBase_GAM.CurrentCell = dataGridViewBase_GAM.Rows[i].Cells[j];
                        return; // Нахождение первого совпадения и выход
                    }
                }
            }

            MessageBox.Show("Совпадения не найдены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReset_GAM_Click(object sender, EventArgs e)
        {
            // Сброс данных (например, очистка DataGridView)
            dataGridViewBase_GAM.Rows.Clear();
            textBoxSearch_GAM.Clear();
        }

        private class saveFileDialogMain_GAM
        {
            public static string FileName { get; internal set; }

            internal static DialogResult ShowDialog()
            {
                throw new NotImplementedException();
            }
        }
    }
}
            


