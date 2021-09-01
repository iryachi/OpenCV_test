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

                roiCtrl1.SetRoi(filter2D);

                int ddepth = depthCtrl1.DepthNo;
                double delta = numberTextBoxDelta.Data;
                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                int anchorX = numXYCtrl1.X;
                int anchorY = numXYCtrl1.Y;

                //プロジェクトでアンセーフコードを許可しておく
                unsafe
                {
                    //アンマネージド配列にコピー
                    int length = kernelSize * kernelSize;
                    System.IntPtr kernel_ptr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(float)) * length);
                    Marshal.Copy(kernel.ToArray(), 0, kernel_ptr, length);


                    string retStr = filter2D.Filter2D_exec(ddepth, (float*)kernel_ptr, kernelSize, anchorX, anchorY, delta, borderType, inputNo, outputNo);
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
