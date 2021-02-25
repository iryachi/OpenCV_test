
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownInputNo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOutNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBorderType = new System.Windows.Forms.ComboBox();
            this.comboBoxDDepth = new System.Windows.Forms.ComboBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDelKernel = new System.Windows.Forms.Button();
            this.buttonAddKernel = new System.Windows.Forms.Button();
            this.numericUpDownAnchorY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnchorX = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).BeginInit();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "ddepth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "Input No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "Output No.";
            // 
            // numericUpDownInputNo
            // 
            this.numericUpDownInputNo.Location = new System.Drawing.Point(82, 3);
            this.numericUpDownInputNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownInputNo.Name = "numericUpDownInputNo";
            this.numericUpDownInputNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownInputNo.TabIndex = 31;
            // 
            // numericUpDownOutNo
            // 
            this.numericUpDownOutNo.Location = new System.Drawing.Point(282, 3);
            this.numericUpDownOutNo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownOutNo.Name = "numericUpDownOutNo";
            this.numericUpDownOutNo.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownOutNo.TabIndex = 34;
            this.numericUpDownOutNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "borderType";
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
            // comboBoxBorderType
            // 
            this.comboBoxBorderType.FormattingEnabled = true;
            this.comboBoxBorderType.Location = new System.Drawing.Point(301, 97);
            this.comboBoxBorderType.Name = "comboBoxBorderType";
            this.comboBoxBorderType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBorderType.TabIndex = 26;
            // 
            // comboBoxDDepth
            // 
            this.comboBoxDDepth.FormattingEnabled = true;
            this.comboBoxDDepth.Location = new System.Drawing.Point(13, 54);
            this.comboBoxDDepth.Name = "comboBoxDDepth";
            this.comboBoxDDepth.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDDepth.TabIndex = 25;
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
            // Filter2DCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownAnchorY);
            this.Controls.Add(this.numericUpDownAnchorX);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownInputNo);
            this.Controls.Add(this.numericUpDownOutNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBorderType);
            this.Controls.Add(this.comboBoxDDepth);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.buttonAddKernel);
            this.Controls.Add(this.buttonDelKernel);
            this.Controls.Add(this.buttonExec);
            this.Name = "Filter2DCtrl";
            this.Size = new System.Drawing.Size(570, 500);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnchorX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownInputNo;
        private System.Windows.Forms.NumericUpDown numericUpDownOutNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBorderType;
        private System.Windows.Forms.ComboBox comboBoxDDepth;
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
    }
}
