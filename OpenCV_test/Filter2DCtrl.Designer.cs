
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
            this.buttonExec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelKernel = new System.Windows.Forms.Button();
            this.buttonAddKernel = new System.Windows.Forms.Button();
            this.borderTypeCtrl1 = new OpenCV_test.Common.BorderTypeCtrl();
            this.depthCtrl1 = new OpenCV_test.Common.DepthCtrl();
            this.imageInOutCtrl1 = new OpenCV_test.Common.ImageInOutCtrl();
            this.numXYCtrl1 = new OpenCV_test.Common.NumXYCtrl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberTextBoxDelta = new OpenCV_test.NumberTextBox();
            this.roiCtrl1 = new OpenCV_test.Common.RoiCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(5, 495);
            this.textBoxParameter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxParameter.Multiline = true;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(409, 218);
            this.textBoxParameter.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 472);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Parameter";
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(552, 495);
            this.buttonExec.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(125, 34);
            this.buttonExec.TabIndex = 22;
            this.buttonExec.Text = "Exec";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 250);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(688, 218);
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
            this.buttonDelKernel.Location = new System.Drawing.Point(698, 434);
            this.buttonDelKernel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonDelKernel.Name = "buttonDelKernel";
            this.buttonDelKernel.Size = new System.Drawing.Size(125, 34);
            this.buttonDelKernel.TabIndex = 22;
            this.buttonDelKernel.Text = "Delete";
            this.buttonDelKernel.UseVisualStyleBackColor = true;
            this.buttonDelKernel.Click += new System.EventHandler(this.buttonDelKernel_Click);
            // 
            // buttonAddKernel
            // 
            this.buttonAddKernel.Location = new System.Drawing.Point(698, 372);
            this.buttonAddKernel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonAddKernel.Name = "buttonAddKernel";
            this.buttonAddKernel.Size = new System.Drawing.Size(125, 34);
            this.buttonAddKernel.TabIndex = 22;
            this.buttonAddKernel.Text = "Add";
            this.buttonAddKernel.UseVisualStyleBackColor = true;
            this.buttonAddKernel.Click += new System.EventHandler(this.buttonAddKernel_Click);
            // 
            // borderTypeCtrl1
            // 
            this.borderTypeCtrl1.BorderNo = 3;
            this.borderTypeCtrl1.Location = new System.Drawing.Point(343, 84);
            this.borderTypeCtrl1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.borderTypeCtrl1.Name = "borderTypeCtrl1";
            this.borderTypeCtrl1.Size = new System.Drawing.Size(333, 75);
            this.borderTypeCtrl1.TabIndex = 55;
            // 
            // depthCtrl1
            // 
            this.depthCtrl1.Location = new System.Drawing.Point(0, 84);
            this.depthCtrl1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.depthCtrl1.Name = "depthCtrl1";
            this.depthCtrl1.Size = new System.Drawing.Size(333, 75);
            this.depthCtrl1.TabIndex = 54;
            // 
            // imageInOutCtrl1
            // 
            this.imageInOutCtrl1.InNo = 0;
            this.imageInOutCtrl1.InputEnable = true;
            this.imageInOutCtrl1.Location = new System.Drawing.Point(0, 0);
            this.imageInOutCtrl1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.imageInOutCtrl1.Name = "imageInOutCtrl1";
            this.imageInOutCtrl1.OutNo = 1;
            this.imageInOutCtrl1.OutputEnable = true;
            this.imageInOutCtrl1.Size = new System.Drawing.Size(250, 75);
            this.imageInOutCtrl1.TabIndex = 53;
            // 
            // numXYCtrl1
            // 
            this.numXYCtrl1.DefaultX = -1;
            this.numXYCtrl1.DefaultY = -1;
            this.numXYCtrl1.Location = new System.Drawing.Point(0, 166);
            this.numXYCtrl1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.numXYCtrl1.MaxX = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numXYCtrl1.MaxY = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numXYCtrl1.MinX = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numXYCtrl1.MinY = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numXYCtrl1.Name = "numXYCtrl1";
            this.numXYCtrl1.Size = new System.Drawing.Size(333, 75);
            this.numXYCtrl1.TabIndex = 56;
            this.numXYCtrl1.Title = "anchor";
            this.numXYCtrl1.XTitle = "X";
            this.numXYCtrl1.YTitle = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberTextBoxDelta);
            this.groupBox1.Location = new System.Drawing.Point(343, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(167, 75);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "delta";
            // 
            // numberTextBoxDelta
            // 
            this.numberTextBoxDelta.Data = 0D;
            this.numberTextBoxDelta.DotNum = 5;
            this.numberTextBoxDelta.Location = new System.Drawing.Point(10, 27);
            this.numberTextBoxDelta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numberTextBoxDelta.MaxVal = 1.7976931348623157E+308D;
            this.numberTextBoxDelta.MinVal = -1.7976931348623157E+308D;
            this.numberTextBoxDelta.Name = "numberTextBoxDelta";
            this.numberTextBoxDelta.Size = new System.Drawing.Size(131, 25);
            this.numberTextBoxDelta.TabIndex = 0;
            this.numberTextBoxDelta.Text = "0";
            this.numberTextBoxDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // roiCtrl1
            // 
            this.roiCtrl1.Location = new System.Drawing.Point(343, 6);
            this.roiCtrl1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.roiCtrl1.Name = "roiCtrl1";
            this.roiCtrl1.Size = new System.Drawing.Size(333, 75);
            this.roiCtrl1.TabIndex = 58;
            // 
            // Filter2DCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roiCtrl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numXYCtrl1);
            this.Controls.Add(this.borderTypeCtrl1);
            this.Controls.Add(this.depthCtrl1);
            this.Controls.Add(this.imageInOutCtrl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAddKernel);
            this.Controls.Add(this.buttonDelKernel);
            this.Controls.Add(this.buttonExec);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Filter2DCtrl";
            this.Size = new System.Drawing.Size(950, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDelKernel;
        private System.Windows.Forms.Button buttonAddKernel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Common.BorderTypeCtrl borderTypeCtrl1;
        private Common.DepthCtrl depthCtrl1;
        private Common.ImageInOutCtrl imageInOutCtrl1;
        private Common.NumXYCtrl numXYCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private NumberTextBox numberTextBoxDelta;
        private Common.RoiCtrl roiCtrl1;
    }
}
