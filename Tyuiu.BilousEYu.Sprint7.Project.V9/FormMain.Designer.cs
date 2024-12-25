using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormMain
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
            if (disposing && components != null)
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
            components = new System.ComponentModel.Container();
            openFileDialogMain_GAM = new OpenFileDialog();
            panelUpper_GAM = new Panel();
            textBoxFilter_GAM = new TextBox();
            textBoxSearch_GAM = new TextBox();
            buttonLeft_GAM = new Button();
            buttonRight_GAM = new Button();
            buttonSearch_GAM = new Button();
            buttonReset_GAM = new Button();
            pictureBoxSearch_GAM = new PictureBox();
            pictureBoxFilter_GAM = new PictureBox();
            menuStripMain_GAM = new MenuStrip();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            panelMiddle_GAM = new Panel();
            groupBoxBase_GAM = new GroupBox();
            dataGridViewBase_GAM = new DataGridView();
            toolTipButtons_GAM = new ToolTip(components);
            panelUpper_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilter_GAM).BeginInit();
            menuStripMain_GAM.SuspendLayout();
            panelMiddle_GAM.SuspendLayout();
            groupBoxBase_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GAM).BeginInit();
            SuspendLayout();
            // 
            // panelUpper_GAM
            // 
            panelUpper_GAM.BackColor = Color.FromArgb(60, 60, 60);
            panelUpper_GAM.Controls.Add(textBoxFilter_GAM);
            panelUpper_GAM.Controls.Add(textBoxSearch_GAM);
            panelUpper_GAM.Controls.Add(buttonLeft_GAM);
            panelUpper_GAM.Controls.Add(buttonRight_GAM);
            panelUpper_GAM.Controls.Add(buttonSearch_GAM);
            panelUpper_GAM.Controls.Add(buttonReset_GAM);
            panelUpper_GAM.Controls.Add(pictureBoxSearch_GAM);
            panelUpper_GAM.Controls.Add(pictureBoxFilter_GAM);
            panelUpper_GAM.Controls.Add(menuStripMain_GAM);
            panelUpper_GAM.Dock = DockStyle.Top;
            panelUpper_GAM.Location = new Point(0, 0);
            panelUpper_GAM.Margin = new Padding(4, 5, 4, 5);
            panelUpper_GAM.Name = "panelUpper_GAM";
            panelUpper_GAM.Size = new Size(1429, 198);
            panelUpper_GAM.TabIndex = 0;
            // 
            // textBoxFilter_GAM
            // 
            textBoxFilter_GAM.BackColor = Color.DarkGray;
            textBoxFilter_GAM.BorderStyle = BorderStyle.FixedSingle;
            textBoxFilter_GAM.Font = new Font("Segoe UI", 9F);
            textBoxFilter_GAM.ForeColor = SystemColors.ControlText;
            textBoxFilter_GAM.Location = new Point(199, 17);
            textBoxFilter_GAM.Margin = new Padding(4, 5, 4, 5);
            textBoxFilter_GAM.Multiline = true;
            textBoxFilter_GAM.Name = "textBoxFilter_GAM";
            textBoxFilter_GAM.Size = new Size(195, 76);
            textBoxFilter_GAM.TabIndex = 0;
            textBoxFilter_GAM.TextChanged += textBoxFilter_GAM_TextChanged;
            // 
            // textBoxSearch_GAM
            // 
            textBoxSearch_GAM.BackColor = Color.DarkGray;
            textBoxSearch_GAM.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch_GAM.Font = new Font("Segoe UI", 9F);
            textBoxSearch_GAM.ForeColor = SystemColors.ControlText;
            textBoxSearch_GAM.Location = new Point(624, 17);
            textBoxSearch_GAM.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch_GAM.Multiline = true;
            textBoxSearch_GAM.Name = "textBoxSearch_GAM";
            textBoxSearch_GAM.Size = new Size(195, 76);
            textBoxSearch_GAM.TabIndex = 1;
            // 
            // buttonLeft_GAM
            // 
            buttonLeft_GAM.BackColor = Color.Transparent;
            buttonLeft_GAM.FlatStyle = FlatStyle.Flat;
            buttonLeft_GAM.Location = new Point(1276, 14);
            buttonLeft_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonLeft_GAM.Name = "buttonLeft_GAM";
            buttonLeft_GAM.Size = new Size(60, 80);
            buttonLeft_GAM.TabIndex = 2;
            buttonLeft_GAM.Text = "<";
            buttonLeft_GAM.UseVisualStyleBackColor = false;
            buttonLeft_GAM.Click += ButtonLeft_GAM_Click;
            // 
            // buttonRight_GAM
            // 
            buttonRight_GAM.BackColor = Color.Transparent;
            buttonRight_GAM.FlatStyle = FlatStyle.Flat;
            buttonRight_GAM.Location = new Point(1348, 14);
            buttonRight_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonRight_GAM.Name = "buttonRight_GAM";
            buttonRight_GAM.Size = new Size(60, 80);
            buttonRight_GAM.TabIndex = 3;
            buttonRight_GAM.Text = ">";
            buttonRight_GAM.UseVisualStyleBackColor = false;
            buttonRight_GAM.Click += ButtonRight_GAM_Click;
            // 
            // buttonSearch_GAM
            // 
            buttonSearch_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonSearch_GAM.FlatStyle = FlatStyle.Popup;
            buttonSearch_GAM.Font = new Font("Segoe UI", 9F);
            buttonSearch_GAM.ForeColor = Color.WhiteSmoke;
            buttonSearch_GAM.Location = new Point(484, 14);
            buttonSearch_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonSearch_GAM.Name = "buttonSearch_GAM";
            buttonSearch_GAM.Size = new Size(133, 80);
            buttonSearch_GAM.TabIndex = 4;
            buttonSearch_GAM.Text = "Поиск";
            buttonSearch_GAM.UseVisualStyleBackColor = false;
            buttonSearch_GAM.Click += ButtonSearch_GAM_Click;
            // 
            // buttonReset_GAM
            // 
            buttonReset_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonReset_GAM.FlatStyle = FlatStyle.Popup;
            buttonReset_GAM.Font = new Font("Segoe UI", 9F);
            buttonReset_GAM.ForeColor = Color.WhiteSmoke;
            buttonReset_GAM.Location = new Point(620, 14);
            buttonReset_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonReset_GAM.Name = "buttonReset_GAM";
            buttonReset_GAM.Size = new Size(133, 80);
            buttonReset_GAM.TabIndex = 5;
            buttonReset_GAM.Text = "Сброс";
            buttonReset_GAM.UseVisualStyleBackColor = false;
            buttonReset_GAM.Click += ButtonReset_GAM_Click;
            // 
            // pictureBoxSearch_GAM
            // 
            pictureBoxSearch_GAM.Location = new Point(412, 14);
            pictureBoxSearch_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxSearch_GAM.Name = "pictureBoxSearch_GAM";
            pictureBoxSearch_GAM.Size = new Size(60, 80);
            pictureBoxSearch_GAM.TabIndex = 6;
            pictureBoxSearch_GAM.TabStop = false;
            // 
            // pictureBoxFilter_GAM
            // 
            pictureBoxFilter_GAM.Location = new Point(5, 14);
            pictureBoxFilter_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxFilter_GAM.Name = "pictureBoxFilter_GAM";
            pictureBoxFilter_GAM.Size = new Size(60, 80);
            pictureBoxFilter_GAM.TabIndex = 7;
            pictureBoxFilter_GAM.TabStop = false;
            // 
            // menuStripMain_GAM
            // 
            menuStripMain_GAM.Dock = DockStyle.None;
            menuStripMain_GAM.ImageScalingSize = new Size(20, 20);
            menuStripMain_GAM.Items.AddRange(new ToolStripItem[] { фильтрToolStripMenuItem });
            menuStripMain_GAM.Location = new Point(73, 26);
            menuStripMain_GAM.Name = "menuStripMain_GAM";
            menuStripMain_GAM.Padding = new Padding(8, 3, 0, 3);
            menuStripMain_GAM.Size = new Size(84, 30);
            menuStripMain_GAM.TabIndex = 8;
            menuStripMain_GAM.Text = "menuStripMain_GAM";
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(74, 24);
            фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // panelMiddle_GAM
            // 
            panelMiddle_GAM.BackColor = Color.FromArgb(20, 20, 20);
            panelMiddle_GAM.Controls.Add(groupBoxBase_GAM);
            panelMiddle_GAM.Dock = DockStyle.Fill;
            panelMiddle_GAM.Location = new Point(0, 198);
            panelMiddle_GAM.Margin = new Padding(4, 5, 4, 5);
            panelMiddle_GAM.Name = "panelMiddle_GAM";
            panelMiddle_GAM.Size = new Size(1429, 453);
            panelMiddle_GAM.TabIndex = 1;
            // 
            // groupBoxBase_GAM
            // 
            groupBoxBase_GAM.Controls.Add(dataGridViewBase_GAM);
            groupBoxBase_GAM.Dock = DockStyle.Fill;
            groupBoxBase_GAM.Location = new Point(0, 0);
            groupBoxBase_GAM.Margin = new Padding(4, 5, 4, 5);
            groupBoxBase_GAM.Name = "groupBoxBase_GAM";
            groupBoxBase_GAM.Padding = new Padding(4, 5, 4, 5);
            groupBoxBase_GAM.Size = new Size(1429, 453);
            groupBoxBase_GAM.TabIndex = 0;
            groupBoxBase_GAM.TabStop = false;
            groupBoxBase_GAM.Text = "Данные";
            // 
            // dataGridViewBase_GAM
            // 
            dataGridViewBase_GAM.ColumnHeadersHeight = 29;
            dataGridViewBase_GAM.ColumnHeadersVisible = false;
            dataGridViewBase_GAM.Dock = DockStyle.Fill;
            dataGridViewBase_GAM.Location = new Point(4, 25);
            dataGridViewBase_GAM.Margin = new Padding(4, 5, 4, 5);
            dataGridViewBase_GAM.Name = "dataGridViewBase_GAM";
            dataGridViewBase_GAM.RowHeadersWidth = 51;
            dataGridViewBase_GAM.Size = new Size(1421, 423);
            dataGridViewBase_GAM.TabIndex = 0;
            dataGridViewBase_GAM.CellContentClick += dataGridViewBase_GAM_CellContentClick_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 651);
            Controls.Add(panelMiddle_GAM);
            Controls.Add(panelUpper_GAM);
            MainMenuStrip = menuStripMain_GAM;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            Text = "Каталог видеоклипов";
            panelUpper_GAM.ResumeLayout(false);
            panelUpper_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilter_GAM).EndInit();
            menuStripMain_GAM.ResumeLayout(false);
            menuStripMain_GAM.PerformLayout();
            panelMiddle_GAM.ResumeLayout(false);
            groupBoxBase_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GAM).EndInit();
            ResumeLayout(false);
        }

        private void textBoxFilter_GAM_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridViewBase_GAM_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonLeft_GAM_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonRight_GAM_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSearch_GAM_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonReset_GAM_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogMain_GAM;
        private System.Windows.Forms.Panel panelUpper_GAM;
        private System.Windows.Forms.TextBox textBoxFilter_GAM;
        private System.Windows.Forms.TextBox textBoxSearch_GAM;
        private System.Windows.Forms.Button buttonLeft_GAM;
        private System.Windows.Forms.Button buttonRight_GAM;
        private System.Windows.Forms.Button buttonSearch_GAM;
        private System.Windows.Forms.Button buttonReset_GAM; // Добавленная кнопка сброса
        private System.Windows.Forms.PictureBox pictureBoxSearch_GAM;
        private System.Windows.Forms.PictureBox pictureBoxFilter_GAM;
        private System.Windows.Forms.MenuStrip menuStripMain_GAM;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.Panel panelMiddle_GAM;
        private System.Windows.Forms.GroupBox groupBoxBase_GAM;
        private System.Windows.Forms.DataGridView dataGridViewBase_GAM;
        private System.Windows.Forms.ToolTip toolTipButtons_GAM;
    }
}