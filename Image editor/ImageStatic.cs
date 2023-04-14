using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Image_editor
{
    internal static class ImageStatic
    {
        internal static string Name { get; set; }
        internal static Image<Bgr, Byte> SelectedImageBgr { get; set; }
        internal static Image<Gray, Byte> SelectedImageGray { get; set; }
        internal static Image<Hsv, Byte> SelectedImageHsv { get; set; }

        internal static ImageForm SelectedForm { get; set; }
    }
}
