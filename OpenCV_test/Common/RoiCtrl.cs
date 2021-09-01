using OpenCVFunc;
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
    public partial class RoiCtrl : UserControl
    {
        public RoiCtrl()
        {
            InitializeComponent();
        }

        public void SetRoi(FilterBase filterBase)
        {
            int roiNo = (int)numericUpDown1.Value;
            if(roiNo == 0) { return; }
            filterBase.SetRoi(roiNo, checkBoxFrameMode.Checked);
        }
    }
}
