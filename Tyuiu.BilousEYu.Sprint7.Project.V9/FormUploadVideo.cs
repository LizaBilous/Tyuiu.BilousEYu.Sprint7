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
    public partial class FormUploadVideo : Form
    {
        public FormUploadVideo()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // Открытие диалога для выбора файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Видео файлы (*.mp4;*.avi;*.mov)|*.mp4;*.avi;*.mov|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите видео для загрузки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    // Логика для загрузки видеофайла
                    UploadVideo(filePath);
                }
            }
        }

        private void UploadVideo(string filePath)
        {
            // Здесь можно добавить код для загрузки видео
            // Например, отправка на сервер

            try
            {
                // Имитируем загрузку видео
                System.Threading.Thread.Sleep(2000); // Симуляция времени загрузки

                // Сообщение об успешной загрузке
                MessageBox.Show("Видео успешно загружено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Ошибка при загрузке видео: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUploadVideo_Load(object sender, EventArgs e)
        {
            // Можно инициализировать интерфейс или данные при загрузке формы, если необходимо
        }
    }
}
