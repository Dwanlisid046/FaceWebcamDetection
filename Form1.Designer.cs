namespace Webcam
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support. Do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolBar = new ToolStrip();
            lblCamera = new ToolStripLabel();
            cameraSelector = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnStartCamera = new ToolStripButton();
            btnPauseCamera = new ToolStripButton();
            btnStopCamera = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCaptureScreenshot = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            btnSave = new ToolStripButton();
            videoDisplay = new PictureBox();
            splitContainer1 = new SplitContainer();
            lstDetectedFace = new ListView();
            imgLstDetect = new ImageList(components);
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(999, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(109, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // toolBar
            // 
            toolBar.Items.AddRange(new ToolStripItem[] { lblCamera, cameraSelector, toolStripSeparator1, btnStartCamera, btnPauseCamera, btnStopCamera, toolStripSeparator2, btnCaptureScreenshot, toolStripSeparator3, toolStripSeparator4, btnSave });
            toolBar.Location = new Point(0, 24);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(999, 25);
            toolBar.TabIndex = 2;
            toolBar.Text = "toolStrip1";
            // 
            // lblCamera
            // 
            lblCamera.Name = "lblCamera";
            lblCamera.Size = new Size(54, 22);
            lblCamera.Text = "Камера: ";
            // 
            // cameraSelector
            // 
            cameraSelector.Name = "cameraSelector";
            cameraSelector.Size = new Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnStartCamera
            // 
            btnStartCamera.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnStartCamera.ImageTransparentColor = Color.Magenta;
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(64, 22);
            btnStartCamera.Text = "Смотреть";
            btnStartCamera.Click += btnStart_Click;
            // 
            // btnPauseCamera
            // 
            btnPauseCamera.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPauseCamera.ImageTransparentColor = Color.Magenta;
            btnPauseCamera.Name = "btnPauseCamera";
            btnPauseCamera.Size = new Size(43, 22);
            btnPauseCamera.Text = "Пауза";
            btnPauseCamera.Click += btnPause_Click;
            // 
            // btnStopCamera
            // 
            btnStopCamera.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnStopCamera.ImageTransparentColor = Color.Magenta;
            btnStopCamera.Name = "btnStopCamera";
            btnStopCamera.Size = new Size(38, 22);
            btnStopCamera.Text = "Стоп";
            btnStopCamera.Click += btnStop_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnCaptureScreenshot
            // 
            btnCaptureScreenshot.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCaptureScreenshot.ImageTransparentColor = Color.Magenta;
            btnCaptureScreenshot.Name = "btnCaptureScreenshot";
            btnCaptureScreenshot.Size = new Size(114, 22);
            btnCaptureScreenshot.Text = "Сделать скриншот";
            btnCaptureScreenshot.Click += btnScreenshot_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 22);
            btnSave.Text = "Сохранить скриншоты";
            btnSave.Click += btnSave_Click;
            // 
            // videoDisplay
            // 
            videoDisplay.Dock = DockStyle.Fill;
            videoDisplay.Location = new Point(0, 0);
            videoDisplay.Name = "videoDisplay";
            videoDisplay.Size = new Size(564, 515);
            videoDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            videoDisplay.TabIndex = 3;
            videoDisplay.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 49);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(videoDisplay);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lstDetectedFace);
            splitContainer1.Size = new Size(999, 515);
            splitContainer1.SplitterDistance = 564;
            splitContainer1.TabIndex = 4;
            // 
            // lstDetectedFace
            // 
            lstDetectedFace.Dock = DockStyle.Fill;
            lstDetectedFace.LargeImageList = imgLstDetect;
            lstDetectedFace.Location = new Point(0, 0);
            lstDetectedFace.Name = "lstDetectedFace";
            lstDetectedFace.Size = new Size(431, 515);
            lstDetectedFace.TabIndex = 0;
            lstDetectedFace.UseCompatibleStateImageBehavior = false;
            // 
            // imgLstDetect
            // 
            imgLstDetect.ColorDepth = ColorDepth.Depth32Bit;
            imgLstDetect.ImageSize = new Size(250, 250);
            imgLstDetect.TransparentColor = Color.Transparent;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 564);
            Controls.Add(splitContainer1);
            Controls.Add(toolBar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Web Cam";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)videoDisplay).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStrip toolBar;
        private ToolStripLabel lblCamera;
        private ToolStripComboBox cameraSelector;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnStartCamera;
        private ToolStripButton btnPauseCamera;
        private ToolStripButton btnStopCamera;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnCaptureScreenshot;
        private ToolStripSeparator toolStripSeparator3;
        private PictureBox videoDisplay;
        private SplitContainer splitContainer1;
        private ImageList imgLstDetect;
        private ListView lstDetectedFace;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSave;
        private SaveFileDialog saveFileDialog1;
    }
}
