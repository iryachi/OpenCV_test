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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            tabControl1.TabPages["tabPageImread"].Controls.Add(new ImreadCtrl());
            tabControl1.TabPages["tabPageThreshold"].Controls.Add(new ThresholdCtrl());
            tabControl1.TabPages["tabPageCvtColor"].Controls.Add(new CvtColorCtrl());
            tabControl1.TabPages["tabPageSobel"].Controls.Add(new SobelCtrl());
            tabControl1.TabPages["tabPageImwrite"].Controls.Add(new ImwriteCtrl());
              tabControl1.TabPages["tabPageCanny"].Controls.Add(new CannyCtrl());
              tabControl1.TabPages["tabPageLaplacian"].Controls.Add(new LaplacianCtrl());
      }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenCVFunc.ImageMemManager.Initialize();
        }

        private void Form1_FontChanged(object sender, EventArgs e)
        {
            OpenCVFunc.ImageMemManager.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.ShowDialog();
        }
    }
}
