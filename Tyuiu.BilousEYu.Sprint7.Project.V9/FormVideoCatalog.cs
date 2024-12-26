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
    public partial class FormVideoCatalog : Form
    {
        private List<string> videoList = new List<string>();

        public FormVideoCatalog()
        {
            InitializeComponent();
            LoadVideoCatalog();
        }

        private void LoadVideoCatalog()
        {
            // Логика загрузки каталога видео
            videoList.Add("Video 1");
            videoList.Add("Video 2");
            // Заполнение списка
            UpdateVideoListBox();
        }

        private void UpdateVideoListBox()
        {
            listBoxVideos.Items.Clear(); // Очистка текущего списка
            foreach (var video in videoList)
            {
                listBoxVideos.Items.Add(video);
            }
        }

        private void ButtonAddVideo_Click(object sender, EventArgs e)
        {
            // Код для добавления нового видео
            string newVideo = $"Video {videoList.Count + 1}"; // Создаем имя для нового видео
            videoList.Add(newVideo);
            UpdateVideoListBox(); // Обновление списка
            MessageBox.Show($"{newVideo} добавлено!", "Добавление видео", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonEditVideo_Click(object sender, EventArgs e)
        {
            // Логика для редактирования видео
            if (listBoxVideos.SelectedItem != null)
            {
                string selectedVideo = listBoxVideos.SelectedItem.ToString();
                string editedVideo = $"{selectedVideo} (edited)";
                int index = videoList.IndexOf(selectedVideo);
                videoList[index] = editedVideo; // Обновляем имя видео в списке
                UpdateVideoListBox(); // Обновление списка
                MessageBox.Show($"Редактирование видео: {selectedVideo} -> {editedVideo}", "Редактирование", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите видео для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteVideo_Click(object sender, EventArgs e)
        {
            // Логика удаления видео
            if (listBoxVideos.SelectedItem != null)
            {
                string selectedVideo = listBoxVideos.SelectedItem.ToString();
                videoList.Remove(selectedVideo);
                UpdateVideoListBox(); // Обновление списка
                MessageBox.Show($"{selectedVideo} удалено!", "Удаление видео", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите видео для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Можно использовать для каких-либо дополнительных действий при выборе видео
        }
    }
}
