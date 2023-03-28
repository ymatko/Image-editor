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
        Image<Bgr, byte> InputImage;
        public ImageForm(OpenFileDialog openFileDialog)
        {
            InitializeComponent();
            InputImage = new Image<Bgr, byte>(openFileDialog.FileName);
            imageBox1.Image = InputImage;
            this.Size = new Size(InputImage.Width + 16, InputImage.Height + 55);
            ImageInfoLabel.Text = InputImage.Width + " x " + InputImage.Height + " pixels";
            this.Text = openFileDialog.SafeFileName;
            this.Activated += ImageForm_Activated;
        }
        private void ImageForm_Activated(object sender, EventArgs e)
        {
            ImageStatic.SelectedImage = InputImage;
        }
    }
}