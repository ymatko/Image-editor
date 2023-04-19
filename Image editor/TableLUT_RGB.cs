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
    public partial class TableLUT_RGB : Form
    {
        public TableLUT_RGB()
        {
            InitializeComponent();
            RefreshForm();
            this.Activated += TableLUT_RGB_Activated;
        }
        private void RefreshForm()
        {
            ImageStorage.CalculateHistogram();
            this.Text = $"Histogram of {ImageStorage.Name}";
            for (int i = 0; i < 256; i++)
            {
                string[] row = new string[] { $"{i}", $"{ImageStorage.red[i]}", $"{ImageStorage.green[i]}", $"{ImageStorage.blue[i]}" };
                TableLUTView.Rows.Add(row);
            }
        }

        private void TableLUT_RGB_Activated(object sender, EventArgs e)
        {
            this.TableLUTView.Rows.Clear();
            RefreshForm();
        }
    }
}
