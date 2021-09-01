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
    public partial class BlurCtrl : UserControl
    {
        public BlurCtrl()
        {
            InitializeComponent();

        }

        private void buttonExec_Click(object sender, EventArgs e)    
        {
            try
            {
                OpenCVFunc.Blur blur = new OpenCVFunc.Blur();

                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                roiCtrl1.SetRoi(blur);

                string retStr = blur.Blur_exec(
                    numXYCtrlKSize.X, numXYCtrlKSize.Y,
                     numXYCtrlAnchor.X, numXYCtrlAnchor.Y,
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
