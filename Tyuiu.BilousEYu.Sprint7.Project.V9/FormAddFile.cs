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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormAddFile : Form
    {
        public FormAddFile()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Видео файл|*.mp4;*.mov;*.wmv;*.avi";
            openFileDialog1.ShowDialog(this);
            string filepath = openFileDialog1.FileName;
            if (openFileDialog1.CheckFileExists)
            {
                textBoxFilePath.Text = filepath;
            }
            else
            {
                MessageBox.Show("Файл не существует или не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSaveInfo_Click(object sender, EventArgs e)
        {
            if (textBoxFilePath.Text == string.Empty || textBoxFilePath.Text == "" || !File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("Файл невыбран или не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Введите название файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxH.Text == string.Empty || textBoxM.Text == string.Empty || textBoxS.Text == string.Empty || Convert.ToInt32(textBoxM.Text) < 0 || Convert.ToInt32(textBoxM.Text) > 59 || Convert.ToInt32(textBoxS.Text) < 0 || Convert.ToInt32(textBoxS.Text) > 59)
            {
                MessageBox.Show("Время введено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxDesc.Text == string.Empty)
            {
                MessageBox.Show("Введите описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool ans = ds.SaveInfo(Convert.ToInt32(textBoxM.Text), Convert.ToInt32(textBoxS.Text), Convert.ToInt32(textBoxH.Text), textBoxDesc.Text, textBoxFilePath.Text, textBoxName.Text);
                if (ans)
                {
                    MessageBox.Show("Файл сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Файл небыл сохранен", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
