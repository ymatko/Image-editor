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
    public partial class Hist2DForm : Form
    {
        public Hist2DForm()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("number"," ");
            dataGridView1.Rows.Add(256);

            for (int i = 0; i < 256; i++)
            {
                dataGridView1.Columns.Add($"{i}", $"{i}");
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }
    }
}
