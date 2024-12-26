

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormSettings
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxLanguage;
        private Button buttonApply;

        private void InitializeComponent()
        {
            this.comboBoxLanguage = new ComboBox();
            this.buttonApply = new Button();
            this.SuspendLayout();

            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(200, 28);
            this.comboBoxLanguage.TabIndex = 0;
            this.comboBoxLanguage.SelectedIndexChanged += new EventHandler(this.ComboBoxLanguage_SelectedIndexChanged);

            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(12, 50);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(200, 30);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new EventHandler(this.ButtonApply_Click);

            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxLanguage);
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
        
        }
    }
}