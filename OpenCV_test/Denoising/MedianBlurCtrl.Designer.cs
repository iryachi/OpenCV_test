﻿
namespace OpenCV_test
{
    partial class MedianBlurCtrl
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
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.kernelSizeCtrl1 = new OpenCV_test.Common.KernelSizeCtrl();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(6, 141);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 44;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(178, 112);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 43;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // kernelSizeCtrl1
            // 
            this.kernelSizeCtrl1.DefaultIndex = 1;
            this.kernelSizeCtrl1.Location = new System.Drawing.Point(3, 59);
            this.kernelSizeCtrl1.Name = "kernelSizeCtrl1";
            this.kernelSizeCtrl1.Size = new System.Drawing.Size(50, 50);
            this.kernelSizeCtrl1.TabIndex = 47;
            this.kernelSizeCtrl1.Title = "ksize";
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InNo = 0;
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(3, 3);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutNo = 1;
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(150, 50);
            this.imageInOutCtrl1.TabIndex = 46;
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(159, 3);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(200, 50);
            this.roiCtrl1.TabIndex = 57;
            // 
            // MedianBlurCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.kernelSizeCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Name = "MedianBlurCtrl";
            this.Size = new System.Drawing.Size(367, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.KernelSizeCtrl kernelSizeCtrl1;
        private Common.RoiCtrl roiCtrl1;
    }
}
