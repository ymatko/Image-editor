using Emgu.CV;
using Emgu.CV.Aruco;
using Emgu.CV.CvEnum;
using Emgu.CV.ImgHash;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using ScottPlot.Drawing.Colormaps;
using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Image_editor
{
    internal static class ImageStorage
    {
        public static dynamic Image { get; set; }
        public static double ValueImageProcessing1 { get; set; }
        public static double ValueImageProcessing2 { get; set; }
        public static double ValueImageProcessing3 { get; set; }
        public static double ValueImageProcessing4 { get; set; }

        public static float[,] Matrix3 = new float[3, 3];
        public static BorderType BorderType { get; set; }

        public static ImageForm Form { get; set; }
        public static List<Point> Points { get; } = new List<Point>();
        public static int Type { get; set; }
        // 1 - Bgr
        // 2 - Hsv
        // 3 - Gray
        // 4 - Lab
        public static string Name { get; set; }
        public static Image<Bgr, byte> ConvertToBgr()
        {
            Type = 1;
            return Image.Convert<Bgr, byte>();
        }
        public static Image<Hsv, byte> ConvertToHsv()
        {
            Type = 2;
            return Image.Convert<Hsv, byte>();
        }
        public static Image<Bgr, byte> ConvertToGray()
        {
            Type = 3;
            return Image.Convert<Gray, byte>().Convert<Bgr, byte>();
        }
        public static Image<Lab, byte> ConvertToLab()
        {
            Type = 4;
            return Image.Convert<Lab, byte>();
        }
        public static UInt16[] red { get; private set; } = new UInt16[256];
        public static UInt16[] green { get; private set; } = new UInt16[256];
        public static UInt16[] blue { get; private set; } = new UInt16[256];

        public static void CalculateHistogram()
        {
            dynamic image = Image;
            if (Type == 1)
            {
                image = ConvertToBgr();
            }
            else if (Type == 2)
            {
                image = ConvertToHsv();
            }
            else if (Type == 3)
            {
                image = ConvertToGray();
            }
            else if (Type == 4)
            {
                image = ConvertToLab();
            }

            red = new UInt16[256];
            green = new UInt16[256];
            blue = new UInt16[256];
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    red[image.Data[y, x, 2]]++;
                    green[image.Data[y, x, 1]]++;
                    blue[image.Data[y, x, 0]]++;
                }
            }
        }
        public static Image<Bgr, byte> Stretching()
        {
            var img = Image.Convert<Bgr, byte>();
            CalculateHistogram();
            UInt16[] redLUT = StretchingLUT(red);
            UInt16[] greenLUT = StretchingLUT(green);
            UInt16[] blueLUT = StretchingLUT(blue);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    img.Data[y, x, 2] = (byte)redLUT[img.Data[y, x, 2]];
                    img.Data[y, x, 1] = (byte)greenLUT[img.Data[y, x, 1]];
                    img.Data[y, x, 0] = (byte)blueLUT[img.Data[y, x, 0]];
                }
            }
            return img;
        }

        private static UInt16[] StretchingLUT(UInt16[] values)
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

        public static Image<Bgr, byte> Negation()
        {
            var img = Image.Convert<Bgr, byte>();
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    img.Data[y, x, 2] = (byte)(255 - img.Data[y, x, 2]);
                    img.Data[y, x, 1] = (byte)(255 - img.Data[y, x, 1]);
                    img.Data[y, x, 0] = (byte)(255 - img.Data[y, x, 0]);
                }
            }
            return img;
        }
        public static Image<Gray, byte> Equalization()
        {
            Image<Gray, byte> img = Image.Convert<Gray, byte>();
            var hist = new int[256];
            for (int i = 0; i < img.Rows; i++)
            {
                for (int j = 0; j < img.Cols; j++)
                {
                    hist[(int)img[i, j].Intensity]++;
                }
            }

            var cumHist = new int[256];
            cumHist[0] = hist[0];
            for (int i = 1; i < 256; i++)
            {
                cumHist[i] = cumHist[i - 1] + hist[i];
            }

            var transform = new int[256];
            for (int i = 0; i < 256; i++)
            {
                transform[i] = (int)((cumHist[i] / (double)(img.Rows * img.Cols)) * 255 + 0.5);
            }

            for (int i = 0; i < img.Rows; i++)
            {
                for (int j = 0; j < img.Cols; j++)
                {
                    var intensity = img[i, j].Intensity;
                    img[i, j] = new Gray(transform[(int)intensity]);
                }
            }
            return img;
        }

        public static Image<Bgr, byte> Posterization()
        {
            Image<Bgr, byte> img = Image.Convert<Bgr, byte>();
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int g = 255 / ((int)ValueImageProcessing1);
                    img.Data[y, x, 2] = (byte)(Math.Floor((double)img.Data[y, x, 2] / g) * g);
                    img.Data[y, x, 1] = (byte)(Math.Floor((double)img.Data[y, x, 1] / g) * g);
                    img.Data[y, x, 0] = (byte)(Math.Floor((double)img.Data[y, x, 0] / g) * g);
                }
            }
            ValueImageProcessing1 = 0;
            return img;
        }
        public static Image<Bgr, byte> SelectiveStretching()
        {
            Image<Bgr, byte> img = Image.Convert<Bgr, byte>();
            float minb = (int)ValueImageProcessing1;
            float maxb = (int)ValueImageProcessing2;
            float mine = (int)ValueImageProcessing3;
            float maxe = (int)ValueImageProcessing4;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    img.Data[y, x, 2] = (byte)(mine + ((float)img.Data[y, x, 2] - minb) * (maxe - mine) / (maxb - mine));
                    img.Data[y, x, 1] = (byte)(mine + ((float)img.Data[y, x, 1] - minb) * (maxe - mine) / (maxb - mine));
                    img.Data[y, x, 0] = (byte)(mine + ((float)img.Data[y, x, 0] - minb) * (maxe - mine) / (maxb - mine));
                }
            }
            ValueImageProcessing1 = 0;
            ValueImageProcessing2 = 0;
            ValueImageProcessing3 = 0;
            ValueImageProcessing4 = 0;
            return img;
        }
        public static Image<Bgr, byte> Blur()
        {
            Image<Bgr, byte> img = Image.Convert<Bgr, byte>();
            img = img.SmoothBlur((int)ValueImageProcessing1, (int)ValueImageProcessing1);
            return img;
        }
        public static Image<Bgr, byte> Sobel1()
        {
            Image<Gray, float> img = Image.Convert<Gray, float>();
            CvInvoke.Sobel(img, img, Emgu.CV.CvEnum.DepthType.Cv32F, 1, 0, 5);
            return img.Convert<Bgr, byte>();
        }
        public static Image<Bgr, byte> Sobel2()
        {
            Image<Gray, float> img = Image.Convert<Gray, float>();
            CvInvoke.Sobel(img, img, Emgu.CV.CvEnum.DepthType.Cv32F, 0, 1, 5);
            return img.Convert<Bgr, byte>();
        }
        public static Image<Gray, byte> BgrToBinary()
        {
            return Image.Convert<Gray, byte>().ThresholdBinary(new Gray(127), new Gray(255));
        }
        public static void MorphologyErode()
        {
            var image = BgrToBinary();
            Mat elem;
            if (ValueImageProcessing1 == 1)
            {
                elem = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(1, 1));
            }
            else
            {
                elem = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
            }
            CvInvoke.Erode(image, image, elem, new Point(-1, -1), 1, BorderType, new MCvScalar(0.0));
            Form.AddImage(image);
        }
        public static void MorphologyDilate()
        {
            var image = BgrToBinary();
            Mat elem;
            if (ValueImageProcessing1 == 1)
            {
                elem = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(1, 1));
            }
            else
            {
                elem = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
            }
            CvInvoke.Dilate(image, image, elem, new Point(-1, -1), 1, BorderType, new MCvScalar(0.0));
            Form.AddImage(image);
        }
        public static void OpenAndClose()
        {
            //ValueImageProcessing2 = 2 / Open
            //ValueImageProcessing2 = 3 / Close
            var image = BgrToBinary();
            Mat elem;
            if (ValueImageProcessing1 == 1)
            {
                elem = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(3, 3), new Point(1, 1));
            }
            else
            {
                elem = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
            }
            CvInvoke.MorphologyEx(image, image, (MorphOp)ValueImageProcessing2, elem, new Point(-1, -1), 1, BorderType, new MCvScalar(0.0));
            Form.AddImage(image);
        }
        public static void Skeletonization()
        {
            Image<Gray, Byte> orig = BgrToBinary();
            Image<Gray, Byte> open = orig.Copy();
            Image<Gray, Byte> temp = orig.Copy();
            Image<Gray, Byte> eroded = orig.Copy();
            Image<Gray, Byte> skel = new Image<Gray, Byte>(orig.Width, orig.Height, new Gray(0));
            Mat elem = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(1, 1));
            Emgu.CV.CvEnum.BorderType btype = Emgu.CV.CvEnum.BorderType.Default;
            while (true)
            {
                CvInvoke.MorphologyEx(orig, open, Emgu.CV.CvEnum.MorphOp.Open, elem, new Point(-1, -1), 1, btype, new MCvScalar(0.0));
                CvInvoke.Subtract(orig, open, temp);
                CvInvoke.Erode(orig, eroded, elem, new Point(-1, -1), 1, btype, new MCvScalar(0.0));
                CvInvoke.BitwiseOr(skel, temp, skel);
                orig = eroded.Copy();

                if (CvInvoke.CountNonZero(orig) == 0)
                    break;
            }
            Form.AddImage(skel);
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach(ImageCodecInfo codec in codecs)
            {
                if(codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        public static void CompressImage(string fileName)
        {
            var image = ConvertToBgr();

            using (Bitmap myBitmap = image.ToBitmap<Bgr, byte>())
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                var myEncoder = System.Drawing.Imaging.Encoder.Quality;
                var myEncoderParameters = new EncoderParameters(1);
                var myEncoderParameter = new EncoderParameter(myEncoder, (int)ValueImageProcessing1);
                myEncoderParameters.Param[0] = myEncoderParameter;
                myBitmap.Save(fileName, jpgEncoder, myEncoderParameters);
            }
        }
        public static void LineDetection()
        {
            Image<Gray, byte> image = Image.Convert<Gray, byte>();
            LineSegment2D[][] lineSegment2D = image.HoughLines(50, 120, 2, Math.PI / 180, 100, 100, 5);
            for (int i = 0; i < lineSegment2D.Length; i++)
            {
                for (int j = 0; j < lineSegment2D[i].Length; j++)
                {
                    LineSegment2D lineSegment = lineSegment2D[i][j];
                    Point point1 = lineSegment.P1;
                    Point point2 = lineSegment.P2;
                    CvInvoke.Line(image, point1, point2, new Bgr(Color.Red).MCvScalar, 2);
                }
            }
            Form.AddImage(image);
        }

        internal static void CalculateHistogram2D()
        {
            //var image = ConvertToBgr();

            //var formBlue = new ImageForm(image.Sub(new Bgr(0, 255, 255)), $"{Name}_BlueChannel");
            //var formRed = new ImageForm(image.Sub(new Bgr(255, 255, 0)), $"{Name}_RedChannel");
            //var formGreen = new ImageForm(image.Sub(new Bgr(255, 0, 255)), $"{Name}_GreenChannel");

            //_ = Task.Run(() => formRed.ShowDialog());
            //_ = Task.Run(() => formGreen.ShowDialog());
            //_ = Task.Run(() => formBlue.ShowDialog());
            var form = new Hist2DForm();
            Task.Run(() => form.ShowDialog());
            
        }

        internal static void ThresholdBinary()
        {
            var form = new SelectValueForm();
            form.ShowDialog();
            var threshold = ValueImageProcessing1;

            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    if (Image.Data[y, x, 2] > threshold)
                        Image.Data[y, x, 2] = 255;
                    else
                        Image.Data[y, x, 2] = 0;

                    if (Image.Data[y, x, 1] > threshold)
                        Image.Data[y, x, 1] = 255;
                    else
                        Image.Data[y, x, 1] = 0;

                    if (Image.Data[y, x, 0] > threshold)
                        Image.Data[y, x, 0] = 255;
                    else
                        Image.Data[y, x, 0] = 0;
                }
            }
            Form.AddImage(Image);
        }

        internal static void ThresholdOtsu()
        {
            Image<Gray, Byte> img = Image.Convert<Gray, byte>();

            CvInvoke.Threshold(img, img, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);

            Form.AddImage(img);
        }

        internal static void ThresholdAdapt()
        {
            // value min = 3
            // value max = 33
            var form = new SelectValueForm();
            form.ShowDialog();
            var threshold = ValueImageProcessing1;

            Image<Gray, Byte> img = Image.Convert<Gray, byte>();
            var blockSize = (int)ValueImageProcessing1;
            if (blockSize % 2 == 0)
                blockSize += 1;

            CvInvoke.AdaptiveThreshold(img, img, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, blockSize, 5);

            Form.AddImage(img);
        }

        internal static void ThresholdWatershed()
        {
            Image<Gray, Byte> gray = Image.Convert<Gray, Byte>();
            CvInvoke.Threshold(gray, gray, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);

            float[,] matrix = new float[3, 3] {
              {1, 1, 1 },
              {1, 1, 1},
              {1, 1, 1 }
            };
            ConvolutionKernelF matrixKernel = new ConvolutionKernelF(matrix);

            CvInvoke.MorphologyEx(gray, gray, Emgu.CV.CvEnum.MorphOp.Open, matrixKernel, new Point(1, 1), 1, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(0.0));
            CvInvoke.Dilate(gray, gray, matrixKernel, new Point(1, 1), 1, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(0.0));

            Image<Bgra, Byte> dist = Image.Convert<Bgra, Byte>();
            CvInvoke.DistanceTransform(gray, dist, dist, Emgu.CV.CvEnum.DistType.L2, 5);

            Image.ConvertFrom(dist);
            Form.AddImage(dist);

        }
    }
}
