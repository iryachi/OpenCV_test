﻿using System;
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
        public int InNo { get { return (int)numericUpDownInputNo.Value; } }
        public int OutNo { get { return (int)numericUpDownOutNo.Value; } }


        public ImageInOutCtrl()
        {
            InitializeComponent();

        }
    }
}
