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
        private List<VideoTape> videoList = new List<VideoTape>();

        public FormVideoCatalog()
        {
            InitializeComponent();
            LoadVideoCatalog();
        }

        private void LoadVideoCatalog()
        {
            // Загрузка видеопленок из файла или базы данных
        }

        private void ButtonAddVideo_Click(object sender, EventArgs e)
        {
            // Логика для добавления нового видеопленки
        }

        private void ButtonEditVideo_Click(object sender, EventArgs e)
        {
            // Логика для редактирования выбранной видеопленки
        }

        private void ButtonDeleteVideo_Click(object sender, EventArgs e)
        {
            // Логика для удаления выбранной видеопленки
        }

        private void FormVideoCatalog_Load(object sender, EventArgs e)
        {

        }

        private void VideoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
