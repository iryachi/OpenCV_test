
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownInputNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOutNo = new System.Windows.Forms.NumericUpDown();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDDepth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxSacale = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Input No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Output No.";
            // 
            // numericUpDownInputNo
            // 
            this.numericUpDownInputNo.Location = new System.Drawing.Point(81, 3);
            this.numericUpDownInputNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownInputNo.Name = "numericUpDownInputNo";
            this.numericUpDownInputNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownInputNo.TabIndex = 11;
            // 
            // numericUpDownOutNo
            // 
            this.numericUpDownOutNo.Location = new System.Drawing.Point(272, 3);
            this.numericUpDownOutNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownOutNo.Name = "numericUpDownOutNo";
            this.numericUpDownOutNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownOutNo.TabIndex = 12;
            this.numericUpDownOutNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(3, 139);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(254, 85);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 16;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "ddepth";
            // 
            // comboBoxDDepth
            // 
            this.comboBoxDDepth.FormattingEnabled = true;
            this.comboBoxDDepth.Location = new System.Drawing.Point(3, 46);
            this.comboBoxDDepth.Name = "comboBoxDDepth";
            this.comboBoxDDepth.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDDepth.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "delta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "scale";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(111, 87);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(100, 19);
            this.textBoxDelta.TabIndex = 22;
            this.textBoxDelta.Text = "0";
            // 
            // textBoxSacale
            // 
            this.textBoxSacale.Location = new System.Drawing.Point(5, 87);
            this.textBoxSacale.Name = "textBoxSacale";
            this.textBoxSacale.Size = new System.Drawing.Size(100, 19);
            this.textBoxSacale.TabIndex = 21;
            this.textBoxSacale.Text = "1";
            // 
            // BitDepthConverterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.textBoxSacale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDDepth);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownInputNo);
            this.Controls.Add(this.numericUpDownOutNo);
            this.Name = "BitDepthConverterCtrl";
            this.Size = new System.Drawing.Size(437, 289);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownInputNo;
        private System.Windows.Forms.NumericUpDown numericUpDownOutNo;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.TextBox textBoxSacale;
    }
}
