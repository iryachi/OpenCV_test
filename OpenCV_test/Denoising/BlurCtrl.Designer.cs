
namespace OpenCV_test
{
    partial class BlurCtrl
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
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.numXYCtrlKSize = new OpenCV_test.Common.NumXYCtrl();
            this.numXYCtrlAnchor = new OpenCV_test.Common.NumXYCtrl();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(5, 213);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(334, 142);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 22;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(209, 3);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(200, 50);
            this.roiCtrl1.TabIndex = 56;
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.BorderNo = 0;
            this.borderTypeCtrl1.Location = new System.Drawing.Point(0, 115);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(200, 50);
            this.borderTypeCtrl1.TabIndex = 52;
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.Location = new System.Drawing.Point(3, 3);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.Size = new System.Drawing.Size(200, 50);
            this.imageInOutCtrl1.TabIndex = 51;
            // 
            // numXYCtrlKSize
            // 
            this.numXYCtrlKSize.DefaultX = 1;
            this.numXYCtrlKSize.DefaultY = 1;
            this.numXYCtrlKSize.Location = new System.Drawing.Point(3, 59);
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
            this.numXYCtrlKSize.TabIndex = 55;
            this.numXYCtrlKSize.Title = "ksize";
            this.numXYCtrlKSize.XTitle = "X";
            this.numXYCtrlKSize.YTitle = "Y";
            // 
            // numXYCtrlAnchor
            // 
            this.numXYCtrlAnchor.DefaultX = -1;
            this.numXYCtrlAnchor.DefaultY = -1;
            this.numXYCtrlAnchor.Location = new System.Drawing.Point(209, 59);
            this.numXYCtrlAnchor.MaxX = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrlAnchor.MaxY = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrlAnchor.MinX = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numXYCtrlAnchor.MinY = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numXYCtrlAnchor.Name = "numXYCtrlAnchor";
            this.numXYCtrlAnchor.Size = new System.Drawing.Size(200, 50);
            this.numXYCtrlAnchor.TabIndex = 55;
            this.numXYCtrlAnchor.Title = "anchor";
            this.numXYCtrlAnchor.XTitle = "X";
            this.numXYCtrlAnchor.YTitle = "Y";
            // 
            // BlurCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numXYCtrlAnchor);
            this.Controls.Add(this.numXYCtrlKSize);
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Name = "BlurCtrl";
            this.Size = new System.Drawing.Size(530, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private Common.RoiCtrl roiCtrl1;
        private Common.NumXYCtrl numXYCtrlKSize;
        private Common.NumXYCtrl numXYCtrlAnchor;
    }
}
