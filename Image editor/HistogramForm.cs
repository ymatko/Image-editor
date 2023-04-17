using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using ScottPlot;

namespace Image_editor
{
    public partial class HistogramForm : Form
    {
        public HistogramForm()
        {
            InitializeComponent();
            //var image = new Image(ImageStatic.SelectedImageBgr);
            //this.Text = $"Histogram of {ImageStatic.Name}";
            //image.CalculateHistogram();
            //List<double> imagehist = new List<double>();
            //for (int i = 0; i < image.red.Length; i++)
            //{
            //    imagehist.Add(Convert.ToDouble(image.red[i]));

            //}
            //double[] doubles = imagehist.ToArray();
            //formsPlot1.Plot.AddBar(doubles);
            //formsPlot1.Refresh();
        }
    }
}
