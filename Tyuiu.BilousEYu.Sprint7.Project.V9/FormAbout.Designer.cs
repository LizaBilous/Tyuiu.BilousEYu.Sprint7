
namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 332);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 16);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 1;
            label1.Text = "Разработчик: Билоус Е.Ю.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 36);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 2;
            label2.Text = "Группа: ИСТНб-24-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 113);
            label3.Name = "label3";
            label3.Size = new Size(387, 20);
            label3.TabIndex = 3;
            label3.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 177);
            label4.Name = "label4";
            label4.Size = new Size(357, 20);
            label4.TabIndex = 4;
            label4.Text = "Тюменский индустриальный университет (с) 2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 197);
            label5.Name = "label5";
            label5.Size = new Size(329, 20);
            label5.TabIndex = 5;
            label5.Text = "Высшая школа цифровых технологий (с) 2024";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 269);
            label6.Name = "label6";
            label6.Size = new Size(360, 20);
            label6.TabIndex = 6;
            label6.Text = "Внутреннее имя: Tyuiu.BilousEYu.Sprint7.V9";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(487, 315);
            buttonOk.Margin = new Padding(3, 4, 3, 4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(115, 33);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 365);
            Controls.Add(buttonOk);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonOk;
    }
}