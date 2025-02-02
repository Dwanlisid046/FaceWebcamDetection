using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Windows.Forms.Design;
using System.Reflection.Metadata;
using System.Drawing.Imaging;

namespace Webcam
{
    public partial class MakeSkrinshot : Form
    {
        private static CascadeClassifier classifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        private Image<Bgr, byte> image = null;

        private string fileName = string.Empty;
        public MakeSkrinshot(Image<Bgr, byte> image)
        {
            this.image = image;
            InitializeComponent();
        }

        private void MakeSkrinshot_Load(object sender, EventArgs e)
        {
            fileName = $"WCVC_Img.jpeg";

            pictureBox1.Image = image.AsBitmap();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(fileName, ImageFormat.Jpeg);
                if (File.Exists(fileName))
                {
                    Close();
                }
                else
                {
                    throw new Exception("No save :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
