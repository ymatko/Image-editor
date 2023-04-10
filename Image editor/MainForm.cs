using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.ML;

namespace Image_editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var newImage = new Image<Bgr, byte>(openFileDialog1.FileName);
                var newImageForm = new ImageForm(newImage, openFileDialog1.SafeFileName);
                newImageForm.dialog = await Task.Run(() => newImageForm.ShowDialog());
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                ImageStatic.SelectedImage.Save(saveFileDialog.FileName);
            }
        }
        private async void tableLUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 124;
            var image = new Image(ImageStatic.SelectedImage);
            image.CalculateHistogram();
            if (image.red[i] == image.green[i] && image.red[i] == image.blue[i])
            {
                var tableLUT = new TableLUT_BW();
                await Task.Run(() => tableLUT.ShowDialog());
            }
            else
            {
                var tableLUT = new TableLUT_RGB();
                await Task.Run(() => tableLUT.ShowDialog());
            }
        }

        private async void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 124;
            var image = new Image(ImageStatic.SelectedImage);
            image.CalculateHistogram();
            if (image.red[i] == image.green[i] && image.red[i] == image.blue[i])
            {
                var histogramForm = new HistogramForm();
                await Task.Run(() => histogramForm.ShowDialog());
            }
            else
            {
                var histogramFormRGB = new HistogramFormRGB();
                await Task.Run(() => histogramFormRGB.ShowDialog());
            }
        }

        public void toMonochromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = new Image(ImageStatic.SelectedImage);
            ImageStatic.SelectedForm.AddImage(image.ToGray());
        }

        private void splitChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStatic.SelectedImage;
            var greenChannel = new ImageForm(image.Sub(new Bgr(255, 0, 255)).Convert<Gray, Byte>(), $"{ImageStatic.Name} Green");
            var redChannel = new ImageForm(image.Sub(new Bgr(255, 255, 0)).Convert<Gray, Byte>(), $"{ImageStatic.Name} Red");
            var blueChannel = new ImageForm(image.Sub(new Bgr(0, 255, 255)).Convert<Gray, Byte>(), $"{ImageStatic.Name} Blue");


            Task.Run(() => blueChannel.ShowDialog());
            Task.Run(() => greenChannel.ShowDialog());
            Task.Run(() => redChannel.ShowDialog());

        }
    }
}