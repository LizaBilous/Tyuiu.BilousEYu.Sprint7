namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormHelp
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
            HelpTextBox = new TextBox();
            SuspendLayout();
            // 
            // HelpTextBox
            // 
            HelpTextBox.Location = new Point(10, 10);
            HelpTextBox.Multiline = true;
            HelpTextBox.Name = "HelpTextBox";
            HelpTextBox.ReadOnly = true;
            HelpTextBox.Size = new Size(380, 263);
            HelpTextBox.TabIndex = 0;
            HelpTextBox.TextChanged += HelpTextBox_TextChanged;
            // 
            // FormHelp
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(HelpTextBox);
            Name = "FormHelp";
            Text = "Помощь";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox HelpTextBox;
    }
 }