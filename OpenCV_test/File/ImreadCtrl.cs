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
    public partial class ImreadCtrl : UserControl
    {
        OpenCVFunc.Imread imread = null;


        public ImreadCtrl()
        {
            InitializeComponent();
            setComboBox(comboBoxFlag1);
            setComboBox(comboBoxFlag2);
            setComboBox(comboBoxFlag3);

            this.comboBoxFlag1.SelectedIndex = 3;
            this.comboBoxFlag2.SelectedIndex = 0;
            this.comboBoxFlag3.SelectedIndex = 0;
        }

        private void setComboBox(ComboBox cmbBox)
        {
            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
  {
                new KeyValuePair<int,string>(-2, "NONE" ),
                new KeyValuePair<int,string>(-1, "IMREAD_UNCHANGED" ),
                new KeyValuePair<int,string>(0, "IMREAD_GRAYSCALE " ),
                new KeyValuePair<int,string>(1, "IMREAD_COLOR" ),
                new KeyValuePair<int,string>(2, "IMREAD_ANYDEPTH " ),
                new KeyValuePair<int,string>(4, "IMREAD_ANYCOLOR" ),
                new KeyValuePair<int,string>(16, "IMREAD_REDUCED_GRAYSCALE_2" ),
                new KeyValuePair<int,string>(17, "IMREAD_REDUCED_COLOR_2" ),
                new KeyValuePair<int,string>(32, "IMREAD_REDUCED_GRAYSCALE_4" ),
                new KeyValuePair<int,string>(33, "IMREAD_REDUCED_COLOR_4" ),
                new KeyValuePair<int,string>(64, "IMREAD_REDUCED_GRAYSCALE_8" ),
                new KeyValuePair<int,string>(65, "IMREAD_REDUCED_COLOR_8" ),
                new KeyValuePair<int,string>(8, "IMREAD_LOAD_GDAL" )
  };
            cmbBox.DataSource = kv;
            cmbBox.DisplayMember = "Value";
            cmbBox.ValueMember = "Key";
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image File. |*.bmp;*.jpg;*.jpeg;*.png|All Files. |*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (imread == null)
                    imread = new OpenCVFunc.Imread();

                int flags = 0;
                if (comboBoxFlag1.SelectedIndex != 0)
                    flags |=  (int)comboBoxFlag1.SelectedValue;
                if (comboBoxFlag2.SelectedIndex != 0)
                    flags |= (int)comboBoxFlag2.SelectedValue;
                if (comboBoxFlag3.SelectedIndex != 0)
                    flags |= (int)comboBoxFlag3.SelectedValue;

                int outputNo = (int)numericUpDownOutNo.Value;

               String paramStr = imread.imread_exec(dlg.FileName, flags, outputNo);
                textBoxParameter.Text = paramStr;
            }
        }
    }
}
