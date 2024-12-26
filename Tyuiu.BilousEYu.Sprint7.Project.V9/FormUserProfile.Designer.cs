namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormUserProfile
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            buttonSave = new Button();
            buttonReset = new Button();
            labelName = new Label();
            labelEmail = new Label();

            SuspendLayout();

            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(15, 15);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(50, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Имя:";

            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(15, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(250, 26);
            textBoxName.TabIndex = 1;

            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(15, 70);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(61, 20);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";

            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(15, 90);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(250, 26);
            textBoxEmail.TabIndex = 3;

            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(15, 130);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(115, 30);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;

            // 
            // buttonReset
            // 
            buttonReset.Location = new System.Drawing.Point(150, 130);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(115, 30);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Сбросить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonReset_Click;

            // 
            // FormUserProfile
            // 
            ClientSize = new System.Drawing.Size(284, 181);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonSave);
            Controls.Add(buttonReset);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormUserProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Профиль пользователя";
            ResumeLayout(false);
            PerformLayout();
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