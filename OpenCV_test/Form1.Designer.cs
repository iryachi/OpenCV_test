
namespace OpenCV_test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageImageFile = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.imreadCtrl1 = new OpenCV_test.ImreadCtrl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.imwriteCtrl1 = new OpenCV_test.ImwriteCtrl();
            this.tabPageConverter = new System.Windows.Forms.TabPage();
            this.converterTabCtrl1 = new OpenCV_test.Converter.ConverterTabCtrl();
            this.tabPageDenoising = new System.Windows.Forms.TabPage();
            this.denoisingTabCtrl1 = new OpenCV_test.Denoising.DenoisingTabCtrl();
            this.tabPageEdge = new System.Windows.Forms.TabPage();
            this.edgeDitectTabCtrl1 = new OpenCV_test.Edge.EdgeDitectTabCtrl();
            this.tabPageFilter2D = new System.Windows.Forms.TabPage();
            this.filter2DCtrl1 = new OpenCV_test.Filter2DCtrl();
            this.tabPageConvTest = new System.Windows.Forms.TabPage();
            this.convolutionTestCtrl1 = new OpenCV_test.ConvolutionTestCtrl();
            this.tabPageRoi = new System.Windows.Forms.TabPage();
            this.roiSettingCtrl1 = new OpenCV_test.Common.RoiSettingCtrl();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageImageFile.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPageConverter.SuspendLayout();
            this.tabPageDenoising.SuspendLayout();
            this.tabPageEdge.SuspendLayout();
            this.tabPageFilter2D.SuspendLayout();
            this.tabPageConvTest.SuspendLayout();
            this.tabPageRoi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageImageFile);
            this.tabControl1.Controls.Add(this.tabPageConverter);
            this.tabControl1.Controls.Add(this.tabPageDenoising);
            this.tabControl1.Controls.Add(this.tabPageEdge);
            this.tabControl1.Controls.Add(this.tabPageFilter2D);
            this.tabControl1.Controls.Add(this.tabPageConvTest);
            this.tabControl1.Controls.Add(this.tabPageRoi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 522);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageImageFile
            // 
            this.tabPageImageFile.Controls.Add(this.tabControl2);
            this.tabPageImageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageImageFile.Name = "tabPageImageFile";
            this.tabPageImageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImageFile.Size = new System.Drawing.Size(661, 496);
            this.tabPageImageFile.TabIndex = 1;
            this.tabPageImageFile.Text = "File";
            this.tabPageImageFile.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Location = new System.Drawing.Point(8, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(647, 484);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.imreadCtrl1);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(639, 458);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "imread";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // imreadCtrl1
            // 
            this.imreadCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imreadCtrl1.Location = new System.Drawing.Point(3, 6);
            this.imreadCtrl1.Name = "imreadCtrl1";
            this.imreadCtrl1.Size = new System.Drawing.Size(630, 446);
            this.imreadCtrl1.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.imwriteCtrl1);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(639, 458);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "imwrite";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // imwriteCtrl1
            // 
            this.imwriteCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imwriteCtrl1.Location = new System.Drawing.Point(6, 6);
            this.imwriteCtrl1.Name = "imwriteCtrl1";
            this.imwriteCtrl1.Size = new System.Drawing.Size(627, 449);
            this.imwriteCtrl1.TabIndex = 0;
            // 
            // tabPageConverter
            // 
            this.tabPageConverter.Controls.Add(this.converterTabCtrl1);
            this.tabPageConverter.Location = new System.Drawing.Point(4, 22);
            this.tabPageConverter.Name = "tabPageConverter";
            this.tabPageConverter.Size = new System.Drawing.Size(661, 496);
            this.tabPageConverter.TabIndex = 2;
            this.tabPageConverter.Text = "Converter";
            this.tabPageConverter.UseVisualStyleBackColor = true;
            // 
            // converterTabCtrl1
            // 
            this.converterTabCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converterTabCtrl1.Location = new System.Drawing.Point(3, 3);
            this.converterTabCtrl1.Name = "converterTabCtrl1";
            this.converterTabCtrl1.Size = new System.Drawing.Size(655, 490);
            this.converterTabCtrl1.TabIndex = 0;
            // 
            // tabPageDenoising
            // 
            this.tabPageDenoising.Controls.Add(this.denoisingTabCtrl1);
            this.tabPageDenoising.Location = new System.Drawing.Point(4, 22);
            this.tabPageDenoising.Name = "tabPageDenoising";
            this.tabPageDenoising.Size = new System.Drawing.Size(661, 496);
            this.tabPageDenoising.TabIndex = 8;
            this.tabPageDenoising.Text = "Denoising";
            this.tabPageDenoising.UseVisualStyleBackColor = true;
            // 
            // denoisingTabCtrl1
            // 
            this.denoisingTabCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.denoisingTabCtrl1.Location = new System.Drawing.Point(0, 0);
            this.denoisingTabCtrl1.Name = "denoisingTabCtrl1";
            this.denoisingTabCtrl1.Size = new System.Drawing.Size(653, 493);
            this.denoisingTabCtrl1.TabIndex = 0;
            // 
            // tabPageEdge
            // 
            this.tabPageEdge.Controls.Add(this.edgeDitectTabCtrl1);
            this.tabPageEdge.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdge.Name = "tabPageEdge";
            this.tabPageEdge.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdge.Size = new System.Drawing.Size(661, 496);
            this.tabPageEdge.TabIndex = 0;
            this.tabPageEdge.Text = "Edge";
            this.tabPageEdge.UseVisualStyleBackColor = true;
            // 
            // edgeDitectTabCtrl1
            // 
            this.edgeDitectTabCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edgeDitectTabCtrl1.Location = new System.Drawing.Point(0, 0);
            this.edgeDitectTabCtrl1.Name = "edgeDitectTabCtrl1";
            this.edgeDitectTabCtrl1.Size = new System.Drawing.Size(653, 490);
            this.edgeDitectTabCtrl1.TabIndex = 0;
            // 
            // tabPageFilter2D
            // 
            this.tabPageFilter2D.Controls.Add(this.filter2DCtrl1);
            this.tabPageFilter2D.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilter2D.Name = "tabPageFilter2D";
            this.tabPageFilter2D.Size = new System.Drawing.Size(661, 496);
            this.tabPageFilter2D.TabIndex = 7;
            this.tabPageFilter2D.Text = "Filter2D";
            this.tabPageFilter2D.UseVisualStyleBackColor = true;
            // 
            // filter2DCtrl1
            // 
            this.filter2DCtrl1.Location = new System.Drawing.Point(3, 3);
            this.filter2DCtrl1.Name = "filter2DCtrl1";
            this.filter2DCtrl1.Size = new System.Drawing.Size(570, 500);
            this.filter2DCtrl1.TabIndex = 0;
            // 
            // tabPageConvTest
            // 
            this.tabPageConvTest.Controls.Add(this.convolutionTestCtrl1);
            this.tabPageConvTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageConvTest.Name = "tabPageConvTest";
            this.tabPageConvTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConvTest.Size = new System.Drawing.Size(661, 496);
            this.tabPageConvTest.TabIndex = 9;
            this.tabPageConvTest.Text = "Convolution Test";
            this.tabPageConvTest.UseVisualStyleBackColor = true;
            // 
            // convolutionTestCtrl1
            // 
            this.convolutionTestCtrl1.Location = new System.Drawing.Point(0, 0);
            this.convolutionTestCtrl1.Name = "convolutionTestCtrl1";
            this.convolutionTestCtrl1.Size = new System.Drawing.Size(628, 360);
            this.convolutionTestCtrl1.TabIndex = 0;
            // 
            // tabPageRoi
            // 
            this.tabPageRoi.Controls.Add(this.roiSettingCtrl1);
            this.tabPageRoi.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoi.Name = "tabPageRoi";
            this.tabPageRoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoi.Size = new System.Drawing.Size(661, 496);
            this.tabPageRoi.TabIndex = 10;
            this.tabPageRoi.Text = "Roi";
            this.tabPageRoi.UseVisualStyleBackColor = true;
            // 
            // roiSettingCtrl1
            // 
            this.roiSettingCtrl1.Location = new System.Drawing.Point(8, 6);
            this.roiSettingCtrl1.Name = "roiSettingCtrl1";
            this.roiSettingCtrl1.Size = new System.Drawing.Size(299, 419);
            this.roiSettingCtrl1.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(560, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 28);
            this.panel1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(578, 355);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "imread";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(578, 355);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "imwrite";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(580, 354);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Sobel";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Visible = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(580, 354);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Canny";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Visible = false;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(580, 354);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Laplacian";
            this.tabPage9.UseVisualStyleBackColor = true;
            this.tabPage9.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 74);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(192, 74);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FontChanged += new System.EventHandler(this.Form1_FontChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPageImageFile.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPageConverter.ResumeLayout(false);
            this.tabPageDenoising.ResumeLayout(false);
            this.tabPageEdge.ResumeLayout(false);
            this.tabPageFilter2D.ResumeLayout(false);
            this.tabPageConvTest.ResumeLayout(false);
            this.tabPageRoi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageImageFile;
        private System.Windows.Forms.TabPage tabPageEdge;
        private System.Windows.Forms.TabPage tabPageConverter;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TabPage tabPageFilter2D;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageDenoising;
        private System.Windows.Forms.TabPage tabPageConvTest;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private Filter2DCtrl filter2DCtrl1;
        private ConvolutionTestCtrl convolutionTestCtrl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPageRoi;
        private Common.RoiSettingCtrl roiSettingCtrl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage10;
        private ImreadCtrl imreadCtrl1;
        private System.Windows.Forms.TabPage tabPage11;
        private ImwriteCtrl imwriteCtrl1;
        private Converter.ConverterTabCtrl converterTabCtrl1;
        private Edge.EdgeDitectTabCtrl edgeDitectTabCtrl1;
        private Denoising.DenoisingTabCtrl denoisingTabCtrl1;
    }
}

