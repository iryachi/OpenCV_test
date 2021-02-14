
namespace OpemCV_test
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
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.textBoxMaxVal = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownOutNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownInputNo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(15, 59);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(100, 19);
            this.textBoxThreshold.TabIndex = 1;
            this.textBoxThreshold.Text = "128";
            // 
            // textBoxMaxVal
            // 
            this.textBoxMaxVal.Location = new System.Drawing.Point(121, 59);
            this.textBoxMaxVal.Name = "textBoxMaxVal";
            this.textBoxMaxVal.Size = new System.Drawing.Size(100, 19);
            this.textBoxMaxVal.TabIndex = 2;
            this.textBoxMaxVal.Text = "255";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(227, 59);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxType.TabIndex = 3;
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(273, 85);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 0;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "maxval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "type";
            // 
            // numericUpDownOutNo
            // 
            this.numericUpDownOutNo.Location = new System.Drawing.Point(291, 7);
            this.numericUpDownOutNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownOutNo.Name = "numericUpDownOutNo";
            this.numericUpDownOutNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownOutNo.TabIndex = 5;
            this.numericUpDownOutNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output No.";
            // 
            // numericUpDownInputNo
            // 
            this.numericUpDownInputNo.Location = new System.Drawing.Point(91, 7);
            this.numericUpDownInputNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownInputNo.Name = "numericUpDownInputNo";
            this.numericUpDownInputNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownInputNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Input No.";
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(15, 132);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Parameter";
            // 
            // ThresholdCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownInputNo);
            this.Controls.Add(this.numericUpDownOutNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxMaxVal);
            this.Controls.Add(this.textBoxThreshold);
            this.Controls.Add(this.buttonExec);
            this.Name = "ThresholdCtrl";
            this.Size = new System.Drawing.Size(354, 294);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.TextBox textBoxMaxVal;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownOutNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownInputNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
    }
}
