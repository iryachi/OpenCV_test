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
    public partial class MedianBlurCtrl : UserControl
    {
        OpenCVFunc.Median median = null;
        public MedianBlurCtrl()
        {
            InitializeComponent();

        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                if (median == null)
                    median = new OpenCVFunc.Median();

                int ksize = kernelSizeCtrl1.KernelSize;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                String retStr = median.MedianBlur_exec(ksize, inputNo, outputNo);
                textBoxParameter.Text = retStr;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
