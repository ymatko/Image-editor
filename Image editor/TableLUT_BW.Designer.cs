namespace Image_editor
{
    partial class TableLUT_BW
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
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableLUTView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLUTView
            // 
            this.TableLUTView.AllowUserToAddRows = false;
            this.TableLUTView.AllowUserToDeleteRows = false;
            this.TableLUTView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLUTView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.Value});
            this.TableLUTView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLUTView.EnableHeadersVisualStyles = false;
            this.TableLUTView.Location = new System.Drawing.Point(0, 0);
            this.TableLUTView.MultiSelect = false;
            this.TableLUTView.Name = "TableLUTView";
            this.TableLUTView.ReadOnly = true;
            this.TableLUTView.RowHeadersVisible = false;
            this.TableLUTView.RowHeadersWidth = 82;
            this.TableLUTView.Size = new System.Drawing.Size(224, 446);
            this.TableLUTView.TabIndex = 1;
            // 
            // Count
            // 
            this.Count.Frozen = true;
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.Frozen = true;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // TableLUT_BW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 446);
            this.Controls.Add(this.TableLUTView);
            this.Name = "TableLUT_BW";
            this.Text = "TableLUT_BW";
            this.Activated += new System.EventHandler(this.TableLUT_BW_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.TableLUTView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableLUTView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}