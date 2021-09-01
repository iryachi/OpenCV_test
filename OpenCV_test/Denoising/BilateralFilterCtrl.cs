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
    public partial class BilateralFilterCtrl : UserControl
    {
        public BilateralFilterCtrl()
        {
            InitializeComponent();
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            OpenCVFunc.BilateralFilter filter = new OpenCVFunc.BilateralFilter();


            try
            {
                int d = (int)numberTextBoxD.Data;
                double sigmaColor = numberTextBoxSigmaColor.Data;
                double sigmaSpace = numberTextBoxSigmaSpace.Data;

                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                roiCtrl1.SetRoi(filter);

                String retStr = filter.Bilateral_exec(d, sigmaColor, sigmaSpace, borderType, inputNo, outputNo);
                textBoxParameter.Text = retStr;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
