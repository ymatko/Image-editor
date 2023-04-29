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
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Image_editor
{
    public delegate void AppendLogProc(dynamic img);
    public partial class ImageForm: Form
    {
        public DialogResult dialog;
        public ImageForm(Image<Bgr, byte> img, string name)
        {
            InitializeComponent();
            imageBox1.Image = img;
            this.Size = new Size(img.Width + 16, img.Height + 55);
            ImageInfoLabel.Text = img.Width + " x " + img.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }
        public ImageForm(Image<Hsv, byte> img, string name)
        {
            InitializeComponent();
            imageBox1.Image = img;
            this.Size = new Size(img.Width + 16, img.Height + 55);
            ImageInfoLabel.Text = img.Width + " x " + img.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }
        public ImageForm(Image<Gray, byte> img, string name)
        {
            InitializeComponent();
            imageBox1.Image = img;
            this.Size = new Size(img.Width + 16, img.Height + 55);
            ImageInfoLabel.Text = img.Width + " x " + img.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }
        public ImageForm(Image<Lab, byte> img, string name)
        {
            InitializeComponent();
            imageBox1.Image = img;
            this.Size = new Size(img.Width + 16, img.Height + 55);
            ImageInfoLabel.Text = img.Width + " x " + img.Height + " pixels";
            this.Text = name;
            this.Activated += ImageForm_Activated;
        }
        public void AddImage(dynamic img)
        {
            if (InvokeRequired) Invoke(new AppendLogProc(AddImage), new object[] { img });
            else this.imageBox1.Image = img;
        }

        private void ImageForm_Activated(object sender, EventArgs e)
        {
            ImageStorage.Form = this;
            ImageStorage.Image = imageBox1.Image;
            ImageStorage.Name = this.Text;
        }
        private void imageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var point = new Point(e.Location.X, e.Location.Y);
            ImageStorage.Points.Add(point);
        }
    }
}