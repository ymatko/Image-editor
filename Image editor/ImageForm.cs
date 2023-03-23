using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_editor
{
    public partial class ImageForm : Form
    {
        public ImageForm(OpenFileDialog ofd)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageInfoLabel.Text = "fdgdf";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
