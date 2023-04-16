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

        private void toMonochromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStatic.SelectedImageBgr;
            ImageStatic.SelectedForm.AddImage(image.Convert<Gray, Byte>());
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

        private void toRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                ImageStatic.SelectedImageBgr.Save(saveFileDialog.FileName);
            }
        }

        private void toGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                ImageStatic.SelectedImageGray.Save(saveFileDialog.FileName);
            }
        }

        private void toHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                ImageStatic.SelectedImageHsv.Save(saveFileDialog.FileName);
            }
        }

        private void splitChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStatic.SelectedImageBgr;
            var greenChannel = new ImageForm(image.Sub(new Bgr(255, 0, 255)).Convert<Gray, Byte>(), $"{ImageStatic.Name} Green");
            var redChannel = new ImageForm(image.Sub(new Bgr(255, 255, 0)).Convert<Gray, Byte>(), $"{ImageStatic.Name} Red");
            var blueChannel = new ImageForm(image.Sub(new Bgr(0, 255, 255)).Convert<Gray, Byte>(), $"{ImageStatic.Name} Blue");


            Task.Run(() => blueChannel.ShowDialog());
            Task.Run(() => greenChannel.ShowDialog());
            Task.Run(() => redChannel.ShowDialog());
        }

        private async void rGBToHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStatic.SelectedImageBgr.Convert<Hsv, Byte>();
            var formImage = new ImageForm(image, openFileDialog1.SafeFileName);

            await Task.Run(() => formImage.ShowDialog());
        }

        private async void histogramTableGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = new Image(ImageStatic.SelectedImageGray);
            image.CalculateHistogram();
            var tableLUT = new TableLUT_BW();
            await Task.Run(() => tableLUT.ShowDialog());
        }
    }
}