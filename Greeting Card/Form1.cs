using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //when program starts, create a graphics object and fill screen with blue.
            Graphics g = this.CreateGraphics();
            g.Clear(Color.DarkBlue);

            //create pens
            Pen whitePenThin = new Pen(Color.White, 5);
            Pen whitePenBold = new Pen(Color.White, 20);
            Pen darkBluePen = new Pen(Color.DarkBlue, 24);

            //create brushes
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush pinkBrush = new SolidBrush(Color.HotPink);
            SolidBrush tealBrush = new SolidBrush(Color.Aqua);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);

            //draw rectangles with for loop

            //center column
            g.FillRectangle(pinkBrush, 163, 95, 45, 25);
            for (int i = 1; i <= 6; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(pinkBrush, 163, 95 + i * 22, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(orangeBrush, 163, 95 + i * 22, 45, 25);
                }
                else
                {
                    g.FillRectangle(tealBrush, 163, 95 + i * 22, 45, 25);
                }
            }

            //right column
            g.FillRectangle(orangeBrush, 207, 92, 45, 25);
            for (int i = 1; i <= 6; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(tealBrush, 207, 95 + i * 22, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(pinkBrush, 207, 95 + i * 22, 45, 25);
                }
                else
                {
                    g.FillRectangle(orangeBrush, 207, 95 + i * 22, 45, 25);
                }
            }

            //left column
            g.FillRectangle(orangeBrush, 119, 95, 45, 25);
            for (int i = 1; i <= 6; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(orangeBrush, 119, 95 + i * 22, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(tealBrush, 119, 95 + i * 22, 45, 25);
                }
                else
                {
                    g.FillRectangle(pinkBrush, 119, 95 + i * 22, 45, 25);
                }
            }


            //draw disco ball circle and background colour circle
            g.DrawEllipse(whitePenBold, 97, 85, 175, 175);
            g.DrawEllipse(darkBluePen, 92, 80, 185, 185);

            //create disco ball line
            g.DrawLine(whitePenThin, 185, 0, 185, 95);

            //create "Happy New Year!" font and draw this text
            Font bigFont = new Font("Impact", 30, FontStyle.Bold);
            g.DrawString("Happy New Year!", bigFont, yellowBrush, 32, 20);

            //create "202" and "4" font and draw this text
            Font smallFont = new Font("Impact", 50, FontStyle.Bold);
            g.DrawString("202", smallFont, yellowBrush, 100, 275);
            g.DrawString("4", smallFont, yellowBrush, 206, 275);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();



            //background colours flashing
            for (int i = 1; i <= 10; i++)
            {
                g.Clear(Color.Red);
                Thread.Sleep(200);
                g.Clear(Color.Yellow);
                Thread.Sleep(200);
                g.Clear(Color.Blue);
                Thread.Sleep(200);
            }
        }
    }
}
