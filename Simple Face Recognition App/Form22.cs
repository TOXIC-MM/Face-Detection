using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Reflection;

namespace Simple_Face_Recognition_App
{
    public partial class HomePage : Form
    {
        int testid = 0;
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCasacdeClassifier = new CascadeClassifier(@"C:\haarcascades\haarcascade_frontalface_alt_tree.xml");

        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();

        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();

        public HomePage()
        {
            InitializeComponent();
            Load2();
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panel_dashboard, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panel_setting, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panel_layout1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panel_hoverSetting, new object[] { true });
        }
        string usernameLabel;
        bool loaded_dashboard, loaded_database, loaded_settings;

        private void Load2() {
            
            //usernameLabel = "";
            label_hello.Text = "Hello " + usernameLabel + "!";
            loaded_dashboard = true;
            loaded_database = false; loaded_settings = false;
            load_dashboard();
        }

        private void btncap_Click(object sender, EventArgs e)
        {

            if (videoCapture != null) videoCapture.Dispose();
            videoCapture = new Capture();
            Application.Idle += ProcessFrame;;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(piccap.Width, piccap.Height, Inter.Cubic);
                if (facesDetectionEnabled)
                {
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(grayImage, grayImage);
                    Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                    if (faces.Length > 0)
                    {
                        foreach (var face in faces)
                        {
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            pictureboxdet.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureboxdet.Image = resultImage.Bitmap;
                            if (EnableSaveImage)
                            {
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtbox_name.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });
                            }
                            EnableSaveImage = false;
                            if (button_add.InvokeRequired)
                            {
                                button_add.Invoke(new ThreadStart(delegate {
                                    button_add.Enabled = true;
                                }));
                            } 
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                hoverData.Image = grayFaceResult.Bitmap;
                                hoverSetting.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
                        }
                    }
                }
                piccap.Image = currentFrame.Bitmap;
            }
            if (currentFrame != null)
                currentFrame.Dispose();
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MM-PC;Initial Catalog=Face;Integrated Security=True");
            bool isNullOrEmpty = pictureboxdet == null || pictureboxdet.Image == null;
            if (isNullOrEmpty)
            {
                string insertNULL = "Insert into faces(Name,Date)Values('" + txtbox_name.Text + "','" + DateTime.Now + "')";
                con.Open();
                SqlCommand cmd2 = new SqlCommand(insertNULL, con);;
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                EnableSaveImage = true;
                Image img = pictureboxdet.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                string insert = "Insert into faces(Name,Date,Picture)Values('" + txtbox_name.Text + "','" + DateTime.Now + "','" + arr + "' )";
                con.Open();
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btntrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }

        private void btnrec_Click(object sender, EventArgs e)
        {

        }

        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    //Debug.WriteLine(ImagesCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }

        private void load_dashboard() {
            loaded_dashboard = true;loaded_database = false; loaded_settings = false;
            hoverDash.Visible = true; hoverData.Visible = false; hoverSetting.Visible = false;
            this.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.home;
            panel_dashboard.Visible = true;  picbox_timeline.Visible = true;
            label_CamNum.Visible = true; txtbox_name.Visible = true; label_Name.Visible = true;
            panel_setting.Visible = false;
            panel_hoverSetting.Visible = false; label_settingDes.Visible = false;
        }

        private void load_setting() {
            loaded_dashboard = false; loaded_database = false; loaded_settings = true;
            hoverDash.Visible = false; hoverData.Visible = false; hoverSetting.Visible = true;
            panel_dashboard.Visible = false; picbox_timeline.Visible = false;
            label_CamNum.Visible = false; txtbox_name.Visible = false; label_Name.Visible = false;
            this.BackgroundImage = global::Simple_Face_Recognition_App.Properties.Resources.Setting_2;
            panel_setting.Visible = true;
        }

        private void Rbutton_storage1_MouseHover(object sender, EventArgs e)
        {
            label_settingDes.Visible = true; panel_hoverSetting.Visible = true;
        }

        private void Rbutton_storage1_MouseLeave(object sender, EventArgs e)
        {
            label_settingDes.Visible = false; panel_hoverSetting.Visible = false;
        }

        private  void button_openSetting_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:camera");
        }

        private void button_ManageAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Manage_Accounts acc = new Form_Manage_Accounts();
            acc.Show();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(1);
            }
        }

        private void taskbar_dataViewer_Click(object sender, EventArgs e)
        {
            loaded_dashboard = false; loaded_database = true; loaded_settings = false;
            hoverDash.Visible = false; hoverData.Visible = true; hoverSetting.Visible = false;

        }

        private void Taskbar_settings_Click(object sender, EventArgs e)
        {
        
            load_setting();
        }

        private void Taskbar_dashboard_Click(object sender, EventArgs e)
        {
            load_dashboard();
        }




    }
}
