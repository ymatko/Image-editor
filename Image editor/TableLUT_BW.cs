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
            RefreshForm();
            this.Activated += TableLUT_BW_Activated;
        }
        private void RefreshForm()
        {
            ImageStorage.CalculateHistogram();
            this.Text = $"Histogram of {ImageStorage.Name}";
            for (int i = 0; i < 256; i++)
            {
                string[] row = new string[] { $"{i}", $"{ImageStorage.red[i]}" };
                TableLUTView.Rows.Add(row);
            }
        }

        private void TableLUT_BW_Activated(object sender, EventArgs e)
        {
            this.TableLUTView.Rows.Clear();
            RefreshForm();
        }
    }
}
