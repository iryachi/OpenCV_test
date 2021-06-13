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

            Util.SetTabPage(this, "tabPageMedianBlur", "Median", new MedianBlurCtrl());
            Util.SetTabPage(this, "tabPageBlur", "Blur", new BlurCtrl());
            Util.SetTabPage(this, "tabPageGaussianBlur", "Gaussian", new GaussianBlurCtrl());
            Util.SetTabPage(this, "tabPageBilateralFilter", "BilateralFilter", new BilateralFilterCtrl());
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
