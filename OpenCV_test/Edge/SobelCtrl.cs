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
        OpenCVFunc.Sobel sobel = null;
        public SobelCtrl()
        {
            InitializeComponent();

        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                if (sobel == null)
                    sobel = new OpenCVFunc.Sobel();

                double scale = double.Parse(textBoxSacale.Text);
                double delta = double.Parse(textBoxDelta.Text);

                int dx = (int)numericUpDownDx.Value;
                int dy = (int)numericUpDownDy.Value;

                int ddepth = depthCtrl1.DepthNo;
                int ksize = kernelSizeCtrl1.KernelSize;
                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;


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
