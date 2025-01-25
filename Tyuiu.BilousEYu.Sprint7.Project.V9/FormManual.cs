using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
        }

        private void pictureBoxLoad_GAM_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBoxManual_GAM.Text = File.ReadAllText(openFileDialog.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBoxSave_GAM_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, textBoxManual_GAM.Text);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Ошибка записи файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBoxSort_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сортировка текста может быть реализована здесь.");
        }

        private void pictureBoxLeft_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перемещение влево...");
        }

        private void pictureBoxRight_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перемещение вправо...");
        }

        private void pictureBoxSearch_GAM_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxManual_GAM.Text;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Пожалуйста, введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxManual_GAM.Text.Contains(searchTerm))
            {
                MessageBox.Show($"Текст '{searchTerm}' найден.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Текст '{searchTerm}' не найден.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBoxAbout_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это краткое руководство к вашему приложению.", "О приложении", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxManual_GAM_TextChanged(object sender, EventArgs e)
        {
            // Дополнительная логика, если нужна, например, обновление статуса редактирования.
        }

        private void panelManual_GAM_Paint(object sender, PaintEventArgs e)
        {
            // Можно добавить пользовательскую отрисовку, если потребуется.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

