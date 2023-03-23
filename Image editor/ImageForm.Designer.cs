namespace Image_editor
{
    partial class ImageForm
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
            this.components = new System.ComponentModel.Container();
            this.ImageInfoLabel = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageInfoLabel
            // 
            this.ImageInfoLabel.AutoSize = true;
            this.ImageInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImageInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.ImageInfoLabel.Name = "ImageInfoLabel";
            this.ImageInfoLabel.Size = new System.Drawing.Size(28, 16);
            this.ImageInfoLabel.TabIndex = 0;
            this.ImageInfoLabel.Text = "Info";
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 16);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(584, 545);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.ImageInfoLabel);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.Activated += new System.EventHandler(this.ImageForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImageInfoLabel;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}