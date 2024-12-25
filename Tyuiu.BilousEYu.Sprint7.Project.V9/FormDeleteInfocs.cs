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
    public partial class FormDeleteInfocs : Form
    {
        public FormDeleteInfocs()
        {
            InitializeComponent();
            this.Text = "Информация об удалении";

            // Создание метки с текстом
            Label label = new Label
            {
                Text = "Чтобы удалить фильм, нажмите на соответствующую кнопку.\n" +
                       "Подтвердите действие в появившемся диалоговом окне.",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };

            // Создание кнопки "OK"
            Button buttonOk = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new System.Drawing.Point(150, 80)
            };

            // Закрытие формы при нажатии кнопки "OK"
            buttonOk.Click += (s, e) => this.Close();

            // Добавление метки и кнопки на форму
            this.Controls.Add(label);
            this.Controls.Add(buttonOk);
        }
    }

}
