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
    public partial class DepthCtrl : UserControl
    {
        public int DepthNo { get { return (int)comboBoxDDepth.SelectedValue; } }

        public DepthCtrl()
        {
            InitializeComponent();

            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
    {
                new KeyValuePair<int,string>(-1, "NONE" ),
                new KeyValuePair<int,string>(0, "CV_8U" ),
                new KeyValuePair<int,string>(1, "CV_8S" ),
                new KeyValuePair<int,string>(2, "CV_16U" ),
                new KeyValuePair<int,string>(3, "CV_16S" ),
                new KeyValuePair<int,string>(7, "CV_16F" ),
                new KeyValuePair<int,string>(4, "CV_32S" ),
                new KeyValuePair<int,string>(5, "CV_32F" ),
                new KeyValuePair<int,string>(6, "CV_64F " ),
    };

            this.comboBoxDDepth.DataSource = kv;
            this.comboBoxDDepth.DisplayMember = "Value";
            this.comboBoxDDepth.ValueMember = "Key";
            this.comboBoxDDepth.SelectedIndex = 2;
        }
    }
}
