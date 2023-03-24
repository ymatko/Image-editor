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
    public partial class TableLUT : Form
    {
        public TableLUT()
        {
            InitializeComponent();
            for (int i = 0; i < 257; i++)
            {
                string[] row = new string[] {$"{i}", "-"};
                TableLUTView.Rows.Add(row);
            }
        }
    }
}
