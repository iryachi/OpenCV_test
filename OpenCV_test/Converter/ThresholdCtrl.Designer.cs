
namespace OpenCV_test
{
    partial class ThresholdCtrl
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberTextBoxThreshold = new OpenCV_test.NumberTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numberTextBoxMaxVal = new OpenCV_test.NumberTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(6, 18);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxType.TabIndex = 3;
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(172, 165);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 0;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(0, 207);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Parameter";
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
            this.imageInOutCtrl1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numberTextBoxThreshold);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numberTextBoxMaxVal);
            this.groupBox1.Location = new System.Drawing.Point(3, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 50);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "threshold";
            // 
            // numberTextBoxThreshold
            // 
            this.numberTextBoxThreshold.Data = 128D;
            this.numberTextBoxThreshold.DotNum = 5;
            this.numberTextBoxThreshold.Location = new System.Drawing.Point(8, 27);
            this.numberTextBoxThreshold.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxThreshold.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxThreshold.Name = "numberTextBoxThreshold";
            this.numberTextBoxThreshold.Size = new System.Drawing.Size(60, 19);
            this.numberTextBoxThreshold.TabIndex = 28;
            this.numberTextBoxThreshold.Text = "128.0000000000";
            this.numberTextBoxThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "maxVal";
            // 
            // numberTextBoxMaxVal
            // 
            this.numberTextBoxMaxVal.Data = 256D;
            this.numberTextBoxMaxVal.DotNum = 5;
            this.numberTextBoxMaxVal.Location = new System.Drawing.Point(79, 27);
            this.numberTextBoxMaxVal.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxMaxVal.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxMaxVal.Name = "numberTextBoxMaxVal";
            this.numberTextBoxMaxVal.Size = new System.Drawing.Size(60, 19);
            this.numberTextBoxMaxVal.TabIndex = 28;
            this.numberTextBoxMaxVal.Text = "256.00000";
            this.numberTextBoxMaxVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxType);
            this.groupBox2.Location = new System.Drawing.Point(3, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 50);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "type";
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(159, 0);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(200, 50);
            this.roiCtrl1.TabIndex = 57;
            // 
            // ThresholdCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Name = "ThresholdCtrl";
            this.Size = new System.Drawing.Size(408, 356);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private NumberTextBox numberTextBoxThreshold;
        private System.Windows.Forms.Label label5;
        private NumberTextBox numberTextBoxMaxVal;
        private System.Windows.Forms.GroupBox groupBox2;
        private Common.RoiCtrl roiCtrl1;
    }
}
