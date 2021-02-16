
namespace OpenCV_test
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageImread = new System.Windows.Forms.TabPage();
            this.tabPageThreshold = new System.Windows.Forms.TabPage();
            this.tabPageCvtColor = new System.Windows.Forms.TabPage();
            this.tabPageSobel = new System.Windows.Forms.TabPage();
            this.tabPageImwrite = new System.Windows.Forms.TabPage();
            this.tabPageCanny = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tabPageLaplacian = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageImread);
            this.tabControl1.Controls.Add(this.tabPageThreshold);
            this.tabControl1.Controls.Add(this.tabPageCvtColor);
            this.tabControl1.Controls.Add(this.tabPageSobel);
            this.tabControl1.Controls.Add(this.tabPageImwrite);
            this.tabControl1.Controls.Add(this.tabPageCanny);
            this.tabControl1.Controls.Add(this.tabPageLaplacian);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 401);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageImread
            // 
            this.tabPageImread.Location = new System.Drawing.Point(4, 22);
            this.tabPageImread.Name = "tabPageImread";
            this.tabPageImread.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImread.Size = new System.Drawing.Size(570, 375);
            this.tabPageImread.TabIndex = 1;
            this.tabPageImread.Text = "imread";
            this.tabPageImread.UseVisualStyleBackColor = true;
            // 
            // tabPageThreshold
            // 
            this.tabPageThreshold.Location = new System.Drawing.Point(4, 22);
            this.tabPageThreshold.Name = "tabPageThreshold";
            this.tabPageThreshold.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThreshold.Size = new System.Drawing.Size(570, 375);
            this.tabPageThreshold.TabIndex = 0;
            this.tabPageThreshold.Text = "threshold";
            this.tabPageThreshold.UseVisualStyleBackColor = true;
            // 
            // tabPageCvtColor
            // 
            this.tabPageCvtColor.Location = new System.Drawing.Point(4, 22);
            this.tabPageCvtColor.Name = "tabPageCvtColor";
            this.tabPageCvtColor.Size = new System.Drawing.Size(570, 375);
            this.tabPageCvtColor.TabIndex = 2;
            this.tabPageCvtColor.Text = "CvtColor";
            this.tabPageCvtColor.UseVisualStyleBackColor = true;
            // 
            // tabPageSobel
            // 
            this.tabPageSobel.Location = new System.Drawing.Point(4, 22);
            this.tabPageSobel.Name = "tabPageSobel";
            this.tabPageSobel.Size = new System.Drawing.Size(570, 375);
            this.tabPageSobel.TabIndex = 3;
            this.tabPageSobel.Text = "Sobel";
            this.tabPageSobel.UseVisualStyleBackColor = true;
            // 
            // tabPageImwrite
            // 
            this.tabPageImwrite.Location = new System.Drawing.Point(4, 22);
            this.tabPageImwrite.Name = "tabPageImwrite";
            this.tabPageImwrite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImwrite.Size = new System.Drawing.Size(570, 375);
            this.tabPageImwrite.TabIndex = 4;
            this.tabPageImwrite.Text = "Imwrite";
            this.tabPageImwrite.UseVisualStyleBackColor = true;
            // 
            // tabPageCanny
            // 
            this.tabPageCanny.Location = new System.Drawing.Point(4, 22);
            this.tabPageCanny.Name = "tabPageCanny";
            this.tabPageCanny.Size = new System.Drawing.Size(570, 375);
            this.tabPageCanny.TabIndex = 5;
            this.tabPageCanny.Text = "Canny";
            this.tabPageCanny.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(515, 1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tabPageLaplacian
            // 
            this.tabPageLaplacian.Location = new System.Drawing.Point(4, 22);
            this.tabPageLaplacian.Name = "tabPageLaplacian";
            this.tabPageLaplacian.Size = new System.Drawing.Size(570, 375);
            this.tabPageLaplacian.TabIndex = 6;
            this.tabPageLaplacian.Text = "Laplacian";
            this.tabPageLaplacian.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 443);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FontChanged += new System.EventHandler(this.Form1_FontChanged);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageImread;
        private System.Windows.Forms.TabPage tabPageThreshold;
        private System.Windows.Forms.TabPage tabPageCvtColor;
        private System.Windows.Forms.TabPage tabPageSobel;
        private System.Windows.Forms.TabPage tabPageImwrite;
        private System.Windows.Forms.TabPage tabPageCanny;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TabPage tabPageLaplacian;
    }
}

