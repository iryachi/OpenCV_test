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
    public partial class CannyCtrl : UserControl
    {
        OpenCVFunc.Canny canny = new OpenCVFunc.Canny();
        public CannyCtrl()
        {
            InitializeComponent();

            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
     {
                new KeyValuePair<int,string>(3, "3" ),
                new KeyValuePair<int,string>(5, "5" ),
                new KeyValuePair<int,string>(7, "7 " ),
     };

            this.comboBoxApertureSize.DataSource = kv;
            this.comboBoxApertureSize.DisplayMember = "Value";
            this.comboBoxApertureSize.ValueMember = "Key";
            this.comboBoxApertureSize.SelectedIndex = 0;
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                double threshold1 = double.Parse(textBoxThreshold1.Text);
                double threshold2 = double.Parse(textBoxThreshold2.Text);

                int apertureSize = (int)comboBoxApertureSize.SelectedValue;
                bool L2gradient = checkBoxL2grradient.Checked;

                int inputNo = (int)numericUpDownInputNo.Value;
                int outputNo = (int)numericUpDownOutNo.Value;

                String retStr = canny.Canny_exec(threshold1, threshold2, apertureSize, L2gradient, inputNo, outputNo);
                textBoxParameter.Text = retStr;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
