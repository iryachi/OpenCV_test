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
    public partial class ConverterTab : TabControl
    {
        public ConverterTab()
        {
            InitializeComponent();

            Util.SetTabPage(this, "tabPageBitConverter", "Bit Converter", new BitDepthConverterCtrl());
            Util.SetTabPage(this, "tabPageCvtColor", "CvtColor", new CvtColorCtrl());
            Util.SetTabPage(this, "tabPageThreshold", "Threshold", new ThresholdCtrl());
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
