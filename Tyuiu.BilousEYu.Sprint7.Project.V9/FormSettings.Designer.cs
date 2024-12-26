

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormSettings
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonApply;

        private void InitializeComponent()
        {
            labelLanguage = new Label();
            comboBoxLanguage = new ComboBox();
            buttonApply = new Button();

            SuspendLayout();

            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Location = new Point(15, 25);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(134, 20);
            labelLanguage.TabIndex = 0;
            labelLanguage.Text = "Выберите язык:";

            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguage.Location = new Point(15, 50);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(200, 28);
            comboBoxLanguage.TabIndex = 1;
            comboBoxLanguage.SelectedIndexChanged += ComboBoxLanguage_SelectedIndexChanged;

            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(15, 100);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(200, 30);
            buttonApply.TabIndex = 2;
            buttonApply.Text = "Применить";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += ButtonApply_Click;

            // 
            // FormSettings
            // 
            ClientSize = new Size(250, 150);
            Controls.Add(buttonApply);
            Controls.Add(comboBoxLanguage);
            Controls.Add(labelLanguage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройки";
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