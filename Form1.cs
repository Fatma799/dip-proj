using System;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Mat originalImage = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                originalImage = Cv2.ImRead(dlg.FileName);
                pictureBox1.Image = BitmapConverter.ToBitmap(originalImage);
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat[] channels = Cv2.Split(originalImage);
            Mat zeros = Mat.Zeros(originalImage.Size(), MatType.CV_8UC1);
            Mat result = new Mat();
            Cv2.Merge(new Mat[] { zeros, zeros, channels[2] }, result);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat[] channels = Cv2.Split(originalImage);
            Mat zeros = Mat.Zeros(originalImage.Size(), MatType.CV_8UC1);
            Mat result = new Mat();
            Cv2.Merge(new Mat[] { zeros, channels[1], zeros }, result);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat[] channels = Cv2.Split(originalImage);
            Mat zeros = Mat.Zeros(originalImage.Size(), MatType.CV_8UC1);
            Mat result = new Mat();
            Cv2.Merge(new Mat[] { channels[0], zeros, zeros }, result);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat result = new Mat();
            Cv2.CvtColor(originalImage, result, ColorConversionCodes.BGR2GRAY);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat gray = new Mat();
            Cv2.CvtColor(originalImage, gray, ColorConversionCodes.BGR2GRAY);
            Mat eq = new Mat();
            Cv2.EqualizeHist(gray, eq);
            pictureBox1.Image = BitmapConverter.ToBitmap(eq);
        }

        private void btnGaussian_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat result = new Mat();
            Cv2.GaussianBlur(originalImage, result, new OpenCvSharp.Size(15, 15), 0);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat result = new Mat();
            originalImage.ConvertTo(result, -1, 1, 50);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat result = new Mat();
            Cv2.BitwiseNot(originalImage, result);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            Mat result = new Mat();
            Cv2.MedianBlur(originalImage, result, 15);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            float[,] kernelData = { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
            Mat kernel = Mat.FromArray(kernelData);
            Mat result = new Mat();
            Cv2.Filter2D(originalImage, result, -1, kernel);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

        private void btnEmboss_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            float[,] kernelData = { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
            Mat kernel = Mat.FromArray(kernelData);
            Mat result = new Mat();
            Cv2.Filter2D(originalImage, result, -1, kernel);
            pictureBox1.Image = BitmapConverter.ToBitmap(result);
        }

    }
}