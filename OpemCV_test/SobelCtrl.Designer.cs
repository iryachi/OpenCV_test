
namespace OpemCV_test
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownInputNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOutNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDDepth = new System.Windows.Forms.ComboBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxSacale = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDx = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownDy = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxKsize = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxBorderType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(16, 137);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Parameter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "Input No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Output No.";
            // 
            // numericUpDownInputNo
            // 
            this.numericUpDownInputNo.Location = new System.Drawing.Point(78, 3);
            this.numericUpDownInputNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownInputNo.Name = "numericUpDownInputNo";
            this.numericUpDownInputNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownInputNo.TabIndex = 16;
            // 
            // numericUpDownOutNo
            // 
            this.numericUpDownOutNo.Location = new System.Drawing.Point(278, 3);
            this.numericUpDownOutNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownOutNo.Name = "numericUpDownOutNo";
            this.numericUpDownOutNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownOutNo.TabIndex = 17;
            this.numericUpDownOutNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "borderType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "delta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "scale";
            // 
            // comboBoxDDepth
            // 
            this.comboBoxDDepth.FormattingEnabled = true;
            this.comboBoxDDepth.Location = new System.Drawing.Point(9, 54);
            this.comboBoxDDepth.Name = "comboBoxDDepth";
            this.comboBoxDDepth.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDDepth.TabIndex = 12;
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(115, 100);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(100, 19);
            this.textBoxDelta.TabIndex = 11;
            this.textBoxDelta.Text = "0";
            // 
            // textBoxSacale
            // 
            this.textBoxSacale.Location = new System.Drawing.Point(9, 100);
            this.textBoxSacale.Name = "textBoxSacale";
            this.textBoxSacale.Size = new System.Drawing.Size(100, 19);
            this.textBoxSacale.TabIndex = 10;
            this.textBoxSacale.Text = "1";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(364, 100);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 9;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "ddepth";
            // 
            // numericUpDownDx
            // 
            this.numericUpDownDx.Location = new System.Drawing.Point(136, 55);
            this.numericUpDownDx.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownDx.Name = "numericUpDownDx";
            this.numericUpDownDx.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownDx.TabIndex = 16;
            this.numericUpDownDx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "dx";
            // 
            // numericUpDownDy
            // 
            this.numericUpDownDy.Location = new System.Drawing.Point(199, 55);
            this.numericUpDownDy.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownDy.Name = "numericUpDownDy";
            this.numericUpDownDy.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownDy.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "dy";
            // 
            // comboBoxKsize
            // 
            this.comboBoxKsize.FormattingEnabled = true;
            this.comboBoxKsize.Location = new System.Drawing.Point(262, 54);
            this.comboBoxKsize.Name = "comboBoxKsize";
            this.comboBoxKsize.Size = new System.Drawing.Size(58, 20);
            this.comboBoxKsize.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "ksize";
            // 
            // comboBoxBorderType
            // 
            this.comboBoxBorderType.FormattingEnabled = true;
            this.comboBoxBorderType.Location = new System.Drawing.Point(221, 100);
            this.comboBoxBorderType.Name = "comboBoxBorderType";
            this.comboBoxBorderType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBorderType.TabIndex = 12;
            // 
            // SobelCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownDy);
            this.Controls.Add(this.numericUpDownDx);
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
            this.Name = "SobelCtrl";
            this.Size = new System.Drawing.Size(445, 301);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownInputNo;
        private System.Windows.Forms.NumericUpDown numericUpDownOutNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDDepth;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.TextBox textBoxSacale;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownDy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxKsize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxBorderType;
    }
}
