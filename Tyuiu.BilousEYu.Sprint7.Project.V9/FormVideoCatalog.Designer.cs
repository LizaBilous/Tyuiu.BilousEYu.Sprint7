namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormVideoCatalog
    {
        private System.ComponentModel.IContainer components = null;

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
            ButtonAddVideo = new Button();
            ButtonEditVideo = new Button();
            ButtonDeleteVideo = new Button();
            VideoListBox = new ListBox();
            SuspendLayout();
            // 
            // ButtonAddVideo
            // 
            ButtonAddVideo.Location = new Point(12, 198);
            ButtonAddVideo.Name = "ButtonAddVideo";
            ButtonAddVideo.Size = new Size(100, 40);
            ButtonAddVideo.TabIndex = 0;
            ButtonAddVideo.Text = "Добавить видео";
            ButtonAddVideo.Click += ButtonAddVideo_Click;
            // 
            // ButtonEditVideo
            // 
            ButtonEditVideo.Location = new Point(310, 74);
            ButtonEditVideo.Name = "ButtonEditVideo";
            ButtonEditVideo.Size = new Size(131, 40);
            ButtonEditVideo.TabIndex = 1;
            ButtonEditVideo.Text = "Редактировать";
            ButtonEditVideo.Click += ButtonEditVideo_Click;
            // 
            // ButtonDeleteVideo
            // 
            ButtonDeleteVideo.Location = new Point(352, 198);
            ButtonDeleteVideo.Name = "ButtonDeleteVideo";
            ButtonDeleteVideo.Size = new Size(100, 40);
            ButtonDeleteVideo.TabIndex = 2;
            ButtonDeleteVideo.Text = "Удалить";
            ButtonDeleteVideo.Click += ButtonDeleteVideo_Click;
            // 
            // VideoListBox
            // 
            VideoListBox.Location = new Point(12, 21);
            VideoListBox.Name = "VideoListBox";
            VideoListBox.Size = new Size(277, 164);
            VideoListBox.TabIndex = 3;
            VideoListBox.SelectedIndexChanged += VideoListBox_SelectedIndexChanged;
            // 
            // FormVideoCatalog
            // 
            ClientSize = new Size(464, 250);
            Controls.Add(ButtonAddVideo);
            Controls.Add(ButtonEditVideo);
            Controls.Add(ButtonDeleteVideo);
            Controls.Add(VideoListBox);
            Name = "FormVideoCatalog";
            Text = "Каталог видеопленок";
            Load += FormVideoCatalog_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button ButtonAddVideo;
        private System.Windows.Forms.Button ButtonEditVideo;
        private System.Windows.Forms.Button ButtonDeleteVideo;
        private System.Windows.Forms.ListBox VideoListBox;
    }
}
