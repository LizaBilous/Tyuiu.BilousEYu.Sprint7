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
            LoadHelpContent();
        }

        private void LoadHelpContent()
        {
            // Загрузка содержимого справки
            HelpTextBox.Text = "Здесь будет информация о том, как использовать приложение.";
        }

        private void HelpTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
