﻿using Emgu.CV;
using Emgu.CV.ImgHash;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Image_editor
{
    internal static class ImageStorage
    {
        public static event EventHandler ImageChanged;

        public static dynamic Image { get; set; }


        public static void OnImageChanged()
        {
            ImageChanged?.Invoke(null, EventArgs.Empty);
        }
        public static ImageForm Form { get; set; }
        private static int _type;
        public static int Type
        {
            get => _type;
            set
            {
                if(_type != value)
                {
                    _type = value;
                    OnImageChanged();
                }
            }
        }
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
    }
}
