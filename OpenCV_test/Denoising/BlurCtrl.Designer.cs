
namespace OpenCV_test
{
    partial class BlurCtrl
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.numericUpDownAnchorY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnchorX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownKsizeX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKsizeY = new System.Windows.Forms.NumericUpDown();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(14, 137);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "Parameter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 12);
            this.label9.TabIndex = 39;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "X";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(244, 94);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 22;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // numericUpDownAnchorY
            // 
            this.numericUpDownAnchorY.Location = new System.Drawing.Point(260, 57);
            this.numericUpDownAnchorY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAnchorY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownAnchorY.Name = "numericUpDownAnchorY";
            this.numericUpDownAnchorY.Size = new System.Drawing.Size(49, 19);
            this.numericUpDownAnchorY.TabIndex = 49;
            this.numericUpDownAnchorY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownAnchorX
            // 
            this.numericUpDownAnchorX.Location = new System.Drawing.Point(189, 57);
            this.numericUpDownAnchorX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAnchorX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownAnchorX.Name = "numericUpDownAnchorX";
            this.numericUpDownAnchorX.Size = new System.Drawing.Size(43, 19);
            this.numericUpDownAnchorX.TabIndex = 50;
            this.numericUpDownAnchorX.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 12);
            this.label11.TabIndex = 48;
            this.label11.Text = "anchor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "ksize";
            // 
            // numericUpDownKsizeX
            // 
            this.numericUpDownKsizeX.Location = new System.Drawing.Point(25, 56);
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
            this.numericUpDownKsizeX.TabIndex = 50;
            this.numericUpDownKsizeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKsizeY
            // 
            this.numericUpDownKsizeY.Location = new System.Drawing.Point(96, 56);
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
            this.numericUpDownKsizeY.TabIndex = 49;
            this.numericUpDownKsizeY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.BorderNo = 0;
            this.borderTypeCtrl1.Location = new System.Drawing.Point(3, 80);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(201, 37);
            this.borderTypeCtrl1.TabIndex = 52;
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.Location = new System.Drawing.Point(3, 3);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.Size = new System.Drawing.Size(145, 35);
            this.imageInOutCtrl1.TabIndex = 51;
            // 
            // BlurCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.numericUpDownKsizeY);
            this.Controls.Add(this.numericUpDownAnchorY);
            this.Controls.Add(this.numericUpDownKsizeX);
            this.Controls.Add(this.numericUpDownAnchorX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonExec);
            this.Name = "BlurCtrl";
            this.Size = new System.Drawing.Size(530, 304);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKsizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.NumericUpDown numericUpDownAnchorY;
        private System.Windows.Forms.NumericUpDown numericUpDownAnchorX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownKsizeX;
        private System.Windows.Forms.NumericUpDown numericUpDownKsizeY;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
    }
}
