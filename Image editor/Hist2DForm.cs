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
        private Image<Gray, byte> image1;
        private Image<Gray, byte> image2;
        public Hist2DForm(Image<Gray, byte> image1, Image<Gray, byte> image2)
        {
            InitializeComponent();
            this.image1 = image1;
            this.image2 = image2;
            dataGridView1.Columns.Add("number", " ");
            dataGridView1.Rows.Add(256);

            for (int i = 0; i < 256; i++)
            {
                dataGridView1.Columns.Add($"{i}", $"{i}");
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Columns[0].Frozen = true;
            }
            for (int i = 0; i < 256; i++)
            {
                for(int j = 0; j <= 256; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    }
                        
                }
            }
            for (int x = 0; x < image1.Height; x++)
            {
                for (int y = 0; y < image1.Width; y++)
                {
                    int value = 0;
                    value = Convert.ToInt32(dataGridView1.Rows[image1.Data[x, y, 0]].Cells[image2.Data[x, y, 0] + 1].Value);
                    
                    dataGridView1.Rows[image1.Data[x, y, 0]].Cells[image2.Data[x, y, 0] + 1].Value = value + 1;
                    dataGridView1.Rows[image1.Data[x, y, 0]].Cells[image2.Data[x, y, 0] + 1].Style.BackColor = Color.White;
                }
            }

        }

        private void BtnNewImage_Click(object sender, EventArgs e)
        {
                CreateNewDataGridViewFromSelection(dataGridView1);
        }
        private void CreateNewDataGridViewFromSelection(DataGridView sourceDataGridView)
        {
            if (sourceDataGridView.SelectedCells.Count > 0)
            {
                DataGridView newDataGridView = new DataGridView();

                #region property of newDataGridView
                newDataGridView.AllowUserToAddRows = false;
                newDataGridView.AllowUserToDeleteRows = false;
                newDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
                newDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                newDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                newDataGridView.Location = new System.Drawing.Point(0, 0);
                newDataGridView.ReadOnly = true;
                newDataGridView.RowHeadersVisible = false;
                newDataGridView.RowHeadersWidth = 10;
                newDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                newDataGridView.Size = new System.Drawing.Size(486, 386);
                newDataGridView.TabIndex = 2;
                newDataGridView.AllowUserToResizeColumns = false;
                newDataGridView.AllowUserToResizeRows = false;

                #endregion
                newDataGridView.Columns.Add("number", " ");
                newDataGridView.Rows.Add(256);
                for (int i = 0; i < 256; i++)
                {
                    newDataGridView.Columns.Add($"{i}", $"{i}");
                    newDataGridView.Rows[i].Cells[0].Value = i;
                    newDataGridView.Columns[0].Frozen = true;

                }
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j <= 256; j++)
                    {
                        if (newDataGridView.Rows[i].Cells[j].Value == null)
                        {
                            newDataGridView.Rows[i].Cells[j].Value = 0;
                            newDataGridView.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                        }

                    }
                }

                foreach (DataGridViewCell sourceCell in sourceDataGridView.SelectedCells)
                {
                    int rowIndex = sourceCell.RowIndex;
                    int columnIndex = sourceCell.ColumnIndex;
                    string cellValue = sourceCell.Value.ToString();
                    newDataGridView.Rows[rowIndex].Cells[columnIndex].Value = cellValue;
                    newDataGridView.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.White;
                }

                var form = new Form();
                form.Controls.Add(newDataGridView);
                form.Text = "Histogram 2D with selected cells";
                form.Size = new Size(502, 463);
                _ = Task.Run(() => form.ShowDialog());
                ImageStorage.CreateImageFromTable(newDataGridView, image2);
            }
        }
    }
}
