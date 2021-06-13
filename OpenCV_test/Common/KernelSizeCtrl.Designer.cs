
namespace OpenCV_test.Common
{
    partial class KernelSizeCtrl
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
            this.lblTitile = new System.Windows.Forms.Label();
            this.comboBoxKsize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.Location = new System.Drawing.Point(-2, 0);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(31, 12);
            this.lblTitile.TabIndex = 39;
            this.lblTitile.Text = "ksize";
            // 
            // comboBoxKsize
            // 
            this.comboBoxKsize.FormattingEnabled = true;
            this.comboBoxKsize.Location = new System.Drawing.Point(0, 15);
            this.comboBoxKsize.Name = "comboBoxKsize";
            this.comboBoxKsize.Size = new System.Drawing.Size(58, 20);
            this.comboBoxKsize.TabIndex = 38;
            // 
            // KernelSizeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitile);
            this.Controls.Add(this.comboBoxKsize);
            this.Name = "KernelSizeCtrl";
            this.Size = new System.Drawing.Size(59, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.ComboBox comboBoxKsize;
    }
}
