using Emgu.CV;
using Emgu.CV.Structure;

namespace Image_editor
{
    internal interface IImage
    {
        ushort[] blue { get; }
        Image<Bgr, byte> cvImage { get; }
        ushort[] green { get; }
        ushort[] red { get; }

        void CalculateHistogram();
        Image<Bgr, byte> ToGray();
        Image<Hsv, byte> ToHsv();
    }
}