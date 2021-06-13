
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
            this.imageFileTab1 = new OpenCV_test.ImageFileTab();
            this.tabPageConverter = new System.Windows.Forms.TabPage();
            this.converterTab1 = new OpenCV_test.ConverterTab();
            this.tabPageDenoising = new System.Windows.Forms.TabPage();
            this.tabPageEdge = new System.Windows.Forms.TabPage();
            this.edgeDitectionTab1 = new OpenCV_test.EdgeDitectionTab();
            this.tabPageFilter2D = new System.Windows.Forms.TabPage();
            this.tabPageConvTest = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.filter2DCtrl1 = new OpenCV_test.Filter2DCtrl();
            this.convolutionTestCtrl1 = new OpenCV_test.ConvolutionTestCtrl();
            this.denoisingTab1 = new OpenCV_test.DenoisingTab();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageImageFile.SuspendLayout();
            this.tabPageConverter.SuspendLayout();
            this.tabPageDenoising.SuspendLayout();
            this.tabPageEdge.SuspendLayout();
            this.tabPageFilter2D.SuspendLayout();
            this.tabPageConvTest.SuspendLayout();
            this.panel1.SuspendLayout();
            this.denoisingTab1.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 522);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageImageFile
            // 
            this.tabPageImageFile.Controls.Add(this.imageFileTab1);
            this.tabPageImageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageImageFile.Name = "tabPageImageFile";
            this.tabPageImageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImageFile.Size = new System.Drawing.Size(594, 389);
            this.tabPageImageFile.TabIndex = 1;
            this.tabPageImageFile.Text = "File";
            this.tabPageImageFile.UseVisualStyleBackColor = true;
            // 
            // imageFileTab1
            // 
            this.imageFileTab1.Location = new System.Drawing.Point(0, 0);
            this.imageFileTab1.Name = "imageFileTab1";
            this.imageFileTab1.SelectedIndex = 0;
            this.imageFileTab1.Size = new System.Drawing.Size(586, 381);
            this.imageFileTab1.TabIndex = 0;
            // 
            // tabPageConverter
            // 
            this.tabPageConverter.Controls.Add(this.converterTab1);
            this.tabPageConverter.Location = new System.Drawing.Point(4, 22);
            this.tabPageConverter.Name = "tabPageConverter";
            this.tabPageConverter.Size = new System.Drawing.Size(661, 496);
            this.tabPageConverter.TabIndex = 2;
            this.tabPageConverter.Text = "Converter";
            this.tabPageConverter.UseVisualStyleBackColor = true;
            // 
            // converterTab1
            // 
            this.converterTab1.Location = new System.Drawing.Point(3, 3);
            this.converterTab1.Name = "converterTab1";
            this.converterTab1.SelectedIndex = 0;
            this.converterTab1.Size = new System.Drawing.Size(583, 383);
            this.converterTab1.TabIndex = 0;
            // 
            // tabPageDenoising
            // 
            this.tabPageDenoising.Controls.Add(this.denoisingTab1);
            this.tabPageDenoising.Location = new System.Drawing.Point(4, 22);
            this.tabPageDenoising.Name = "tabPageDenoising";
            this.tabPageDenoising.Size = new System.Drawing.Size(661, 496);
            this.tabPageDenoising.TabIndex = 8;
            this.tabPageDenoising.Text = "Denoising";
            this.tabPageDenoising.UseVisualStyleBackColor = true;
            // 
            // tabPageEdge
            // 
            this.tabPageEdge.Controls.Add(this.edgeDitectionTab1);
            this.tabPageEdge.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdge.Name = "tabPageEdge";
            this.tabPageEdge.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdge.Size = new System.Drawing.Size(661, 496);
            this.tabPageEdge.TabIndex = 0;
            this.tabPageEdge.Text = "Edge";
            this.tabPageEdge.UseVisualStyleBackColor = true;
            // 
            // edgeDitectionTab1
            // 
            this.edgeDitectionTab1.Location = new System.Drawing.Point(3, 3);
            this.edgeDitectionTab1.Name = "edgeDitectionTab1";
            this.edgeDitectionTab1.SelectedIndex = 0;
            this.edgeDitectionTab1.Size = new System.Drawing.Size(588, 380);
            this.edgeDitectionTab1.TabIndex = 0;
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
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(582, 3);
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
            // filter2DCtrl1
            // 
            this.filter2DCtrl1.Location = new System.Drawing.Point(3, 3);
            this.filter2DCtrl1.Name = "filter2DCtrl1";
            this.filter2DCtrl1.Size = new System.Drawing.Size(570, 500);
            this.filter2DCtrl1.TabIndex = 0;
            // 
            // convolutionTestCtrl1
            // 
            this.convolutionTestCtrl1.Location = new System.Drawing.Point(0, 0);
            this.convolutionTestCtrl1.Name = "convolutionTestCtrl1";
            this.convolutionTestCtrl1.Size = new System.Drawing.Size(628, 360);
            this.convolutionTestCtrl1.TabIndex = 0;
            // 
            // denoisingTab1
            // 
            this.denoisingTab1.Location = new System.Drawing.Point(0, 0);
            this.denoisingTab1.Name = "denoisingTab1";
            this.denoisingTab1.SelectedIndex = 0;
            this.denoisingTab1.Size = new System.Drawing.Size(552, 413);
            this.denoisingTab1.TabIndex = 0;
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
            this.tabPageConverter.ResumeLayout(false);
            this.tabPageDenoising.ResumeLayout(false);
            this.tabPageEdge.ResumeLayout(false);
            this.tabPageFilter2D.ResumeLayout(false);
            this.tabPageConvTest.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.denoisingTab1.ResumeLayout(false);
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
        private ImageFileTab imageFileTab1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ConverterTab converterTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private EdgeDitectionTab edgeDitectionTab1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private Filter2DCtrl filter2DCtrl1;
        private ConvolutionTestCtrl convolutionTestCtrl1;
        private DenoisingTab denoisingTab1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}

