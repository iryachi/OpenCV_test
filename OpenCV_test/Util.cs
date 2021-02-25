using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_test
{
    static class Util
    {
        public static void SetTabPage(TabControl tabControl, string tabPageName, string tabTitle, UserControl childCtrl)
        {
            TabPage tabPag = new TabPage();
            tabPag.Location = new System.Drawing.Point(4, 22);
            tabPag.Name = tabPageName;
            tabPag.Padding = new System.Windows.Forms.Padding(3);
            tabPag.TabIndex = 1;
            tabPag.Text = tabTitle;
            tabPag.UseVisualStyleBackColor = true;
            tabPag.Controls.Add(childCtrl);
            childCtrl.Dock = DockStyle.Fill;

            tabControl.TabPages.Add(tabPag);
        }
    }
}
