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
    public partial class Select4ValueForm : Form
    {
        public Select4ValueForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageStorage.ValueImageProcessing1 = Convert.ToInt32(textBox1.Text);
            ImageStorage.ValueImageProcessing2 = Convert.ToInt32(textBox2.Text);
            ImageStorage.ValueImageProcessing3 = Convert.ToInt32(textBox3.Text);
            ImageStorage.ValueImageProcessing4 = Convert.ToInt32(textBox4.Text);
            this.Close();
        }
    }
}
