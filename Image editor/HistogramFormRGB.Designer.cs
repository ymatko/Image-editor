namespace Image_editor
{
    partial class HistogramFormRGB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.formsPlotR = new ScottPlot.FormsPlot();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formsPlotB = new ScottPlot.FormsPlot();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formsPlotG = new ScottPlot.FormsPlot();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formsPlotR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 250);
            this.panel1.TabIndex = 0;
            // 
            // formsPlotR
            // 
            this.formsPlotR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotR.Enabled = false;
            this.formsPlotR.Location = new System.Drawing.Point(0, 0);
            this.formsPlotR.Margin = new System.Windows.Forms.Padding(0);
            this.formsPlotR.Name = "formsPlotR";
            this.formsPlotR.Size = new System.Drawing.Size(400, 250);
            this.formsPlotR.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formsPlotB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 250);
            this.panel2.TabIndex = 0;
            // 
            // formsPlotB
            // 
            this.formsPlotB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotB.Enabled = false;
            this.formsPlotB.Location = new System.Drawing.Point(0, 0);
            this.formsPlotB.Name = "formsPlotB";
            this.formsPlotB.Size = new System.Drawing.Size(400, 250);
            this.formsPlotB.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.formsPlotG);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 250);
            this.panel3.TabIndex = 0;
            // 
            // formsPlotG
            // 
            this.formsPlotG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotG.Enabled = false;
            this.formsPlotG.Location = new System.Drawing.Point(0, 0);
            this.formsPlotG.Name = "formsPlotG";
            this.formsPlotG.Size = new System.Drawing.Size(400, 250);
            this.formsPlotG.TabIndex = 1;
            // 
            // HistogramFormRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HistogramFormRGB";
            this.Text = "HistogramFormRGB";
            this.Activated += new System.EventHandler(this.HistogramFormRGB_Activated);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ScottPlot.FormsPlot formsPlotR;
        private ScottPlot.FormsPlot formsPlotB;
        private ScottPlot.FormsPlot formsPlotG;
    }
}