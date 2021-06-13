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
    public partial class BitDepthConverterCtrl : UserControl
    {
        OpenCVFunc.BitDepthConverter bitDepthConverter = null;
        public BitDepthConverterCtrl()
        {
            InitializeComponent();      
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                double scale = double.Parse(textBoxSacale.Text);
                double delta = double.Parse(textBoxDelta.Text);

                int ddepth = depthCtrl1.DepthNo;
                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                if (bitDepthConverter == null)
                    bitDepthConverter = new OpenCVFunc.BitDepthConverter();

                String retStr = bitDepthConverter.BitDepthConverter_exec(ddepth, scale, delta, inputNo, outputNo);
                textBoxParameter.Text = retStr;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
