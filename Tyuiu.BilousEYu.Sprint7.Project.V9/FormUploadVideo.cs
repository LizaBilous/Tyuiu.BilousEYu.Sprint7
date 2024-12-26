using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormUploadVideo : Form
    {
        public FormUploadVideo()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            this.BackColor = Color.LightGray; // Фоновый цвет формы
            ButtonSelectFile.BackColor = Color.DarkSlateBlue;
            ButtonSelectFile.ForeColor = Color.White;
            ButtonSelectFile.FlatStyle = FlatStyle.Flat;

            ButtonUpload.BackColor = Color.DarkSlateGray;
            ButtonUpload.ForeColor = Color.White;
            ButtonUpload.FlatStyle = FlatStyle.Flat;

            ButtonSelectFile.MouseEnter += (s, e) => { ButtonSelectFile.BackColor = Color.LightBlue; };
            ButtonSelectFile.MouseLeave += (s, e) => { ButtonSelectFile.BackColor = Color.DarkSlateBlue; };

            ButtonUpload.MouseEnter += (s, e) => { ButtonUpload.BackColor = Color.LightBlue; };
            ButtonUpload.MouseLeave += (s, e) => { ButtonUpload.BackColor = Color.DarkSlateGray; };
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Видео успешно загружено!");
            this.Close();
        }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov|All Files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void FormUploadVideo_Load(object sender, EventArgs e)
        {

        }
    }
}
