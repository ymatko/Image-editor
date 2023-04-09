using ScottPlot;
using ScottPlot.Renderable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_editor
{
    public partial class HistogramFormRGB : Form
    {
        public HistogramFormRGB()
        {
            InitializeComponent();
            var image = new Image(ImageStatic.SelectedImage);
            image.CalculateHistogram();
            List<double> imagehistR = new List<double>();
            List<double> imagehistG = new List<double>();
            List<double> imagehistB = new List<double>();

            for (int i = 0; i < image.red.Length; i++)
            {
                imagehistR.Add(Convert.ToDouble(image.red[i]));

            }

            for (int i = 0; i < image.green.Length; i++)
            {
                imagehistG.Add(Convert.ToDouble(image.green[i]));

            }

            for (int i = 0; i < image.blue.Length; i++)
            {
                imagehistB.Add(Convert.ToDouble(image.blue[i]));

            }

            double[] doublesR = imagehistR.ToArray();
            double[] doublesG = imagehistG.ToArray();
            double[] doublesB = imagehistB.ToArray();

            formsPlotR.Plot.AddBar(doublesR, color:Color.Red).BorderColor = Color.Red;
            formsPlotG.Plot.AddBar(doublesG, color: Color.Green).BorderColor = Color.Green;
            formsPlotB.Plot.AddBar(doublesB, color: Color.Blue).BorderColor = Color.Blue;

            formsPlotR.Refresh();
            formsPlotG.Refresh();
            formsPlotB.Refresh();
        }
    }
}
