namespace Webcam.Forms
{
    partial class FrmImgProcessing
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
            btnOpen = new Button();
            btnGray = new Button();
            btnNegative = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            imgLstSourcePhoto = new ImageList(components);
            lstViewSourcePhoto = new ListView();
            lstResults = new ListView();
            imgLstResult = new ImageList(components);
            btnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(332, 261);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(118, 51);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Открыть изображения";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnGray
            // 
            btnGray.Location = new Point(332, 129);
            btnGray.Name = "btnGray";
            btnGray.Size = new Size(118, 51);
            btnGray.TabIndex = 1;
            btnGray.Text = "В серый цвет";
            btnGray.UseVisualStyleBackColor = true;
            btnGray.Click += btnGray_Click;
            // 
            // btnNegative
            // 
            btnNegative.Location = new Point(332, 195);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(118, 51);
            btnNegative.TabIndex = 2;
            btnNegative.Text = "В негатив";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += btnNegative_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Multiselect = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // imgLstSourcePhoto
            // 
            imgLstSourcePhoto.ColorDepth = ColorDepth.Depth32Bit;
            imgLstSourcePhoto.ImageSize = new Size(250, 250);
            imgLstSourcePhoto.TransparentColor = Color.Transparent;
            // 
            // lstViewSourcePhoto
            // 
            lstViewSourcePhoto.GroupImageList = imgLstSourcePhoto;
            lstViewSourcePhoto.LargeImageList = imgLstSourcePhoto;
            lstViewSourcePhoto.Location = new Point(2, 3);
            lstViewSourcePhoto.Name = "lstViewSourcePhoto";
            lstViewSourcePhoto.Size = new Size(324, 443);
            lstViewSourcePhoto.TabIndex = 4;
            lstViewSourcePhoto.TileSize = new Size(1, 1);
            lstViewSourcePhoto.UseCompatibleStateImageBehavior = false;
            // 
            // lstResults
            // 
            lstResults.GroupImageList = imgLstResult;
            lstResults.LargeImageList = imgLstResult;
            lstResults.Location = new Point(456, 3);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(342, 443);
            lstResults.TabIndex = 5;
            lstResults.UseCompatibleStateImageBehavior = false;
            // 
            // imgLstResult
            // 
            imgLstResult.ColorDepth = ColorDepth.Depth32Bit;
            imgLstResult.ImageSize = new Size(250, 250);
            imgLstResult.TransparentColor = Color.Transparent;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(332, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 63);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить обработанные изображения";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 459);
            label2.Name = "label2";
            label2.Size = new Size(475, 15);
            label2.TabIndex = 7;
            label2.Text = "Первым делом загрузите изображения с п омощью кнопки \"Открыть изображения\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 484);
            label3.Name = "label3";
            label3.Size = new Size(803, 15);
            label3.TabIndex = 8;
            label3.Text = "Выберите нужну операцию! Лучше всего выбрать одну операцию для фото(Перевод в ч/б или негатив), чтобы изображения не перемешались\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 509);
            label4.Name = "label4";
            label4.Size = new Size(577, 15);
            label4.TabIndex = 9;
            label4.Text = "Максимальный размер изображения 250x250, т.к оно лучше всего подходит для машинного обучения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 527);
            label5.Name = "label5";
            label5.Size = new Size(502, 15);
            label5.TabIndex = 10;
            label5.Text = "Для новой обработки, закройте текущее окно и откройте его заново через главное меню";
            // 
            // FrmImgProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 551);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(lstResults);
            Controls.Add(lstViewSourcePhoto);
            Controls.Add(label1);
            Controls.Add(btnNegative);
            Controls.Add(btnGray);
            Controls.Add(btnOpen);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmImgProcessing";
            Text = "Обработка изображений";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private Button btnGray;
        private Button btnNegative;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private ImageList imgLstSourcePhoto;
        private ListView lstViewSourcePhoto;
        private ListView lstResults;
        private ImageList imgLstResult;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}