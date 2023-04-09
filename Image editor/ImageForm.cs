using Emgu.CV;
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

namespace Image_editor
{
    public delegate void AppendLogProc(Image<Bgr, Byte> img);
    public partial class ImageForm : Form
    {
        public DialogResult dialog;
        public ImageForm(Image<Bgr, Byte> image, string name)
        {
            InitializeComponent();
            imageBox1.Image = image;
            this.Size = new Size(image.Width + 16, image.Height + 55);
            ImageInfoLabel.Text = image.Width + " x " + image.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }
        public ImageForm(Image<Gray, Byte> image, string name)
        {
            InitializeComponent();
            imageBox1.Image = image.Convert<Bgr, Byte>();
            this.Size = new Size(image.Width + 16, image.Height + 55);
            ImageInfoLabel.Text = image.Width + " x " + image.Height + " pixels";
            this.Text = $"{name}_B&W";
            this.Activated += ImageForm_Activated;
        }
        public void AddImage(Image<Bgr, Byte> img)
        {
            if (InvokeRequired) Invoke(new AppendLogProc(AddImage), new object[] { img });
            else this.imageBox1.Image = img;
        }

        private void ImageForm_Activated(object sender, EventArgs e)
        {
            ImageStatic.SelectedForm = this;
            ImageStatic.SelectedImage = (Image<Bgr, byte>)imageBox1.Image;
            ImageStatic.Name = this.Text;
        }
    }
}