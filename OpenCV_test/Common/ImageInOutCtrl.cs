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
    public partial class ImageInOutCtrl : UserControl
    {
        public int InNo 
        { 
            set { numericUpDownInputNo.Value = value; }            
            get { return (int)numericUpDownInputNo.Value; }
        }
        public int OutNo
        {
            set { numericUpDownOutNo.Value = value; }
            get { return (int)numericUpDownOutNo.Value; } }

        public bool InputEnable
        {
            set { numericUpDownInputNo.Enabled = value; }
            get { return numericUpDownInputNo.Enabled; }

        }
        public bool OutputEnable
        {
            set { numericUpDownOutNo.Enabled = value; }
            get { return numericUpDownOutNo.Enabled; }
        }


        public ImageInOutCtrl()
        {
            InitializeComponent();

        }
    }
}
