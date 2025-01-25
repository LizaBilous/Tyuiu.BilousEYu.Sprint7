using AxWMPLib;
using System.Windows.Forms;
using Tyuiu.BilousEYu.Sprint7.Project.V9.Properties;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private LibVLCSharp.WinForms.VideoView videoControl; // Это элемент для отображения видео
        private System.Windows.Forms.Button buttonLoadVideo;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            videoControl = new LibVLCSharp.WinForms.VideoView();
            buttonLoadVideo = new Button();
            openFileDialogMain_GAM = new OpenFileDialog();
            panelUpper_GAM = new Panel();
            buttonMenu_GAM = new Button();
            pictureBoxSort_GAM = new PictureBox();
            buttonReset_GAM = new Button();
            menuStripSort_GAM = new MenuStrip();
            toolStripMenuItemMain_GAM = new ToolStripMenuItem();
            сортировкаToolStripMenuItemMain_GAM = new ToolStripMenuItem();
            столбецВесToolStripMenuItem = new ToolStripMenuItem();
            столбецIDToolStripMenuItem = new ToolStripMenuItem();
            поУбываниюToolStripMenuItem = new ToolStripMenuItem();
            столбецДлительностьToolStripMenuItem = new ToolStripMenuItem();
            столбецВесToolStripMenuItem1 = new ToolStripMenuItem();
            столбецДатаToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBoxAbout_GAM = new PictureBox();
            pictureBoxSave_GAM = new PictureBox();
            pictureBoxManagement_GAM = new PictureBox();
            pictureBoxLoad_GAM = new PictureBox();
            buttonAbout_GAM = new Button();
            buttonSave_GAM = new Button();
            buttonManagement_GAM = new Button();
            buttonLoad_GAM = new Button();
            panelDown_GAM = new Panel();
            buttonGraph_GAM = new Button();
            textBoxFilter_GAM = new TextBox();
            textBoxSearch_GAM = new TextBox();
            buttonLeft_GAM = new Button();
            buttonRight_GAM = new Button();
            buttonSearch_GAM = new Button();
            pictureBoxSearch_GAM = new PictureBox();
            pictureBoxFilter_GAM = new PictureBox();
            menuStripMain_GAM = new MenuStrip();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            названиеToolStripMenuItem = new ToolStripMenuItem();
            весToolStripMenuItem = new ToolStripMenuItem();
            длительностьToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            категорияToolStripMenuItem = new ToolStripMenuItem();
            iDToolStripMenuItem = new ToolStripMenuItem();
            panelMiddle_GAM = new Panel();
            groupBoxBase_GAM = new GroupBox();
            dataGridViewBase_GAM = new DataGridView();
            saveFileDialogMain_GAM = new SaveFileDialog();
            toolTipButtons_GAM = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)videoControl).BeginInit();
            panelUpper_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSort_GAM).BeginInit();
            menuStripSort_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSave_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxManagement_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoad_GAM).BeginInit();
            panelDown_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_GAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilter_GAM).BeginInit();
            menuStripMain_GAM.SuspendLayout();
            panelMiddle_GAM.SuspendLayout();
            groupBoxBase_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GAM).BeginInit();
            SuspendLayout();
            // 
            // videoControl
            // 
            videoControl.BackColor = Color.Black;
            videoControl.Dock = DockStyle.Fill;
            videoControl.Location = new Point(0, 129);
            videoControl.MediaPlayer = null;
            videoControl.Name = "videoControl";
            videoControl.Size = new Size(1072, 505);
            videoControl.TabIndex = 0;
            videoControl.Text = "videoControl";
            videoControl.DoubleClick += videoControl_DoubleClick;
            // 
            // buttonLoadVideo
            // 
            buttonLoadVideo.Location = new Point(63, 18);
            buttonLoadVideo.Name = "buttonLoadVideo";
            buttonLoadVideo.Size = new Size(120, 30);
            buttonLoadVideo.TabIndex = 1;
            buttonLoadVideo.Text = "Load Video";
            buttonLoadVideo.UseVisualStyleBackColor = true;
            buttonLoadVideo.Click += buttonLoadVideo_Click;
            // 
            // openFileDialogMain_GAM
            // 
            openFileDialogMain_GAM.FileName = "openFileDialog1";
            // 
            // panelUpper_GAM
            // 
            panelUpper_GAM.BackColor = Color.FromArgb(60, 60, 60);
            panelUpper_GAM.Controls.Add(buttonLoadVideo);
            panelUpper_GAM.Controls.Add(buttonMenu_GAM);
            panelUpper_GAM.Controls.Add(pictureBoxSort_GAM);
            panelUpper_GAM.Controls.Add(buttonReset_GAM);
            panelUpper_GAM.Controls.Add(menuStripSort_GAM);
            panelUpper_GAM.Controls.Add(pictureBoxAbout_GAM);
            panelUpper_GAM.Controls.Add(pictureBoxSave_GAM);
            panelUpper_GAM.Controls.Add(pictureBoxManagement_GAM);
            panelUpper_GAM.Controls.Add(pictureBoxLoad_GAM);
            panelUpper_GAM.Controls.Add(buttonAbout_GAM);
            panelUpper_GAM.Controls.Add(buttonSave_GAM);
            panelUpper_GAM.Controls.Add(buttonManagement_GAM);
            panelUpper_GAM.Controls.Add(buttonLoad_GAM);
            panelUpper_GAM.Dock = DockStyle.Top;
            panelUpper_GAM.Location = new Point(0, 0);
            panelUpper_GAM.Margin = new Padding(4, 5, 4, 5);
            panelUpper_GAM.Name = "panelUpper_GAM";
            panelUpper_GAM.Size = new Size(1072, 129);
            panelUpper_GAM.TabIndex = 0;
            // 
            // buttonMenu_GAM
            // 
            buttonMenu_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonMenu_GAM.FlatStyle = FlatStyle.Popup;
            buttonMenu_GAM.ForeColor = Color.WhiteSmoke;
            buttonMenu_GAM.Location = new Point(7, 71);
            buttonMenu_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonMenu_GAM.Name = "buttonMenu_GAM";
            buttonMenu_GAM.Size = new Size(176, 52);
            buttonMenu_GAM.TabIndex = 6;
            buttonMenu_GAM.Text = "Главное меню";
            toolTipButtons_GAM.SetToolTip(buttonMenu_GAM, "Вернуться в главное меню");
            buttonMenu_GAM.UseVisualStyleBackColor = false;
            buttonMenu_GAM.Click += buttonMenu_GAM_Click;
            buttonMenu_GAM.MouseEnter += buttonMenu_GAM_MouseEnter;
            buttonMenu_GAM.MouseLeave += buttonMenu_GAM_MouseLeave;
            // 
            // pictureBoxSort_GAM
            // 
            pictureBoxSort_GAM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxSort_GAM.Location = new Point(743, 85);
            pictureBoxSort_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxSort_GAM.Name = "pictureBoxSort_GAM";
            pictureBoxSort_GAM.Size = new Size(39, 45);
            pictureBoxSort_GAM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSort_GAM.TabIndex = 5;
            pictureBoxSort_GAM.TabStop = false;
            // 
            // buttonReset_GAM
            // 
            buttonReset_GAM.BackColor = Color.Transparent;
            buttonReset_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReset_GAM.Enabled = false;
            buttonReset_GAM.FlatAppearance.BorderSize = 0;
            buttonReset_GAM.FlatStyle = FlatStyle.Flat;
            buttonReset_GAM.Location = new Point(405, 9);
            buttonReset_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonReset_GAM.Name = "buttonReset_GAM";
            buttonReset_GAM.Size = new Size(43, 49);
            buttonReset_GAM.TabIndex = 4;
            toolTipButtons_GAM.SetToolTip(buttonReset_GAM, "Вернуть таблицу к исходному виду");
            buttonReset_GAM.UseVisualStyleBackColor = false;
            buttonReset_GAM.Click += buttonReset_GAM_Click;
            buttonReset_GAM.MouseEnter += buttonReset_GAM_MouseEnter;
            buttonReset_GAM.MouseLeave += buttonReset_GAM_MouseLeave;
            // 
            // menuStripSort_GAM
            // 
            menuStripSort_GAM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            menuStripSort_GAM.BackColor = Color.FromArgb(120, 120, 120);
            menuStripSort_GAM.Dock = DockStyle.None;
            menuStripSort_GAM.ImageScalingSize = new Size(20, 20);
            menuStripSort_GAM.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMain_GAM, поУбываниюToolStripMenuItem });
            menuStripSort_GAM.Location = new Point(802, 98);
            menuStripSort_GAM.Name = "menuStripSort_GAM";
            menuStripSort_GAM.Padding = new Padding(8, 3, 0, 3);
            menuStripSort_GAM.Size = new Size(269, 30);
            menuStripSort_GAM.TabIndex = 3;
            menuStripSort_GAM.Text = "menuStrip1";
            // 
            // toolStripMenuItemMain_GAM
            // 
            toolStripMenuItemMain_GAM.BackColor = Color.FromArgb(120, 120, 120);
            toolStripMenuItemMain_GAM.DropDownItems.AddRange(new ToolStripItem[] { сортировкаToolStripMenuItemMain_GAM, столбецВесToolStripMenuItem, столбецIDToolStripMenuItem });
            toolStripMenuItemMain_GAM.ForeColor = SystemColors.ControlText;
            toolStripMenuItemMain_GAM.Name = "toolStripMenuItemMain_GAM";
            toolStripMenuItemMain_GAM.Size = new Size(139, 24);
            toolStripMenuItemMain_GAM.Text = "По возрастанию";
            // 
            // сортировкаToolStripMenuItemMain_GAM
            // 
            сортировкаToolStripMenuItemMain_GAM.Name = "сортировкаToolStripMenuItemMain_GAM";
            сортировкаToolStripMenuItemMain_GAM.Size = new Size(262, 26);
            сортировкаToolStripMenuItemMain_GAM.Text = "Столбец \"Длительность\"";
            сортировкаToolStripMenuItemMain_GAM.Click += сортировкаToolStripMenuItem_Click_1;
            // 
            // столбецВесToolStripMenuItem
            // 
            столбецВесToolStripMenuItem.Name = "столбецВесToolStripMenuItem";
            столбецВесToolStripMenuItem.Size = new Size(262, 26);
            столбецВесToolStripMenuItem.Text = "Столбец \"Вес\"";
            столбецВесToolStripMenuItem.Click += столбецВесToolStripMenuItem_Click;
            // 
            // столбецIDToolStripMenuItem
            // 
            столбецIDToolStripMenuItem.Name = "столбецIDToolStripMenuItem";
            столбецIDToolStripMenuItem.Size = new Size(262, 26);
            столбецIDToolStripMenuItem.Text = "Столбец \"ID\"";
            столбецIDToolStripMenuItem.Click += столбецIDToolStripMenuItem_Click;
            // 
            // поУбываниюToolStripMenuItem
            // 
            поУбываниюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { столбецДлительностьToolStripMenuItem, столбецВесToolStripMenuItem1, столбецДатаToolStripMenuItem1 });
            поУбываниюToolStripMenuItem.ForeColor = SystemColors.ControlText;
            поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            поУбываниюToolStripMenuItem.Size = new Size(120, 24);
            поУбываниюToolStripMenuItem.Text = "По убыванию";
            // 
            // столбецДлительностьToolStripMenuItem
            // 
            столбецДлительностьToolStripMenuItem.Name = "столбецДлительностьToolStripMenuItem";
            столбецДлительностьToolStripMenuItem.Size = new Size(262, 26);
            столбецДлительностьToolStripMenuItem.Text = "Столбец \"Длительность\"";
            столбецДлительностьToolStripMenuItem.Click += столбецДлительностьToolStripMenuItem_Click;
            // 
            // столбецВесToolStripMenuItem1
            // 
            столбецВесToolStripMenuItem1.Name = "столбецВесToolStripMenuItem1";
            столбецВесToolStripMenuItem1.Size = new Size(262, 26);
            столбецВесToolStripMenuItem1.Text = "Столбец \"Вес\"";
            столбецВесToolStripMenuItem1.Click += столбецВесToolStripMenuItem1_Click;
            // 
            // столбецДатаToolStripMenuItem1
            // 
            столбецДатаToolStripMenuItem1.Name = "столбецДатаToolStripMenuItem1";
            столбецДатаToolStripMenuItem1.Size = new Size(262, 26);
            столбецДатаToolStripMenuItem1.Text = "Столбец \"ID\"";
            столбецДатаToolStripMenuItem1.Click += столбецДатаToolStripMenuItem1_Click;
            // 
            // pictureBoxAbout_GAM
            // 
            pictureBoxAbout_GAM.Anchor = AnchorStyles.Right;
            pictureBoxAbout_GAM.BackColor = Color.Transparent;
            pictureBoxAbout_GAM.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxAbout_GAM.ErrorImage = null;
            pictureBoxAbout_GAM.InitialImage = null;
            pictureBoxAbout_GAM.Location = new Point(880, 9);
            pictureBoxAbout_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxAbout_GAM.Name = "pictureBoxAbout_GAM";
            pictureBoxAbout_GAM.Size = new Size(45, 52);
            pictureBoxAbout_GAM.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxAbout_GAM.TabIndex = 1;
            pictureBoxAbout_GAM.TabStop = false;
            // 
            // pictureBoxSave_GAM
            // 
            pictureBoxSave_GAM.BackColor = Color.Transparent;
            pictureBoxSave_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxSave_GAM.ErrorImage = null;
            pictureBoxSave_GAM.InitialImage = null;
            pictureBoxSave_GAM.Location = new Point(201, 9);
            pictureBoxSave_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxSave_GAM.Name = "pictureBoxSave_GAM";
            pictureBoxSave_GAM.Size = new Size(45, 52);
            pictureBoxSave_GAM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSave_GAM.TabIndex = 1;
            pictureBoxSave_GAM.TabStop = false;
            // 
            // pictureBoxManagement_GAM
            // 
            pictureBoxManagement_GAM.Anchor = AnchorStyles.Right;
            pictureBoxManagement_GAM.BackColor = Color.Transparent;
            pictureBoxManagement_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxManagement_GAM.ErrorImage = null;
            pictureBoxManagement_GAM.InitialImage = null;
            pictureBoxManagement_GAM.Location = new Point(680, 9);
            pictureBoxManagement_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxManagement_GAM.Name = "pictureBoxManagement_GAM";
            pictureBoxManagement_GAM.Size = new Size(45, 52);
            pictureBoxManagement_GAM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxManagement_GAM.TabIndex = 1;
            pictureBoxManagement_GAM.TabStop = false;
            // 
            // pictureBoxLoad_GAM
            // 
            pictureBoxLoad_GAM.BackColor = Color.Transparent;
            pictureBoxLoad_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLoad_GAM.ErrorImage = null;
            pictureBoxLoad_GAM.InitialImage = null;
            pictureBoxLoad_GAM.Location = new Point(4, 9);
            pictureBoxLoad_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLoad_GAM.Name = "pictureBoxLoad_GAM";
            pictureBoxLoad_GAM.Size = new Size(45, 52);
            pictureBoxLoad_GAM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoad_GAM.TabIndex = 1;
            pictureBoxLoad_GAM.TabStop = false;
            // 
            // buttonAbout_GAM
            // 
            buttonAbout_GAM.Anchor = AnchorStyles.Right;
            buttonAbout_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonAbout_GAM.FlatStyle = FlatStyle.Popup;
            buttonAbout_GAM.Font = new Font("Segoe UI", 9F);
            buttonAbout_GAM.ForeColor = Color.WhiteSmoke;
            buttonAbout_GAM.Location = new Point(933, 9);
            buttonAbout_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonAbout_GAM.Name = "buttonAbout_GAM";
            buttonAbout_GAM.Size = new Size(124, 52);
            buttonAbout_GAM.TabIndex = 0;
            buttonAbout_GAM.Text = "О программе";
            toolTipButtons_GAM.SetToolTip(buttonAbout_GAM, "Информация о разработчике");
            buttonAbout_GAM.UseVisualStyleBackColor = false;
            buttonAbout_GAM.Click += buttonAbout_GAM_Click;
            buttonAbout_GAM.MouseEnter += buttonAbout_GAM_MouseEnter;
            buttonAbout_GAM.MouseLeave += buttonAbout_GAM_MouseLeave;
            // 
            // buttonSave_GAM
            // 
            buttonSave_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonSave_GAM.FlatStyle = FlatStyle.Popup;
            buttonSave_GAM.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave_GAM.ForeColor = Color.WhiteSmoke;
            buttonSave_GAM.Location = new Point(255, 9);
            buttonSave_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonSave_GAM.Name = "buttonSave_GAM";
            buttonSave_GAM.Size = new Size(143, 52);
            buttonSave_GAM.TabIndex = 0;
            buttonSave_GAM.Text = "Сохранить файл";
            toolTipButtons_GAM.SetToolTip(buttonSave_GAM, "Сохранить измененный файл");
            buttonSave_GAM.UseVisualStyleBackColor = false;
            buttonSave_GAM.Click += buttonSave_GAM_Click;
            buttonSave_GAM.MouseEnter += buttonSave_GAM_MouseEnter;
            buttonSave_GAM.MouseLeave += buttonSave_GAM_MouseLeave;
            // 
            // buttonManagement_GAM
            // 
            buttonManagement_GAM.Anchor = AnchorStyles.Right;
            buttonManagement_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonManagement_GAM.FlatStyle = FlatStyle.Popup;
            buttonManagement_GAM.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonManagement_GAM.ForeColor = Color.WhiteSmoke;
            buttonManagement_GAM.Location = new Point(757, 9);
            buttonManagement_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonManagement_GAM.Name = "buttonManagement_GAM";
            buttonManagement_GAM.Size = new Size(115, 52);
            buttonManagement_GAM.TabIndex = 0;
            buttonManagement_GAM.Text = "Руководство";
            toolTipButtons_GAM.SetToolTip(buttonManagement_GAM, "Открыть краткое руководство по программе");
            buttonManagement_GAM.UseVisualStyleBackColor = false;
            buttonManagement_GAM.Click += buttonManagement_GAM_Click;
            buttonManagement_GAM.MouseEnter += buttonManagement_GAM_MouseEnter;
            buttonManagement_GAM.MouseLeave += buttonManagement_GAM_MouseLeave;
            // 
            // buttonLoad_GAM
            // 
            buttonLoad_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonLoad_GAM.FlatStyle = FlatStyle.Popup;
            buttonLoad_GAM.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoad_GAM.ForeColor = Color.WhiteSmoke;
            buttonLoad_GAM.Location = new Point(55, 9);
            buttonLoad_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonLoad_GAM.Name = "buttonLoad_GAM";
            buttonLoad_GAM.Size = new Size(139, 52);
            buttonLoad_GAM.TabIndex = 0;
            buttonLoad_GAM.Text = "Выбрать файл";
            toolTipButtons_GAM.SetToolTip(buttonLoad_GAM, "Открыть нужный файл для работы");
            buttonLoad_GAM.UseVisualStyleBackColor = false;
            buttonLoad_GAM.Click += buttonLoad_GAM_Click;
            buttonLoad_GAM.MouseEnter += buttonLoad_GAM_MouseEnter;
            buttonLoad_GAM.MouseLeave += buttonLoad_GAM_MouseLeave;
            // 
            // panelDown_GAM
            // 
            panelDown_GAM.BackColor = Color.FromArgb(60, 60, 60);
            panelDown_GAM.Controls.Add(buttonGraph_GAM);
            panelDown_GAM.Controls.Add(textBoxFilter_GAM);
            panelDown_GAM.Controls.Add(textBoxSearch_GAM);
            panelDown_GAM.Controls.Add(buttonLeft_GAM);
            panelDown_GAM.Controls.Add(buttonRight_GAM);
            panelDown_GAM.Controls.Add(buttonSearch_GAM);
            panelDown_GAM.Controls.Add(pictureBoxSearch_GAM);
            panelDown_GAM.Controls.Add(pictureBoxFilter_GAM);
            panelDown_GAM.Controls.Add(menuStripMain_GAM);
            panelDown_GAM.Dock = DockStyle.Bottom;
            panelDown_GAM.Location = new Point(0, 634);
            panelDown_GAM.Margin = new Padding(4, 5, 4, 5);
            panelDown_GAM.Name = "panelDown_GAM";
            panelDown_GAM.Size = new Size(1072, 75);
            panelDown_GAM.TabIndex = 1;
            // 
            // buttonGraph_GAM
            // 
            buttonGraph_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonGraph_GAM.FlatStyle = FlatStyle.Popup;
            buttonGraph_GAM.Font = new Font("Segoe UI", 9F);
            buttonGraph_GAM.ForeColor = Color.WhiteSmoke;
            buttonGraph_GAM.Location = new Point(625, 11);
            buttonGraph_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonGraph_GAM.Name = "buttonGraph_GAM";
            buttonGraph_GAM.Size = new Size(100, 51);
            buttonGraph_GAM.TabIndex = 3;
            buttonGraph_GAM.Text = "График";
            toolTipButtons_GAM.SetToolTip(buttonGraph_GAM, "Перейти в среду для отображения графиков");
            buttonGraph_GAM.UseVisualStyleBackColor = false;
            buttonGraph_GAM.Click += buttonGraph_GAM_Click;
            buttonGraph_GAM.MouseEnter += buttonGraph_GAM_MouseEnter;
            buttonGraph_GAM.MouseLeave += buttonGraph_GAM_MouseLeave;
            // 
            // textBoxFilter_GAM
            // 
            textBoxFilter_GAM.BackColor = Color.DarkGray;
            textBoxFilter_GAM.BorderStyle = BorderStyle.FixedSingle;
            textBoxFilter_GAM.Font = new Font("Segoe UI", 9F);
            textBoxFilter_GAM.ForeColor = SystemColors.ControlText;
            textBoxFilter_GAM.Location = new Point(149, 11);
            textBoxFilter_GAM.Margin = new Padding(4, 5, 4, 5);
            textBoxFilter_GAM.Multiline = true;
            textBoxFilter_GAM.Name = "textBoxFilter_GAM";
            textBoxFilter_GAM.Size = new Size(147, 50);
            textBoxFilter_GAM.TabIndex = 2;
            // 
            // textBoxSearch_GAM
            // 
            textBoxSearch_GAM.BackColor = Color.DarkGray;
            textBoxSearch_GAM.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch_GAM.Font = new Font("Segoe UI", 9F);
            textBoxSearch_GAM.ForeColor = SystemColors.ControlText;
            textBoxSearch_GAM.Location = new Point(468, 11);
            textBoxSearch_GAM.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch_GAM.Multiline = true;
            textBoxSearch_GAM.Name = "textBoxSearch_GAM";
            textBoxSearch_GAM.Size = new Size(147, 50);
            textBoxSearch_GAM.TabIndex = 2;
            // 
            // buttonLeft_GAM
            // 
            buttonLeft_GAM.Anchor = AnchorStyles.Right;
            buttonLeft_GAM.BackColor = Color.Transparent;
            buttonLeft_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLeft_GAM.FlatAppearance.BorderSize = 0;
            buttonLeft_GAM.FlatStyle = FlatStyle.Flat;
            buttonLeft_GAM.Location = new Point(957, 9);
            buttonLeft_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonLeft_GAM.Name = "buttonLeft_GAM";
            buttonLeft_GAM.Size = new Size(45, 52);
            buttonLeft_GAM.TabIndex = 0;
            toolTipButtons_GAM.SetToolTip(buttonLeft_GAM, "Перелистнуть влево");
            buttonLeft_GAM.UseVisualStyleBackColor = false;
            buttonLeft_GAM.Click += buttonLeft_GAM_Click;
            buttonLeft_GAM.MouseEnter += buttonLeft_GAM_MouseEnter;
            buttonLeft_GAM.MouseLeave += buttonLeft_GAM_MouseLeave;
            // 
            // buttonRight_GAM
            // 
            buttonRight_GAM.Anchor = AnchorStyles.Right;
            buttonRight_GAM.BackColor = Color.Transparent;
            buttonRight_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRight_GAM.FlatAppearance.BorderSize = 0;
            buttonRight_GAM.FlatStyle = FlatStyle.Flat;
            buttonRight_GAM.Location = new Point(1011, 9);
            buttonRight_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonRight_GAM.Name = "buttonRight_GAM";
            buttonRight_GAM.Size = new Size(45, 52);
            buttonRight_GAM.TabIndex = 0;
            toolTipButtons_GAM.SetToolTip(buttonRight_GAM, "Перелистнуть вправо");
            buttonRight_GAM.UseVisualStyleBackColor = false;
            buttonRight_GAM.Click += buttonRight_GAM_Click;
            buttonRight_GAM.MouseEnter += buttonRight_GAM_MouseEnter;
            buttonRight_GAM.MouseLeave += buttonRight_GAM_MouseLeave;
            // 
            // buttonSearch_GAM
            // 
            buttonSearch_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonSearch_GAM.FlatStyle = FlatStyle.Popup;
            buttonSearch_GAM.Font = new Font("Segoe UI", 9F);
            buttonSearch_GAM.ForeColor = Color.WhiteSmoke;
            buttonSearch_GAM.Location = new Point(363, 9);
            buttonSearch_GAM.Margin = new Padding(4, 5, 4, 5);
            buttonSearch_GAM.Name = "buttonSearch_GAM";
            buttonSearch_GAM.Size = new Size(100, 52);
            buttonSearch_GAM.TabIndex = 0;
            buttonSearch_GAM.Text = "Поиск";
            toolTipButtons_GAM.SetToolTip(buttonSearch_GAM, "Выполнить поиск по заданному тексту");
            buttonSearch_GAM.UseVisualStyleBackColor = false;
            buttonSearch_GAM.Click += buttonSearch_GAM_Click;
            buttonSearch_GAM.MouseEnter += buttonSearch_GAM_MouseEnter;
            buttonSearch_GAM.MouseLeave += buttonSearch_GAM_MouseLeave;
            // 
            // pictureBoxSearch_GAM
            // 
            pictureBoxSearch_GAM.BackColor = Color.Transparent;
            pictureBoxSearch_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxSearch_GAM.ErrorImage = null;
            pictureBoxSearch_GAM.InitialImage = null;
            pictureBoxSearch_GAM.Location = new Point(309, 9);
            pictureBoxSearch_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxSearch_GAM.Name = "pictureBoxSearch_GAM";
            pictureBoxSearch_GAM.Size = new Size(45, 52);
            pictureBoxSearch_GAM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch_GAM.TabIndex = 1;
            pictureBoxSearch_GAM.TabStop = false;
            // 
            // pictureBoxFilter_GAM
            // 
            pictureBoxFilter_GAM.BackColor = Color.Transparent;
            pictureBoxFilter_GAM.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxFilter_GAM.ErrorImage = null;
            pictureBoxFilter_GAM.InitialImage = null;
            pictureBoxFilter_GAM.Location = new Point(4, 9);
            pictureBoxFilter_GAM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxFilter_GAM.Name = "pictureBoxFilter_GAM";
            pictureBoxFilter_GAM.Size = new Size(45, 52);
            pictureBoxFilter_GAM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFilter_GAM.TabIndex = 1;
            pictureBoxFilter_GAM.TabStop = false;
            // 
            // menuStripMain_GAM
            // 
            menuStripMain_GAM.BackColor = Color.FromArgb(120, 120, 120);
            menuStripMain_GAM.BackgroundImageLayout = ImageLayout.Stretch;
            menuStripMain_GAM.Dock = DockStyle.None;
            menuStripMain_GAM.ImageScalingSize = new Size(20, 20);
            menuStripMain_GAM.Items.AddRange(new ToolStripItem[] { фильтрToolStripMenuItem });
            menuStripMain_GAM.Location = new Point(55, 17);
            menuStripMain_GAM.Name = "menuStripMain_GAM";
            menuStripMain_GAM.Padding = new Padding(8, 3, 0, 3);
            menuStripMain_GAM.Size = new Size(84, 30);
            menuStripMain_GAM.TabIndex = 4;
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.BackColor = Color.FromArgb(120, 120, 120);
            фильтрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { названиеToolStripMenuItem, весToolStripMenuItem, длительностьToolStripMenuItem, форматToolStripMenuItem, категорияToolStripMenuItem, iDToolStripMenuItem });
            фильтрToolStripMenuItem.ForeColor = SystemColors.ControlText;
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(74, 24);
            фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // названиеToolStripMenuItem
            // 
            названиеToolStripMenuItem.Name = "названиеToolStripMenuItem";
            названиеToolStripMenuItem.Size = new Size(188, 26);
            названиеToolStripMenuItem.Text = "Название";
            названиеToolStripMenuItem.Click += названиеToolStripMenuItem_Click;
            // 
            // весToolStripMenuItem
            // 
            весToolStripMenuItem.Name = "весToolStripMenuItem";
            весToolStripMenuItem.Size = new Size(188, 26);
            весToolStripMenuItem.Text = "Вес";
            весToolStripMenuItem.Click += весToolStripMenuItem_Click;
            // 
            // длительностьToolStripMenuItem
            // 
            длительностьToolStripMenuItem.Name = "длительностьToolStripMenuItem";
            длительностьToolStripMenuItem.Size = new Size(188, 26);
            длительностьToolStripMenuItem.Text = "Длительность";
            длительностьToolStripMenuItem.Click += длительностьToolStripMenuItem_Click;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(188, 26);
            форматToolStripMenuItem.Text = "Формат";
            форматToolStripMenuItem.Click += форматToolStripMenuItem_Click;
            // 
            // категорияToolStripMenuItem
            // 
            категорияToolStripMenuItem.Name = "категорияToolStripMenuItem";
            категорияToolStripMenuItem.Size = new Size(188, 26);
            категорияToolStripMenuItem.Text = "Категория";
            категорияToolStripMenuItem.Click += категорияToolStripMenuItem_Click;
            // 
            // iDToolStripMenuItem
            // 
            iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            iDToolStripMenuItem.Size = new Size(188, 26);
            iDToolStripMenuItem.Text = "ID";
            iDToolStripMenuItem.Click += iDToolStripMenuItem_Click;
            // 
            // panelMiddle_GAM
            // 
            panelMiddle_GAM.BackColor = Color.FromArgb(20, 20, 20);
            panelMiddle_GAM.BorderStyle = BorderStyle.Fixed3D;
            panelMiddle_GAM.Controls.Add(groupBoxBase_GAM);
            panelMiddle_GAM.Dock = DockStyle.Fill;
            panelMiddle_GAM.Location = new Point(0, 129);
            panelMiddle_GAM.Margin = new Padding(4, 5, 4, 5);
            panelMiddle_GAM.Name = "panelMiddle_GAM";
            panelMiddle_GAM.Size = new Size(1072, 505);
            panelMiddle_GAM.TabIndex = 2;
            // 
            // groupBoxBase_GAM
            // 
            groupBoxBase_GAM.Controls.Add(dataGridViewBase_GAM);
            groupBoxBase_GAM.Dock = DockStyle.Fill;
            groupBoxBase_GAM.FlatStyle = FlatStyle.Popup;
            groupBoxBase_GAM.ForeColor = SystemColors.ButtonHighlight;
            groupBoxBase_GAM.Location = new Point(0, 0);
            groupBoxBase_GAM.Margin = new Padding(4, 5, 4, 5);
            groupBoxBase_GAM.Name = "groupBoxBase_GAM";
            groupBoxBase_GAM.Padding = new Padding(4, 5, 4, 5);
            groupBoxBase_GAM.Size = new Size(1068, 501);
            groupBoxBase_GAM.TabIndex = 0;
            groupBoxBase_GAM.TabStop = false;
            groupBoxBase_GAM.Text = "Данные";
            // 
            // dataGridViewBase_GAM
            // 
            dataGridViewBase_GAM.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewBase_GAM.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewBase_GAM.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBase_GAM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBase_GAM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_GAM.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewBase_GAM.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBase_GAM.Dock = DockStyle.Fill;
            dataGridViewBase_GAM.GridColor = Color.FromArgb(64, 64, 64);
            dataGridViewBase_GAM.Location = new Point(4, 25);
            dataGridViewBase_GAM.Margin = new Padding(4, 5, 4, 5);
            dataGridViewBase_GAM.Name = "dataGridViewBase_GAM";
            dataGridViewBase_GAM.RowHeadersVisible = false;
            dataGridViewBase_GAM.RowHeadersWidth = 51;
            dataGridViewBase_GAM.Size = new Size(1060, 471);
            dataGridViewBase_GAM.TabIndex = 0;
            dataGridViewBase_GAM.CellContentClick += dataGridViewBase_GAM_CellContentClick;
            // 
            // toolTipButtons_GAM
            // 
            toolTipButtons_GAM.ToolTipIcon = ToolTipIcon.Info;
            toolTipButtons_GAM.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1072, 709);
            Controls.Add(videoControl);
            Controls.Add(panelMiddle_GAM);
            Controls.Add(panelDown_GAM);
            Controls.Add(panelUpper_GAM);
            MainMenuStrip = menuStripMain_GAM;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог видеоклипов";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)videoControl).EndInit();
            panelUpper_GAM.ResumeLayout(false);
            panelUpper_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSort_GAM).EndInit();
            menuStripSort_GAM.ResumeLayout(false);
            menuStripSort_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSave_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxManagement_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoad_GAM).EndInit();
            panelDown_GAM.ResumeLayout(false);
            panelDown_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_GAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilter_GAM).EndInit();
            menuStripMain_GAM.ResumeLayout(false);
            menuStripMain_GAM.PerformLayout();
            panelMiddle_GAM.ResumeLayout(false);
            groupBoxBase_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GAM).EndInit();
            ResumeLayout(false);

            

        }

        private void videoControl_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogMain_GAM;
        private System.Windows.Forms.Panel panelUpper_GAM;
        private System.Windows.Forms.PictureBox pictureBoxLoad_GAM;
        private System.Windows.Forms.Button buttonSave_GAM;
        private System.Windows.Forms.Button buttonLoad_GAM;
        private System.Windows.Forms.Panel panelDown_GAM;
        private System.Windows.Forms.Panel panelMiddle_GAM;
        private System.Windows.Forms.PictureBox pictureBoxSave_GAM;
        private System.Windows.Forms.PictureBox pictureBoxAbout_GAM;
        private System.Windows.Forms.PictureBox pictureBoxManagement_GAM;
        private System.Windows.Forms.Button buttonAbout_GAM;
        private System.Windows.Forms.Button buttonManagement_GAM;
        private System.Windows.Forms.Button buttonLeft_GAM;
        private System.Windows.Forms.Button buttonRight_GAM;
        private System.Windows.Forms.PictureBox pictureBoxFilter_GAM;
        private System.Windows.Forms.GroupBox groupBoxBase_GAM;
        private System.Windows.Forms.DataGridView dataGridViewBase_GAM;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_GAM;
        private System.Windows.Forms.Button buttonSearch_GAM;
        private System.Windows.Forms.PictureBox pictureBoxSearch_GAM;
        private System.Windows.Forms.MenuStrip menuStripSort_GAM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMain_GAM;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItemMain_GAM;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецДлительностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецВесToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem столбецДатаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem столбецIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецВесToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset_GAM;
        private System.Windows.Forms.PictureBox pictureBoxSort_GAM;
        private System.Windows.Forms.TextBox textBoxSearch_GAM;
        private System.Windows.Forms.TextBox textBoxFilter_GAM;
        private System.Windows.Forms.ToolTip toolTipButtons_GAM;
        private System.Windows.Forms.Button buttonGraph_GAM;
        private System.Windows.Forms.MenuStrip menuStripMain_GAM;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem длительностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.Button buttonMenu_GAM;
        private Control buttonOpenFile;
    }
}
