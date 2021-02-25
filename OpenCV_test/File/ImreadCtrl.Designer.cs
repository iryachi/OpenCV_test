
namespace OpenCV_test
{
    partial class ImreadCtrl
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.numericUpDownOutNo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFlag1 = new System.Windows.Forms.ComboBox();
            this.comboBoxFlag2 = new System.Windows.Forms.ComboBox();
            this.comboBoxFlag3 = new System.Windows.Forms.ComboBox();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(308, 106);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // numericUpDownOutNo
            // 
            this.numericUpDownOutNo.Location = new System.Drawing.Point(295, 0);
            this.numericUpDownOutNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownOutNo.Name = "numericUpDownOutNo";
            this.numericUpDownOutNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownOutNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "flags";
            // 
            // comboBoxFlag1
            // 
            this.comboBoxFlag1.FormattingEnabled = true;
            this.comboBoxFlag1.Location = new System.Drawing.Point(58, 56);
            this.comboBoxFlag1.Name = "comboBoxFlag1";
            this.comboBoxFlag1.Size = new System.Drawing.Size(231, 20);
            this.comboBoxFlag1.TabIndex = 3;
            // 
            // comboBoxFlag2
            // 
            this.comboBoxFlag2.FormattingEnabled = true;
            this.comboBoxFlag2.Location = new System.Drawing.Point(58, 82);
            this.comboBoxFlag2.Name = "comboBoxFlag2";
            this.comboBoxFlag2.Size = new System.Drawing.Size(231, 20);
            this.comboBoxFlag2.TabIndex = 3;
            // 
            // comboBoxFlag3
            // 
            this.comboBoxFlag3.FormattingEnabled = true;
            this.comboBoxFlag3.Location = new System.Drawing.Point(58, 108);
            this.comboBoxFlag3.Name = "comboBoxFlag3";
            this.comboBoxFlag3.Size = new System.Drawing.Size(231, 20);
            this.comboBoxFlag3.TabIndex = 3;
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(41, 163);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 97);
            this.textBoxParameter.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "A | B | C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "C";
            // 
            // ImreadCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.comboBoxFlag3);
            this.Controls.Add(this.comboBoxFlag2);
            this.Controls.Add(this.comboBoxFlag1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownOutNo);
            this.Controls.Add(this.buttonOpen);
            this.Name = "ImreadCtrl";
            this.Size = new System.Drawing.Size(444, 278);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.NumericUpDown numericUpDownOutNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFlag1;
        private System.Windows.Forms.ComboBox comboBoxFlag2;
        private System.Windows.Forms.ComboBox comboBoxFlag3;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
