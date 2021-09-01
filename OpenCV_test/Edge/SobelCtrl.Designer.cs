
namespace OpenCV_test
{
    partial class SobelCtrl
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
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.depthCtrl1 = new OpenCV_test.Common.DepthCtrl();
            this.kernelSizeCtrl1 = new OpenCV_test.Common.KernelSizeCtrl();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.numXYCtrl1 = new OpenCV_test.Common.NumXYCtrl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTextBoxScale = new OpenCV_test.NumberTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberTextBoxDelta = new OpenCV_test.NumberTextBox();
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(3, 319);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(124, 280);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 9;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InNo = 0;
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(0, 0);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutNo = 1;
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(200, 50);
            this.imageInOutCtrl1.TabIndex = 49;
            // 
            // depthCtrl1
            // 
            this.depthCtrl1.Location = new System.Drawing.Point(0, 56);
            this.depthCtrl1.Name = "depthCtrl1";
            this.depthCtrl1.Size = new System.Drawing.Size(200, 50);
            this.depthCtrl1.TabIndex = 50;
            // 
            // kernelSizeCtrl1
            // 
            this.kernelSizeCtrl1.DefaultIndex = 1;
            this.kernelSizeCtrl1.Location = new System.Drawing.Point(141, 168);
            this.kernelSizeCtrl1.Name = "kernelSizeCtrl1";
            this.kernelSizeCtrl1.Size = new System.Drawing.Size(59, 50);
            this.kernelSizeCtrl1.TabIndex = 51;
            this.kernelSizeCtrl1.Title = "ksize";
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.BorderNo = 3;
            this.borderTypeCtrl1.Location = new System.Drawing.Point(-1, 224);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(200, 50);
            this.borderTypeCtrl1.TabIndex = 52;
            // 
            // numXYCtrl1
            // 
            this.numXYCtrl1.DefaultX = 1;
            this.numXYCtrl1.DefaultY = 0;
            this.numXYCtrl1.Location = new System.Drawing.Point(0, 112);
            this.numXYCtrl1.MaxX = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrl1.MaxY = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXYCtrl1.MinX = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numXYCtrl1.MinY = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numXYCtrl1.Name = "numXYCtrl1";
            this.numXYCtrl1.Size = new System.Drawing.Size(200, 50);
            this.numXYCtrl1.TabIndex = 53;
            this.numXYCtrl1.Title = "";
            this.numXYCtrl1.XTitle = "dx";
            this.numXYCtrl1.YTitle = "dy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numberTextBoxScale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numberTextBoxDelta);
            this.groupBox1.Location = new System.Drawing.Point(0, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 50);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "scale";
            // 
            // numberTextBoxScale
            // 
            this.numberTextBoxScale.Data = 1D;
            this.numberTextBoxScale.DotNum = 10;
            this.numberTextBoxScale.Location = new System.Drawing.Point(8, 27);
            this.numberTextBoxScale.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxScale.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxScale.Name = "numberTextBoxScale";
            this.numberTextBoxScale.Size = new System.Drawing.Size(60, 19);
            this.numberTextBoxScale.TabIndex = 28;
            this.numberTextBoxScale.Text = "1";
            this.numberTextBoxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "delta";
            // 
            // numberTextBoxDelta
            // 
            this.numberTextBoxDelta.Data = 0D;
            this.numberTextBoxDelta.DotNum = 10;
            this.numberTextBoxDelta.Location = new System.Drawing.Point(74, 27);
            this.numberTextBoxDelta.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxDelta.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxDelta.Name = "numberTextBoxDelta";
            this.numberTextBoxDelta.Size = new System.Drawing.Size(60, 19);
            this.numberTextBoxDelta.TabIndex = 28;
            this.numberTextBoxDelta.Text = "0";
            this.numberTextBoxDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(206, 0);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(200, 50);
            this.roiCtrl1.TabIndex = 57;
            // 
            // SobelCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numXYCtrl1);
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.kernelSizeCtrl1);
            this.Controls.Add(this.depthCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Name = "SobelCtrl";
            this.Size = new System.Drawing.Size(465, 470);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.DepthCtrl depthCtrl1;
        private Common.KernelSizeCtrl kernelSizeCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private Common.NumXYCtrl numXYCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private NumberTextBox numberTextBoxScale;
        private System.Windows.Forms.Label label4;
        private NumberTextBox numberTextBoxDelta;
        private Common.RoiCtrl roiCtrl1;
    }
}
