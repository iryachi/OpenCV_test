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
    public partial class NumXYCtrl : UserControl
    {
        public decimal MaxX
        {
            set { numericUpDownX.Maximum = value; }

            get { return numericUpDownX.Maximum; }
            
            }

        public decimal MinX
        {
            set { numericUpDownX.Minimum = value; }
            get { return numericUpDownX.Minimum; }
        }

        public decimal MaxY
        {
            set { numericUpDownY.Maximum = value; }
            get { return numericUpDownY.Maximum; }
        }

        public decimal MinY
        {
            set { numericUpDownY.Minimum = value; }
            get { return numericUpDownY.Minimum; }
        }

        public string Title
        {
            set { groupBoxTitle.Text = value; }
            get { return groupBoxTitle.Text; }
        }

        public string XTitle
        {
            set { labelTitleX.Text = value; }
            get { return labelTitleX.Text; }
        }

        public string YTitle
        {
            set { labelTitleY.Text = value; }
            get { return labelTitleY.Text; }
        }

        public int X
        {
            get { return (int)numericUpDownX.Value; }
        }

        public int Y
        { 
            get { return (int)numericUpDownY.Value; }
        }

        private int defaultX = 0;
        public int DefaultX
        {
            set { defaultX = value; }
            get { return defaultX; }
        }

        private int defaultY = 0;
        public int DefaultY
        {
            set { defaultY = value; }
            get { return defaultY; }
        }

        public NumXYCtrl()
        {
            InitializeComponent();
            numericUpDownX.Value = (decimal)defaultX;
            numericUpDownY.Value = (decimal)defaultY;
        }
    }
}
