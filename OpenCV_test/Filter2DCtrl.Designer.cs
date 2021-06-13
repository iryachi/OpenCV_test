
namespace OpenCV_test
{
    partial class Filter2DCtrl
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
            this.buttonExec = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelKernel = new System.Windows.Forms.Button();
            this.buttonAddKernel = new System.Windows.Forms.Button();
            this.numericUpDownAnchorY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnchorX = new System.Windows.Forms.NumericUpDown();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.depthCtrl1 = new OpenCV_test.Common.DepthCtrl();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorX)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(18, 308);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(247, 147);
            this.textBoxParameter.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 41;
            this.label6.Text = "Parameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "delta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "anchor";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(195, 97);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(100, 19);
            this.textBoxDelta.TabIndex = 24;
            this.textBoxDelta.Text = "0";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(444, 97);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 22;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "Y";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(25, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(413, 145);
            this.dataGridView1.TabIndex = 43;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            // 
            // buttonDelKernel
            // 
            this.buttonDelKernel.Location = new System.Drawing.Point(444, 232);
            this.buttonDelKernel.Name = "buttonDelKernel";
            this.buttonDelKernel.Size = new System.Drawing.Size(75, 23);
            this.buttonDelKernel.TabIndex = 22;
            this.buttonDelKernel.Text = "Delete";
            this.buttonDelKernel.UseVisualStyleBackColor = true;
            this.buttonDelKernel.Click += new System.EventHandler(this.buttonDelKernel_Click);
            // 
            // buttonAddKernel
            // 
            this.buttonAddKernel.Location = new System.Drawing.Point(444, 193);
            this.buttonAddKernel.Name = "buttonAddKernel";
            this.buttonAddKernel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddKernel.TabIndex = 22;
            this.buttonAddKernel.Text = "Add";
            this.buttonAddKernel.UseVisualStyleBackColor = true;
            this.buttonAddKernel.Click += new System.EventHandler(this.buttonAddKernel_Click);
            // 
            // numericUpDownAnchorY
            // 
            this.numericUpDownAnchorY.Location = new System.Drawing.Point(100, 98);
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
            this.numericUpDownAnchorY.TabIndex = 44;
            this.numericUpDownAnchorY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownAnchorX
            // 
            this.numericUpDownAnchorX.Location = new System.Drawing.Point(32, 98);
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
            this.numericUpDownAnchorX.TabIndex = 45;
            this.numericUpDownAnchorX.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.Location = new System.Drawing.Point(276, 42);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(201, 37);
            this.borderTypeCtrl1.TabIndex = 55;
            // 
            // depthCtrl1
            // 
            this.depthCtrl1.Location = new System.Drawing.Point(0, 41);
            this.depthCtrl1.Name = "depthCtrl1";
            this.depthCtrl1.Size = new System.Drawing.Size(201, 38);
            this.depthCtrl1.TabIndex = 54;
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.Location = new System.Drawing.Point(0, 0);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.Size = new System.Drawing.Size(145, 35);
            this.imageInOutCtrl1.TabIndex = 53;
            // 
            // Filter2DCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.depthCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.numericUpDownAnchorY);
            this.Controls.Add(this.numericUpDownAnchorX);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.buttonAddKernel);
            this.Controls.Add(this.buttonDelKernel);
            this.Controls.Add(this.buttonExec);
            this.Name = "Filter2DCtrl";
            this.Size = new System.Drawing.Size(570, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelKernel;
        private System.Windows.Forms.Button buttonAddKernel;
        private System.Windows.Forms.NumericUpDown numericUpDownAnchorY;
        private System.Windows.Forms.NumericUpDown numericUpDownAnchorX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private Common.DepthCtrl depthCtrl1;
        private Common.ImageInOutCtrl imageInOutCtrl1;
    }
}
