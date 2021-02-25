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
    public partial class EdgeDitectionTab : TabControl

    {
        public EdgeDitectionTab()
        {
            InitializeComponent();

            Util.SetTabPage(this, "tabPageSobel", "Sobel", new SobelCtrl());
            Util.SetTabPage(this, "tabPageCanny", "Canny", new CannyCtrl());
            Util.SetTabPage(this, "tabPageLaplacian", "Laplacian", new LaplacianCtrl());
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
