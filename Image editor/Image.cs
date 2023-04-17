using Emgu.CV;
using Emgu.CV.Ocl;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_editor
{
    internal partial class Image
    {
        public Image(Image<Bgr, Byte> img)
        {
            cvImage = img;
        }
        public Image(Image<Gray, Byte> img)
        {
            cvImageGray = img;
        }
        public Image(Image<Hsv, Byte> img)
        {
            cvImageHsv = img;
        }
        public Image(string link)
        {
            cvImage = new Image<Bgr, byte>(link);
        }

        public Emgu.CV.Image<Bgr, Byte> cvImage { get; private set; }
        public Emgu.CV.Image<Gray, Byte> cvImageGray { get; private set; }
        public Emgu.CV.Image<Hsv, Byte> cvImageHsv { get; private set; }


        public UInt16[] red { get; private set; } = new UInt16[256];
        public UInt16[] green { get; private set; } = new UInt16[256];
        public UInt16[] blue { get; private set; } = new UInt16[256];

        public void CalculateHistogram()
        {
            red = new UInt16[256];
            green = new UInt16[256];
            blue = new UInt16[256];
            for (int x = 0; x < cvImage.Width; x++)
            {
                for (int y = 0; y < cvImage.Height; y++)
                {
                    red[cvImage.Data[y, x, 2]]++;
                    green[cvImage.Data[y, x, 1]]++;
                    blue[cvImage.Data[y, x, 0]]++;
                }
            }
        }
        public Image<Bgr, Byte> ToGray()
        {
            return cvImage.Convert<Gray, Byte>().Convert<Bgr, Byte>();
        }
        public Image<Hsv, Byte> ToHsv()
        {
            return cvImage.Convert<Hsv, Byte>();
        }
    }
}
