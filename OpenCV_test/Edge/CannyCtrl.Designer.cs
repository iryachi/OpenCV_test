
namespace OpenCV_test
{
    partial class CannyCtrl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxL2grradient = new System.Windows.Forms.CheckBox();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.kernelSizeCtrl1 = new OpenCV_test.Common.KernelSizeCtrl();
            this.groupBoxThreshold = new System.Windows.Forms.GroupBox();
            this.numberTextBoxThreshold2 = new OpenCV_test.NumberTextBox();
            this.numberTextBoxThreshold1 = new OpenCV_test.NumberTextBox();
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            this.groupBoxThreshold.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "1";
            // 
            // checkBoxL2grradient
            // 
            this.checkBoxL2grradient.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxL2grradient.Location = new System.Drawing.Point(25, 156);
            this.checkBoxL2grradient.Name = "checkBoxL2grradient";
            this.checkBoxL2grradient.Size = new System.Drawing.Size(78, 24);
            this.checkBoxL2grradient.TabIndex = 30;
            this.checkBoxL2grradient.Text = "L2gradient";
            this.checkBoxL2grradient.UseVisualStyleBackColor = true;
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(0, 242);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 146);
            this.textBoxParameter.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(172, 195);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 33;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InNo = 0;
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(3, 0);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutNo = 1;
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(150, 50);
            this.imageInOutCtrl1.TabIndex = 47;
            // 
            // kernelSizeCtrl1
            // 
            this.kernelSizeCtrl1.DefaultIndex = 2;
            this.kernelSizeCtrl1.Location = new System.Drawing.Point(3, 100);
            this.kernelSizeCtrl1.Name = "kernelSizeCtrl1";
            this.kernelSizeCtrl1.Size = new System.Drawing.Size(100, 50);
            this.kernelSizeCtrl1.TabIndex = 48;
            this.kernelSizeCtrl1.Title = "apertureSize";
            // 
            // groupBoxThreshold
            // 
            this.groupBoxThreshold.Controls.Add(this.numberTextBoxThreshold2);
            this.groupBoxThreshold.Controls.Add(this.numberTextBoxThreshold1);
            this.groupBoxThreshold.Controls.Add(this.label1);
            this.groupBoxThreshold.Controls.Add(this.label2);
            this.groupBoxThreshold.Location = new System.Drawing.Point(3, 50);
            this.groupBoxThreshold.Name = "groupBoxThreshold";
            this.groupBoxThreshold.Size = new System.Drawing.Size(150, 50);
            this.groupBoxThreshold.TabIndex = 49;
            this.groupBoxThreshold.TabStop = false;
            this.groupBoxThreshold.Text = "Threshold";
            // 
            // numberTextBoxThreshold2
            // 
            this.numberTextBoxThreshold2.Data = 0D;
            this.numberTextBoxThreshold2.DotNum = 100;
            this.numberTextBoxThreshold2.Location = new System.Drawing.Point(64, 25);
            this.numberTextBoxThreshold2.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxThreshold2.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxThreshold2.Name = "numberTextBoxThreshold2";
            this.numberTextBoxThreshold2.Size = new System.Drawing.Size(50, 19);
            this.numberTextBoxThreshold2.TabIndex = 50;
            this.numberTextBoxThreshold2.Text = "0";
            this.numberTextBoxThreshold2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberTextBoxThreshold1
            // 
            this.numberTextBoxThreshold1.Data = 0D;
            this.numberTextBoxThreshold1.DotNum = 100;
            this.numberTextBoxThreshold1.Location = new System.Drawing.Point(8, 25);
            this.numberTextBoxThreshold1.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxThreshold1.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxThreshold1.Name = "numberTextBoxThreshold1";
            this.numberTextBoxThreshold1.Size = new System.Drawing.Size(50, 19);
            this.numberTextBoxThreshold1.TabIndex = 50;
            this.numberTextBoxThreshold1.Text = "0";
            this.numberTextBoxThreshold1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(159, 0);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(200, 50);
            this.roiCtrl1.TabIndex = 57;
            // 
            // CannyCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.groupBoxThreshold);
            this.Controls.Add(this.kernelSizeCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxL2grradient);
            this.Name = "CannyCtrl";
            this.Size = new System.Drawing.Size(370, 393);
            this.groupBoxThreshold.ResumeLayout(false);
            this.groupBoxThreshold.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxL2grradient;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.KernelSizeCtrl kernelSizeCtrl1;
        private System.Windows.Forms.GroupBox groupBoxThreshold;
        private NumberTextBox numberTextBoxThreshold1;
        private NumberTextBox numberTextBoxThreshold2;
        private Common.RoiCtrl roiCtrl1;
    }
}
