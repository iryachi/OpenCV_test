
namespace OpenCV_test
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxSacale = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.numericUpDownDx = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownDy = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.depthCtrl1 = new OpenCV_test.Common.DepthCtrl();
            this.kernelSizeCtrl1 = new OpenCV_test.Common.KernelSizeCtrl();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(12, 150);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Parameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "delta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "scale";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(111, 113);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(100, 19);
            this.textBoxDelta.TabIndex = 11;
            this.textBoxDelta.Text = "0";
            // 
            // textBoxSacale
            // 
            this.textBoxSacale.Location = new System.Drawing.Point(5, 113);
            this.textBoxSacale.Name = "textBoxSacale";
            this.textBoxSacale.Size = new System.Drawing.Size(100, 19);
            this.textBoxSacale.TabIndex = 10;
            this.textBoxSacale.Text = "1";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(265, 135);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 9;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // numericUpDownDx
            // 
            this.numericUpDownDx.Location = new System.Drawing.Point(202, 60);
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
            this.label8.Location = new System.Drawing.Point(200, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "dx";
            // 
            // numericUpDownDy
            // 
            this.numericUpDownDy.Location = new System.Drawing.Point(265, 60);
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
            this.label9.Location = new System.Drawing.Point(263, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "dy";
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.Location = new System.Drawing.Point(0, 0);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.Size = new System.Drawing.Size(145, 35);
            this.imageInOutCtrl1.TabIndex = 49;
            // 
            // depthCtrl1
            // 
            this.depthCtrl1.Location = new System.Drawing.Point(0, 41);
            this.depthCtrl1.Name = "depthCtrl1";
            this.depthCtrl1.Size = new System.Drawing.Size(201, 38);
            this.depthCtrl1.TabIndex = 50;
            // 
            // kernelSizeCtrl1
            // 
            this.kernelSizeCtrl1.Location = new System.Drawing.Point(328, 44);
            this.kernelSizeCtrl1.Name = "kernelSizeCtrl1";
            this.kernelSizeCtrl1.Size = new System.Drawing.Size(59, 38);
            this.kernelSizeCtrl1.TabIndex = 51;
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.Location = new System.Drawing.Point(217, 98);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(201, 37);
            this.borderTypeCtrl1.TabIndex = 52;
            // 
            // SobelCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.kernelSizeCtrl1);
            this.Controls.Add(this.depthCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownDy);
            this.Controls.Add(this.numericUpDownDx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.textBoxSacale);
            this.Controls.Add(this.buttonExec);
            this.Name = "SobelCtrl";
            this.Size = new System.Drawing.Size(445, 301);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.TextBox textBoxSacale;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.NumericUpDown numericUpDownDx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownDy;
        private System.Windows.Forms.Label label9;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.DepthCtrl depthCtrl1;
        private Common.KernelSizeCtrl kernelSizeCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
    }
}
