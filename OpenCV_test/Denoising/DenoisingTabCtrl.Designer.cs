﻿
namespace OpenCV_test.Denoising
{
    partial class DenoisingTabCtrl
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
            this.medianBlurCtrl1 = new OpenCV_test.MedianBlurCtrl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.blurCtrl1 = new OpenCV_test.BlurCtrl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gaussianBlurCtrl1 = new OpenCV_test.GaussianBlurCtrl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bilateralFilterCtrl1 = new OpenCV_test.BilateralFilterCtrl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.medianBlurCtrl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Median";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // medianBlurCtrl1
            // 
            this.medianBlurCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medianBlurCtrl1.Location = new System.Drawing.Point(6, 6);
            this.medianBlurCtrl1.Name = "medianBlurCtrl1";
            this.medianBlurCtrl1.Size = new System.Drawing.Size(559, 404);
            this.medianBlurCtrl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.blurCtrl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // blurCtrl1
            // 
            this.blurCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blurCtrl1.Location = new System.Drawing.Point(6, 6);
            this.blurCtrl1.Name = "blurCtrl1";
            this.blurCtrl1.Size = new System.Drawing.Size(559, 404);
            this.blurCtrl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gaussianBlurCtrl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(571, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gaussian";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gaussianBlurCtrl1
            // 
            this.gaussianBlurCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gaussianBlurCtrl1.Location = new System.Drawing.Point(3, 3);
            this.gaussianBlurCtrl1.Name = "gaussianBlurCtrl1";
            this.gaussianBlurCtrl1.Size = new System.Drawing.Size(565, 410);
            this.gaussianBlurCtrl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bilateralFilterCtrl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(571, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bilateral";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bilateralFilterCtrl1
            // 
            this.bilateralFilterCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bilateralFilterCtrl1.Location = new System.Drawing.Point(3, 3);
            this.bilateralFilterCtrl1.Name = "bilateralFilterCtrl1";
            this.bilateralFilterCtrl1.Size = new System.Drawing.Size(565, 410);
            this.bilateralFilterCtrl1.TabIndex = 0;
            // 
            // DenoisingTabCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DenoisingTabCtrl";
            this.Size = new System.Drawing.Size(585, 448);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MedianBlurCtrl medianBlurCtrl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private BlurCtrl blurCtrl1;
        private GaussianBlurCtrl gaussianBlurCtrl1;
        private BilateralFilterCtrl bilateralFilterCtrl1;
    }
}
