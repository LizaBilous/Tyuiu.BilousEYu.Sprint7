
namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormUploadVideo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonUpload;

        private void InitializeComponent()
        {
            buttonUpload = new Button();
            SuspendLayout();

            // 
            // buttonUpload
            // 
            buttonUpload.Location = new System.Drawing.Point(15, 15);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new System.Drawing.Size(150, 30);
            buttonUpload.TabIndex = 0;
            buttonUpload.Text = "Загрузить видео";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;

            // 
            // FormUploadVideo
            // 
            ClientSize = new System.Drawing.Size(180, 60);
            Controls.Add(buttonUpload);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormUploadVideo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Загрузка видео";
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
