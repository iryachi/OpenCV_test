
namespace OpenCV_test
{
    partial class CvtColorCtrl
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
            this.comboBoxCode = new System.Windows.Forms.ComboBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.numericUpDownCnNum = new System.Windows.Forms.NumericUpDown();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(3, 194);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Parameter";
            // 
            // comboBoxCode
            // 
            this.comboBoxCode.FormattingEnabled = true;
            this.comboBoxCode.Location = new System.Drawing.Point(6, 18);
            this.comboBoxCode.Name = "comboBoxCode";
            this.comboBoxCode.Size = new System.Drawing.Size(338, 20);
            this.comboBoxCode.TabIndex = 12;
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(151, 141);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 11;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // numericUpDownCnNum
            // 
            this.numericUpDownCnNum.Location = new System.Drawing.Point(6, 18);
            this.numericUpDownCnNum.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownCnNum.Name = "numericUpDownCnNum";
            this.numericUpDownCnNum.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownCnNum.TabIndex = 7;
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(3, 3);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(150, 50);
            this.imageInOutCtrl1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCode);
            this.groupBox1.Location = new System.Drawing.Point(3, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 50);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownCnNum);
            this.groupBox2.Location = new System.Drawing.Point(3, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 50);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dstCh";
            // 
            // CvtColorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Name = "CvtColorCtrl";
            this.Size = new System.Drawing.Size(409, 348);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCode;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.NumericUpDown numericUpDownCnNum;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
