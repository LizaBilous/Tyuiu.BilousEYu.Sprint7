

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button ButtonUserProfile;
        private System.Windows.Forms.Button ButtonVideoCatalog;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonStatistics;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonUploadVideo;

        /// <summary>
        /// Освобождает ресурсы, используемые формой.
        /// </summary>
        /// <param name="disposing">true, если необходимо освободить управляемые ресурсы; в противном случае false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ButtonUserProfile = new Button();
            ButtonVideoCatalog = new Button();
            ButtonSettings = new Button();
            ButtonStatistics = new Button();
            ButtonHelp = new Button();
            ButtonUploadVideo = new Button();
            SuspendLayout();
            // 
            // ButtonUserProfile
            // 
            ButtonUserProfile.BackColor = Color.Gainsboro;
            ButtonUserProfile.FlatStyle = FlatStyle.Flat;
            ButtonUserProfile.ForeColor = Color.Black;
            ButtonUserProfile.Location = new Point(67, 46);
            ButtonUserProfile.Margin = new Padding(4, 5, 4, 5);
            ButtonUserProfile.Name = "ButtonUserProfile";
            ButtonUserProfile.Size = new Size(267, 62);
            ButtonUserProfile.TabIndex = 0;
            ButtonUserProfile.Text = "Профиль пользователя";
            ButtonUserProfile.UseVisualStyleBackColor = false;
            ButtonUserProfile.Click += ButtonUserProfile_Click;
            // 
            // ButtonVideoCatalog
            // 
            ButtonVideoCatalog.BackColor = Color.Gainsboro;
            ButtonVideoCatalog.FlatStyle = FlatStyle.Flat;
            ButtonVideoCatalog.ForeColor = Color.Black;
            ButtonVideoCatalog.Location = new Point(67, 123);
            ButtonVideoCatalog.Margin = new Padding(4, 5, 4, 5);
            ButtonVideoCatalog.Name = "ButtonVideoCatalog";
            ButtonVideoCatalog.Size = new Size(267, 62);
            ButtonVideoCatalog.TabIndex = 1;
            ButtonVideoCatalog.Text = "Каталог видеопленок";
            ButtonVideoCatalog.UseVisualStyleBackColor = false;
            ButtonVideoCatalog.Click += ButtonVideoCatalog_Click;
            // 
            // ButtonSettings
            // 
            ButtonSettings.BackColor = Color.Gainsboro;
            ButtonSettings.FlatStyle = FlatStyle.Flat;
            ButtonSettings.ForeColor = Color.Black;
            ButtonSettings.Location = new Point(67, 200);
            ButtonSettings.Margin = new Padding(4, 5, 4, 5);
            ButtonSettings.Name = "ButtonSettings";
            ButtonSettings.Size = new Size(267, 62);
            ButtonSettings.TabIndex = 2;
            ButtonSettings.Text = "Настройки";
            ButtonSettings.UseVisualStyleBackColor = false;
            ButtonSettings.Click += ButtonSettings_Click;
            // 
            // ButtonStatistics
            // 
            ButtonStatistics.BackColor = Color.Gainsboro;
            ButtonStatistics.FlatStyle = FlatStyle.Flat;
            ButtonStatistics.ForeColor = Color.Black;
            ButtonStatistics.Location = new Point(67, 277);
            ButtonStatistics.Margin = new Padding(4, 5, 4, 5);
            ButtonStatistics.Name = "ButtonStatistics";
            ButtonStatistics.Size = new Size(267, 62);
            ButtonStatistics.TabIndex = 3;
            ButtonStatistics.Text = "Статистика";
            ButtonStatistics.UseVisualStyleBackColor = false;
            ButtonStatistics.Click += ButtonStatistics_Click;
            // 
            // ButtonHelp
            // 
            ButtonHelp.BackColor = Color.Gainsboro;
            ButtonHelp.FlatStyle = FlatStyle.Flat;
            ButtonHelp.ForeColor = Color.Black;
            ButtonHelp.Location = new Point(67, 354);
            ButtonHelp.Margin = new Padding(4, 5, 4, 5);
            ButtonHelp.Name = "ButtonHelp";
            ButtonHelp.Size = new Size(267, 62);
            ButtonHelp.TabIndex = 4;
            ButtonHelp.Text = "Помощь";
            ButtonHelp.UseVisualStyleBackColor = false;
            ButtonHelp.Click += ButtonHelp_Click;
            // 
            // ButtonUploadVideo
            // 
            ButtonUploadVideo.BackColor = Color.Gainsboro;
            ButtonUploadVideo.FlatStyle = FlatStyle.Flat;
            ButtonUploadVideo.ForeColor = Color.Black;
            ButtonUploadVideo.Location = new Point(67, 431);
            ButtonUploadVideo.Margin = new Padding(4, 5, 4, 5);
            ButtonUploadVideo.Name = "ButtonUploadVideo";
            ButtonUploadVideo.Size = new Size(267, 62);
            ButtonUploadVideo.TabIndex = 5;
            ButtonUploadVideo.Text = "Загрузить видео";
            ButtonUploadVideo.UseVisualStyleBackColor = false;
            ButtonUploadVideo.Click += ButtonUploadVideo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 615);
            Controls.Add(ButtonUserProfile);
            Controls.Add(ButtonVideoCatalog);
            Controls.Add(ButtonSettings);
            Controls.Add(ButtonStatistics);
            Controls.Add(ButtonHelp);
            Controls.Add(ButtonUploadVideo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "Главное меню";
            Load += FormMain_Load_1;
            ResumeLayout(false);
        }
    }
}

