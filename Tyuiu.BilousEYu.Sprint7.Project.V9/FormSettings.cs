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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // Инициализация значений по умолчанию для настроек
            comboBoxLanguage.Items.AddRange(new string[] { "Русский", "English", "Français" });
            comboBoxLanguage.SelectedItem = "Русский"; // Устанавливаем язык по умолчанию
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            // Логика применения настроек
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();
            SaveSettings(selectedLanguage);

            MessageBox.Show("Настройки успешно применены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Логика для изменения языка приложения
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();
            ChangeApplicationLanguage(selectedLanguage);
        }

        private void SaveSettings(string language)
        {
            // Здесь можно добавить код для сохранения выбранного языка в файл или базу данных
            // Например, сохранение в файл конфигурации
            System.IO.File.WriteAllText("settings.txt", language);
        }

        private void ChangeApplicationLanguage(string language)
        {
            // Замените на логику для изменения языка интерфейса приложения
            // Например, обновление текстов кнопок и меток
            if (language == "Русский")
            {
                // Обновление интерфейса на русский
            }
            else if (language == "English")
            {
                // Обновление интерфейса на английский
            }
            else if (language == "Français")
            {
                // Обновление интерфейса на французский
            }
        }
    }
}