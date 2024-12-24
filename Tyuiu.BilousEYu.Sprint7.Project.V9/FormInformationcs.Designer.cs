using System.ComponentModel;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormInformationcs
    {
        private IContainer components = null;
        private Label label1;
        private Button buttonOK_RKN;
        private PictureBox pictureBoxAvatar_RKN;

        /// <summary>
        /// Освободить все использованные ресурсы.
        /// </summary>
        /// <param name="disposing">true, если управляемые ресурсы следует освободить; в противном случае - false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformationcs));
            label1 = new Label();
            buttonOK_RKN = new Button();
            pictureBoxAvatar_RKN = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)(pictureBoxAvatar_RKN)).BeginInit();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 25);
            label1.Name = "label1";
            label1.Size = new Size(302, 150);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");

            // 
            // buttonOK_RKN
            // 
            buttonOK_RKN.Cursor = Cursors.Hand;
            buttonOK_RKN.Location = new Point(415, 193);
            buttonOK_RKN.Name = "buttonOK_RKN";
            buttonOK_RKN.Size = new Size(80, 29);
            buttonOK_RKN.TabIndex = 2;
            buttonOK_RKN.Text = "OK";
            buttonOK_RKN.UseVisualStyleBackColor = true;
            buttonOK_RKN.Click += buttonOK_RKN_Click; // Подписка на событие

            // 
            // pictureBoxAvatar_RKN
            // 
            pictureBoxAvatar_RKN.Location = new Point(12, 25);
            pictureBoxAvatar_RKN.Name = "pictureBoxAvatar_RKN";
            pictureBoxAvatar_RKN.Size = new Size(145, 141);
            pictureBoxAvatar_RKN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_RKN.TabIndex = 1;
            pictureBoxAvatar_RKN.TabStop = false;

            // 
            // FormInformationcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 233);
            Controls.Add(buttonOK_RKN);
            Controls.Add(pictureBoxAvatar_RKN);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInformationcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";

            ((System.ComponentModel.ISupportInitialize)(pictureBoxAvatar_RKN)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}