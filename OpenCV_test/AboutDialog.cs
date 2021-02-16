using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_test
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();




            string fileName =Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location);
            fileName += @"\LICENSE_BSD.txt";

            labelAppName.Text = Application.ProductName;

            labelVersion.Text = Application.ProductVersion;

            textBoxMyLicense.Text = "このアプリケーションのソースは自由に使って頂いて構いません。" + System.Environment.NewLine+
                "画像処理を勉強し始めた方のお役に立てれば幸いです。" +
                "もちろん責任は一切取りませんが。";

            string str;
            using (var stream = new StreamReader(fileName))
            {
                if (stream != null)
                {                   
                    str = stream.ReadToEnd();
                    textBox1.Text = str;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
