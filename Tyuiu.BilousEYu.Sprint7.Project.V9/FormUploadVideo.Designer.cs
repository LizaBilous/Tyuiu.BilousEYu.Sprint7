
namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormUploadVideo
    {
        private System.ComponentModel.IContainer components = null;
        private Button ButtonUpload;
        private Button ButtonSelectFile;
        private TextBox TextBoxFilePath;
        private Label LabelFilePath;

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
            ButtonUpload = new Button();
            ButtonSelectFile = new Button();
            TextBoxFilePath = new TextBox();
            LabelFilePath = new Label();
            SuspendLayout();
            // 
            // ButtonUpload
            // 
            ButtonUpload.Location = new Point(10, 168);
            ButtonUpload.Name = "ButtonUpload";
            ButtonUpload.Size = new Size(120, 30);
            ButtonUpload.TabIndex = 3;
            ButtonUpload.Text = "Загрузить";
            ButtonUpload.Click += ButtonUpload_Click;
            // 
            // ButtonSelectFile
            // 
            ButtonSelectFile.Location = new Point(130, 98);
            ButtonSelectFile.Name = "ButtonSelectFile";
            ButtonSelectFile.Size = new Size(120, 30);
            ButtonSelectFile.TabIndex = 0;
            ButtonSelectFile.Text = "Выбрать видео";
            ButtonSelectFile.Click += ButtonSelectFile_Click;
            // 
            // TextBoxFilePath
            // 
            TextBoxFilePath.Location = new Point(10, 98);
            TextBoxFilePath.Name = "TextBoxFilePath";
            TextBoxFilePath.ReadOnly = true;
            TextBoxFilePath.Size = new Size(240, 27);
            TextBoxFilePath.TabIndex = 1;
            // 
            // LabelFilePath
            // 
            LabelFilePath.Location = new Point(12, 72);
            LabelFilePath.Name = "LabelFilePath";
            LabelFilePath.Size = new Size(137, 23);
            LabelFilePath.TabIndex = 2;
            LabelFilePath.Text = "Путь к файлу:";
            // 
            // FormUploadVideo
            // 
            ClientSize = new Size(300, 210);
            Controls.Add(ButtonSelectFile);
            Controls.Add(TextBoxFilePath);
            Controls.Add(LabelFilePath);
            Controls.Add(ButtonUpload);
            Name = "FormUploadVideo";
            Text = "Загрузка видео";
            Load += FormUploadVideo_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}