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
            RefreshForm();
            this.Activated += HistogramForm_Activated;
        }
        private void RefreshForm()
        {
            ImageStorage.CalculateHistogram();
            this.Text = $"Histogram of {ImageStorage.Name}";
            List<double> imagehist = new List<double>();
            for (int i = 0; i < ImageStorage.red.Length; i++)
            {
                imagehist.Add(Convert.ToDouble(ImageStorage.red[i]));

            }
            double[] doubles = imagehist.ToArray();
            formsPlot1.Plot.AddBar(doubles);
            formsPlot1.Refresh();
        }

        private void HistogramForm_Activated(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            RefreshForm();
        }
    }
}
