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
                var image = new Image<Bgr, byte>(openFileDialog1.FileName);
                var form = new ImageForm(image, openFileDialog1.SafeFileName);
                await Task.Run(() => form.ShowDialog());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                if (ImageStorage.Type == 2)
                {
                    var image = ImageStorage.ConvertToHsv();
                    image.Save(saveFileDialog.FileName);
                }
                else if(ImageStorage.Type == 3)
                {
                    var image = ImageStorage.ConvertToGray();
                    image.Save(saveFileDialog.FileName);
                }
                else if (ImageStorage.Type == 4)
                {
                    var image = ImageStorage.ConvertToLab();
                    image.Save(saveFileDialog.FileName);
                }
                else if (ImageStorage.Type != 2 && ImageStorage.Type != 3)
                {
                    var image = ImageStorage.ConvertToBgr();
                    image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void toMonochromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.ConvertToGray();
            ImageStorage.Form.AddImage(image);
        }

        private void rGBToHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.ConvertToHsv();
            ImageStorage.Form.AddImage(image);
        }
        private void rGBToLABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.ConvertToLab();
            ImageStorage.Form.AddImage(image);
        }

        private void toRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.ConvertToBgr();
            ImageStorage.Form.AddImage(image);
        }

        private void splitChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic image = ImageStorage.ConvertToBgr();
            if (ImageStorage.Type == 1)
            {
                image = ImageStorage.ConvertToBgr();
            }
            else if (ImageStorage.Type == 2)
            {
                image = ImageStorage.ConvertToHsv();
            }
            else if (ImageStorage.Type == 3)
            {
                image = ImageStorage.ConvertToGray();
            }
            else if (ImageStorage.Type == 4)
            {
                image = ImageStorage.ConvertToLab();
            }

            var channels = image.Split();

            var formBlue = new ImageForm(channels[0], $"{ImageStorage.Name}_BlueChannel");
            var formRed = new ImageForm(channels[2], $"{ImageStorage.Name}_RedChannel");
            var formGreen = new ImageForm(channels[1], $"{ImageStorage.Name}_GreenChannel");

            _ = Task.Run(() => formRed.ShowDialog());
            _ = Task.Run(() => formGreen.ShowDialog());
            _ = Task.Run(() => formBlue.ShowDialog());
        }

        private async void histogramTableGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TableLUT_BW();
            await Task.Run(() => form.ShowDialog());
        }

        private async void tableLUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TableLUT_RGB();
            await Task.Run(() => form.ShowDialog());
        }

        private async void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HistogramForm();
            await Task.Run(() => form.ShowDialog());
        }

        private async void histogramRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HistogramFormRGB();
            await Task.Run(() => form.ShowDialog());
        }

    }
}