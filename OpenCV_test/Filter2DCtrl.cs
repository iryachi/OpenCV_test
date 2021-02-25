using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_test
{
    public partial class Filter2DCtrl : UserControl
    {

        OpenCVFunc.Filter2D filter2D;
        public Filter2DCtrl()
        {
            InitializeComponent();

            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
      {
                new KeyValuePair<int,string>(-1, "NONE" ),
                new KeyValuePair<int,string>(0, "CV_8U" ),
                new KeyValuePair<int,string>(1, "CV_8S" ),
                new KeyValuePair<int,string>(2, "CV_16U" ),
                new KeyValuePair<int,string>(3, "CV_16S" ),
                new KeyValuePair<int,string>(7, "CV_16F" ),
                new KeyValuePair<int,string>(4, "CV_32S" ),
                new KeyValuePair<int,string>(5, "CV_32F" ),
                new KeyValuePair<int,string>(6, "CV_64F " ),
      };

            this.comboBoxDDepth.DataSource = kv;
            this.comboBoxDDepth.DisplayMember = "Value";
            this.comboBoxDDepth.ValueMember = "Key";
            this.comboBoxDDepth.SelectedIndex = 0;



            KeyValuePair<int, string>[] border = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(0, "BORDER_CONSTANT" ),
                new KeyValuePair<int,string>(1, "BORDER_REPLICATE" ),
                new KeyValuePair<int,string>(2, "BORDER_REFLECT" ),
              //  new KeyValuePair<int,string>(3, "BORDER_WRAP" ),
                new KeyValuePair<int,string>(4, "BORDER_DEFAULT" ),
             //   new KeyValuePair<int,string>(5, "BORDER_TRANSPARENT" ),
                new KeyValuePair<int,string>(16, "BORDER_ISOLATED" ),
            };

            this.comboBoxBorderType.DataSource = border;
            this.comboBoxBorderType.DisplayMember = "Value";
            this.comboBoxBorderType.ValueMember = "Key";
            this.comboBoxBorderType.SelectedIndex = 3;

            for (int i = 0; i < 3; i++)
            {
                int no = dataGridView1.Rows.Add();
                DataGridViewRow r = dataGridView1.Rows[no];
               r.HeaderCell.Value = (no + 1).ToString();

                foreach (DataGridViewTextBoxCell item in r.Cells)
                {
                    item.Value = "0";
                }
            }
        }

        private void addData()
        {
            var col = new DataGridViewTextBoxColumn();
            int colNo = dataGridView1.Columns.Add(col);
            col.HeaderText =( colNo+1).ToString();
            int no = dataGridView1.Rows.Add();

            DataGridViewRow r = dataGridView1.Rows[no];
            r.HeaderCell.Value = (no + 1).ToString();
            foreach (DataGridViewTextBoxCell item in r.Cells)
            {
                item.Value = "0";
            }
        }

        private void buttonAddKernel_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void buttonDelKernel_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            dataGridView1.Rows.RemoveAt(dataGridView1.RowCount - 1);
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                List<float> kernel = new List<float>();
                int kernelSize = dataGridView1.Rows.Count;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    foreach (var cell in item.Cells)
                    {
                        string s = (string)(cell as DataGridViewCell).Value;
                        float val = 0;
                        if (float.TryParse(s, out val))
                        {
                            kernel.Add(val);
                        }
                        else
                        {
                            MessageBox.Show("数値では有りません");
                            return;
                        }
                    }
                }

                if (filter2D == null)
                    filter2D = new OpenCVFunc.Filter2D();

                int ddepth = (int)comboBoxDDepth.SelectedValue;
                double delta = double.Parse(textBoxDelta.Text);
                int borderType = (int)comboBoxBorderType.SelectedValue;

                int inputNo = (int)numericUpDownInputNo.Value;
                int outputNo = (int)numericUpDownOutNo.Value;

                int anchorX = (int)numericUpDownAnchorX.Value;
                int anchorY = (int)numericUpDownAnchorY.Value;

                //プロジェクトでアンセーフコードを許可しておく
                unsafe
                {
                    //アンマネージド配列にコピー
                    int length = kernelSize * kernelSize;
                    System.IntPtr kernel_ptr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(float)) * length);
                    Marshal.Copy(kernel.ToArray(), 0, kernel_ptr, length);


                    String retStr = filter2D.Filter2D_exec(ddepth, (float*)kernel_ptr, kernelSize, anchorX, anchorY, delta, borderType, inputNo, outputNo);
                    textBoxParameter.Text = retStr;

                    Marshal.FreeCoTaskMem(kernel_ptr);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
