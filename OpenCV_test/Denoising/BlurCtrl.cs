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
        private OpenCVFunc.Blur blur = null;
        public BlurCtrl()
        {
            InitializeComponent();

        }

        private void buttonExec_Click(object sender, EventArgs e)    
        {
            try
            {
                if (blur == null)
                    blur = new OpenCVFunc.Blur();

                int borderType = borderTypeCtrl1.BorderNo;

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                string retStr = blur.Blur_exec(
                    (int)numericUpDownKsizeX.Value, (int)numericUpDownKsizeY.Value,
                     (int)numericUpDownAnchorX.Value, (int)numericUpDownAnchorY.Value,
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
