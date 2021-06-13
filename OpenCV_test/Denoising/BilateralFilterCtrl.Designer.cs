
namespace OpenCV_test
{
    partial class BilateralFilterCtrl
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
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSigmaSpace = new System.Windows.Forms.TextBox();
            this.textBoxSigmaColor = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.Location = new System.Drawing.Point(3, 3);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.Size = new System.Drawing.Size(145, 35);
            this.imageInOutCtrl1.TabIndex = 50;
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.Location = new System.Drawing.Point(3, 81);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(201, 37);
            this.borderTypeCtrl1.TabIndex = 56;
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(3, 136);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 54;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(246, 95);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 53;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 59;
            this.label2.Text = "sigmaSpace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 60;
            this.label1.Text = "sigmaColor";
            // 
            // textBoxSigmaSpace
            // 
            this.textBoxSigmaSpace.Location = new System.Drawing.Point(217, 56);
            this.textBoxSigmaSpace.Name = "textBoxSigmaSpace";
            this.textBoxSigmaSpace.Size = new System.Drawing.Size(100, 19);
            this.textBoxSigmaSpace.TabIndex = 58;
            this.textBoxSigmaSpace.Text = "0";
            // 
            // textBoxSigmaColor
            // 
            this.textBoxSigmaColor.Location = new System.Drawing.Point(111, 56);
            this.textBoxSigmaColor.Name = "textBoxSigmaColor";
            this.textBoxSigmaColor.Size = new System.Drawing.Size(100, 19);
            this.textBoxSigmaColor.TabIndex = 57;
            this.textBoxSigmaColor.Text = "1";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(5, 56);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 19);
            this.textBoxD.TabIndex = 57;
            this.textBoxD.Text = "-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "d";
            // 
            // BilateralFilterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSigmaSpace);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxSigmaColor);
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Name = "BilateralFilterCtrl";
            this.Size = new System.Drawing.Size(438, 289);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSigmaSpace;
        private System.Windows.Forms.TextBox textBoxSigmaColor;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label3;
    }
}
