﻿using Tyuiu.BilousEYu.Sprint7.Project.V9.Lib;
namespace Tyuiu.BilousEYu.Sprint7.Project.V9


{
    partial class FormMenu
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
            this.SuspendLayout();
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            ShowMenu(); // Инициализация данных при загрузке формы
        }

        #endregion
    }  
}