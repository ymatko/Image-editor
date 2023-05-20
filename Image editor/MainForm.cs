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
using ScottPlot.Drawing.Colormaps;
using ScottPlot.Palettes;

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
            openFileDialog1.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageStorage.Type = 1;
                var image = new Image<Bgr, byte>(openFileDialog1.FileName);
                var form = new ImageForm(image, openFileDialog1.SafeFileName);
                await Task.Run(() => form.ShowDialog());
            }
        }
        int number;
        private async void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           number++;
           var form = new ImageForm(ImageStorage.Image, $"{ImageStorage.Name}_{number}");
            await Task.Run(() => form.ShowDialog());
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

            var channels = image.Split();

            var formBlue = new ImageForm(channels[0], $"{ImageStorage.Name}_H Channel");
            var formRed = new ImageForm(channels[2], $"{ImageStorage.Name}_S Channel");
            var formGreen = new ImageForm(channels[1], $"{ImageStorage.Name}_V Channel");

            _ = Task.Run(() => formRed.ShowDialog());
            _ = Task.Run(() => formGreen.ShowDialog());
            _ = Task.Run(() => formBlue.ShowDialog());
        }
        private void rGBToLABToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.ConvertToLab();
            ImageStorage.Form.AddImage(image);

            var channels = image.Split();

            var formBlue = new ImageForm(channels[0], $"{ImageStorage.Name}_L Channel");
            var formRed = new ImageForm(channels[2], $"{ImageStorage.Name}_A Channel");
            var formGreen = new ImageForm(channels[1], $"{ImageStorage.Name}_B Channel");

            _ = Task.Run(() => formRed.ShowDialog());
            _ = Task.Run(() => formGreen.ShowDialog());
            _ = Task.Run(() => formBlue.ShowDialog());
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

        private async void plotProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PlotProfileForm();
            await Task.Run(() => form.ShowDialog());
        }

        private void stretchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.Stretching();
            ImageStorage.Form.AddImage(image);
        }

        private void negationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.Negation();
            ImageStorage.Form.AddImage(image);
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var image = ImageStorage.Equalization();
            ImageStorage.Form.AddImage(image);
        }

        private void posterizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectValueForm = new SelectValueForm();
            selectValueForm.ShowDialog();
            var image = ImageStorage.Posterization();
            ImageStorage.Form.AddImage(image);
        }

        private void selectiveStretchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectValueForm = new Select4ValueForm();
            selectValueForm.ShowDialog();
            var image = ImageStorage.SelectiveStretching();
            ImageStorage.Form.AddImage(image);
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectValueForm = new SelectValueForm();
            selectValueForm.ShowDialog();
            var image = ImageStorage.Blur();
            ImageStorage.Form.AddImage(image);
        }

        private void sobelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.Sobel1();
            var image2 = ImageStorage.Sobel2();

            var sobel1 = new ImageForm(image, $"{ImageStorage.Name}_Sobel1");
            var sobel2 = new ImageForm(image2, $"{ImageStorage.Name}_Sobel2");

            _ = Task.Run(() => sobel1.ShowDialog());
            _ = Task.Run(() => sobel2.ShowDialog());
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.ConvertToBgr();
            image.ConvertFrom(image.Laplace(3));
            ImageStorage.Form.AddImage(image);
        }

        private void cannyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> image = ImageStorage.ConvertToBgr().Copy().Convert<Gray, byte>();
            CvInvoke.Canny(ImageStorage.ConvertToBgr(), image, 100, 200, 3);
            ImageStorage.ConvertToBgr().ConvertFrom(image);
            ImageStorage.Form.AddImage(image);
        }

        private void kernelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MatrixKernel();
            form.ShowDialog();
            var image = ImageStorage.ConvertToBgr();
            ConvolutionKernelF matrixKernel = new ConvolutionKernelF(ImageStorage.Matrix3);
            CvInvoke.Filter2D(image, image, matrixKernel, new Point(-1, -1), borderType: ImageStorage.BorderType);
            ImageStorage.Form.AddImage(image);
        }

        private void medianFiltrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MedianBlurForm();
            form.ShowDialog();
            var image = ImageStorage.ConvertToBgr();
            CvInvoke.MedianBlur(image, image, (int)ImageStorage.ValueImageProcessing1);
            ImageStorage.Form.AddImage(image);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> secondimage = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                secondimage = new Image<Bgr, byte>(openFileDialog1.FileName);
                var image = ImageStorage.ConvertToBgr();
                secondimage = secondimage.Resize(image.Width, image.Height, Emgu.CV.CvEnum.Inter.Nearest);
                CvInvoke.Add(image, secondimage, secondimage);
                var form = new ImageForm(secondimage, $"{ImageStorage.Name} + {openFileDialog1.SafeFileName}");
                Task.Run(() => form.ShowDialog());
            }
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> secondimage = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                secondimage = new Image<Bgr, byte>(openFileDialog1.FileName);
                var image = ImageStorage.ConvertToBgr();
                secondimage = secondimage.Resize(image.Width, image.Height, Emgu.CV.CvEnum.Inter.Nearest);
                secondimage = image.Sub(secondimage);
                var form = new ImageForm(secondimage, $"{ImageStorage.Name} - {openFileDialog1.SafeFileName}");
                Task.Run(() => form.ShowDialog());
            }
        }

        private async void blendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> secondimage = null;
            var form1 = new BlendingForm();
            await Task.Run(() => form1.ShowDialog());
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                secondimage = new Image<Bgr, byte>(openFileDialog1.FileName);
                var image = ImageStorage.ConvertToBgr();
                secondimage = secondimage.Resize(image.Width, image.Height, Emgu.CV.CvEnum.Inter.Nearest);
                var blendedImage = new Image<Bgr, byte>(image.Size);
                double alpha = ImageStorage.ValueImageProcessing1; // Weight for the first image
                double beta = ImageStorage.ValueImageProcessing2; // Weight for the second image
                double gamma = ImageStorage.ValueImageProcessing3; // Scalar added to each sum
                CvInvoke.AddWeighted(image, alpha, secondimage, beta, gamma, blendedImage);
                var form = new ImageForm(blendedImage, $"{ImageStorage.Name} blended {openFileDialog1.SafeFileName}");
                await Task.Run(() => form.ShowDialog());
            }
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.BgrToBinary();
            Image<Bgr, byte> img = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(openFileDialog1.FileName);
                var secondimage = img.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));
                secondimage = secondimage.Resize(image.Width, image.Height, Emgu.CV.CvEnum.Inter.Nearest);

                CvInvoke.BitwiseAnd(image, secondimage, image);
                secondimage.ConvertFrom(image);

                var form = new ImageForm(secondimage, $"{ImageStorage.Name} AND {openFileDialog1.SafeFileName}");
                Task.Run(() => form.ShowDialog());
            }
        }

        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.BgrToBinary();
            Image<Bgr, byte> img = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(openFileDialog1.FileName);
                var secondimage = img.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));
                secondimage = secondimage.Resize(image.Width, image.Height, Emgu.CV.CvEnum.Inter.Nearest);

                CvInvoke.BitwiseOr(image, secondimage, image);
                secondimage.ConvertFrom(image);

                var form = new ImageForm(secondimage, $"{ImageStorage.Name} OR {openFileDialog1.SafeFileName}");
                Task.Run(() => form.ShowDialog());
            }
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage.BgrToBinary();
            Image<Bgr, byte> img = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(openFileDialog1.FileName);
                var secondimage = img.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));
                secondimage = secondimage.Resize(image.Width, image.Height, Emgu.CV.CvEnum.Inter.Nearest);

                CvInvoke.BitwiseXor(image, secondimage, image);
                secondimage.ConvertFrom(image);

                var form = new ImageForm(secondimage, $"{ImageStorage.Name} AND {openFileDialog1.SafeFileName}");
                Task.Run(() => form.ShowDialog());
            }
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MorphologyForm();
            form.ShowDialog();
            ImageStorage.MorphologyErode();
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MorphologyForm();
            form.ShowDialog();
            ImageStorage.MorphologyDilate();
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MorphologyForm();
            form.ShowDialog();
            ImageStorage.ValueImageProcessing2 = 2;
            ImageStorage.OpenAndClose();
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MorphologyForm();
            form.ShowDialog();
            ImageStorage.ValueImageProcessing2 = 3;
            ImageStorage.OpenAndClose();
        }

        private void scletonizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageStorage.Skeletonization();
        }
    }
}