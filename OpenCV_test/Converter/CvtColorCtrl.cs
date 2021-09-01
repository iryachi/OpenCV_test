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
    public partial class CvtColorCtrl : UserControl
    {
        public CvtColorCtrl()
        {
            InitializeComponent();


            KeyValuePair<int, string>[] kv = new KeyValuePair<int, string>[]
{
    new KeyValuePair<int, string>(7, "COLOR_RGB2GRAY"),
    new KeyValuePair<int, string>(8, "COLOR_GRAY2RGB"),

    new KeyValuePair<int, string>(0, "COLOR_BGR2BGRA"),
    new KeyValuePair<int, string>(0, "COLOR_RGB2RGBA"),
    new KeyValuePair<int, string>(1, "COLOR_BGRA2BGR"),
    new KeyValuePair<int, string>(1, "COLOR_RGBA2RGB"),
    new KeyValuePair<int, string>(2, "COLOR_BGR2RGBA"),
    new KeyValuePair<int, string>(2, "COLOR_RGB2BGRA"),
    new KeyValuePair<int, string>(3, "COLOR_RGBA2BGR"),
    new KeyValuePair<int, string>(3, "COLOR_BGRA2RGB"),
    new KeyValuePair<int, string>(4, "COLOR_BGR2RGB"),
    new KeyValuePair<int, string>(4, "COLOR_RGB2BGR"),
    new KeyValuePair<int, string>(5, "COLOR_BGRA2RGBA"),
    new KeyValuePair<int, string>(5, "COLOR_RGBA2BGRA"),
    new KeyValuePair<int, string>(6, "COLOR_BGR2GRAY"),
    new KeyValuePair<int, string>(8, "COLOR_GRAY2BGR"),
    new KeyValuePair<int, string>(9, "COLOR_GRAY2BGRA"),
    new KeyValuePair<int, string>(9, "COLOR_GRAY2RGBA"),
    new KeyValuePair<int, string>(10, "COLOR_BGRA2GRAY"),
    new KeyValuePair<int, string>(11, "COLOR_RGBA2GRAY"),
    new KeyValuePair<int, string>(12, "COLOR_BGR2BGR565"),
    new KeyValuePair<int, string>(13, "COLOR_RGB2BGR565"),
    new KeyValuePair<int, string>(14, "COLOR_BGR5652BGR"),
    new KeyValuePair<int, string>(15, "COLOR_BGR5652RGB"),
    new KeyValuePair<int, string>(16, "COLOR_BGRA2BGR565"),
    new KeyValuePair<int, string>(17, "COLOR_RGBA2BGR565"),
    new KeyValuePair<int, string>(18, "COLOR_BGR5652BGRA"),
    new KeyValuePair<int, string>(19, "COLOR_BGR5652RGBA"),
    new KeyValuePair<int, string>(20, "COLOR_GRAY2BGR565"),
    new KeyValuePair<int, string>(21, "COLOR_BGR5652GRAY"),
    new KeyValuePair<int, string>(22, "COLOR_BGR2BGR555"),
    new KeyValuePair<int, string>(23, "COLOR_RGB2BGR555"),
    new KeyValuePair<int, string>(24, "COLOR_BGR5552BGR"),
    new KeyValuePair<int, string>(25, "COLOR_BGR5552RGB"),
    new KeyValuePair<int, string>(26, "COLOR_BGRA2BGR555"),
    new KeyValuePair<int, string>(27, "COLOR_RGBA2BGR555"),
    new KeyValuePair<int, string>(28, "COLOR_BGR5552BGRA"),
    new KeyValuePair<int, string>(29, "COLOR_BGR5552RGBA"),
    new KeyValuePair<int, string>(30, "COLOR_GRAY2BGR555"),
    new KeyValuePair<int, string>(31, "COLOR_BGR5552GRAY"),
    new KeyValuePair<int, string>(32, "COLOR_BGR2XYZ"),
    new KeyValuePair<int, string>(33, "COLOR_RGB2XYZ"),
    new KeyValuePair<int, string>(34, "COLOR_XYZ2BGR"),
    new KeyValuePair<int, string>(35, "COLOR_XYZ2RGB"),
    new KeyValuePair<int, string>(36, "COLOR_BGR2YCrCb"),
    new KeyValuePair<int, string>(37, "COLOR_RGB2YCrCb"),
    new KeyValuePair<int, string>(38, "COLOR_YCrCb2BGR"),
    new KeyValuePair<int, string>(39, "COLOR_YCrCb2RGB"),
    new KeyValuePair<int, string>(40, "COLOR_BGR2HSV"),
    new KeyValuePair<int, string>(41, "COLOR_RGB2HSV"),
    new KeyValuePair<int, string>(44, "COLOR_BGR2Lab"),
    new KeyValuePair<int, string>(45, "COLOR_RGB2Lab"),
    new KeyValuePair<int, string>(50, "COLOR_BGR2Luv"),
    new KeyValuePair<int, string>(51, "COLOR_RGB2Luv"),
    new KeyValuePair<int, string>(52, "COLOR_BGR2HLS"),
    new KeyValuePair<int, string>(53, "COLOR_RGB2HLS"),
    new KeyValuePair<int, string>(54, "COLOR_HSV2BGR"),
    new KeyValuePair<int, string>(55, "COLOR_HSV2RGB"),
    new KeyValuePair<int, string>(56, "COLOR_Lab2BGR"),
    new KeyValuePair<int, string>(57, "COLOR_Lab2RGB"),
    new KeyValuePair<int, string>(58, "COLOR_Luv2BGR"),
    new KeyValuePair<int, string>(59, "COLOR_Luv2RGB"),
    new KeyValuePair<int, string>(60, "COLOR_HLS2BGR"),
    new KeyValuePair<int, string>(61, "COLOR_HLS2RGB"),
    new KeyValuePair<int, string>(66, "COLOR_BGR2HSV_FULL"),
    new KeyValuePair<int, string>(67, "COLOR_RGB2HSV_FULL"),
    new KeyValuePair<int, string>(68, "COLOR_BGR2HLS_FULL"),
    new KeyValuePair<int, string>(69, "COLOR_RGB2HLS_FULL"),
    new KeyValuePair<int, string>(70, "COLOR_HSV2BGR_FULL"),
    new KeyValuePair<int, string>(71, "COLOR_HSV2RGB_FULL"),
    new KeyValuePair<int, string>(72, "COLOR_HLS2BGR_FULL"),
    new KeyValuePair<int, string>(73, "COLOR_HLS2RGB_FULL"),
    new KeyValuePair<int, string>(74, "COLOR_LBGR2Lab"),
    new KeyValuePair<int, string>(75, "COLOR_LRGB2Lab"),
    new KeyValuePair<int, string>(76, "COLOR_LBGR2Luv"),
    new KeyValuePair<int, string>(77, "COLOR_LRGB2Luv"),
    new KeyValuePair<int, string>(78, "COLOR_Lab2LBGR"),
    new KeyValuePair<int, string>(79, "COLOR_Lab2LRGB"),
    new KeyValuePair<int, string>(80, "COLOR_Luv2LBGR"),
    new KeyValuePair<int, string>(81, "COLOR_Luv2LRGB"),
    new KeyValuePair<int, string>(82, "COLOR_BGR2YUV"),
    new KeyValuePair<int, string>(83, "COLOR_RGB2YUV"),
    new KeyValuePair<int, string>(84, "COLOR_YUV2BGR"),
    new KeyValuePair<int, string>(85, "COLOR_YUV2RGB"),
    new KeyValuePair<int, string>(90, "COLOR_YUV2RGB_NV12"),
    new KeyValuePair<int, string>(91, "COLOR_YUV2BGR_NV12"),
    new KeyValuePair<int, string>(92, "COLOR_YUV2RGB_NV21, COLOR_YUV420sp2RGB"),
    new KeyValuePair<int, string>(93, "COLOR_YUV2BGR_NV21, COLOR_YUV420sp2BGR"),
    new KeyValuePair<int, string>(94, "COLOR_YUV2RGBA_NV12"),
    new KeyValuePair<int, string>(95, "COLOR_YUV2BGRA_NV12"),
    new KeyValuePair<int, string>(96, "COLOR_YUV2RGBA_NV21, COLOR_YUV420sp2RGBA"),
    new KeyValuePair<int, string>(97, "COLOR_YUV2BGRA_NV21, COLOR_YUV420sp2BGRA"),
    new KeyValuePair<int, string>(98, "COLOR_YUV2RGB_YV12, COLOR_YUV420p2RGB"),
    new KeyValuePair<int, string>(99, "COLOR_YUV2BGR_YV12, COLOR_YUV420p2BGR"),
    new KeyValuePair<int, string>(100, "COLOR_YUV2RGB_IYUV, COLOR_YUV2RGB_I420"),
    new KeyValuePair<int, string>(101, "COLOR_YUV2BGR_IYUV, COLOR_YUV2BGR_I420"),
    new KeyValuePair<int, string>(102, "COLOR_YUV2RGBA_YV12, COLOR_YUV420p2RGBA"),
    new KeyValuePair<int, string>(103, "COLOR_YUV2BGRA_YV12, COLOR_YUV420p2BGRA"),
    new KeyValuePair<int, string>(104, "COLOR_YUV2RGBA_IYUV, COLOR_YUV2RGBA_I420"),
    new KeyValuePair<int, string>(105, "COLOR_YUV2BGRA_IYUV, COLOR_YUV2BGRA_I420"),
    new KeyValuePair<int, string>(106, "COLOR_YUV2GRAY_420,YUV2GRAY_..., YUV420... "),    
    new KeyValuePair<int, string>(107, "COLOR_YUV2RGB_UYVY, COLOR_YUV2RGB_Y422, COLOR_YUV2RGB_UYNV"),
    new KeyValuePair<int, string>(108, "COLOR_YUV2BGR_UYVY, COLOR_YUV2BGR_Y422, COLOR_YUV2BGR_UYNV"),

    new KeyValuePair<int, string>(111, "COLOR_YUV2RGBA_UYVY, COLOR_YUV2RGBA_Y422, COLOR_YUV2RGBA_UYNV"),
    new KeyValuePair<int, string>(112, "COLOR_YUV2BGRA_UYVY, COLOR_YUV2BGRA_Y422, COLOR_YUV2BGRA_UYNV"),
  
    /*  疲れたのでパス
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGRA_UYNV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGB_YUY2"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGR_YUY2"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGB_YVYU"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGR_YVYU"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGB_YUYV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGR_YUYV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGB_YUNV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGR_YUNV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGBA_YUY2"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGRA_YUY2"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGBA_YVYU"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGRA_YVYU"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGBA_YUYV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGRA_YUYV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2RGBA_YUNV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2BGRA_YUNV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2GRAY_UYVY"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2GRAY_YUY2"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2GRAY_Y422"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2GRAY_UYNV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2GRAY_YVYU"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2GRAY_YUYV"),
    new KeyValuePair<int, string>(0, "COLOR_YUV2GRAY_YUNV"),
    new KeyValuePair<int, string>(0, "COLOR_RGBA2mRGBA"),
    new KeyValuePair<int, string>(0, "COLOR_mRGBA2RGBA"),
    new KeyValuePair<int, string>(0, "COLOR_RGB2YUV_I420"),
    new KeyValuePair<int, string>(0, "COLOR_BGR2YUV_I420"),
    new KeyValuePair<int, string>(0, "COLOR_RGB2YUV_IYUV"),
    new KeyValuePair<int, string>(0, "COLOR_BGR2YUV_IYUV"),
    new KeyValuePair<int, string>(0, "COLOR_RGBA2YUV_I420"),
    new KeyValuePair<int, string>(0, "COLOR_BGRA2YUV_I420"),
    new KeyValuePair<int, string>(0, "COLOR_RGBA2YUV_IYUV"),
    new KeyValuePair<int, string>(0, "COLOR_BGRA2YUV_IYUV"),
    new KeyValuePair<int, string>(0, "COLOR_RGB2YUV_YV12"),
    new KeyValuePair<int, string>(0, "COLOR_BGR2YUV_YV12"),
    new KeyValuePair<int, string>(0, "COLOR_RGBA2YUV_YV12"),
    new KeyValuePair<int, string>(0, "COLOR_BGRA2YUV_YV12"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2BGR"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2BGR"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2BGR"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2BGR"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2RGB"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2RGB"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2RGB"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2RGB"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2GRAY"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2GRAY"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2GRAY"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2GRAY"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2BGR_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2BGR_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2BGR_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2BGR_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2RGB_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2RGB_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2RGB_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2RGB_VNG"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2BGR_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2BGR_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2BGR_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2BGR_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2RGB_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2RGB_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2RGB_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2RGB_EA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2BGRA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2BGRA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2BGRA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2BGRA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerBG2RGBA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGB2RGBA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerRG2RGBA"),
    new KeyValuePair<int, string>(0, "COLOR_BayerGR2RGBA")
    */
};


            this.comboBoxCode.DataSource = kv;
            this.comboBoxCode.DisplayMember = "Value";
            this.comboBoxCode.ValueMember = "Key";

            this.comboBoxCode.SelectedIndex = 0;
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenCVFunc.CvtColor cvtColor = new OpenCVFunc.CvtColor();

                int inputNo = imageInOutCtrl1.InNo;
                int outputNo = imageInOutCtrl1.OutNo;

                int code = (int)comboBoxCode.SelectedValue;
                int dstCn = (int)numericUpDownCnNum.Value;

                String retStr = cvtColor.cvtColor_exec(code, dstCn, inputNo, outputNo);
                textBoxParameter.Text = retStr;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}








/*
  cv::COLOR_YUV2RGB_UYVY = 107,
  cv::COLOR_YUV2BGR_UYVY = 108,
  cv::COLOR_YUV2RGB_Y422 = COLOR_YUV2RGB_UYVY,
  cv::COLOR_YUV2BGR_Y422 = COLOR_YUV2BGR_UYVY,
  cv::COLOR_YUV2RGB_UYNV = COLOR_YUV2RGB_UYVY,
  cv::COLOR_YUV2BGR_UYNV = COLOR_YUV2BGR_UYVY,
  cv::COLOR_YUV2RGBA_UYVY = 111,
  cv::COLOR_YUV2BGRA_UYVY = 112,
  cv::COLOR_YUV2RGBA_Y422 = COLOR_YUV2RGBA_UYVY,
  cv::COLOR_YUV2BGRA_Y422 = COLOR_YUV2BGRA_UYVY,
  cv::COLOR_YUV2RGBA_UYNV = COLOR_YUV2RGBA_UYVY,
  cv::COLOR_YUV2BGRA_UYNV = COLOR_YUV2BGRA_UYVY,
  cv::COLOR_YUV2RGB_YUY2 = 115,
  cv::COLOR_YUV2BGR_YUY2 = 116,
  cv::COLOR_YUV2RGB_YVYU = 117,
  cv::COLOR_YUV2BGR_YVYU = 118,
  cv::COLOR_YUV2RGB_YUYV = COLOR_YUV2RGB_YUY2,
  cv::COLOR_YUV2BGR_YUYV = COLOR_YUV2BGR_YUY2,
  cv::COLOR_YUV2RGB_YUNV = COLOR_YUV2RGB_YUY2,
  cv::COLOR_YUV2BGR_YUNV = COLOR_YUV2BGR_YUY2,
  cv::COLOR_YUV2RGBA_YUY2 = 119,
  cv::COLOR_YUV2BGRA_YUY2 = 120,
  cv::COLOR_YUV2RGBA_YVYU = 121,
  cv::COLOR_YUV2BGRA_YVYU = 122,
  cv::COLOR_YUV2RGBA_YUYV = COLOR_YUV2RGBA_YUY2,
  cv::COLOR_YUV2BGRA_YUYV = COLOR_YUV2BGRA_YUY2,
  cv::COLOR_YUV2RGBA_YUNV = COLOR_YUV2RGBA_YUY2,
  cv::COLOR_YUV2BGRA_YUNV = COLOR_YUV2BGRA_YUY2,
  cv::COLOR_YUV2GRAY_UYVY = 123,
  cv::COLOR_YUV2GRAY_YUY2 = 124,
  cv::COLOR_YUV2GRAY_Y422 = COLOR_YUV2GRAY_UYVY,
  cv::COLOR_YUV2GRAY_UYNV = COLOR_YUV2GRAY_UYVY,
  cv::COLOR_YUV2GRAY_YVYU = COLOR_YUV2GRAY_YUY2,
  cv::COLOR_YUV2GRAY_YUYV = COLOR_YUV2GRAY_YUY2,
  cv::COLOR_YUV2GRAY_YUNV = COLOR_YUV2GRAY_YUY2,
  cv::COLOR_RGBA2mRGBA = 125,
  cv::COLOR_mRGBA2RGBA = 126,
  cv::COLOR_RGB2YUV_I420 = 127,
  cv::COLOR_BGR2YUV_I420 = 128,
  cv::COLOR_RGB2YUV_IYUV = COLOR_RGB2YUV_I420,
  cv::COLOR_BGR2YUV_IYUV = COLOR_BGR2YUV_I420,
  cv::COLOR_RGBA2YUV_I420 = 129,
  cv::COLOR_BGRA2YUV_I420 = 130,
  cv::COLOR_RGBA2YUV_IYUV = COLOR_RGBA2YUV_I420,
  cv::COLOR_BGRA2YUV_IYUV = COLOR_BGRA2YUV_I420,
  cv::COLOR_RGB2YUV_YV12 = 131,
  cv::COLOR_BGR2YUV_YV12 = 132,
  cv::COLOR_RGBA2YUV_YV12 = 133,
  cv::COLOR_BGRA2YUV_YV12 = 134,
  cv::COLOR_BayerBG2BGR = 46,
  cv::COLOR_BayerGB2BGR = 47,
  cv::COLOR_BayerRG2BGR = 48,
  cv::COLOR_BayerGR2BGR = 49,
  cv::COLOR_BayerBG2RGB = COLOR_BayerRG2BGR,
  cv::COLOR_BayerGB2RGB = COLOR_BayerGR2BGR,
  cv::COLOR_BayerRG2RGB = COLOR_BayerBG2BGR,
  cv::COLOR_BayerGR2RGB = COLOR_BayerGB2BGR,
  cv::COLOR_BayerBG2GRAY = 86,
  cv::COLOR_BayerGB2GRAY = 87,
  cv::COLOR_BayerRG2GRAY = 88,
  cv::COLOR_BayerGR2GRAY = 89,
  cv::COLOR_BayerBG2BGR_VNG = 62,
  cv::COLOR_BayerGB2BGR_VNG = 63,
  cv::COLOR_BayerRG2BGR_VNG = 64,
  cv::COLOR_BayerGR2BGR_VNG = 65,
  cv::COLOR_BayerBG2RGB_VNG = COLOR_BayerRG2BGR_VNG,
  cv::COLOR_BayerGB2RGB_VNG = COLOR_BayerGR2BGR_VNG,
  cv::COLOR_BayerRG2RGB_VNG = COLOR_BayerBG2BGR_VNG,
  cv::COLOR_BayerGR2RGB_VNG = COLOR_BayerGB2BGR_VNG,
  cv::COLOR_BayerBG2BGR_EA = 135,
  cv::COLOR_BayerGB2BGR_EA = 136,
  cv::COLOR_BayerRG2BGR_EA = 137,
  cv::COLOR_BayerGR2BGR_EA = 138,
  cv::COLOR_BayerBG2RGB_EA = COLOR_BayerRG2BGR_EA,
  cv::COLOR_BayerGB2RGB_EA = COLOR_BayerGR2BGR_EA,
  cv::COLOR_BayerRG2RGB_EA = COLOR_BayerBG2BGR_EA,
  cv::COLOR_BayerGR2RGB_EA = COLOR_BayerGB2BGR_EA,
  cv::COLOR_BayerBG2BGRA = 139,
  cv::COLOR_BayerGB2BGRA = 140,
  cv::COLOR_BayerRG2BGRA = 141,
  cv::COLOR_BayerGR2BGRA = 142,
  cv::COLOR_BayerBG2RGBA = COLOR_BayerRG2BGRA,
  cv::COLOR_BayerGB2RGBA = COLOR_BayerGR2BGRA,
  cv::COLOR_BayerRG2RGBA = COLOR_BayerBG2BGRA,
  cv::COLOR_BayerGR2RGBA = COLOR_BayerGB2BGRA,
  cv::COLOR_COLORCVT_MAX = 143
*/