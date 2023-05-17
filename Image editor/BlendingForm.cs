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
    public partial class BlendingForm : Form
    {
        public BlendingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageStorage.ValueImageProcessing1 = trackBar1.Value * 0.01;
            ImageStorage.ValueImageProcessing2 = trackBar1.Value * 0.01; 
            ImageStorage.ValueImageProcessing3 = trackBar1.Value * 0.01;
            this.Close();

        }
    }
}
