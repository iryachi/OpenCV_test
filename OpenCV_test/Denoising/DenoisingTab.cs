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
    public partial class DenoisingTab : TabControl
    {
        public DenoisingTab()
        {
            InitializeComponent();

            Util.SetTabPage(this, "tabPageBitConverter", "Bit Converter", new BitDepthConverterCtrl());
            Util.SetTabPage(this, "tabPageCvtColor", "CvtColor", new BitDepthConverterCtrl());


        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
