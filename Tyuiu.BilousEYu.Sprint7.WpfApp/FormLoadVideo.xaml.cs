using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormLoadVideo : Window
    {
        public FormLoadVideo()
        {
            InitializeComponent();
        }

        private void buttonLoadVideo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Video Files|*.mp4;*.avi;*.wmv;*.mkv|All Files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                mediaElement.Source = new Uri(openFileDialog.FileName);
                mediaElement.Play(); // Автоматическое воспроизведение
            }
        }
    }
}