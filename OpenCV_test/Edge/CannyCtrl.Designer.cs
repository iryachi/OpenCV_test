
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownInputNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOutNo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxThreshold2 = new System.Windows.Forms.TextBox();
            this.textBoxThreshold1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxL2grradient = new System.Windows.Forms.CheckBox();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.comboBoxApertureSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "Input No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "Output No.";
            // 
            // numericUpDownInputNo
            // 
            this.numericUpDownInputNo.Location = new System.Drawing.Point(79, 3);
            this.numericUpDownInputNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownInputNo.Name = "numericUpDownInputNo";
            this.numericUpDownInputNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownInputNo.TabIndex = 20;
            // 
            // numericUpDownOutNo
            // 
            this.numericUpDownOutNo.Location = new System.Drawing.Point(279, 3);
            this.numericUpDownOutNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownOutNo.Name = "numericUpDownOutNo";
            this.numericUpDownOutNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownOutNo.TabIndex = 21;
            this.numericUpDownOutNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "threshold2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "threshold1";
            // 
            // textBoxThreshold2
            // 
            this.textBoxThreshold2.Location = new System.Drawing.Point(111, 58);
            this.textBoxThreshold2.Name = "textBoxThreshold2";
            this.textBoxThreshold2.Size = new System.Drawing.Size(100, 19);
            this.textBoxThreshold2.TabIndex = 25;
            this.textBoxThreshold2.Text = "0";
            // 
            // textBoxThreshold1
            // 
            this.textBoxThreshold1.Location = new System.Drawing.Point(5, 58);
            this.textBoxThreshold1.Name = "textBoxThreshold1";
            this.textBoxThreshold1.Size = new System.Drawing.Size(100, 19);
            this.textBoxThreshold1.TabIndex = 24;
            this.textBoxThreshold1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "apertureSize";
            // 
            // checkBoxL2grradient
            // 
            this.checkBoxL2grradient.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxL2grradient.Location = new System.Drawing.Point(307, 55);
            this.checkBoxL2grradient.Name = "checkBoxL2grradient";
            this.checkBoxL2grradient.Size = new System.Drawing.Size(78, 24);
            this.checkBoxL2grradient.TabIndex = 30;
            this.checkBoxL2grradient.Text = "L2gradient";
            this.checkBoxL2grradient.UseVisualStyleBackColor = true;
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(3, 139);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 146);
            this.textBoxParameter.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(310, 85);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 33;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // comboBoxApertureSize
            // 
            this.comboBoxApertureSize.FormattingEnabled = true;
            this.comboBoxApertureSize.Location = new System.Drawing.Point(215, 58);
            this.comboBoxApertureSize.Name = "comboBoxApertureSize";
            this.comboBoxApertureSize.Size = new System.Drawing.Size(68, 20);
            this.comboBoxApertureSize.TabIndex = 34;
            // 
            // CannyCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxApertureSize);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxL2grradient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxThreshold2);
            this.Controls.Add(this.textBoxThreshold1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownInputNo);
            this.Controls.Add(this.numericUpDownOutNo);
            this.Name = "CannyCtrl";
            this.Size = new System.Drawing.Size(400, 310);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxThreshold2;
        private System.Windows.Forms.TextBox textBoxThreshold1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxL2grradient;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.ComboBox comboBoxApertureSize;
    }
}
