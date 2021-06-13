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
        private OpenCVFunc.GaussianBlur gaussian = null;

        public GaussianBlurCtrl()
        {
            InitializeComponent();

        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                if (gaussian == null)
                    gaussian = new OpenCVFunc.GaussianBlur();

                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                string retStr = gaussian.GaussianBlur_exec(
                    (int)numericUpDownKsizeX.Value, (int)numericUpDownKsizeY.Value,
                     (int)numericUpDownSigmaX.Value, (int)numericUpDownSigmaY.Value,
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
