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
    public partial class FormFeedback : Form
    {
        public FormFeedback()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string feedback = textBoxFeedback.Text;

            if (string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Пожалуйста, введите ваш отзыв.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Здесь может быть код для сохранения или отправки отзыва

            MessageBox.Show("Ваш отзыв отправлен!", "Спасибо!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void textBoxFeedback_TextChanged(object sender, EventArgs e)
        {
            // Ограничиваем количество символов в текстовом поле
            const int maxChars = 500; // Максимальное количество символов
            if (textBoxFeedback.Text.Length > maxChars)
            {
                MessageBox.Show($"Отзыв не может превышать {maxChars} символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFeedback.Text = textBoxFeedback.Text.Substring(0, maxChars); // Обрезаем текст
            }
        }
    }
}
