using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webcam.Forms
{
    public partial class FrmImgProcessing : Form
    {
        public FrmImgProcessing()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        try
                        {
                            using (var tempImage = Image.FromFile(fileName))
                            {
                                Image image = new Bitmap(tempImage);
                                imgLstSourcePhoto.Images.Add(image);
                                ListViewItem item = new ListViewItem("Фото для обработки");
                                item.ImageIndex = imgLstSourcePhoto.Images.Count - 1;
                                item.Tag = fileName;
                                lstViewSourcePhoto.Items.Add(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке файла: {fileName}\n{ex.Message}");
                        }
                    }
                    lstViewSourcePhoto.Refresh();
                    MessageBox.Show($"Загружено изображений: {imgLstSourcePhoto.Images.Count}");
                }
            }
        }


        private void btnGray_Click(object sender, EventArgs e)
        {
            if (lstViewSourcePhoto.Items.Count > 0)
            {
                foreach (ListViewItem item in lstViewSourcePhoto.Items)
                {
                    string filePath = item.Tag?.ToString();
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        using (Bitmap input = new Bitmap(filePath))
                        {
                            using (Bitmap output = new Bitmap(input.Width, input.Height))
                            {
                                for (int x = 0; x < input.Width; x++)
                                {
                                    for (int y = 0; y < input.Height; y++)
                                    {
                                        Color pixel = input.GetPixel(x, y);
                                        float R = pixel.R;
                                        float G = pixel.G;
                                        float B = pixel.B;

                                        float gray = (R + G + B) / 3.0f;
                                        Color newPixel = Color.FromArgb((int)gray, (int)gray, (int)gray);

                                        output.SetPixel(x, y, newPixel);
                                    }
                                }
                                imgLstResult.Images.Add(output);
                                ListViewItem itemGray = new ListViewItem("Фото для обработки");
                                itemGray.ImageIndex = imgLstResult.Images.Count - 1;
                                lstResults.Items.Add(itemGray);
                            }
                        }
                    }
                }
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (lstViewSourcePhoto.Items.Count > 0)
            {
                foreach (ListViewItem item in lstViewSourcePhoto.Items)
                {
                    string filePath = item.Tag?.ToString();
                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    {
                        using (Bitmap input = new Bitmap(filePath))
                        {
                            using (Bitmap output = new Bitmap(input.Width, input.Height))
                            {
                                for (int y = 0; y < input.Height; y++)
                                {
                                    for (int x = 0; x < input.Width; x++)
                                    {
                                        Color p = input.GetPixel(x, y);
                                        int a = p.A;
                                        int r = p.R;
                                        int g = p.G;
                                        int b = p.B;
                                        r = 255 - r;
                                        g = 255 - g;
                                        b = 255 - b;
                                        output.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                                    }
                                }

                                imgLstResult.Images.Add(output);
                                ListViewItem itemGray = new ListViewItem("Фото для обработки");
                                itemGray.ImageIndex = imgLstResult.Images.Count - 1;
                                lstResults.Items.Add(itemGray);
                            }
                        }
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Выберите папку для сохранения скриншотов";

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        var imgResult = imgLstResult.Images;

                        for (int i = 0; i < imgResult.Count; i++)
                        {
                            Image screenshot = imgResult[i];
                            string fileName = Path.Combine(folderDialog.SelectedPath, $"imgResult{i + 1}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.png");

                            screenshot.Save(fileName);
                        }

                        MessageBox.Show("Обработанные изображения успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


