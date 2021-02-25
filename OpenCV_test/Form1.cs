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

            //デザイナがうまく動かないので　手動コードで入力
            tabControl1.TabPages["tabPageImageFile"].Controls.Add(new ImageFileTab() { Dock = DockStyle.Fill });
            tabControl1.TabPages["tabPageConverter"].Controls.Add(new ConverterTab() { Dock = DockStyle.Fill });
            tabControl1.TabPages["tabPageEdge"].Controls.Add(new EdgeDitectionTab() { Dock = DockStyle.Fill });
            tabControl1.TabPages["tabPageFilter2D"].Controls.Add(new Filter2DCtrl() { Dock = DockStyle.Fill });
            tabControl1.TabPages["tabPageConvTest"].Controls.Add(new ConvolutionTestCtrl() { Dock = DockStyle.Fill });
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
