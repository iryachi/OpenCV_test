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
    public partial class GaussianBlurCtrl : UserControl
    {
     

        public GaussianBlurCtrl()
        {
            InitializeComponent();

        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {   
                OpenCVFunc.GaussianBlur gaussian =new OpenCVFunc.GaussianBlur();

                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                roiCtrl1.SetRoi(gaussian);

                string retStr = gaussian.GaussianBlur_exec(
                    numXYCtrlKSize.X, numXYCtrlKSize.Y,
                     numXYCtrlSigma.X, numXYCtrlSigma.Y,
                    borderType,
                    inputNo, outputNo);

                textBoxParameter.Text = retStr;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
