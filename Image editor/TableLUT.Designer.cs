namespace Image_editor
{
    partial class TableLUT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLUTView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableLUTView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLUTView
            // 
            this.TableLUTView.AllowUserToAddRows = false;
            this.TableLUTView.AllowUserToDeleteRows = false;
            this.TableLUTView.BackgroundColor = System.Drawing.Color.Snow;
            this.TableLUTView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLUTView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Count});
            this.TableLUTView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLUTView.Location = new System.Drawing.Point(0, 0);
            this.TableLUTView.Name = "TableLUTView";
            this.TableLUTView.ReadOnly = true;
            this.TableLUTView.RowHeadersVisible = false;
            this.TableLUTView.RowTemplate.ReadOnly = true;
            this.TableLUTView.Size = new System.Drawing.Size(223, 508);
            this.TableLUTView.TabIndex = 0;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MaxInputLength = 1000;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // TableLUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 508);
            this.Controls.Add(this.TableLUTView);
            this.Name = "TableLUT";
            this.Text = "LUT";
            ((System.ComponentModel.ISupportInitialize)(this.TableLUTView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableLUTView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}