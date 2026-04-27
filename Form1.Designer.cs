namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGaussian = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnEmboss = new System.Windows.Forms.Button();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(323, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            this.btnOpen.Location = new System.Drawing.Point(39, 70);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(109, 41);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);

            this.btnRed.Location = new System.Drawing.Point(39, 117);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(109, 31);
            this.btnRed.TabIndex = 5;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);

            this.btnGreen.Location = new System.Drawing.Point(39, 154);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(109, 41);
            this.btnGreen.TabIndex = 6;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);

            this.btnBlue.Location = new System.Drawing.Point(39, 201);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(109, 35);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);

            this.btnGray.Location = new System.Drawing.Point(39, 242);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(109, 37);
            this.btnGray.TabIndex = 3;
            this.btnGray.Text = "Grayscale";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);

            this.btnGaussian.Location = new System.Drawing.Point(39, 285);
            this.btnGaussian.Name = "btnGaussian";
            this.btnGaussian.Size = new System.Drawing.Size(109, 39);
            this.btnGaussian.TabIndex = 2;
            this.btnGaussian.Text = "Gaussian Blur";
            this.btnGaussian.UseVisualStyleBackColor = true;
            this.btnGaussian.Click += new System.EventHandler(this.btnGaussian_Click);

            this.btnHistogram.Location = new System.Drawing.Point(39, 330);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(109, 35);
            this.btnHistogram.TabIndex = 7;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);

            this.btnBrightness.Location = new System.Drawing.Point(39, 371);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(109, 34);
            this.btnBrightness.TabIndex = 14;
            this.btnBrightness.Text = "Brightness";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);

            this.btnNegative.Location = new System.Drawing.Point(39, 411);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(109, 31);
            this.btnNegative.TabIndex = 13;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);

            this.btnMedian.Location = new System.Drawing.Point(39, 448);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(109, 35);
            this.btnMedian.TabIndex = 12;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);

            this.btnSharpen.Location = new System.Drawing.Point(39, 489);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(109, 33);
            this.btnSharpen.TabIndex = 11;
            this.btnSharpen.Text = "Sharpen";
            this.btnSharpen.UseVisualStyleBackColor = true;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);

            this.btnEmboss.Location = new System.Drawing.Point(39, 528);
            this.btnEmboss.Name = "btnEmboss";
            this.btnEmboss.Size = new System.Drawing.Size(109, 33);
            this.btnEmboss.TabIndex = 10;
            this.btnEmboss.Text = "Emboss";
            this.btnEmboss.UseVisualStyleBackColor = true;
            this.btnEmboss.Click += new System.EventHandler(this.btnEmboss_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnSharpen);
            this.Controls.Add(this.btnEmboss);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnGaussian);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGaussian;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnEmboss;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnBrightness;
    }
}