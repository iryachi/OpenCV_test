
namespace OpenCV_test
{
    partial class GaussianBlurCtrl
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
            this.buttonExec = new System.Windows.Forms.Button();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.numXYCtrlKSize = new OpenCV_test.Common.NumXYCtrl();
            this.numXYCtrlSigma = new OpenCV_test.Common.NumXYCtrl();
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            this.SuspendLayout();
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(213, 195);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 55;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(7, 245);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "Parameter";
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InNo = 0;
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(7, 0);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutNo = 1;
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(200, 50);
            this.imageInOutCtrl1.TabIndex = 0;
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.BorderNo = 3;
            this.borderTypeCtrl1.Location = new System.Drawing.Point(7, 168);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(200, 50);
            this.borderTypeCtrl1.TabIndex = 0;
            // 
            // numXYCtrlKSize
            // 
            this.numXYCtrlKSize.DefaultX = 1;
            this.numXYCtrlKSize.DefaultY = 1;
            this.numXYCtrlKSize.Location = new System.Drawing.Point(7, 56);
            this.numXYCtrlKSize.MaxX = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrlKSize.MaxY = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrlKSize.MinX = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXYCtrlKSize.MinY = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXYCtrlKSize.Name = "numXYCtrlKSize";
            this.numXYCtrlKSize.Size = new System.Drawing.Size(200, 50);
            this.numXYCtrlKSize.TabIndex = 65;
            this.numXYCtrlKSize.Title = "ksize";
            this.numXYCtrlKSize.XTitle = "X";
            this.numXYCtrlKSize.YTitle = "Y";
            // 
            // numXYCtrlSigma
            // 
            this.numXYCtrlSigma.DefaultX = -1;
            this.numXYCtrlSigma.DefaultY = -1;
            this.numXYCtrlSigma.Location = new System.Drawing.Point(7, 112);
            this.numXYCtrlSigma.MaxX = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrlSigma.MaxY = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrlSigma.MinX = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numXYCtrlSigma.MinY = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numXYCtrlSigma.Name = "numXYCtrlSigma";
            this.numXYCtrlSigma.Size = new System.Drawing.Size(200, 50);
            this.numXYCtrlSigma.TabIndex = 65;
            this.numXYCtrlSigma.Title = "sigma";
            this.numXYCtrlSigma.XTitle = "X";
            this.numXYCtrlSigma.YTitle = "Y";
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(213, 0);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(200, 50);
            this.roiCtrl1.TabIndex = 66;
            // 
            // GaussianBlurCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.numXYCtrlSigma);
            this.Controls.Add(this.numXYCtrlKSize);
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Name = "GaussianBlurCtrl";
            this.Size = new System.Drawing.Size(423, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private Common.NumXYCtrl numXYCtrlKSize;
        private Common.NumXYCtrl numXYCtrlSigma;
        private Common.RoiCtrl roiCtrl1;
    }
}
