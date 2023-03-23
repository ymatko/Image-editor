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
    public partial class ImageForm : Form
    {
        public ImageForm(string fileName)
        {
            Image<Bgr, Byte>  InputImage = new Image<Bgr, byte>(fileName);
            InitializeComponent();
            imageBox1.Image = InputImage;
            this.Size = new Size(InputImage.Width + 16, InputImage.Height + 55);
            ImageInfoLabel.Text = InputImage.Width + " x " + InputImage.Height;
            //this.Width = imageBox1.Width - 56;
            // this.Height = imageBox1.Height + 22;
        }
    }
}
