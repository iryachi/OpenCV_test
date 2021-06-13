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
        OpenCVFunc.Canny canny = null;
        public CannyCtrl()
        {
            InitializeComponent();


            kernelSizeCtrl1.Title = "apertureSize";
            kernelSizeCtrl1.DefaultIndex = 2;
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                if (canny == null)
                    canny = new OpenCVFunc.Canny();

                double threshold1 = double.Parse(textBoxThreshold1.Text);
                double threshold2 = double.Parse(textBoxThreshold2.Text);

                int apertureSize = kernelSizeCtrl1.KernelSize;
                bool L2gradient = checkBoxL2grradient.Checked;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                String retStr = canny.Canny_exec(threshold1, threshold2, apertureSize, L2gradient, inputNo, outputNo);
                textBoxParameter.Text = retStr;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
