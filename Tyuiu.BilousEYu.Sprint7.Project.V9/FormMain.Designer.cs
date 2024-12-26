

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // Кнопки и другие элементы управления
        private System.Windows.Forms.Button ButtonUserProfile;
        private System.Windows.Forms.Button ButtonVideoCatalog;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonStatistics;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonUploadVideo;

        /// <summary>
        /// Необходимый метод для поддержки конструктора - не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonUserProfile = new System.Windows.Forms.Button();
            this.ButtonVideoCatalog = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonStatistics = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonUploadVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // ButtonUserProfile
            // 
            this.ButtonUserProfile.Location = new System.Drawing.Point(67, 46);
            this.ButtonUserProfile.Name = "ButtonUserProfile";
            this.ButtonUserProfile.Size = new System.Drawing.Size(267, 62);
            this.ButtonUserProfile.TabIndex = 0;
            this.ButtonUserProfile.Text = "Профиль пользователя";
            this.ButtonUserProfile.UseVisualStyleBackColor = true;
            this.ButtonUserProfile.Click += new System.EventHandler(this.ButtonUserProfile_Click);

            // 
            // ButtonVideoCatalog
            // 
            this.ButtonVideoCatalog.Location = new System.Drawing.Point(67, 123);
            this.ButtonVideoCatalog.Name = "ButtonVideoCatalog";
            this.ButtonVideoCatalog.Size = new System.Drawing.Size(267, 62);
            this.ButtonVideoCatalog.TabIndex = 1;
            this.ButtonVideoCatalog.Text = "Каталог видеопленок";
            this.ButtonVideoCatalog.UseVisualStyleBackColor = true;
            this.ButtonVideoCatalog.Click += new System.EventHandler(this.ButtonVideoCatalog_Click);

            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(67, 200);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(267, 62);
            this.ButtonSettings.TabIndex = 2;
            this.ButtonSettings.Text = "Настройки";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);

            // 
            // ButtonStatistics
            // 
            this.ButtonStatistics.Location = new System.Drawing.Point(67, 277);
            this.ButtonStatistics.Name = "ButtonStatistics";
            this.ButtonStatistics.Size = new System.Drawing.Size(267, 62);
            this.ButtonStatistics.TabIndex = 3;
            this.ButtonStatistics.Text = "Статистика";
            this.ButtonStatistics.UseVisualStyleBackColor = true;
            this.ButtonStatistics.Click += new System.EventHandler(this.ButtonStatistics_Click);

            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(67, 354);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(267, 62);
            this.ButtonHelp.TabIndex = 4;
            this.ButtonHelp.Text = "Помощь";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);

            // 
            // ButtonUploadVideo
            // 
            this.ButtonUploadVideo.Location = new System.Drawing.Point(67, 431);
            this.ButtonUploadVideo.Name = "ButtonUploadVideo";
            this.ButtonUploadVideo.Size = new System.Drawing.Size(267, 62);
            this.ButtonUploadVideo.TabIndex = 5;
            this.ButtonUploadVideo.Text = "Загрузить видео";
            this.ButtonUploadVideo.UseVisualStyleBackColor = true;
            this.ButtonUploadVideo.Click += new System.EventHandler(this.ButtonUploadVideo_Click);

            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 615);
            this.Controls.Add(this.ButtonUserProfile);
            this.Controls.Add(this.ButtonVideoCatalog);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonStatistics);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonUploadVideo);
            this.Name = "FormMain";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
        }
    }
}

