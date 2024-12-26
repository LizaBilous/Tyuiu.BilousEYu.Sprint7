namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormVideoCatalog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxVideos;
        private System.Windows.Forms.Button buttonAddVideo;
        private System.Windows.Forms.Button buttonEditVideo;
        private System.Windows.Forms.Button buttonDeleteVideo;

        private void InitializeComponent()
        {
            listBoxVideos = new ListBox();
            buttonAddVideo = new Button();
            buttonEditVideo = new Button();
            buttonDeleteVideo = new Button();

            SuspendLayout();

            // 
            // listBoxVideos
            // 
            listBoxVideos.FormattingEnabled = true;
            listBoxVideos.ItemHeight = 20;
            listBoxVideos.Location = new System.Drawing.Point(15, 15);
            listBoxVideos.Name = "listBoxVideos";
            listBoxVideos.Size = new System.Drawing.Size(250, 180);
            listBoxVideos.TabIndex = 0;
            listBoxVideos.SelectedIndexChanged += listBoxVideos_SelectedIndexChanged;

            // 
            // buttonAddVideo
            // 
            buttonAddVideo.Location = new System.Drawing.Point(15, 210);
            buttonAddVideo.Name = "buttonAddVideo";
            buttonAddVideo.Size = new System.Drawing.Size(75, 30);
            buttonAddVideo.Text = "Добавить";
            buttonAddVideo.UseVisualStyleBackColor = true;
            buttonAddVideo.Click += ButtonAddVideo_Click;

            // 
            // buttonEditVideo
            // 
            buttonEditVideo.Location = new System.Drawing.Point(100, 210);
            buttonEditVideo.Name = "buttonEditVideo";
            buttonEditVideo.Size = new System.Drawing.Size(75, 30);
            buttonEditVideo.Text = "Редактировать";
            buttonEditVideo.UseVisualStyleBackColor = true;
            buttonEditVideo.Click += ButtonEditVideo_Click;

            // 
            // buttonDeleteVideo
            // 
            buttonDeleteVideo.Location = new System.Drawing.Point(185, 210);
            buttonDeleteVideo.Name = "buttonDeleteVideo";
            buttonDeleteVideo.Size = new System.Drawing.Size(75, 30);
            buttonDeleteVideo.Text = "Удалить";
            buttonDeleteVideo.UseVisualStyleBackColor = true;
            buttonDeleteVideo.Click += ButtonDeleteVideo_Click;

            // 
            // FormVideoCatalog
            // 
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(listBoxVideos);
            Controls.Add(buttonAddVideo);
            Controls.Add(buttonEditVideo);
            Controls.Add(buttonDeleteVideo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormVideoCatalog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Каталог Видео";
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
