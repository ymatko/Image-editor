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
    public partial class SelectValueForm : Form
    {
        public SelectValueForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageStorage.ValueImageProcessing = Convert.ToInt32(textBox1.Text);
            this.Close();
        }
    }
}
