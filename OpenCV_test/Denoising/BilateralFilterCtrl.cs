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
        OpenCVFunc.BilateralFilter filter = null;
        public BilateralFilterCtrl()
        {
            InitializeComponent();
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            if (filter == null)
                filter = new OpenCVFunc.BilateralFilter();

            int d = int.Parse(textBoxD.Text);
            double sigmaColor = double.Parse(textBoxSigmaColor.Text);
            double sigmaSpace = double.Parse(textBoxSigmaSpace.Text);

            int borderType = borderTypeCtrl1.BorderNo;

            int inputNo = imageInOutCtrl1.InNo;
            int outputNo = imageInOutCtrl1.OutNo;


            String retStr = filter.Bilateral_exec(d, sigmaColor, sigmaSpace, borderType,inputNo, outputNo);
            textBoxParameter.Text = retStr;
        }
    }
}
