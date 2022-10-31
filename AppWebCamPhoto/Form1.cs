using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace AppWebCamPhoto
{
    public partial class Form1 : Form
    {

        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void video_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctCapturaImagem.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //código do carregamento (load) do Form
            //lista os dispositivos de captura de imagem do computador/notebook
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cbbDispositivo.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cbbDispositivo.Items.Add(device.Name);
                }
                cbbDispositivo.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cbbDispositivo.Items.Add("Nenhum dispositivo encontrado!");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbbDispositivo.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    //Encerra o sinal da camera.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCapturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum dispositivo encontrado!");
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    //Encerra o sinal da camera.
                    // Note que este bloco de código se repetiu, você pode cirar um método para ele.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            // salva a imagem;
                            sfdSalvarImagem.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*.jfif";
                            DialogResult res = sfdSalvarImagem.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                pctCapturaImagem.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                }
            }
        }
    }
}

