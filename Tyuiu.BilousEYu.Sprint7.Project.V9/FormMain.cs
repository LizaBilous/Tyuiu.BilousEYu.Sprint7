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
            // Ваш код загрузки формы
        }

        private void ButtonUserProfile_Click(object sender, EventArgs e)
        {
            // Логика кнопки "Профиль пользователя"
        }

        private void ButtonVideoCatalog_Click(object sender, EventArgs e)
        {
            // Логика кнопки "Каталог видеопленок"
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            // Логика кнопки "Настройки"
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            // Логика кнопки "Статистика"
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            // Логика кнопки "Помощь"
        }

        private void ButtonUploadVideo_Click(object sender, EventArgs e)
        {
            // Логика кнопки "Загрузить видео"
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}

