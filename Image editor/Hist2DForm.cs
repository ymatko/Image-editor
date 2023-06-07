using Emgu.CV;
using Emgu.CV.Structure;
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
        public Hist2DForm(Image<Gray, byte> image1, Image<Gray, byte> image2)
        {
            InitializeComponent();
            dataGridView1.Columns.Add("number", " ");
            dataGridView1.Rows.Add(256);

            for (int i = 0; i < 256; i++)
            {
                dataGridView1.Columns.Add($"{i}", $"{i}");
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    if (image1.Data[y, x, 0] == image2.Data[y, x, 0])
                    {
                        int value;
                        if(dataGridView1.Rows[image1.Data[y, x, 0]].Cells[image2.Data[y, x, 0] + 1].Value == null)
                        {
                            value = 0;
                        }
                        else
                        {
                            value = (int)dataGridView1.Rows[image1.Data[y, x, 0]].Cells[image2.Data[y, x, 0] + 1].Value;
                        }
                        dataGridView1.Rows[image1.Data[y, x, 0]].Cells[image2.Data[y, x, 0] + 1].Value = value + 1;
                    }
                    else
                    {
                        int value;
                        if (dataGridView1.Rows[image1.Data[y, x, 0]].Cells[image2.Data[y, x, 0] + 1].Value == null)
                        {
                            value = 0;
                        }
                        else
                        {
                            value = (int)dataGridView1.Rows[image1.Data[y, x, 0]].Cells[image2.Data[y, x, 0] + 1].Value;
                        }
                        dataGridView1.Rows[image1.Data[y, x, 0]].Cells[image2.Data[y, x, 0] + 1].Value = value + 1;
                    }
                }
            }
        }
    }
}
