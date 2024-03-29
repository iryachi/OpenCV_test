﻿
namespace OpenCV_test
{
    partial class BilateralFilterCtrl
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberTextBoxSigmaSpace = new OpenCV_test.NumberTextBox();
            this.numberTextBoxSigmaColor = new OpenCV_test.NumberTextBox();
            this.numberTextBoxD = new OpenCV_test.NumberTextBox();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(3, 192);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 54;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(254, 142);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 53;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 59;
            this.label2.Text = "sigmaSpace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 60;
            this.label1.Text = "sigmaColor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "d";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberTextBoxSigmaSpace);
            this.groupBox1.Controls.Add(this.numberTextBoxSigmaColor);
            this.groupBox1.Controls.Add(this.numberTextBoxD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 53);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // numberTextBoxSigmaSpace
            // 
            this.numberTextBoxSigmaSpace.Data = 0D;
            this.numberTextBoxSigmaSpace.DotNum = 5;
            this.numberTextBoxSigmaSpace.Location = new System.Drawing.Point(148, 28);
            this.numberTextBoxSigmaSpace.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxSigmaSpace.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxSigmaSpace.Name = "numberTextBoxSigmaSpace";
            this.numberTextBoxSigmaSpace.Size = new System.Drawing.Size(80, 19);
            this.numberTextBoxSigmaSpace.TabIndex = 62;
            this.numberTextBoxSigmaSpace.Text = "0.00000";
            this.numberTextBoxSigmaSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberTextBoxSigmaColor
            // 
            this.numberTextBoxSigmaColor.Data = 0D;
            this.numberTextBoxSigmaColor.DotNum = 5;
            this.numberTextBoxSigmaColor.Location = new System.Drawing.Point(62, 28);
            this.numberTextBoxSigmaColor.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxSigmaColor.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxSigmaColor.Name = "numberTextBoxSigmaColor";
            this.numberTextBoxSigmaColor.Size = new System.Drawing.Size(80, 19);
            this.numberTextBoxSigmaColor.TabIndex = 62;
            this.numberTextBoxSigmaColor.Text = "0.00000";
            this.numberTextBoxSigmaColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberTextBoxD
            // 
            this.numberTextBoxD.Data = -1D;
            this.numberTextBoxD.DotNum = 0;
            this.numberTextBoxD.Location = new System.Drawing.Point(6, 28);
            this.numberTextBoxD.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxD.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxD.Name = "numberTextBoxD";
            this.numberTextBoxD.Size = new System.Drawing.Size(50, 19);
            this.numberTextBoxD.TabIndex = 62;
            this.numberTextBoxD.Text = "-1";
            this.numberTextBoxD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.BorderNo = 3;
            this.borderTypeCtrl1.Location = new System.Drawing.Point(3, 115);
            this.borderTypeCtrl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(244, 50);
            this.borderTypeCtrl1.TabIndex = 56;
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InNo = 0;
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(3, 3);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutNo = 1;
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(244, 50);
            this.imageInOutCtrl1.TabIndex = 50;
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(265, 4);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(200, 50);
            this.roiCtrl1.TabIndex = 62;
            // 
            // BilateralFilterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Name = "BilateralFilterCtrl";
            this.Size = new System.Drawing.Size(474, 355);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private NumberTextBox numberTextBoxD;
        private NumberTextBox numberTextBoxSigmaSpace;
        private NumberTextBox numberTextBoxSigmaColor;
        private Common.RoiCtrl roiCtrl1;
    }
}
