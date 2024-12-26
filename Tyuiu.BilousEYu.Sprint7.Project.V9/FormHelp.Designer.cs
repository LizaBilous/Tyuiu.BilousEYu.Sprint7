namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormHelp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.Label labelHint;

        private void InitializeComponent()
        {
            labelPrompt = new Label();
            textBoxHelp = new TextBox();
            labelHint = new Label();

            SuspendLayout();

            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.Location = new Point(15, 25);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(200, 20);
            labelPrompt.TabIndex = 0;
            labelPrompt.Text = "Введите ваш вопрос о помощи:";

            // 
            // textBoxHelp
            // 
            textBoxHelp.Location = new Point(15, 50);
            textBoxHelp.Multiline = true;
            textBoxHelp.Name = "textBoxHelp";
            textBoxHelp.Size = new Size(400, 100);
            textBoxHelp.TabIndex = 1;
            textBoxHelp.TextChanged += textBoxHelp_TextChanged;

            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Location = new Point(15, 160);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(0, 20);
            labelHint.TabIndex = 2;

            // 
            // FormHelp
            // 
            ClientSize = new Size(450, 200);
            Controls.Add(labelHint);
            Controls.Add(textBoxHelp);
            Controls.Add(labelPrompt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Помощь";
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
