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
    public partial class ImageFileTab : TabControl
    {
        public ImageFileTab()
        {
            InitializeComponent();

            Util.SetTabPage(this, "tabPageImread", "imread", new ImreadCtrl());
            Util.SetTabPage(this, "tabPageImwrite", "imwrite", new ImwriteCtrl());
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
