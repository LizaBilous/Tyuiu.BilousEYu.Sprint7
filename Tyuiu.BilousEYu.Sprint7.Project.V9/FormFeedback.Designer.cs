namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormFeedback
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
            TextBoxFeedback = new TextBox();
            ButtonSubmit = new Button();
            SuspendLayout();
            // 
            // TextBoxFeedback
            // 
            TextBoxFeedback.Location = new Point(10, 10);
            TextBoxFeedback.Multiline = true;
            TextBoxFeedback.Name = "TextBoxFeedback";
            TextBoxFeedback.Size = new Size(380, 200);
            TextBoxFeedback.TabIndex = 0;
            TextBoxFeedback.TextChanged += TextBoxFeedback_TextChanged;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(10, 220);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(98, 31);
            ButtonSubmit.TabIndex = 1;
            ButtonSubmit.Text = "Отправить";
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // FormFeedback
            // 
            ClientSize = new Size(400, 285);
            Controls.Add(TextBoxFeedback);
            Controls.Add(ButtonSubmit);
            Name = "FormFeedback";
            Text = "Отзывы";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox TextBoxFeedback;
        private System.Windows.Forms.Button ButtonSubmit;
    }

    #region Windows Form Designer generated code

        #endregion
}
