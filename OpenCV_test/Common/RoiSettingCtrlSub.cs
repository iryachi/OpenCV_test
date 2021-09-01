using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_test.Common
{
    public partial class RoiSettingCtrlSub : UserControl
    {
        private int no = 0;
        public int No
        {
            set
            {
                groupBox1.Text = value.ToString();
                no = value;
            }
            get { return no; }
        }
        public RoiSettingCtrlSub()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            OpenCVFunc.RoiManager.SetRoi(
                (int)numberTextBoxX.Data,
                (int)numberTextBoxY.Data,
                (int)numberTextBoxWidth.Data,
                (int)numberTextBoxHeight.Data,
                No);
        }
    }
}
