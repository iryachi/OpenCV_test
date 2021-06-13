using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_test
{
    public partial class ThresholdCtrl : UserControl
    {
        OpenCVFunc.Threshold threshold = null;
        public ThresholdCtrl()
        {
            InitializeComponent();

            

            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(0, "THRESH_BINARY" ),
                new KeyValuePair<int,string>(1, "THRESH_BINARY_INV " ),
                new KeyValuePair<int,string>(2, "THRESH_TRUNC" ),
                new KeyValuePair<int,string>(3, "THRESH_TOZERO " ),
                new KeyValuePair<int,string>(4, "THRESH_TOZERO_INV " ),
                new KeyValuePair<int,string>(7, "THRESH_MASK" ),
                new KeyValuePair<int,string>(8, "THRESH_OTSU " ),
                new KeyValuePair<int,string>(16, "THRESH_TRIANGLE " ),
            };

            this.comboBoxType.DataSource = kv;
            this.comboBoxType.DisplayMember = "Value";
            this.comboBoxType.ValueMember = "Key";

            this.comboBoxType.SelectedIndex = 0;
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                if (threshold == null)
                    threshold = new OpenCVFunc.Threshold();

                double thre = double.Parse(textBoxThreshold.Text);
                double maxval = double.Parse(textBoxMaxVal.Text);

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

               String retStr =   threshold.threshold_exec(thre, maxval, (int)comboBoxType.SelectedValue, inputNo, outputNo);
                textBoxParameter.Text = retStr;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
