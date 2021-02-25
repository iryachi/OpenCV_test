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
    public partial class ConvolutionTestCtrl : UserControl
    {
        const int imageSize = 5;
        const int kernelSize = 3;

        Label[,] labelIn = new Label[imageSize, imageSize];//5x5 決め打ち
        TextBox[,] txtBxKernel = new TextBox[kernelSize, kernelSize];//3x3 決め打ち
        Label[,] labelOut = new Label[imageSize, imageSize];//5x5 決め打ち

        public ConvolutionTestCtrl()
        {
            InitializeComponent();

            labelIn[0, 0] = lbl11;
            labelIn[0, 1] = lbl12;
            labelIn[0, 2] = lbl13;
            labelIn[0, 3] = lbl14;
            labelIn[0, 4] = lbl15;
            labelIn[1, 0] = lbl21;
            labelIn[1, 1] = lbl22;
            labelIn[1, 2] = lbl23;
            labelIn[1, 3] = lbl24;
            labelIn[1, 4] = lbl25;
            labelIn[2, 0] = lbl31;
            labelIn[2, 1] = lbl32;
            labelIn[2, 2] = lbl33;
            labelIn[2, 3] = lbl34;
            labelIn[2, 4] = lbl35;
            labelIn[3, 0] = lbl41;
            labelIn[3, 1] = lbl42;
            labelIn[3, 2] = lbl43;
            labelIn[3, 3] = lbl44;
            labelIn[3, 4] = lbl45;
            labelIn[4, 0] = lbl51;
            labelIn[4, 1] = lbl52;
            labelIn[4, 2] = lbl53;
            labelIn[4, 3] = lbl54;
            labelIn[4, 4] = lbl55;

            txtBxKernel[0, 0] = txtBx11;
            txtBxKernel[0, 1] = txtBx12;
            txtBxKernel[0, 2] = txtBx13;
            txtBxKernel[1, 0] = txtBx21;
            txtBxKernel[1, 1] = txtBx22;
            txtBxKernel[1, 2] = txtBx23;
            txtBxKernel[2, 0] = txtBx31;
            txtBxKernel[2, 1] = txtBx32;
            txtBxKernel[2, 2] = txtBx33;


            labelOut[0, 0] = lblo11;
            labelOut[0, 1] = lblo12;
            labelOut[0, 2] = lblo13;
            labelOut[0, 3] = lblo14;
            labelOut[0, 4] = lblo15;
            labelOut[1, 0] = lblo21;
            labelOut[1, 1] = lblo22;
            labelOut[1, 2] = lblo23;
            labelOut[1, 3] = lblo24;
            labelOut[1, 4] = lblo25;
            labelOut[2, 0] = lblo31;
            labelOut[2, 1] = lblo32;
            labelOut[2, 2] = lblo33;
            labelOut[2, 3] = lblo34;
            labelOut[2, 4] = lblo35;
            labelOut[3, 0] = lblo41;
            labelOut[3, 1] = lblo42;
            labelOut[3, 2] = lblo43;
            labelOut[3, 3] = lblo44;
            labelOut[3, 4] = lblo45;
            labelOut[4, 0] = lblo51;
            labelOut[4, 1] = lblo52;
            labelOut[4, 2] = lblo53;
            labelOut[4, 3] = lblo54;
            labelOut[4, 4] = lblo55;

        }

        private void setLabel(byte[,] blist)
        {
            for (int i = 0; i < imageSize; i++)
            {
                for (int j = 0; j < imageSize; j++)
                {
                    byte b = blist[i,j];
                labelIn[i,j].Text = b.ToString();
                labelIn[i,j].BackColor = Color.FromArgb(b, b, b);
                }
            }
        }

        private void setTextBox(double[,] l)
        {
            for (int i = 0; i < kernelSize; i++)
            {
                for (int j = 0; j < kernelSize; j++)
                {
                    txtBxKernel[i,j].Text = l[i,j].ToString("0.00");
                }
            }
        }


        private void buttonPoint_Click(object sender, EventArgs e)
        {
            byte max = (byte)numericUpDownMax.Value;
            byte min = (byte)numericUpDownMin.Value;

            byte[,] b = new byte[,]
            {
                { min,min,min,min,min },
                { min,min,min,min,min },
            {   min,min,max,min,min    },
                { min,min,min,min,min },
                { min,min,min,min,min },

            };
            setLabel(b);
        }

        private void buttonHLine_Click(object sender, EventArgs e)
        {
            byte max = (byte)numericUpDownMax.Value;
            byte min = (byte)numericUpDownMin.Value;
            byte[,] b = new byte[,]
     {
                { min,min,min,min,min },
                { min,min,min,min,min },
              {max,max,max,max,max },
                { min,min,min,min,min },
                { min,min,min,min,min },
     };
            setLabel(b);
        }

        private void buttonVLine_Click(object sender, EventArgs e)
        {
            byte max = (byte)numericUpDownMax.Value;
            byte min = (byte)numericUpDownMin.Value;

            byte[,] b = new byte[,]
{
           {   min,min,max,min,min      },
           {   min,min,max,min,min      },
           {   min,min,max,min,min      },
           {   min,min,max,min,min      },
           {   min,min,max,min,min      }
};
            setLabel(b);
        }

        private void buttonGradation_Click(object sender, EventArgs e)
        {
            byte max = (byte)numericUpDownMax.Value;
            byte min = (byte)numericUpDownMin.Value;
            if (min > max) { return; }
            byte half = (byte)((max -min)/ 2 + min);

            byte[,] b = new byte[,]
{
                { min,min,min,min,min },
             {     half,half,half,half,half         },
             {     max,max,max,max,max        },
             {     half,half,half,half,half        },
                { min,min,min,min,min },
};
            setLabel(b);
        }

        private void buttonDiffH1_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
            {
             {0,0,0},
             {-1,1,0 },
             {0,0,0}
            };
            setTextBox(b);
        }

        private void buttonDiffV1_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
     {
             {0,-1,0},
             {0,1,0 },
             {0,0,0}
     };
            setTextBox(b);
        }

        private void buttonDiffH2_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
        {
             {0,0,0},
             {-1,2,-1 },
             {0,0,0}
        };
            setTextBox(b);
        }

        private void buttonDiffV2_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
{
             {0,-1,0},
             {0,2,0 },
             {0,-1,0}
};
            setTextBox(b);

        }

        private void buttonPreH_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
{
             {-1,0,1},
             {-1,0,1},
             {-1,0,1}
};
            setTextBox(b);
        }

        private void buttonPreV_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
{
             {-1,-1,-1},
             {0,0,0},
             {1,1,1}
};
            setTextBox(b);
        }

        private void buttonSobelH_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
{
             {-1,0,1},
             {-2,0,2},
             {-1,0,1}
};
            setTextBox(b);
        }

        private void button2SobelV_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
{
             {-1,-2,-1},
             {0,0,0},
             {1,2,1}
};
            setTextBox(b);
        }

        private void buttonMeaning_Click(object sender, EventArgs e)
        {
            double[,] b = new double[,]
{
             {0.11,0.11,0.11},
             {0.11,0.11,0.11},
             {0.11,0.11,0.11}
};
            setTextBox(b);
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            //カーネル作成
            double[,] kernel = new double[kernelSize, kernelSize];
            for (int i = 0; i < kernelSize; i++)
            {
                for (int j = 0; j < kernelSize; j++)
                {
                    double d = 0;
                    if (double.TryParse(txtBxKernel[i, j].Text, out d))
                    {
                        kernel[i, j] = d;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            //InImage 作成
            double[,] inimage = new double[imageSize, imageSize];
            for (int i = 0; i < imageSize; i++)
            {
                for (int j = 0; j < imageSize; j++)
                {
                    double d = 0;
                    if (double.TryParse(labelIn[i, j].Text, out d))
                    {
                        inimage[i, j] = d;
                    }
                    else
                    {
                        return;
                    }
                }
            }




            for (int i = 0, posY = 1; i < 3; i++, posY++)
            {

                for (int j = 0, posX = 1; j < 3; j++, posX++)
                {
                    int idata  = (int) calc(inimage, kernel, posY, posX);
                    idata = Math.Max(0, idata);
                    idata = Math.Min(255, idata);
                    byte b = (byte)idata;
                    labelOut[posY, posX].Text = b.ToString();
                    labelOut[posY, posX].BackColor = Color.FromArgb(b, b, b);
                }
            }
        }

        double calc(double[,] inimage, double[,] kernel, int posY, int posX)
        {
            //直書き計算
            double line1 = kernel[0, 0] * inimage[posY - 1, posX - 1]
                + kernel[0, 1] * inimage[posY-1, posX ]
                + kernel[0, 2] * inimage[posY - 1, posX + 1];
            double line2 = kernel[1, 0] * inimage[posY, posX-1]
        + kernel[1, 1] * inimage[posY, posX]
        + kernel[1, 2] * inimage[posY, posX+1];
            double line3 = kernel[2, 0] * inimage[posY + 1, posX - 1]
          + kernel[2, 1] * inimage[posY+1, posX ]
          + kernel[2, 2] * inimage[posY + 1, posX + 1];

            return line1 + line2 + line3; 
        }
    }
}
