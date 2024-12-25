namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormDeleteInfocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FormDeleteInfocs()
        {
            InitializeComponent();
            InitializeCustomComponents();  // Вызов метода для создания пользовательских компонентов
        }

        private void InitializeCustomComponents()
        {
            // Настройка формы
            this.Text = "Информация об удалении";

            Label label = new Label
            {
                Text = "Чтобы удалить фильм, нажмите на соответствующую кнопку.\n" +
                       "Подтвердите действие в появившемся диалоговом окне.",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };

            Button buttonOk = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new System.Drawing.Point(150, 80)
            };

            buttonOk.Click += (s, e) => this.Close(); // Закрытие формы при нажатии "OK"

            this.Controls.Add(label);
            this.Controls.Add(buttonOk);
        }

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
            this.SuspendLayout();
            // 
            // FormDeleteInfocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormDeleteInfocs";
            this.Text = "Информация об удалении";
            this.Load += new System.EventHandler(this.FormDeleteInfocs_Load);
            this.ResumeLayout(false);
        }

        private void FormDeleteInfocs_Load(object sender, EventArgs e)
        {
            
        }
    }
}