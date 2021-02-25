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
    public partial class SobelCtrl : UserControl
    {
            OpenCVFunc.Sobel sobel = new OpenCVFunc.Sobel();
        public SobelCtrl()
        {
            InitializeComponent();

            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(-1, "NONE" ),
                new KeyValuePair<int,string>(3, "CV_16S" ),
                new KeyValuePair<int,string>(5, "CV_32F" ),
                new KeyValuePair<int,string>(6, "CV_64F " ),
            };

            this.comboBoxDDepth.DataSource = kv;
            this.comboBoxDDepth.DisplayMember = "Value";
            this.comboBoxDDepth.ValueMember = "Key";
            this.comboBoxDDepth.SelectedIndex = 2;

            KeyValuePair<int, string>[] ksize = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(1, "1" ),
                new KeyValuePair<int,string>(3, "3" ),
                new KeyValuePair<int,string>(5, "5" ),
                new KeyValuePair<int,string>(7, "7 " ),
            };

            this.comboBoxKsize.DataSource = ksize;
            this.comboBoxKsize.DisplayMember = "Value";
            this.comboBoxKsize.ValueMember = "Key";
            this.comboBoxKsize.SelectedIndex = 1;


            KeyValuePair<int, string>[] border = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(0, "BORDER_CONSTANT" ),
                new KeyValuePair<int,string>(1, "BORDER_REPLICATE" ),
                new KeyValuePair<int,string>(2, "BORDER_REFLECT" ),
              //  new KeyValuePair<int,string>(3, "BORDER_WRAP" ),
                new KeyValuePair<int,string>(4, "BORDER_DEFAULT" ),
             //   new KeyValuePair<int,string>(5, "BORDER_TRANSPARENT" ),
                new KeyValuePair<int,string>(16, "BORDER_ISOLATED" ),
            };

            this.comboBoxBorderType.DataSource = border;
            this.comboBoxBorderType.DisplayMember = "Value";
            this.comboBoxBorderType.ValueMember = "Key";
            this.comboBoxBorderType.SelectedIndex = 3;

        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {


                double scale = double.Parse(textBoxSacale.Text);
                double delta = double.Parse(textBoxDelta.Text);

                int dx = (int)numericUpDownDx.Value;
                int dy = (int)numericUpDownDy.Value;
                int ddepth = (int)comboBoxDDepth.SelectedValue;
                int ksize = (int)comboBoxKsize.SelectedValue;
                int borderType = (int)comboBoxBorderType.SelectedValue;

                int inputNo = (int)numericUpDownInputNo.Value;
                int outputNo = (int)numericUpDownOutNo.Value;


                String retStr = sobel.Sobel_exec(ddepth, dx, dy, ksize, scale, delta, borderType, inputNo, outputNo);
                textBoxParameter.Text = retStr;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
