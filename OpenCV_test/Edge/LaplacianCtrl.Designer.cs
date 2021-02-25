
namespace OpenCV_test
{
    partial class LaplacianCtrl
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
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownInputNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOutNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKsize = new System.Windows.Forms.ComboBox();
            this.comboBoxBorderType = new System.Windows.Forms.ComboBox();
            this.comboBoxDDepth = new System.Windows.Forms.ComboBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxSacale = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(22, 137);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "Parameter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "ksize";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "ddepth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "Input No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "Output No.";
            // 
            // numericUpDownInputNo
            // 
            this.numericUpDownInputNo.Location = new System.Drawing.Point(84, 3);
            this.numericUpDownInputNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownInputNo.Name = "numericUpDownInputNo";
            this.numericUpDownInputNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownInputNo.TabIndex = 31;
            // 
            // numericUpDownOutNo
            // 
            this.numericUpDownOutNo.Location = new System.Drawing.Point(284, 3);
            this.numericUpDownOutNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownOutNo.Name = "numericUpDownOutNo";
            this.numericUpDownOutNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownOutNo.TabIndex = 34;
            this.numericUpDownOutNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "borderType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "delta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "scale";
            // 
            // comboBoxKsize
            // 
            this.comboBoxKsize.FormattingEnabled = true;
            this.comboBoxKsize.Location = new System.Drawing.Point(142, 54);
            this.comboBoxKsize.Name = "comboBoxKsize";
            this.comboBoxKsize.Size = new System.Drawing.Size(58, 20);
            this.comboBoxKsize.TabIndex = 27;
            // 
            // comboBoxBorderType
            // 
            this.comboBoxBorderType.FormattingEnabled = true;
            this.comboBoxBorderType.Location = new System.Drawing.Point(227, 100);
            this.comboBoxBorderType.Name = "comboBoxBorderType";
            this.comboBoxBorderType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBorderType.TabIndex = 26;
            // 
            // comboBoxDDepth
            // 
            this.comboBoxDDepth.FormattingEnabled = true;
            this.comboBoxDDepth.Location = new System.Drawing.Point(15, 54);
            this.comboBoxDDepth.Name = "comboBoxDDepth";
            this.comboBoxDDepth.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDDepth.TabIndex = 25;
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(121, 100);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(100, 19);
            this.textBoxDelta.TabIndex = 24;
            this.textBoxDelta.Text = "0";
            // 
            // textBoxSacale
            // 
            this.textBoxSacale.Location = new System.Drawing.Point(15, 100);
            this.textBoxSacale.Name = "textBoxSacale";
            this.textBoxSacale.Size = new System.Drawing.Size(100, 19);
            this.textBoxSacale.TabIndex = 23;
            this.textBoxSacale.Text = "1";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(370, 100);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 22;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // LaplacianCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownInputNo);
            this.Controls.Add(this.numericUpDownOutNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKsize);
            this.Controls.Add(this.comboBoxBorderType);
            this.Controls.Add(this.comboBoxDDepth);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.textBoxSacale);
            this.Controls.Add(this.buttonExec);
            this.Name = "LaplacianCtrl";
            this.Size = new System.Drawing.Size(458, 315);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownInputNo;
        private System.Windows.Forms.NumericUpDown numericUpDownOutNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKsize;
        private System.Windows.Forms.ComboBox comboBoxBorderType;
        private System.Windows.Forms.ComboBox comboBoxDDepth;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.TextBox textBoxSacale;
        private System.Windows.Forms.Button buttonExec;
    }
}
