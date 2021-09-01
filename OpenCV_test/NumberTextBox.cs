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
    public partial class NumberTextBox : TextBox
    {
        private int dotNum = 100;
        private int maxDigit = 1000;
        private string numFormat = "0";
        private double maxVal = double.MaxValue;
        private double minVal = double.MinValue;
        private double data = 0.0;

        public double Data
        {
            get { return data; }
            set
            {
                data = value;
                this.Text = data.ToString(numFormat);
            }
        }

        /// <summary>
        /// 最大値
        /// </summary>
        public double MaxVal
        {
            get { return maxVal; }
            set { maxVal = value; }
        }
        /// <summary>
        /// 最小値
        /// </summary>
        public double MinVal
        {
            get { return minVal; }
            set { minVal = value; }
        }

        public int DotNum
        {
            get { return dotNum; }
            set
            {
                dotNum = value;
                setFormat();
            }
        }




        protected void setFormat()
        {
            numFormat = "";
            if (dotNum == 100) { return; }
            numFormat = "0";
            if (dotNum == 0) { return; }

            numFormat += ".";
            for (int i = 0; i < dotNum; i++)
            {
                numFormat += "0";
            }
        }


        public NumberTextBox()
        {
            InitializeComponent();
            this.Text = data.ToString(numFormat);
            this.TextAlign = HorizontalAlignment.Right;
            setFormat();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void NumTextBox_Leave(object sender, EventArgs e)
        {
            double ddat = 0.0;
            if (double.TryParse(this.Text, out ddat))
            {
                if (maxVal < ddat) { ddat = maxVal; }
                else if (minVal > ddat) { ddat = minVal; }
            }
            else
            {
                ddat = data;
            }
            this.Text = ddat.ToString(numFormat);
            bool eventFlag = false;
            if (data != ddat) { eventFlag = true; }
            data = ddat;
            if (eventFlag == true)
                OnDataChanged();
        }

        /// <summary>
        /// データが変更された時に発行
        /// </summary>
        private event EventHandler<EventArgs> dataChangedEvent;
        /// <summary>
        /// データが変更された時に発行
        /// </summary>
        public event EventHandler<EventArgs> DataChanged
        {
            add { dataChangedEvent += value; }
            remove { dataChangedEvent -= value; }
        }

        private void OnDataChanged()
        {
            if (dataChangedEvent != null)
            {
                dataChangedEvent(this, new EventArgs());
            }
        }

    }
}
