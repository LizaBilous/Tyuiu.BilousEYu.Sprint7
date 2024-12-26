namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormSettings
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
            CheckBoxNotifications = new CheckBox();
            ComboBoxLanguage = new ComboBox();
            LabelLanguage = new Label();
            ButtonApply = new Button();
            SuspendLayout();
            // 
            // CheckBoxNotifications
            // 
            CheckBoxNotifications.AutoSize = true;
            CheckBoxNotifications.Location = new Point(20, 20);
            CheckBoxNotifications.Name = "CheckBoxNotifications";
            CheckBoxNotifications.Size = new Size(195, 24);
            CheckBoxNotifications.TabIndex = 0;
            CheckBoxNotifications.Text = "Включить уведомления";
            // 
            // ComboBoxLanguage
            // 
            ComboBoxLanguage.Items.AddRange(new object[] { "Русский", "Английский" });
            ComboBoxLanguage.Location = new Point(270, 60);
            ComboBoxLanguage.Name = "ComboBoxLanguage";
            ComboBoxLanguage.Size = new Size(121, 28);
            ComboBoxLanguage.TabIndex = 1;
            ComboBoxLanguage.SelectedIndexChanged += ComboBoxLanguage_SelectedIndexChanged;
            // 
            // LabelLanguage
            // 
            LabelLanguage.AutoSize = true;
            LabelLanguage.Location = new Point(20, 60);
            LabelLanguage.Name = "LabelLanguage";
            LabelLanguage.Size = new Size(133, 20);
            LabelLanguage.TabIndex = 2;
            LabelLanguage.Text = "Язык интерфейса:";
            // 
            // ButtonApply
            // 
            ButtonApply.Location = new Point(20, 100);
            ButtonApply.Name = "ButtonApply";
            ButtonApply.Size = new Size(101, 34);
            ButtonApply.TabIndex = 3;
            ButtonApply.Text = "Применить";
            ButtonApply.Click += ButtonApply_Click;
            // 
            // FormSettings
            // 
            ClientSize = new Size(403, 163);
            Controls.Add(CheckBoxNotifications);
            Controls.Add(ComboBoxLanguage);
            Controls.Add(LabelLanguage);
            Controls.Add(ButtonApply);
            Name = "FormSettings";
            Text = "Настройки";
            Load += FormSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckBox CheckBoxNotifications;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.Button ButtonApply;
    }
    #region Windows Form Designer generated code
}
#endregion