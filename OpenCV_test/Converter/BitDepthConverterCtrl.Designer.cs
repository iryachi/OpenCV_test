
namespace OpenCV_test
{
    partial class BitDepthConverterCtrl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberTextBoxScale = new OpenCV_test.NumberTextBox();
            this.numberTextBoxDelta = new OpenCV_test.NumberTextBox();
            this.depthCtrl1 = new OpenCV_test.Common.DepthCtrl();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(5, 163);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(292, 111);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 16;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "delta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "scale";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 46);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Example\r\nCV_8U -> CV_16U   scale = 256\r\nCV_8U -> CV_16S   scale = 256, delta = -3" +
    "2767";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numberTextBoxScale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberTextBoxDelta);
            this.groupBox1.Location = new System.Drawing.Point(5, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 50);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
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
            // depthCtrl1
            // 
            this.depthCtrl1.Location = new System.Drawing.Point(167, 3);
            this.depthCtrl1.Name = "depthCtrl1";
            this.depthCtrl1.Size = new System.Drawing.Size(200, 50);
            this.depthCtrl1.TabIndex = 26;
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(5, 3);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(150, 50);
            this.imageInOutCtrl1.TabIndex = 25;
            // 
            // BitDepthConverterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.depthCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Name = "BitDepthConverterCtrl";
            this.Size = new System.Drawing.Size(430, 317);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.DepthCtrl depthCtrl1;
        private System.Windows.Forms.TextBox textBox1;
        private NumberTextBox numberTextBoxDelta;
        private NumberTextBox numberTextBoxScale;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
