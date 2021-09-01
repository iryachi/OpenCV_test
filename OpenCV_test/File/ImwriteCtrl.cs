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
    public partial class ImwriteCtrl : UserControl
    {

        public ImwriteCtrl()
        {
            InitializeComponent();

            setComboBox(comboBoxID1);
            setComboBox(comboBoxID2);
            setComboBox(comboBoxID3);
        }


        private void setComboBox(ComboBox cmbBox)
        {
            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(-1, "NONE" ),
                new KeyValuePair<int,string>(1, "IMWRITE_JPEG_QUALITY" ),
                new KeyValuePair<int,string>(2, "IMWRITE_JPEG_PROGRESSIVE " ),
                new KeyValuePair<int,string>(3, "IMWRITE_JPEG_OPTIMIZE" ),
                new KeyValuePair<int,string>(4, "IMWRITE_JPEG_RST_INTERVAL" ),
                new KeyValuePair<int,string>(5, "IMWRITE_JPEG_LUMA_QUALITY" ),
                new KeyValuePair<int,string>(6, "IMWRITE_JPEG_CHROMA_QUALITY" ),
                new KeyValuePair<int,string>(16, "IMWRITE_PNG_COMPRESSION" ),
                new KeyValuePair<int,string>(17, "IMWRITE_PNG_STRATEGY" ),
                new KeyValuePair<int,string>(18, "IMWRITE_PNG_BILEVEL" ),
                new KeyValuePair<int,string>(32, "IMWRITE_PXM_BINARY" ),
                new KeyValuePair<int,string>(48, "IMWRITE_EXR_TYPE" ),
                new KeyValuePair<int,string>(64, "IMWRITE_WEBP_QUALITY" ),
                new KeyValuePair<int,string>(128, "IMWRITE_PAM_TUPLETYPE" ),
                new KeyValuePair<int,string>(256, "IMWRITE_TIFF_RESUNIT" ),
                new KeyValuePair<int,string>(257, "IMWRITE_TIFF_XDPI" ),
                new KeyValuePair<int,string>(258, "IMWRITE_TIFF_YDPI" ),
                new KeyValuePair<int,string>(259, "IMWRITE_TIFF_COMPRESSION" ),
                new KeyValuePair<int,string>(272, "IMWRITE_JPEG2000_COMPRESSION_X1000" )
            };
            cmbBox.DataSource = kv;
            cmbBox.DisplayMember = "Value";
            cmbBox.ValueMember = "Key";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Image File. |*.bmp;*.jpg;*.jpeg;*.png|All Files. |*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                OpenCVFunc.Imwrite imwrite = new OpenCVFunc.Imwrite();


                List<int> parameter = new List<int>();
                if(comboBoxID1.SelectedIndex != 0)
                {
                    parameter.Add((int)comboBoxID1.SelectedValue);
                    parameter.Add((int)numericUpDownValue1.Value);
                }
                if (comboBoxID2.SelectedIndex != 0)
                {
                    parameter.Add((int)comboBoxID2.SelectedValue);
                    parameter.Add((int)numericUpDownValue2.Value);
                }
                if (comboBoxID3.SelectedIndex != 0)
                {
                    parameter.Add((int)comboBoxID3.SelectedValue);
                    parameter.Add((int)numericUpDownValue3.Value);
                }
                int inputNo = imageInOutCtrl1.InNo;


              String paramStr =    imwrite.imwrite_exec(dlg.FileName, parameter, inputNo);
                 textBoxParameter.Text = paramStr;

            }
        }
    }
}
