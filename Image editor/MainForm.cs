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
            openFileDialog1.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var form = new ImageForm();
                form.LoadImage<Bgr>(openFileDialog1.FileName, openFileDialog1.SafeFileName);
                await Task.Run(() => form.ShowDialog());

            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                if(ImageStorage<Bgr>.ImageType == typeof(Bgr))
{
                    ImageStorage<Bgr>.Image.Save(saveFileDialog.FileName);
                }
                else if (ImageStorage<Hsv>.ImageType == typeof(Hsv))
                {
                    ImageStorage<Hsv>.Image.Save(saveFileDialog.FileName);
                }
                else if (ImageStorage<Gray>.ImageType == typeof(Gray))
                {
                    ImageStorage<Gray>.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private async void toMonochromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImageStorage<Bgr>.ImageType == typeof(Bgr))
            {
                var form = new ImageForm();
                var image = ImageStorage<Bgr>.Image.Convert<Gray, byte>();
                form.LoadImage(image, $"{ ImageStorage<Bgr>.Name}_Gray");
                await Task.Run(() => form.ShowDialog());
            }
            else if (ImageStorage<Hsv>.ImageType == typeof(Hsv))
            {
                var form = new ImageForm();
                var image = ImageStorage<Hsv>.Image.Convert<Gray, byte>();
                form.LoadImage(image, $"{ImageStorage<Hsv>.Name}_Gray");
                await Task.Run(() => form.ShowDialog());
            }
        }

        private async void splitChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var image = ImageStorage<Bgr>.Image;
            var channels = image.Split();

            var formRed = new ImageForm();
            formRed.LoadImage(channels[2], $"{ImageStorage<Bgr>.Name}_RedChannel");

            var formGreen = new ImageForm();
            formGreen.LoadImage(channels[1], $"{ImageStorage<Bgr>.Name}_GreenChannel"); 

            var formBlue = new ImageForm();
            formBlue.LoadImage(channels[0], $"{ImageStorage<Bgr>.Name}_BlueChannel");

            _ = Task.Run(() => formRed.ShowDialog());
            _ = Task.Run(() => formGreen.ShowDialog());
            _ = Task.Run(() => formBlue.ShowDialog());
        }
    }
}