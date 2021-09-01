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
    public partial class CannyCtrl : UserControl
    {
        public CannyCtrl()
        {
            InitializeComponent();
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenCVFunc.Canny canny = new OpenCVFunc.Canny();


                int apertureSize = kernelSizeCtrl1.KernelSize;
                bool L2gradient = checkBoxL2grradient.Checked;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                roiCtrl1.SetRoi(canny);

                String retStr = canny.Canny_exec(
                    numberTextBoxThreshold1.Data, 
                    numberTextBoxThreshold2.Data,
                    apertureSize,
                    L2gradient,
                    inputNo,
                    outputNo);
                textBoxParameter.Text = retStr;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
