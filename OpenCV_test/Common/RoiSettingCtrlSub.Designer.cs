
namespace OpenCV_test.Common
{
    partial class RoiSettingCtrlSub
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
            this.labelX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberTextBoxX = new OpenCV_test.NumberTextBox();
            this.numberTextBoxY = new OpenCV_test.NumberTextBox();
            this.numberTextBoxWidth = new OpenCV_test.NumberTextBox();
            this.numberTextBoxHeight = new OpenCV_test.NumberTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(6, 21);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(12, 12);
            this.labelX.TabIndex = 26;
            this.labelX.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "Height";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(212, 41);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(50, 23);
            this.buttonSet.TabIndex = 27;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberTextBoxY);
            this.groupBox1.Controls.Add(this.numberTextBoxHeight);
            this.groupBox1.Controls.Add(this.numberTextBoxWidth);
            this.groupBox1.Controls.Add(this.numberTextBoxX);
            this.groupBox1.Controls.Add(this.buttonSet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 70);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "0";
            // 
            // numberTextBoxX
            // 
            this.numberTextBoxX.Data = 0D;
            this.numberTextBoxX.DotNum = 0;
            this.numberTextBoxX.Location = new System.Drawing.Point(45, 18);
            this.numberTextBoxX.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxX.MinVal = 0D;
            this.numberTextBoxX.Name = "numberTextBoxX";
            this.numberTextBoxX.Size = new System.Drawing.Size(50, 19);
            this.numberTextBoxX.TabIndex = 28;
            this.numberTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberTextBoxY
            // 
            this.numberTextBoxY.Data = 0D;
            this.numberTextBoxY.DotNum = 0;
            this.numberTextBoxY.Location = new System.Drawing.Point(156, 18);
            this.numberTextBoxY.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxY.MinVal = 0D;
            this.numberTextBoxY.Name = "numberTextBoxY";
            this.numberTextBoxY.Size = new System.Drawing.Size(50, 19);
            this.numberTextBoxY.TabIndex = 28;
            this.numberTextBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberTextBoxWidth
            // 
            this.numberTextBoxWidth.Data = 0D;
            this.numberTextBoxWidth.DotNum = 0;
            this.numberTextBoxWidth.Location = new System.Drawing.Point(45, 43);
            this.numberTextBoxWidth.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxWidth.MinVal = 1D;
            this.numberTextBoxWidth.Name = "numberTextBoxWidth";
            this.numberTextBoxWidth.Size = new System.Drawing.Size(50, 19);
            this.numberTextBoxWidth.TabIndex = 28;
            this.numberTextBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberTextBoxHeight
            // 
            this.numberTextBoxHeight.Data = 0D;
            this.numberTextBoxHeight.DotNum = 0;
            this.numberTextBoxHeight.Location = new System.Drawing.Point(156, 43);
            this.numberTextBoxHeight.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxHeight.MinVal = 1D;
            this.numberTextBoxHeight.Name = "numberTextBoxHeight";
            this.numberTextBoxHeight.Size = new System.Drawing.Size(50, 19);
            this.numberTextBoxHeight.TabIndex = 28;
            this.numberTextBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RoiSettingCtrlSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RoiSettingCtrlSub";
            this.Size = new System.Drawing.Size(273, 71);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private NumberTextBox numberTextBoxY;
        private NumberTextBox numberTextBoxHeight;
        private NumberTextBox numberTextBoxWidth;
        private NumberTextBox numberTextBoxX;
    }
}
