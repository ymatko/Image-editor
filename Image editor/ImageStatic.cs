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
    internal static class ImageStorage<T> where T : struct, IColor
    {
        private static Image<T, byte> _image;
        public static Image<T, byte> Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public static string Name { get; set; }
        public static Type ImageType = typeof(T);
    }
}
