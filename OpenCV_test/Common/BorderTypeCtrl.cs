using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_test.Common
{
    public partial class BorderTypeCtrl : UserControl
    {
        public int BorderNo
        {
            set { comboBoxBorderType.SelectedValue = value; }
            get { return (int)comboBoxBorderType.SelectedValue; }
        }

        public BorderTypeCtrl()
        {
            InitializeComponent();

            KeyValuePair<int, string>[] border = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(0, "BORDER_CONSTANT" ),
                new KeyValuePair<int,string>(1, "BORDER_REPLICATE" ),
                new KeyValuePair<int,string>(2, "BORDER_REFLECT" ),
                new KeyValuePair<int,string>(3, "BORDER_WRAP" ),
                new KeyValuePair<int,string>(4, "BORDER_DEFAULT" ),
                new KeyValuePair<int,string>(5, "BORDER_TRANSPARENT" ),
                new KeyValuePair<int,string>(16, "BORDER_ISOLATED" ),
            };

            this.comboBoxBorderType.DataSource = border;
            this.comboBoxBorderType.DisplayMember = "Value";
            this.comboBoxBorderType.ValueMember = "Key";
            this.comboBoxBorderType.SelectedIndex = 3;
        }
    }
}
