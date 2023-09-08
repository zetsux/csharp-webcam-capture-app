using System;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;

namespace PBKK2
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice vidSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in captureDevice)
            {
                comboBoxWebcamList.Items.Add(device.Name);
            }
            comboBoxWebcamList.SelectedIndex = 0;
            vidSource = new VideoCaptureDevice();
        }

        private void VidSource_NewFrame(object sender, NewFrameEventArgs e)
        {
            pictureBox1.Image = (Bitmap)e.Frame.Clone();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (vidSource.IsRunning)
            {
                vidSource.SignalToStop();
                vidSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }

            vidSource = new VideoCaptureDevice(captureDevice[comboBoxWebcamList.SelectedIndex].MonikerString);
            vidSource.NewFrame += new NewFrameEventHandler(VidSource_NewFrame);
            vidSource.Start();
        }

        private void buttonCapt_Click(object sender, EventArgs e)
        {
            if (vidSource.IsRunning) pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null) return;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Capture As";
            saveDialog.Filter = "Image files (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imgFormat = ImageFormat.Png;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imgFormat = ImageFormat.Jpeg; break;
                    case ".png":
                        imgFormat = ImageFormat.Png; break;
                }
                pictureBox2.Image.Save(saveDialog.FileName, imgFormat);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (vidSource.IsRunning)
            {
                vidSource.SignalToStop();
                vidSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }
            Application.Exit(null);
        }
    }
}