namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormUserProfile
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
            LabelName = new Label();
            TextBoxName = new TextBox();
            LabelEmail = new Label();
            TextBoxEmail = new TextBox();
            ButtonSave = new Button();
            ButtonReset = new Button();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(20, 20);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(42, 20);
            LabelName.TabIndex = 0;
            LabelName.Text = "Имя:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(172, 27);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(247, 27);
            TextBoxName.TabIndex = 1;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(20, 60);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(146, 20);
            LabelEmail.TabIndex = 2;
            LabelEmail.Text = "Электронная почта:";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(172, 60);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(247, 27);
            TextBoxEmail.TabIndex = 3;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(12, 136);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(106, 38);
            ButtonSave.TabIndex = 4;
            ButtonSave.Text = "Сохранить";
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(305, 136);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(103, 38);
            ButtonReset.TabIndex = 5;
            ButtonReset.Text = "Сбросить";
            ButtonReset.Click += ButtonReset_Click;
            // 
            // FormUserProfile
            // 
            ClientSize = new Size(431, 186);
            Controls.Add(LabelName);
            Controls.Add(TextBoxName);
            Controls.Add(LabelEmail);
            Controls.Add(TextBoxEmail);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonReset);
            Name = "FormUserProfile";
            Text = "Профиль пользователя";
            Load += FormUserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonReset;
    }
}