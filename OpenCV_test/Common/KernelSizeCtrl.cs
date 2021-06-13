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
    public partial class KernelSizeCtrl : UserControl
    {

        public string Title { set { lblTitile.Text = value; } }
        public int KernelSize { get { return (int)comboBoxKsize.SelectedValue; } }

        public int DefaultIndex { set { comboBoxKsize.SelectedIndex = value; } }
        public KernelSizeCtrl()
        {
            InitializeComponent();


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

        }
    }
}
