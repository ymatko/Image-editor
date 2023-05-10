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
    public partial class MatrixKernel : Form
    {
        public MatrixKernel()
        {
            InitializeComponent();
        }
        private void CreateMatrix(float[,] kernel)
        {
            List<TextBox> matrix = new List<TextBox>()
            {
                textBox1, textBox2, textBox3,
                textBox4, textBox5, textBox6,
                textBox7, textBox8, textBox9,
            };
            int k = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matrix[k].Text = Convert.ToString(kernel[i, j]);
                    k++;
                }
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { 0, -1, 0 },
              {-1, 5, -1},
              { 0, -1, 0 }
            };
            CreateMatrix(kernel);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { -1, -1, -1 },
              {-1, 9, -1},
              { -1, -1, -1 }
            };
            CreateMatrix(kernel);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { 1, -2, 1 },
              {-2, 5, -2},
              { 1, -2, 1 }
            };
            CreateMatrix(kernel);
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { -1, 0, 1 },
              {-1, 0, 1},
              { -1, 0, 1 }
            };
            CreateMatrix(kernel);
        }

        private void nEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { -1, -1, 0 },
              {-1, 0, 1},
              { 0, 1, 1 }
            };
            CreateMatrix(kernel);
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { -1, -1, -1 },
              {0, 0, 0},
              { 1, 1, 1 }
            };
            CreateMatrix(kernel);
        }

        private void sEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { 0, -1, -1 },
              {1, 0, -1},
              { 1, 1, 0 }
            };
            CreateMatrix(kernel);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { 1, 0, -1 },
              {1, 0, -1},
              { 1, 0, -1 }
            };
            CreateMatrix(kernel);
        }

        private void sWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { 1, 1, 0 },
              {1, 0, -1},
              { 0, -1, -1 }
            };
            CreateMatrix(kernel);
        }

        private void wToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { 1, 1, 1 },
              {0, 0, 0},
              { -1, -1, -1 }
            };
            CreateMatrix(kernel);
        }

        private void nWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[,] kernel = new float[3, 3]
            {
              { 1, 1, 0 },
              {1, 0, -1},
              { 0, -1, -1 }
            };
            CreateMatrix(kernel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TextBox> matrix = new List<TextBox>()
            {
                textBox1, textBox2, textBox3,
                textBox4, textBox5, textBox6,
                textBox7, textBox8, textBox9,
            };
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (int.TryParse(matrix[k].Text, out int value))
                    {
                        ImageStorage.Matrix3[i, j] = value; 
                    }
                    k++;
                }
            }
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.BorderType = Emgu.CV.CvEnum.BorderType.Isolated;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.BorderType = Emgu.CV.CvEnum.BorderType.Reflect;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ImageStorage.BorderType = Emgu.CV.CvEnum.BorderType.Replicate;
        }
    }
}
