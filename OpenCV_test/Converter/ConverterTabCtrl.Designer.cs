
namespace OpenCV_test.Converter
{
    partial class ConverterTabCtrl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bitDepthConverterCtrl1 = new OpenCV_test.BitDepthConverterCtrl();
            this.cvtColorCtrl1 = new OpenCV_test.CvtColorCtrl();
            this.thresholdCtrl1 = new OpenCV_test.ThresholdCtrl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bitDepthConverterCtrl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BitDepth";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cvtColorCtrl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CvtColor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.thresholdCtrl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(559, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ThresholdCtrl";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bitDepthConverterCtrl1
            // 
            this.bitDepthConverterCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitDepthConverterCtrl1.Location = new System.Drawing.Point(8, 8);
            this.bitDepthConverterCtrl1.Name = "bitDepthConverterCtrl1";
            this.bitDepthConverterCtrl1.Size = new System.Drawing.Size(545, 340);
            this.bitDepthConverterCtrl1.TabIndex = 0;
            // 
            // cvtColorCtrl1
            // 
            this.cvtColorCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvtColorCtrl1.Location = new System.Drawing.Point(6, 6);
            this.cvtColorCtrl1.Name = "cvtColorCtrl1";
            this.cvtColorCtrl1.Size = new System.Drawing.Size(547, 387);
            this.cvtColorCtrl1.TabIndex = 0;
            // 
            // thresholdCtrl1
            // 
            this.thresholdCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdCtrl1.Location = new System.Drawing.Point(3, 3);
            this.thresholdCtrl1.Name = "thresholdCtrl1";
            this.thresholdCtrl1.Size = new System.Drawing.Size(553, 390);
            this.thresholdCtrl1.TabIndex = 0;
            // 
            // ConverterTabCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ConverterTabCtrl";
            this.Size = new System.Drawing.Size(570, 425);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BitDepthConverterCtrl bitDepthConverterCtrl1;
        private System.Windows.Forms.TabPage tabPage2;
        private CvtColorCtrl cvtColorCtrl1;
        private System.Windows.Forms.TabPage tabPage3;
        private ThresholdCtrl thresholdCtrl1;
    }
}
