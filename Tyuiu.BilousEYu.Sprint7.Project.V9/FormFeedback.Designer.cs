namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormFeedback
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Button buttonSubmit;

        private void InitializeComponent()
        {
            labelPrompt = new Label();
            textBoxFeedback = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();

            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.Location = new Point(15, 25);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(186, 20);
            labelPrompt.TabIndex = 0;
            labelPrompt.Text = "Введите ваш отзыв ниже:";

            // 
            // textBoxFeedback
            // 
            textBoxFeedback.Location = new Point(15, 44);
            textBoxFeedback.Multiline = true;
            textBoxFeedback.Name = "textBoxFeedback";
            textBoxFeedback.Size = new Size(442, 131);
            textBoxFeedback.TabIndex = 1;
            textBoxFeedback.TextChanged += textBoxFeedback_TextChanged; // Используем единственный обработчик

            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(340, 181);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(104, 30);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Отправить отзыв";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;

            // 
            // FormFeedback
            // 
            ClientSize = new Size(483, 220);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxFeedback);
            Controls.Add(labelPrompt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormFeedback";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Форма обратной связи";
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
