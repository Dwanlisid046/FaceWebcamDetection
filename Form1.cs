using Emgu.CV;
using Emgu.CV.Structure;
using DirectShowLib;

namespace Webcam
{
    public partial class MainForm : Form
    {
        private static readonly CascadeClassifier faceClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        private VideoCapture? videoCapture = null;
        private double totalFrames;
        private DsDevice[] availableCameras = null;
        private int selectedCameraIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private Image<Bgr, byte> DetectFaces(Image<Bgr, byte> image)
        {
            if (image == null) return null;

            using (var gray = image.Convert<Gray, byte>())
            {
                var faces = faceClassifier.DetectMultiScale(gray, 1.1, 10, Size.Empty, Size.Empty);
                foreach (var face in faces)
                {
                    image.Draw(face, new Bgr(Color.Red), 2);
                    CvInvoke.PutText(image, "Face", new Point(face.X, face.Y - 10),
                        Emgu.CV.CvEnum.FontFace.HersheyComplex, 1, new MCvScalar(0, 255, 0), 2, Emgu.CV.CvEnum.LineType.AntiAlias);
                }
            }
            return image;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            availableCameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            foreach (var camera in availableCameras)
            {
                cameraSelector.Items.Add(camera.Name);
            }
        }

        private void cameraSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCameraIndex = cameraSelector.SelectedIndex;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (availableCameras.Length == 0)
                    throw new Exception("No cameras available.");
                if (cameraSelector.SelectedItem == null)
                    throw new Exception("Select a camera first!");
                if (videoCapture != null)
                {
                    videoCapture.Start();
                    return;
                }

                videoCapture = new VideoCapture(selectedCameraIndex);
                videoCapture.ImageGrabbed += Capture_ImageGrabbed;
                videoCapture.Start();
                Mat frame = new Mat();
                videoCapture.Read(frame);
                videoDisplay.Image = frame.ToBitmap();
                totalFrames = videoCapture.Get(Emgu.CV.CvEnum.CapProp.FrameCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Capture_ImageGrabbed(object? sender, EventArgs e)
        {
            try
            {
                Mat frame = new Mat();
                videoCapture.Retrieve(frame);
                var img = frame.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
                videoDisplay.Image = DetectFaces(img).ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                videoCapture?.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture != null)
                {
                    videoCapture.Pause();
                    videoCapture.Dispose();
                    videoCapture = null;
                    videoDisplay.Image?.Dispose();
                    videoDisplay.Image = null;
                    selectedCameraIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture == null)
                    throw new Exception("No video stream.");

                Mat frame = new Mat();
                videoCapture.Retrieve(frame);
                var screenshot = new MakeSkrinshot(frame.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal));
                screenshot.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
