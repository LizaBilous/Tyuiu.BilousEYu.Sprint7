namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormGraph
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelMiddleGraph_GAM = new Panel();
            groupBoxBaseGraph_GAM = new GroupBox();
            pictureBoxWait_GAM = new PictureBox();
            chartGraph_GAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTipButtonsGraph_GAM = new ToolTip(components);
            buttonBack_GAM = new Button();
            buttonAbout_GAM = new Button();
            buttonManagement_GAM = new Button();
            menuStrip1 = new MenuStrip();
            графикToolStripMenuItem = new ToolStripMenuItem();
            форматВидеоклипаToolStripMenuItem = new ToolStripMenuItem();
            весВидеоклипаToolStripMenuItem = new ToolStripMenuItem();
            категорияВидеоклипаToolStripMenuItem = new ToolStripMenuItem();
            длительностьВидеоклипаToolStripMenuItem2 = new ToolStripMenuItem();
            минимальноеЗначениеToolStripMenuItem = new ToolStripMenuItem();
            весВидеоклипаToolStripMenuItem1 = new ToolStripMenuItem();
            длительностьВидеоклипаToolStripMenuItem = new ToolStripMenuItem();
            максимальноеЗначениеToolStripMenuItem = new ToolStripMenuItem();
            весВидеоклипаToolStripMenuItem2 = new ToolStripMenuItem();
            длительностьВидеоклипаToolStripMenuItem1 = new ToolStripMenuItem();
            среднееЗначениеToolStripMenuItem = new ToolStripMenuItem();
            весВидеоклипаToolStripMenuItem3 = new ToolStripMenuItem();
            длительностьВидеоклипаToolStripMenuItem3 = new ToolStripMenuItem();
            saveFileDialogGraph_GAM = new SaveFileDialog();
            panelUpperGraph_GAM = new Panel();
            labelOPMM_GAM = new Label();
            textBoxOutPutMinMax_GAM = new TextBox();
            pictureBoxAbout_GAM = new PictureBox();
            pictureBoxManagement_GAM = new PictureBox();
            pictureBoxBack_GAM = new PictureBox();
            openFileDialogGraph_GAM = new OpenFileDialog();
            panelMiddleGraph_GAM.SuspendLayout();
            groupBoxBaseGraph_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWait_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGraph_GAM).BeginInit();
            menuStrip1.SuspendLayout();
            panelUpperGraph_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxManagement_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack_GAM).BeginInit();
            SuspendLayout();
            // 
            // panelMiddleGraph_GAM
            // 
            panelMiddleGraph_GAM.BackColor = Color.DarkGray;
            panelMiddleGraph_GAM.Controls.Add(groupBoxBaseGraph_GAM);
            panelMiddleGraph_GAM.Dock = DockStyle.Fill;
            panelMiddleGraph_GAM.Location = new Point(0, 129);
            panelMiddleGraph_GAM.Margin = new Padding(4, 5, 4, 5);
            panelMiddleGraph_GAM.Name = "panelMiddleGraph_GAM";
            panelMiddleGraph_GAM.Size = new Size(1067, 563);
            panelMiddleGraph_GAM.TabIndex = 5;
            // 
            // groupBoxBaseGraph_GAM
            // 
            groupBoxBaseGraph_GAM.BackColor = Color.FromArgb(20, 20, 20);
            groupBoxBaseGraph_GAM.Controls.Add(pictureBoxWait_GAM);
            groupBoxBaseGraph_GAM.Controls.Add(chartGraph_GAM);
            groupBoxBaseGraph_GAM.Dock = DockStyle.Fill;
            groupBoxBaseGraph_GAM.ForeColor = SystemColors.HighlightText;
            groupBoxBaseGraph_GAM.Location = new Point(0, 0);
            groupBoxBaseGraph_GAM.Margin = new Padding(4, 5, 4, 5);
            groupBoxBaseGraph_GAM.Name = "groupBoxBaseGraph_GAM";
            groupBoxBaseGraph_GAM.Padding = new Padding(4, 5, 4, 5);
            groupBoxBaseGraph_GAM.Size = new Size(1067, 563);
            groupBoxBaseGraph_GAM.TabIndex = 0;
            groupBoxBaseGraph_GAM.TabStop = false;
            groupBoxBaseGraph_GAM.Text = "Данные";
            // 
            // pictureBoxWait_GAM
            // 
            pictureBoxWait_GAM.Dock = DockStyle.Fill;
            pictureBoxWait_GAM.Location = new Point(4, 25);
            pictureBoxWait_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxWait_GAM.Name = "pictureBoxWait_GAM";
            pictureBoxWait_GAM.Size = new Size(1059, 533);
            pictureBoxWait_GAM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWait_GAM.TabIndex = 1;
            pictureBoxWait_GAM.TabStop = false;
            pictureBoxWait_GAM.Click += pictureBoxWait_GAM_Click;
            // 
            // chartGraph_GAM
            // 
            chartGraph_GAM.BackColor = Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            chartGraph_GAM.ChartAreas.Add(chartArea1);
            chartGraph_GAM.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartGraph_GAM.Legends.Add(legend1);
            chartGraph_GAM.Location = new Point(4, 25);
            chartGraph_GAM.Margin = new Padding(4, 5, 4, 5);
            chartGraph_GAM.Name = "chartGraph_GAM";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Indigo;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraph_GAM.Series.Add(series1);
            chartGraph_GAM.Size = new Size(1059, 533);
            chartGraph_GAM.TabIndex = 0;
            // 
            // toolTipButtonsGraph_GAM
            // 
            toolTipButtonsGraph_GAM.ToolTipIcon = ToolTipIcon.Info;
            toolTipButtonsGraph_GAM.ToolTipTitle = "Подсказка";
            // 
            // buttonBack_GAM
            // 
            buttonBack_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonBack_GAM.FlatStyle = FlatStyle.Popup;
            buttonBack_GAM.Font = new Font("Segoe UI", 9F);
            buttonBack_GAM.ForeColor = Color.WhiteSmoke;
            buttonBack_GAM.Location = new Point(57, 9);
            buttonBack_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonBack_GAM.Name = "buttonBack_GAM";
            buttonBack_GAM.Size = new Size(100, 52);
            buttonBack_GAM.TabIndex = 6;
            buttonBack_GAM.Text = "Назад";
            toolTipButtonsGraph_GAM.SetToolTip(buttonBack_GAM, "Вернуться на главный экран");
            buttonBack_GAM.UseVisualStyleBackColor = false;
            buttonBack_GAM.Click += buttonBack_GAM_Click;
            buttonBack_GAM.MouseEnter += buttonBack_GAM_MouseEnter;
            buttonBack_GAM.MouseLeave += buttonBack_GAM_MouseLeave;
            // 
            // buttonAbout_GAM
            // 
            buttonAbout_GAM.Anchor = AnchorStyles.Right;
            buttonAbout_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonAbout_GAM.FlatStyle = FlatStyle.Popup;
            buttonAbout_GAM.Font = new Font("Segoe UI", 9F);
            buttonAbout_GAM.ForeColor = Color.WhiteSmoke;
            buttonAbout_GAM.Location = new Point(925, 9);
            buttonAbout_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonAbout_GAM.Name = "buttonAbout_GAM";
            buttonAbout_GAM.Size = new Size(125, 52);
            buttonAbout_GAM.TabIndex = 7;
            buttonAbout_GAM.Text = "О программе";
            toolTipButtonsGraph_GAM.SetToolTip(buttonAbout_GAM, "Информация о разработчике");
            buttonAbout_GAM.UseVisualStyleBackColor = false;
            buttonAbout_GAM.Click += buttonAbout_GAM_Click;
            buttonAbout_GAM.MouseEnter += buttonAbout_GAM_MouseEnter;
            buttonAbout_GAM.MouseLeave += buttonAbout_GAM_MouseLeave;
            // 
            // buttonManagement_GAM
            // 
            buttonManagement_GAM.Anchor = AnchorStyles.Right;
            buttonManagement_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonManagement_GAM.FlatStyle = FlatStyle.Popup;
            buttonManagement_GAM.Font = new Font("Segoe UI", 9F);
            buttonManagement_GAM.ForeColor = Color.WhiteSmoke;
            buttonManagement_GAM.Location = new Point(749, 9);
            buttonManagement_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonManagement_GAM.Name = "buttonManagement_GAM";
            buttonManagement_GAM.Size = new Size(115, 52);
            buttonManagement_GAM.TabIndex = 8;
            buttonManagement_GAM.Text = "Руководство";
            toolTipButtonsGraph_GAM.SetToolTip(buttonManagement_GAM, "Открыть краткое руководство по программе");
            buttonManagement_GAM.UseVisualStyleBackColor = false;
            buttonManagement_GAM.Click += buttonManagement_GAM_Click;
            buttonManagement_GAM.MouseEnter += buttonManagement_GAM_MouseEnter;
            buttonManagement_GAM.MouseLeave += buttonManagement_GAM_MouseLeave;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            menuStrip1.BackColor = Color.FromArgb(120, 120, 120);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { графикToolStripMenuItem, минимальноеЗначениеToolStripMenuItem, максимальноеЗначениеToolStripMenuItem, среднееЗначениеToolStripMenuItem });
            menuStrip1.Location = new Point(4, 95);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(685, 30);
            menuStrip1.TabIndex = 11;
            toolTipButtonsGraph_GAM.SetToolTip(menuStrip1, "Выберите нужный для вас график");
            // 
            // графикToolStripMenuItem
            // 
            графикToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { форматВидеоклипаToolStripMenuItem, весВидеоклипаToolStripMenuItem, категорияВидеоклипаToolStripMenuItem, длительностьВидеоклипаToolStripMenuItem2 });
            графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            графикToolStripMenuItem.Size = new Size(131, 24);
            графикToolStripMenuItem.Text = "Выбор графика";
            графикToolStripMenuItem.ToolTipText = "Выберите нужный для вас график";
            // 
            // форматВидеоклипаToolStripMenuItem
            // 
            форматВидеоклипаToolStripMenuItem.Name = "форматВидеоклипаToolStripMenuItem";
            форматВидеоклипаToolStripMenuItem.Size = new Size(275, 26);
            форматВидеоклипаToolStripMenuItem.Text = "Формат видеоклипа";
            форматВидеоклипаToolStripMenuItem.Click += форматВидеоклипаToolStripMenuItem_Click;
            // 
            // весВидеоклипаToolStripMenuItem
            // 
            весВидеоклипаToolStripMenuItem.Name = "весВидеоклипаToolStripMenuItem";
            весВидеоклипаToolStripMenuItem.Size = new Size(275, 26);
            весВидеоклипаToolStripMenuItem.Text = "Вес видеоклипа";
            весВидеоклипаToolStripMenuItem.Click += весВидеоклипаToolStripMenuItem_Click;
            // 
            // категорияВидеоклипаToolStripMenuItem
            // 
            категорияВидеоклипаToolStripMenuItem.Name = "категорияВидеоклипаToolStripMenuItem";
            категорияВидеоклипаToolStripMenuItem.Size = new Size(275, 26);
            категорияВидеоклипаToolStripMenuItem.Text = "Категория видеоклипа";
            категорияВидеоклипаToolStripMenuItem.Click += категорияВидеоклипаToolStripMenuItem_Click;
            // 
            // длительностьВидеоклипаToolStripMenuItem2
            // 
            длительностьВидеоклипаToolStripMenuItem2.Name = "длительностьВидеоклипаToolStripMenuItem2";
            длительностьВидеоклипаToolStripMenuItem2.Size = new Size(275, 26);
            длительностьВидеоклипаToolStripMenuItem2.Text = "Длительность видеоклипа";
            длительностьВидеоклипаToolStripMenuItem2.Click += длительностьВидеоклипаToolStripMenuItem2_Click;
            // 
            // минимальноеЗначениеToolStripMenuItem
            // 
            минимальноеЗначениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { весВидеоклипаToolStripMenuItem1, длительностьВидеоклипаToolStripMenuItem });
            минимальноеЗначениеToolStripMenuItem.Name = "минимальноеЗначениеToolStripMenuItem";
            минимальноеЗначениеToolStripMenuItem.Size = new Size(194, 24);
            минимальноеЗначениеToolStripMenuItem.Text = "Минимальное значение";
            минимальноеЗначениеToolStripMenuItem.ToolTipText = "Выберите интересующее вас минимальное значение";
            // 
            // весВидеоклипаToolStripMenuItem1
            // 
            весВидеоклипаToolStripMenuItem1.Name = "весВидеоклипаToolStripMenuItem1";
            весВидеоклипаToolStripMenuItem1.Size = new Size(275, 26);
            весВидеоклипаToolStripMenuItem1.Text = "Вес видеоклипа";
            весВидеоклипаToolStripMenuItem1.Click += весВидеоклипаToolStripMenuItem1_Click;
            // 
            // длительностьВидеоклипаToolStripMenuItem
            // 
            длительностьВидеоклипаToolStripMenuItem.Name = "длительностьВидеоклипаToolStripMenuItem";
            длительностьВидеоклипаToolStripMenuItem.Size = new Size(275, 26);
            длительностьВидеоклипаToolStripMenuItem.Text = "Длительность видеоклипа";
            длительностьВидеоклипаToolStripMenuItem.Click += длительностьВидеоклипаToolStripMenuItem_Click;
            // 
            // максимальноеЗначениеToolStripMenuItem
            // 
            максимальноеЗначениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { весВидеоклипаToolStripMenuItem2, длительностьВидеоклипаToolStripMenuItem1 });
            максимальноеЗначениеToolStripMenuItem.Name = "максимальноеЗначениеToolStripMenuItem";
            максимальноеЗначениеToolStripMenuItem.Size = new Size(198, 24);
            максимальноеЗначениеToolStripMenuItem.Text = "Максимальное значение";
            максимальноеЗначениеToolStripMenuItem.ToolTipText = "Выберите интересующее вас максимальное значение";
            // 
            // весВидеоклипаToolStripMenuItem2
            // 
            весВидеоклипаToolStripMenuItem2.Name = "весВидеоклипаToolStripMenuItem2";
            весВидеоклипаToolStripMenuItem2.Size = new Size(275, 26);
            весВидеоклипаToolStripMenuItem2.Text = "Вес видеоклипа";
            весВидеоклипаToolStripMenuItem2.Click += весВидеоклипаToolStripMenuItem2_Click;
            // 
            // длительностьВидеоклипаToolStripMenuItem1
            // 
            длительностьВидеоклипаToolStripMenuItem1.Name = "длительностьВидеоклипаToolStripMenuItem1";
            длительностьВидеоклипаToolStripMenuItem1.Size = new Size(275, 26);
            длительностьВидеоклипаToolStripMenuItem1.Text = "Длительность видеоклипа";
            длительностьВидеоклипаToolStripMenuItem1.Click += длительностьВидеоклипаToolStripMenuItem1_Click;
            // 
            // среднееЗначениеToolStripMenuItem
            // 
            среднееЗначениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { весВидеоклипаToolStripMenuItem3, длительностьВидеоклипаToolStripMenuItem3 });
            среднееЗначениеToolStripMenuItem.Name = "среднееЗначениеToolStripMenuItem";
            среднееЗначениеToolStripMenuItem.Size = new Size(152, 24);
            среднееЗначениеToolStripMenuItem.Text = "Среднее значение";
            // 
            // весВидеоклипаToolStripMenuItem3
            // 
            весВидеоклипаToolStripMenuItem3.Name = "весВидеоклипаToolStripMenuItem3";
            весВидеоклипаToolStripMenuItem3.Size = new Size(275, 26);
            весВидеоклипаToolStripMenuItem3.Text = "Вес видеоклипа";
            весВидеоклипаToolStripMenuItem3.Click += весВидеоклипаToolStripMenuItem3_Click;
            // 
            // длительностьВидеоклипаToolStripMenuItem3
            // 
            длительностьВидеоклипаToolStripMenuItem3.Name = "длительностьВидеоклипаToolStripMenuItem3";
            длительностьВидеоклипаToolStripMenuItem3.Size = new Size(275, 26);
            длительностьВидеоклипаToolStripMenuItem3.Text = "Длительность видеоклипа";
            длительностьВидеоклипаToolStripMenuItem3.Click += длительностьВидеоклипаToolStripMenuItem3_Click;
            // 
            // panelUpperGraph_GAM
            // 
            panelUpperGraph_GAM.BackColor = Color.FromArgb(60, 60, 60);
            panelUpperGraph_GAM.Controls.Add(labelOPMM_GAM);
            panelUpperGraph_GAM.Controls.Add(textBoxOutPutMinMax_GAM);
            panelUpperGraph_GAM.Controls.Add(pictureBoxAbout_GAM);
            panelUpperGraph_GAM.Controls.Add(pictureBoxManagement_GAM);
            panelUpperGraph_GAM.Controls.Add(buttonAbout_GAM);
            panelUpperGraph_GAM.Controls.Add(buttonManagement_GAM);
            panelUpperGraph_GAM.Controls.Add(buttonBack_GAM);
            panelUpperGraph_GAM.Controls.Add(pictureBoxBack_GAM);
            panelUpperGraph_GAM.Controls.Add(menuStrip1);
            panelUpperGraph_GAM.Dock = DockStyle.Top;
            panelUpperGraph_GAM.Location = new Point(0, 0);
            panelUpperGraph_GAM.Margin = new Padding(4, 5, 4, 5);
            panelUpperGraph_GAM.Name = "panelUpperGraph_GAM";
            panelUpperGraph_GAM.Size = new Size(1067, 129);
            panelUpperGraph_GAM.TabIndex = 3;
            // 
            // labelOPMM_GAM
            // 
            labelOPMM_GAM.AutoSize = true;
            labelOPMM_GAM.ForeColor = SystemColors.Info;
            labelOPMM_GAM.Location = new Point(731, 63);
            labelOPMM_GAM.Margin = new Padding(4, 0, 4, 0);
            labelOPMM_GAM.Name = "labelOPMM_GAM";
            labelOPMM_GAM.Size = new Size(78, 20);
            labelOPMM_GAM.TabIndex = 13;
            labelOPMM_GAM.Text = "Результат:";
            // 
            // textBoxOutPutMinMax_GAM
            // 
            textBoxOutPutMinMax_GAM.BackColor = Color.DarkGray;
            textBoxOutPutMinMax_GAM.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutPutMinMax_GAM.Location = new Point(731, 88);
            textBoxOutPutMinMax_GAM.Margin = new Padding(4, 5, 4, 5);
            textBoxOutPutMinMax_GAM.Multiline = true;
            textBoxOutPutMinMax_GAM.Name = "textBoxOutPutMinMax_GAM";
            textBoxOutPutMinMax_GAM.ReadOnly = true;
            textBoxOutPutMinMax_GAM.Size = new Size(133, 36);
            textBoxOutPutMinMax_GAM.TabIndex = 12;
            // 
            // pictureBoxAbout_GAM
            // 
            pictureBoxAbout_GAM.Anchor = AnchorStyles.Right;
            pictureBoxAbout_GAM.BackColor = Color.Transparent;
            pictureBoxAbout_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAbout_GAM.ErrorImage = null;
            pictureBoxAbout_GAM.InitialImage = null;
            pictureBoxAbout_GAM.Location = new Point(872, 9);
            pictureBoxAbout_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxAbout_GAM.Name = "pictureBoxAbout_GAM";
            pictureBoxAbout_GAM.Size = new Size(45, 52);
            pictureBoxAbout_GAM.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxAbout_GAM.TabIndex = 9;
            pictureBoxAbout_GAM.TabStop = false;
            // 
            // pictureBoxManagement_GAM
            // 
            pictureBoxManagement_GAM.Anchor = AnchorStyles.Right;
            pictureBoxManagement_GAM.BackColor = Color.Transparent;
            pictureBoxManagement_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxManagement_GAM.ErrorImage = null;
            pictureBoxManagement_GAM.InitialImage = null;
            pictureBoxManagement_GAM.Location = new Point(696, 9);
            pictureBoxManagement_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxManagement_GAM.Name = "pictureBoxManagement_GAM";
            pictureBoxManagement_GAM.Size = new Size(45, 52);
            pictureBoxManagement_GAM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxManagement_GAM.TabIndex = 10;
            pictureBoxManagement_GAM.TabStop = false;
            // 
            // pictureBoxBack_GAM
            // 
            pictureBoxBack_GAM.BackColor = Color.Transparent;
            pictureBoxBack_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxBack_GAM.ErrorImage = null;
            pictureBoxBack_GAM.InitialImage = null;
            pictureBoxBack_GAM.Location = new Point(4, 9);
            pictureBoxBack_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxBack_GAM.Name = "pictureBoxBack_GAM";
            pictureBoxBack_GAM.Size = new Size(45, 52);
            pictureBoxBack_GAM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack_GAM.TabIndex = 5;
            pictureBoxBack_GAM.TabStop = false;
            // 
            // openFileDialogGraph_GAM
            // 
            openFileDialogGraph_GAM.FileName = "openFileDialog1";
            // 
            // FormGraph
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(panelMiddleGraph_GAM);
            Controls.Add(panelUpperGraph_GAM);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGraph";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Графики";
            WindowState = FormWindowState.Maximized;
            panelMiddleGraph_GAM.ResumeLayout(false);
            groupBoxBaseGraph_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWait_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGraph_GAM).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelUpperGraph_GAM.ResumeLayout(false);
            panelUpperGraph_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxManagement_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack_GAM).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipButtonsGraph_GAM;
        private System.Windows.Forms.Panel panelMiddleGraph_GAM;
        private System.Windows.Forms.GroupBox groupBoxBaseGraph_GAM;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGraph_GAM;
        private System.Windows.Forms.Panel panelUpperGraph_GAM;
        private System.Windows.Forms.OpenFileDialog openFileDialogGraph_GAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_GAM;
        private System.Windows.Forms.PictureBox pictureBoxBack_GAM;
        private System.Windows.Forms.Button buttonBack_GAM;
        private System.Windows.Forms.PictureBox pictureBoxAbout_GAM;
        private System.Windows.Forms.PictureBox pictureBoxManagement_GAM;
        private System.Windows.Forms.Button buttonAbout_GAM;
        private System.Windows.Forms.Button buttonManagement_GAM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорияВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальноеЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальноеЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem1;
        private System.Windows.Forms.Label labelOPMM_GAM;
        private System.Windows.Forms.TextBox textBoxOutPutMinMax_GAM;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem среднееЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBoxWait_GAM;
    }
}