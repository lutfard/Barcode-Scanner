using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace BarcodeScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCaptureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in FilterInfoCollection)
            {
                ddlCameraDevice.Items.Add(device.Name);
            }
            ddlCameraDevice.SelectedIndex = 0;
        }

        private void btnStartApps_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[ddlCameraDevice.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                txtBarcodeString.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcodeString.Text = result.ToString();
                }));
            }
            scrScanner.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                {
                    VideoCaptureDevice.Stop();
                }
            }
        }
    }
}
