using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_editor
{
    internal class ImageProcessing
    {
        public ImageProcessing(Image<Bgr, Byte> img)
        {
            cvImage = img;
        }
        public Emgu.CV.Image<Bgr, Byte> cvImage { get; private set; }
        public UInt16[] red { get; private set; } = ImageStorage.red;   
        public UInt16[] green { get; private set; } = ImageStorage.green;
        public UInt16[] blue { get; private set; } = ImageStorage.blue;
        public Image<Bgr, byte> Rozciaganie()
        {
            UInt16[] redLUT = RozciaganieLUT(red);
            UInt16[] greenLUT = RozciaganieLUT(green);
            UInt16[] blueLUT = RozciaganieLUT(blue);

            for (int x = 0; x < cvImage.Width; x++)
            {
                for (int y = 0; y < cvImage.Height; y++)
                {
                    cvImage.Data[y, x, 2] = (byte)redLUT[cvImage.Data[y, x, 2]];
                    cvImage.Data[y, x, 1] = (byte)greenLUT[cvImage.Data[y, x, 1]];
                    cvImage.Data[y, x, 0] = (byte)blueLUT[cvImage.Data[y, x, 0]];
                }
            }
            return cvImage;
        }

        private UInt16[] RozciaganieLUT(UInt16[] values)
        {
            int min = 256;
            for (int i = 0; i < 256; i++)
            {
                if (values[i] != 0)
                {
                    min = i;
                    break;
                }
            }
            int max = 255;
            for (int i = 255; i >= 0; i--)
            {
                if (values[i] != 0)
                {
                    max = i;
                    break;
                }
            }

            UInt16[] result = new UInt16[256];
            double a = 255.0 / (max - min);
            for (int i = 0; i < 256; i++)
            {
                result[i] = (UInt16)(a * (i - min));
            }
            return result;
        }
    }
}
