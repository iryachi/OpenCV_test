
namespace OpenCV_test
{
    partial class GaussianBlurCtrl
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
            this.numericUpDownKsizeY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKsizeX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownSigmaY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSigmaX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaX)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownKsizeY
            // 
            this.numericUpDownKsizeY.Location = new System.Drawing.Point(98, 57);
            this.numericUpDownKsizeY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKsizeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKsizeY.Name = "numericUpDownKsizeY";
            this.numericUpDownKsizeY.Size = new System.Drawing.Size(49, 19);
            this.numericUpDownKsizeY.TabIndex = 53;
            this.numericUpDownKsizeY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKsizeX
            // 
            this.numericUpDownKsizeX.Location = new System.Drawing.Point(27, 57);
            this.numericUpDownKsizeX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKsizeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKsizeX.Name = "numericUpDownKsizeX";
            this.numericUpDownKsizeX.Size = new System.Drawing.Size(43, 19);
            this.numericUpDownKsizeX.TabIndex = 54;
            this.numericUpDownKsizeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 52;
            this.label1.Text = "ksize";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "Y";
            // 
            // numericUpDownSigmaY
            // 
            this.numericUpDownSigmaY.Location = new System.Drawing.Point(259, 57);
            this.numericUpDownSigmaY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSigmaY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownSigmaY.Name = "numericUpDownSigmaY";
            this.numericUpDownSigmaY.Size = new System.Drawing.Size(49, 19);
            this.numericUpDownSigmaY.TabIndex = 61;
            this.numericUpDownSigmaY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownSigmaX
            // 
            this.numericUpDownSigmaX.Location = new System.Drawing.Point(188, 57);
            this.numericUpDownSigmaX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSigmaX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownSigmaX.Name = "numericUpDownSigmaX";
            this.numericUpDownSigmaX.Size = new System.Drawing.Size(43, 19);
            this.numericUpDownSigmaX.TabIndex = 62;
            this.numericUpDownSigmaX.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 12);
            this.label7.TabIndex = 58;
            this.label7.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 12);
            this.label10.TabIndex = 59;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 60;
            this.label11.Text = "sigma";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(243, 108);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 55;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(0, 149);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "Parameter";
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.Location = new System.Drawing.Point(7, 0);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.Size = new System.Drawing.Size(145, 35);
            this.imageInOutCtrl1.TabIndex = 0;
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.Location = new System.Drawing.Point(7, 94);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(201, 37);
            this.borderTypeCtrl1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 51;
            this.label2.Text = "X";
            // 
            // GaussianBlurCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownSigmaY);
            this.Controls.Add(this.numericUpDownSigmaX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.numericUpDownKsizeY);
            this.Controls.Add(this.numericUpDownKsizeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "GaussianBlurCtrl";
            this.Size = new System.Drawing.Size(392, 299);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownKsizeY;
        private System.Windows.Forms.NumericUpDown numericUpDownKsizeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownSigmaY;
        private System.Windows.Forms.NumericUpDown numericUpDownSigmaX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private System.Windows.Forms.Label label2;
    }
}
