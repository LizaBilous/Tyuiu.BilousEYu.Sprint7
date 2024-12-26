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
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            // Инициализация данных пользователя при загрузке формы
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            // Здесь должна быть логика загрузки данных пользователя
            // Например, из базы данных или файла
            textBoxName.Text = "Имя Пользователя"; // Пример данных
            textBoxEmail.Text = "example@mail.com"; // Пример данных
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Логика для сохранения профиля пользователя
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;

            // Здесь можно добавить код для сохранения данных, например, в базу данных

            MessageBox.Show("Профиль сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // Логика для сброса изменений в профиле
            LoadUserProfile(); // Сбросить данные до исходного состояния
            MessageBox.Show("Изменения сброшены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
