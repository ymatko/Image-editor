using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Image_editor
{
    public partial class PlotProfileForm : Form
    {
        public PlotProfileForm()
        {
            InitializeComponent();
            RefreshForm();
            this.Activated += PlotProfileForm_Activated;
        }
        private void RefreshForm()
        {
            var startPoint = ImageStorage.Points[ImageStorage.Points.Count - 1];
            var endPoint = ImageStorage.Points[ImageStorage.Points.Count - 2];

            var imageMat = ImageStorage.ConvertToGray().Mat;
            var image = ImageStorage.ConvertToGray();

            var lineIterator = new LineIterator(imageMat, startPoint, endPoint, 8, false);
            int numPixels = lineIterator.Count;
            var pixels = new double[numPixels];


            for(int i = 0; i < numPixels; i++)
            {
                var point = lineIterator.Pos;
                pixels[i] = image[point].Red;
                lineIterator.MoveNext();
            }
            formsPlot1.Plot.AddBar(pixels);
            formsPlot1.Refresh();
        }

        private void PlotProfileForm_Activated(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            RefreshForm();
        }
    }
}
