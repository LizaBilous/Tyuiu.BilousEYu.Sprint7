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

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при загрузке формы
            MessageBox.Show("Добро пожаловать в приложение!");
        }

        private void ButtonUserProfile_Click(object sender, EventArgs e)
        {
            // Открытие формы профиля пользователя
            FormUserProfile userProfileForm = new FormUserProfile();
            userProfileForm.Show();
        }

        private void ButtonVideoCatalog_Click(object sender, EventArgs e)
        {
            // Открытие формы каталога видео
            FormVideoCatalog videoCatalogForm = new FormVideoCatalog();
            videoCatalogForm.Show();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            // Открытие формы настроек
            FormSettings settingsForm = new FormSettings();
            settingsForm.Show();
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            // Открытие формы статистики
            FormStatistics statisticsForm = new FormStatistics();
            statisticsForm.Show();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            // Открытие формы помощи
            FormHelp helpForm = new FormHelp();
            helpForm.Show();
        }

        private void ButtonUploadVideo_Click(object sender, EventArgs e)
        {
            // Открытие формы загрузки видео
            FormUploadVideo uploadVideoForm = new FormUploadVideo();
            uploadVideoForm.Show();
        }
    }
}

