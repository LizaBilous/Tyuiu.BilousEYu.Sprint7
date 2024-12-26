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
            comboBoxLanguage.Items.AddRange(new string[] { "Русский", "English", "Français", "Español" });
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
            try
            {
                System.IO.File.WriteAllText("settings.txt", language);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении настроек: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeApplicationLanguage(string language)
        {
            // Здесь меняем текст интерфейса в зависимости от выбранного языка
            if (language == "Русский")
            {
                this.Text = "Настройки";
                buttonApply.Text = "Применить";
            }
            else if (language == "English")
            {
                this.Text = "Settings";
                buttonApply.Text = "Apply";
            }
            else if (language == "Français")
            {
                this.Text = "Paramètres";
                buttonApply.Text = "Appliquer";
            }
            else if (language == "Español")
            {
                this.Text = "Configuraciones";
                buttonApply.Text = "Aplicar";
            }
        }
    }
}