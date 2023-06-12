namespace Image_editor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOryginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCompressedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMonochromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToHSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToLABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posterizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectiveStretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFiltrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoargumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morfologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scletonizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingAdaptiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingOtsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingWatershedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramTableGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogram2DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.processToolStripMenuItem,
            this.analyzeToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOryginalToolStripMenuItem,
            this.saveCompressedToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveOryginalToolStripMenuItem
            // 
            this.saveOryginalToolStripMenuItem.Name = "saveOryginalToolStripMenuItem";
            this.saveOryginalToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveOryginalToolStripMenuItem.Text = "Save original";
            this.saveOryginalToolStripMenuItem.Click += new System.EventHandler(this.saveOryginalToolStripMenuItem_Click);
            // 
            // saveCompressedToolStripMenuItem
            // 
            this.saveCompressedToolStripMenuItem.Name = "saveCompressedToolStripMenuItem";
            this.saveCompressedToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveCompressedToolStripMenuItem.Text = "Save compressed";
            this.saveCompressedToolStripMenuItem.Click += new System.EventHandler(this.saveCompressedToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toRGBToolStripMenuItem,
            this.toMonochromToolStripMenuItem,
            this.rGBToHSVToolStripMenuItem,
            this.rGBToLABToolStripMenuItem,
            this.splitChannelsToolStripMenuItem,
            this.stretchingToolStripMenuItem,
            this.equalizationToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // toRGBToolStripMenuItem
            // 
            this.toRGBToolStripMenuItem.Name = "toRGBToolStripMenuItem";
            this.toRGBToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.toRGBToolStripMenuItem.Text = "To RGB";
            this.toRGBToolStripMenuItem.Click += new System.EventHandler(this.toRGBToolStripMenuItem_Click);
            // 
            // toMonochromToolStripMenuItem
            // 
            this.toMonochromToolStripMenuItem.Name = "toMonochromToolStripMenuItem";
            this.toMonochromToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.toMonochromToolStripMenuItem.Text = "RGB to Gray";
            this.toMonochromToolStripMenuItem.Click += new System.EventHandler(this.toMonochromToolStripMenuItem_Click);
            // 
            // rGBToHSVToolStripMenuItem
            // 
            this.rGBToHSVToolStripMenuItem.Name = "rGBToHSVToolStripMenuItem";
            this.rGBToHSVToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.rGBToHSVToolStripMenuItem.Text = "RGB to HSV";
            this.rGBToHSVToolStripMenuItem.Click += new System.EventHandler(this.rGBToHSVToolStripMenuItem_Click);
            // 
            // rGBToLABToolStripMenuItem
            // 
            this.rGBToLABToolStripMenuItem.Name = "rGBToLABToolStripMenuItem";
            this.rGBToLABToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.rGBToLABToolStripMenuItem.Text = "RGB to LAB";
            this.rGBToLABToolStripMenuItem.Click += new System.EventHandler(this.rGBToLABToolStripMenuItem_Click);
            // 
            // splitChannelsToolStripMenuItem
            // 
            this.splitChannelsToolStripMenuItem.Name = "splitChannelsToolStripMenuItem";
            this.splitChannelsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.splitChannelsToolStripMenuItem.Text = "Split channels";
            this.splitChannelsToolStripMenuItem.Click += new System.EventHandler(this.splitChannelsToolStripMenuItem_Click);
            // 
            // stretchingToolStripMenuItem
            // 
            this.stretchingToolStripMenuItem.Name = "stretchingToolStripMenuItem";
            this.stretchingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.stretchingToolStripMenuItem.Text = "Stretching";
            this.stretchingToolStripMenuItem.Click += new System.EventHandler(this.stretchingToolStripMenuItem_Click);
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negationToolStripMenuItem,
            this.posterizationToolStripMenuItem,
            this.selectiveStretchingToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.kernelToolStripMenuItem,
            this.medianFiltrToolStripMenuItem,
            this.twoargumentToolStripMenuItem,
            this.morfologiaToolStripMenuItem,
            this.lineDetectionToolStripMenuItem,
            this.thresholdingToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // negationToolStripMenuItem
            // 
            this.negationToolStripMenuItem.Name = "negationToolStripMenuItem";
            this.negationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.negationToolStripMenuItem.Text = "Negation";
            this.negationToolStripMenuItem.Click += new System.EventHandler(this.negationToolStripMenuItem_Click);
            // 
            // posterizationToolStripMenuItem
            // 
            this.posterizationToolStripMenuItem.Name = "posterizationToolStripMenuItem";
            this.posterizationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.posterizationToolStripMenuItem.Text = "Posterization";
            this.posterizationToolStripMenuItem.Click += new System.EventHandler(this.posterizationToolStripMenuItem_Click);
            // 
            // selectiveStretchingToolStripMenuItem
            // 
            this.selectiveStretchingToolStripMenuItem.Name = "selectiveStretchingToolStripMenuItem";
            this.selectiveStretchingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.selectiveStretchingToolStripMenuItem.Text = "Selective stretching";
            this.selectiveStretchingToolStripMenuItem.Click += new System.EventHandler(this.selectiveStretchingToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelToolStripMenuItem1,
            this.laplacianToolStripMenuItem,
            this.cannyToolStripMenuItem1});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.edgeDetectionToolStripMenuItem.Text = "Edge detection";
            // 
            // sobelToolStripMenuItem1
            // 
            this.sobelToolStripMenuItem1.Name = "sobelToolStripMenuItem1";
            this.sobelToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.sobelToolStripMenuItem1.Text = "Sobel";
            this.sobelToolStripMenuItem1.Click += new System.EventHandler(this.sobelToolStripMenuItem1_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem1
            // 
            this.cannyToolStripMenuItem1.Name = "cannyToolStripMenuItem1";
            this.cannyToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.cannyToolStripMenuItem1.Text = "Canny";
            this.cannyToolStripMenuItem1.Click += new System.EventHandler(this.cannyToolStripMenuItem1_Click);
            // 
            // kernelToolStripMenuItem
            // 
            this.kernelToolStripMenuItem.Name = "kernelToolStripMenuItem";
            this.kernelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kernelToolStripMenuItem.Text = "Kernel";
            this.kernelToolStripMenuItem.Click += new System.EventHandler(this.kernelToolStripMenuItem_Click);
            // 
            // medianFiltrToolStripMenuItem
            // 
            this.medianFiltrToolStripMenuItem.Name = "medianFiltrToolStripMenuItem";
            this.medianFiltrToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.medianFiltrToolStripMenuItem.Text = "Median filter";
            this.medianFiltrToolStripMenuItem.Click += new System.EventHandler(this.medianFiltrToolStripMenuItem_Click);
            // 
            // twoargumentToolStripMenuItem
            // 
            this.twoargumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.subToolStripMenuItem,
            this.blendingToolStripMenuItem,
            this.logicToolStripMenuItem});
            this.twoargumentToolStripMenuItem.Name = "twoargumentToolStripMenuItem";
            this.twoargumentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.twoargumentToolStripMenuItem.Text = "Two-argument";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // subToolStripMenuItem
            // 
            this.subToolStripMenuItem.Name = "subToolStripMenuItem";
            this.subToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.subToolStripMenuItem.Text = "Sub";
            this.subToolStripMenuItem.Click += new System.EventHandler(this.subToolStripMenuItem_Click);
            // 
            // blendingToolStripMenuItem
            // 
            this.blendingToolStripMenuItem.Name = "blendingToolStripMenuItem";
            this.blendingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.blendingToolStripMenuItem.Text = "Blending";
            this.blendingToolStripMenuItem.Click += new System.EventHandler(this.blendingToolStripMenuItem_Click);
            // 
            // logicToolStripMenuItem
            // 
            this.logicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNDToolStripMenuItem,
            this.oRToolStripMenuItem,
            this.xORToolStripMenuItem});
            this.logicToolStripMenuItem.Name = "logicToolStripMenuItem";
            this.logicToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.logicToolStripMenuItem.Text = "Logic";
            // 
            // aNDToolStripMenuItem
            // 
            this.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            this.aNDToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aNDToolStripMenuItem.Text = "AND";
            this.aNDToolStripMenuItem.Click += new System.EventHandler(this.aNDToolStripMenuItem_Click);
            // 
            // oRToolStripMenuItem
            // 
            this.oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            this.oRToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.oRToolStripMenuItem.Text = "OR";
            this.oRToolStripMenuItem.Click += new System.EventHandler(this.oRToolStripMenuItem_Click);
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.xORToolStripMenuItem.Text = "XOR";
            this.xORToolStripMenuItem.Click += new System.EventHandler(this.xORToolStripMenuItem_Click);
            // 
            // morfologiaToolStripMenuItem
            // 
            this.morfologiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.scletonizToolStripMenuItem});
            this.morfologiaToolStripMenuItem.Name = "morfologiaToolStripMenuItem";
            this.morfologiaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.morfologiaToolStripMenuItem.Text = "Morphology";
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dilationToolStripMenuItem.Text = "Dilatation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // scletonizToolStripMenuItem
            // 
            this.scletonizToolStripMenuItem.Name = "scletonizToolStripMenuItem";
            this.scletonizToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.scletonizToolStripMenuItem.Text = "Skeletonization";
            this.scletonizToolStripMenuItem.Click += new System.EventHandler(this.scletonizToolStripMenuItem_Click);
            // 
            // lineDetectionToolStripMenuItem
            // 
            this.lineDetectionToolStripMenuItem.Name = "lineDetectionToolStripMenuItem";
            this.lineDetectionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.lineDetectionToolStripMenuItem.Text = "Line detection";
            this.lineDetectionToolStripMenuItem.Click += new System.EventHandler(this.lineDetectionToolStripMenuItem_Click);
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thresholdingBinaryToolStripMenuItem,
            this.thresholdingAdaptiveToolStripMenuItem,
            this.thresholdingOtsuToolStripMenuItem,
            this.thresholdingWatershedToolStripMenuItem});
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            // 
            // thresholdingBinaryToolStripMenuItem
            // 
            this.thresholdingBinaryToolStripMenuItem.Name = "thresholdingBinaryToolStripMenuItem";
            this.thresholdingBinaryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thresholdingBinaryToolStripMenuItem.Text = "Thresholding binary";
            this.thresholdingBinaryToolStripMenuItem.Click += new System.EventHandler(this.thresholdingBinaryToolStripMenuItem_Click);
            // 
            // thresholdingAdaptiveToolStripMenuItem
            // 
            this.thresholdingAdaptiveToolStripMenuItem.Name = "thresholdingAdaptiveToolStripMenuItem";
            this.thresholdingAdaptiveToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thresholdingAdaptiveToolStripMenuItem.Text = "Thresholding adaptive";
            this.thresholdingAdaptiveToolStripMenuItem.Click += new System.EventHandler(this.thresholdingAdaptiveToolStripMenuItem_Click);
            // 
            // thresholdingOtsuToolStripMenuItem
            // 
            this.thresholdingOtsuToolStripMenuItem.Name = "thresholdingOtsuToolStripMenuItem";
            this.thresholdingOtsuToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thresholdingOtsuToolStripMenuItem.Text = "Thresholding Otsu";
            this.thresholdingOtsuToolStripMenuItem.Click += new System.EventHandler(this.thresholdingOtsuToolStripMenuItem_Click);
            // 
            // thresholdingWatershedToolStripMenuItem
            // 
            this.thresholdingWatershedToolStripMenuItem.Name = "thresholdingWatershedToolStripMenuItem";
            this.thresholdingWatershedToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thresholdingWatershedToolStripMenuItem.Text = "Thresholding Watershed";
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramTableGrayToolStripMenuItem,
            this.tableLUTToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.histogramRGBToolStripMenuItem,
            this.plotProfileToolStripMenuItem,
            this.histogram2DToolStripMenuItem});
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // histogramTableGrayToolStripMenuItem
            // 
            this.histogramTableGrayToolStripMenuItem.Name = "histogramTableGrayToolStripMenuItem";
            this.histogramTableGrayToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.histogramTableGrayToolStripMenuItem.Text = "Histogram Table Gray";
            this.histogramTableGrayToolStripMenuItem.Click += new System.EventHandler(this.histogramTableGrayToolStripMenuItem_Click);
            // 
            // tableLUTToolStripMenuItem
            // 
            this.tableLUTToolStripMenuItem.Name = "tableLUTToolStripMenuItem";
            this.tableLUTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tableLUTToolStripMenuItem.Text = "Histogram Table RGB";
            this.tableLUTToolStripMenuItem.Click += new System.EventHandler(this.tableLUTToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.histogramToolStripMenuItem.Text = "Histogram Gray";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // histogramRGBToolStripMenuItem
            // 
            this.histogramRGBToolStripMenuItem.Name = "histogramRGBToolStripMenuItem";
            this.histogramRGBToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.histogramRGBToolStripMenuItem.Text = "Histogram RGB";
            this.histogramRGBToolStripMenuItem.Click += new System.EventHandler(this.histogramRGBToolStripMenuItem_Click);
            // 
            // plotProfileToolStripMenuItem
            // 
            this.plotProfileToolStripMenuItem.Name = "plotProfileToolStripMenuItem";
            this.plotProfileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.plotProfileToolStripMenuItem.Text = "Plot profile";
            this.plotProfileToolStripMenuItem.Click += new System.EventHandler(this.plotProfileToolStripMenuItem_Click);
            // 
            // histogram2DToolStripMenuItem
            // 
            this.histogram2DToolStripMenuItem.Name = "histogram2DToolStripMenuItem";
            this.histogram2DToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.histogram2DToolStripMenuItem.Text = "Histogram 2D";
            this.histogram2DToolStripMenuItem.Click += new System.EventHandler(this.histogram2DToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"(*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(423, 36);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Image editor";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tableLUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toMonochromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitChannelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToHSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramTableGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToLABToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posterizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectiveStretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFiltrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoargumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morfologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scletonizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOryginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCompressedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogram2DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingAdaptiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingOtsuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingWatershedToolStripMenuItem;
    }
}

