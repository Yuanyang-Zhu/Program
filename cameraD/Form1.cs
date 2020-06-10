using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

using Camera_NET;

namespace cameraD
{
    public partial class Form1 : Form
    {
        // Camera choice
        private CameraChoice _CameraChoice = new CameraChoice();
        Bitmap bitmap = null;
        bool bCatchBMP = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill camera list combobox with available cameras
            FillCameraList();

            // Select the first one
            if (comboBoxCameraList.Items.Count > 0)
            {
                comboBoxCameraList.SelectedIndex = 0;
            }

            // Fill camera list combobox with available resolutions
            FillResolutionList();
        }

        private void comboBoxCameraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCameraList.SelectedIndex < 0)
            {
                cameraControl.CloseCamera();
            }
            else
            {
                // Set camera
                SetCamera(_CameraChoice.Devices[comboBoxCameraList.SelectedIndex].Mon, null);
            }

            FillResolutionList();
        }

        private void comboBoxResolutionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cameraControl.CameraCreated)
                return;

            int comboBoxResolutionIndex = comboBoxResolutionList.SelectedIndex;
            if (comboBoxResolutionIndex < 0)
            {
                return;
            }
            ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);

            if (resolutions == null)
                return;

            if (comboBoxResolutionIndex >= resolutions.Count)
                return; // throw

            if (0 == resolutions[comboBoxResolutionIndex].CompareTo(cameraControl.Resolution))
            {
                // this resolution is already selected
                return;
            }

            // Recreate camera
            SetCamera(cameraControl.Moniker, resolutions[comboBoxResolutionIndex]);
        }

        #region Camera creation and destroy

        // Set current camera to camera_device
        private void SetCamera(IMoniker camera_moniker, Resolution resolution)
        {
            try
            {
                // NOTE: You can debug with DirectShow logging:
                //cameraControl.DirectShowLogFilepath = @"C:\YOUR\LOG\PATH.txt";

                // Makes all magic with camera and DirectShow graph
                cameraControl.SetCamera(camera_moniker, resolution);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error while running camera");
            }

            if (!cameraControl.CameraCreated)
                return;
            // If you are using Direct3D surface overlay
            // (see documentation about rebuild of library for it)
            //cameraControl.UseGDI = false;

            cameraControl.MixerEnabled = true;

            //cameraControl.OutputVideoSizeChanged += Camera_OutputVideoSizeChanged;

            //UpdateCameraBitmap();


            // gui update
           // UpdateGUIButtons();
        }

        #endregion

        private void FillResolutionList()
        {
            comboBoxResolutionList.Items.Clear();

            if (!cameraControl.CameraCreated)
                return;

            ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);

            if (resolutions == null)
                return;

            int index_to_select = -1;

            for (int index = 0; index < resolutions.Count; index++)
            {
                comboBoxResolutionList.Items.Add(resolutions[index].ToString());

                if (resolutions[index].CompareTo(cameraControl.Resolution) == 0)
                {
                    index_to_select = index;
                }
            }

            // select current resolution
            if (index_to_select >= 0)
            {
                comboBoxResolutionList.SelectedIndex = index_to_select;
            }
        }

        private void FillCameraList()
        {
            comboBoxCameraList.Items.Clear();

            _CameraChoice.UpdateDeviceList();

            foreach (var camera_device in _CameraChoice.Devices)
            {
                comboBoxCameraList.Items.Add(camera_device.Name);
            }
        }

        private void buttonCameraSettings_Click(object sender, EventArgs e)
        {
            if (cameraControl.CameraCreated)
            {
                Camera.DisplayPropertyPage_Device(cameraControl.Moniker, this.Handle);
            }
        }

        private void buttonSnapshotNextSourceFrame_Click(object sender, EventArgs e)
        {
            if (!cameraControl.CameraCreated)
                return;

            bitmap = null;
            try
            {
                bitmap = cameraControl.SnapshotSourceImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error while getting a snapshot");
            }

            if (bitmap == null)
                return;

            bCatchBMP = true;

            int px = bitmap.Width / 2;
            int py = bitmap.Height / 2;
            Color color;
            double iRed = 0, iGreen = 0, iBlue = 0;
            for (int i = px - 10; i < px + 10; i++)
            {
                for (int j = py - 10; j < py + 10; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    iRed += color.R;
                    iGreen += color.G;
                    iBlue += color.B;
                }
            }
            iRed /= 400; iGreen /= 400; iBlue /= 400;
            txb_Red.Text = iRed.ToString("f2");
            txb_Green.Text = iGreen.ToString("f2");
            txb_Blue.Text = iBlue.ToString("f2");

            double fL1=0, fA1=0, fB1=0;
            RGB2Lab(iRed, iGreen, iBlue, out fL1, out fA1, out fB1);

            txb_L.Text = fL1.ToString("f2");
            txb_a.Text = fA1.ToString("f2");
            txb_b.Text = fB1.ToString("f2");
            pictureBoxScreenshot.Image = bitmap;
            pictureBoxScreenshot.Update();
        }

        private Bitmap overLapRec()
        {
            int w = cameraControl.OutputVideoSize.Width;
            int h = cameraControl.OutputVideoSize.Height;

            if (w <= 0 || h <= 0)
                return null;

            // Create RGB bitmap
            Bitmap bmp = new Bitmap(w, h, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.None;
            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

            // Clear the bitmap with the color key
            g.Clear(cameraControl.GDIColorKey);

            // Draw selection rect --------------------------
            Color color_of_pen = Color.Green;
            Pen pen = new Pen(color_of_pen, 2.0f);
            Rectangle rect = new Rectangle((int)(w/2-25), (int)(h/2-25), 50, 50);
            g.DrawRectangle(pen, rect);
            pen.Dispose();
            // dispose Graphics
            g.Dispose();
            // return the bitmap
            return bmp;
        }

        private void buttonMixerOnOff_Click(object sender, EventArgs e)
        {
            cameraControl.MixerEnabled = !cameraControl.MixerEnabled;
            if (!cameraControl.MixerEnabled)
                return;

            cameraControl.OverlayBitmap = overLapRec();
        }

        private void buttonSaveBMP_Click(object sender, EventArgs e)
        {
            if (!bCatchBMP)
            {
                MessageBox.Show("Please get a frame first!", "Message");
                return;
            }
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.InitialDirectory = "d:\\bmpdata";
            //设置文件类型
            savefiledialog.Filter = "BMP图像文件|*.bmp";
            //saveFileDialog1.FilterIndex = 1;//设置文件类型显示
           // saveFileDialog1.FileName = "自己取个";//设置默认文件名
            savefiledialog.RestoreDirectory = true;//保存对话框是否记忆上次打开的目录
            savefiledialog.CheckPathExists = true;//检查目录
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                string strSaveFileLocation = savefiledialog.FileName;//文件路径
                bitmap.Save(strSaveFileLocation, System.Drawing.Imaging.ImageFormat.Bmp);
            }       
        }

        private void RGB2Lab(double iR, double iG, double iB, out double fL1, out double fA1, out double fB1)  //转换ＲＧＢ为空白的ＬＡＢ
        {
            double X, Y, Z, fX, fY, fZ;
            //double fL1 = 0, fA1 = 0, fB1 = 0;

            X = 0.412453 * iR + 0.357580 * iG + 0.180423 * iB;
            Y = 0.212671 * iR + 0.715160 * iG + 0.072169 * iB;
            Z = 0.019334 * iR + 0.119193 * iG + 0.950227 * iB;

            X /= (255 * 0.950456);
            Y /= 255;
            Z /= (255 * 1.088754);

            if (Y > 0.008856)
            {
                fY = Math.Pow(Y, 1.0 / 3.0);
                fL1 = 116.0 * fY - 16.0;
            }
            else
            {
                fY = 7.787 * Y + 16.0 / 116.0;
                fL1 = 903.3 * fY;
            }

            if (X > 0.008856) fX = Math.Pow(X, 1.0 / 3.0);
            else fX = 7.787 * X + 16.0 / 116.0;

            if (Z > 0.008856) fZ = Math.Pow(Z, 1.0 / 3.0);
            else fZ = 7.787 * Z + 16.0 / 116.0;

            fA1 = 500.0 * (fX - fY); fB1 = 200.0 * (fY - fZ);
        }
    }
}
