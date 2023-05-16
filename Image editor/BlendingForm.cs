using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_editor
{
    public partial class BlendingForm : Form
    {
        public BlendingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ImageStorage.ValueImageProcessing1 = trackBar1.Value * 0.01;
            //ImageStorage.ValueImageProcessing2 = trackBar1.Value * 0.01; 
            //ImageStorage.ValueImageProcessing3 = trackBar1.Value * 0.01;
            Image<Bgr, byte> secondimage = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
                secondimage = new Image<Bgr, byte>(ofd.FileName);
                var image = ImageStorage.ConvertToBgr();
                secondimage = secondimage.Resize(image.Width, image.Height, Emgu.CV.CvEnum.Inter.Nearest);
                var blendedImage = new Image<Bgr, byte>(image.Size);
                double alpha = trackBar1.Value * 0.01; // Weight for the first image
                double beta = trackBar2.Value * 0.01; // Weight for the second image
                double gamma = trackBar3.Value * 0.01; // Scalar added to each sum
                CvInvoke.AddWeighted(image, alpha, secondimage, beta, gamma, blendedImage);
                var form = new ImageForm(blendedImage, $"{ImageStorage.Name} blended {ofd.SafeFileName}");
                Task.Run(() => form.ShowDialog());
            
            this.Close();
        }
    }
}
