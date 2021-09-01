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
    public partial class SobelCtrl : UserControl
    {
        public SobelCtrl()
        {
            InitializeComponent();

        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenCVFunc.Sobel sobel = new OpenCVFunc.Sobel();

                double scale = numberTextBoxScale.Data;
                double delta = numberTextBoxDelta.Data;

                int dx = numXYCtrl1.X;
                int dy = numXYCtrl1.Y;

                int ddepth = depthCtrl1.DepthNo;
                int ksize = kernelSizeCtrl1.KernelSize;
                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                roiCtrl1.SetRoi(sobel);

                String retStr = sobel.Sobel_exec(ddepth, dx, dy, ksize, scale, delta, borderType, inputNo, outputNo);
                textBoxParameter.Text = retStr;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
