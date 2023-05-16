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
    public partial class MedianBlurForm : Form
    {
        public MedianBlurForm()
        {
            InitializeComponent();
            ImageStorage.ValueImageProcessing1 = 3;
            ImageStorage.BorderType = Emgu.CV.CvEnum.BorderType.Default;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.BorderType = Emgu.CV.CvEnum.BorderType.Isolated;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.BorderType = Emgu.CV.CvEnum.BorderType.Reflect;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.BorderType = Emgu.CV.CvEnum.BorderType.Replicate;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.ValueImageProcessing1 = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.ValueImageProcessing1 = 5;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.ValueImageProcessing1 = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
