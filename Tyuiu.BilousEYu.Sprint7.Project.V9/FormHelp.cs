﻿using System;
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
            this.Text = "Информация об удалении";
            Label label = new Label
            {
                Text = "Для удаления фильма нажмите на соответствующую кнопку.\n" +
                       "Подтвердите действие в появившемся диалоговом окне.",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };

            Button buttonOk = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new System.Drawing.Point(150, 80)
            };

            buttonOk.Click += (s, e) => this.Close(); // Закрывает форму при нажатии "OK"

            this.Controls.Add(label);
            this.Controls.Add(buttonOk);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
