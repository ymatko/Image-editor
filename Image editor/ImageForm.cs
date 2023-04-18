using Emgu.CV;
using Emgu.CV.DepthAI;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Image_editor
{
    public partial class ImageForm: Form
    {
        private dynamic _image;
        public ImageForm()
        {
            InitializeComponent();
        }
        public void LoadImage<T>(string path, string name) where T : struct, IColor
        {
            _image = new Image<T, byte>(path);
            imageBox1.Image = _image;
            this.Size = new Size(_image.Width + 16, _image.Height + 55);
            ImageInfoLabel.Text = _image.Width + " x " + _image.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }
        public void LoadImage(Image<Bgr, byte> bgrImage, string name)
        {
            imageBox1.Image = bgrImage;
            this.Size = new Size(bgrImage.Width + 16, bgrImage.Height + 55);
            ImageInfoLabel.Text = bgrImage.Width + " x " + bgrImage.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }

        public void LoadImage(Image<Hsv, byte> hsvImage, string name)
        {
            imageBox1.Image = hsvImage;
            this.Size = new Size(hsvImage.Width + 16, hsvImage.Height + 55);
            ImageInfoLabel.Text = hsvImage.Width + " x " + hsvImage.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }
        public void LoadImage(Image<Gray, byte> hsvImage, string name)
        {
            imageBox1.Image = hsvImage;
            this.Size = new Size(hsvImage.Width + 16, hsvImage.Height + 55);
            ImageInfoLabel.Text = hsvImage.Width + " x " + hsvImage.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }

        private void ImageForm_Activated(object sender, EventArgs e)
        {
            if (imageBox1.Image is Image<Bgr, byte> bgrImage)
            {
                ImageStorage<Bgr>.Image = bgrImage;
                ImageStorage<Bgr>.Name = this.Text;
            }
            else if (imageBox1.Image is Image<Hsv, byte> hsvImage)
            {
                ImageStorage<Hsv>.Image = hsvImage;
                ImageStorage<Hsv>.Name = this.Text;
            }
            else if (imageBox1.Image is Image<Gray, byte> grayImage)
            {
                ImageStorage<Gray>.Image = grayImage;
                ImageStorage<Gray>.Name = this.Text;
            }
        }
    }
}