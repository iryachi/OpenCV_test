
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
            this.tabPageImageFile = new System.Windows.Forms.TabPage();
            this.tabPageConverter = new System.Windows.Forms.TabPage();
            this.tabPageDenoising = new System.Windows.Forms.TabPage();
            this.tabPageEdge = new System.Windows.Forms.TabPage();
            this.tabPageFilter2D = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageConvTest = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageImageFile);
            this.tabControl1.Controls.Add(this.tabPageConverter);
            this.tabControl1.Controls.Add(this.tabPageDenoising);
            this.tabControl1.Controls.Add(this.tabPageEdge);
            this.tabControl1.Controls.Add(this.tabPageFilter2D);
            this.tabControl1.Controls.Add(this.tabPageConvTest);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 415);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageImageFile
            // 
            this.tabPageImageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageImageFile.Name = "tabPageImageFile";
            this.tabPageImageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImageFile.Size = new System.Drawing.Size(594, 389);
            this.tabPageImageFile.TabIndex = 1;
            this.tabPageImageFile.Text = "File";
            this.tabPageImageFile.UseVisualStyleBackColor = true;
            // 
            // tabPageConverter
            // 
            this.tabPageConverter.Location = new System.Drawing.Point(4, 22);
            this.tabPageConverter.Name = "tabPageConverter";
            this.tabPageConverter.Size = new System.Drawing.Size(594, 389);
            this.tabPageConverter.TabIndex = 2;
            this.tabPageConverter.Text = "Converter";
            this.tabPageConverter.UseVisualStyleBackColor = true;
            // 
            // tabPageDenoising
            // 
            this.tabPageDenoising.Location = new System.Drawing.Point(4, 22);
            this.tabPageDenoising.Name = "tabPageDenoising";
            this.tabPageDenoising.Size = new System.Drawing.Size(594, 389);
            this.tabPageDenoising.TabIndex = 8;
            this.tabPageDenoising.Text = "Denoising";
            this.tabPageDenoising.UseVisualStyleBackColor = true;
            // 
            // tabPageEdge
            // 
            this.tabPageEdge.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdge.Name = "tabPageEdge";
            this.tabPageEdge.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdge.Size = new System.Drawing.Size(594, 389);
            this.tabPageEdge.TabIndex = 0;
            this.tabPageEdge.Text = "Edge";
            this.tabPageEdge.UseVisualStyleBackColor = true;
            // 
            // tabPageFilter2D
            // 
            this.tabPageFilter2D.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilter2D.Name = "tabPageFilter2D";
            this.tabPageFilter2D.Size = new System.Drawing.Size(594, 389);
            this.tabPageFilter2D.TabIndex = 7;
            this.tabPageFilter2D.Text = "Filter2D";
            this.tabPageFilter2D.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(515, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 28);
            this.panel1.TabIndex = 2;
            // 
            // tabPageConvTest
            // 
            this.tabPageConvTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageConvTest.Name = "tabPageConvTest";
            this.tabPageConvTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConvTest.Size = new System.Drawing.Size(594, 389);
            this.tabPageConvTest.TabIndex = 9;
            this.tabPageConvTest.Text = "Convolution Test";
            this.tabPageConvTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FontChanged += new System.EventHandler(this.Form1_FontChanged);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageImageFile;
        private System.Windows.Forms.TabPage tabPageEdge;
        private System.Windows.Forms.TabPage tabPageConverter;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TabPage tabPageFilter2D;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageDenoising;
        private System.Windows.Forms.TabPage tabPageConvTest;
    }
}

