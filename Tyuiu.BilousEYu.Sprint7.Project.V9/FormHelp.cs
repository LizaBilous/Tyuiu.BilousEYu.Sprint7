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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void textBoxHelp_TextChanged(object sender, EventArgs e)
        {
            // Метод, который вызывается при изменении текста в текстовом поле
            string input = textBoxHelp.Text;

            // Пример логики, показывающей подсказку на основе ввода
            if (string.IsNullOrWhiteSpace(input))
            {
                labelHint.Text = "Введите текст для получения подсказки...";
            }
            else if (input.Contains("как"))
            {
                labelHint.Text = "Наберите вопрос, например: 'Как использовать приложение?'";
            }
            else if (input.Contains("где"))
            {
                labelHint.Text = "Например: 'Где найти настройки?'";
            }
            else
            {
                labelHint.Text = "Не могу помочь с этим вопросом.";
            }
        }
    }
}
