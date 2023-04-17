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
    public partial class TableLUT_BW : Form
    {
        public TableLUT_BW()
        {
            InitializeComponent();
            //var selectedImage = ImageStatic.SelectedImageBgr;
            //var image = new Image(selectedImage);
            //image.CalculateHistogram();
            //this.Text = $"LUT of {ImageStatic.Name}";
            //for (int i = 0; i < 256; i++)
            //{
            //    string[] row = new string[] { $"{i}", $"{image.red[i]}"};
            //    TableLUTView.Rows.Add(row);
            //}
        }
    }
}
