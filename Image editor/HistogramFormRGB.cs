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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image_editor
{

    public partial class HistogramFormRGB : Form
    {
        public HistogramFormRGB()
        {
            InitializeComponent();
            RefreshForm();
            this.Activated += HistogramFormRGB_Activated;
        }
        private void RefreshForm()
        {
            ImageStorage.CalculateHistogram();
            this.Text = $"Histogram of {ImageStorage.Name}";

            List<double> imagehistR = new List<double>();
            List<double> imagehistG = new List<double>();
            List<double> imagehistB = new List<double>();

            for (int i = 0; i < ImageStorage.red.Length; i++)
            {
                imagehistR.Add(Convert.ToDouble(ImageStorage.red[i]));

            }

            for (int i = 0; i < ImageStorage.green.Length; i++)
            {
                imagehistG.Add(Convert.ToDouble(ImageStorage.green[i]));

            }

            for (int i = 0; i < ImageStorage.blue.Length; i++)
            {
                imagehistB.Add(Convert.ToDouble(ImageStorage.blue[i]));

            }

            double[] doublesR = imagehistR.ToArray();
            double[] doublesG = imagehistG.ToArray();
            double[] doublesB = imagehistB.ToArray();

            formsPlotR.Plot.AddBar(doublesR, color: Color.Red).BorderColor = Color.Red;
            formsPlotG.Plot.AddBar(doublesG, color: Color.Green).BorderColor = Color.Green;
            formsPlotB.Plot.AddBar(doublesB, color: Color.Blue).BorderColor = Color.Blue;

            formsPlotR.Refresh();
            formsPlotG.Refresh();
            formsPlotB.Refresh();
        }

        private void HistogramFormRGB_Activated(object sender, EventArgs e)
        {
            formsPlotR.Plot.Clear();
            formsPlotG.Plot.Clear(); 
            formsPlotB.Plot.Clear();
            RefreshForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = Convert.ToUInt16(textBox3.Text);
            textBox4.Text = Convert.ToString(ImageStorage.red[value]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = Convert.ToUInt16(textBox5.Text);
            textBox6.Text = Convert.ToString(ImageStorage.green[value]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = Convert.ToUInt16(textBox8.Text);
            textBox7.Text = Convert.ToString(ImageStorage.blue[value]);
        }
    }
}
