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
using System.Media;

//a greeting card that utilizes for loops and a graphics object
//Avery Durand
//ICS3U Mr. T

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        //declare variable
        Graphics g;

        //create sound player
        SoundPlayer sp = new SoundPlayer(Properties.Resources.notRickAstley);

        //create pens
        Pen whitePenThin = new Pen(Color.White, 5);
        Pen whitePenBold = new Pen(Color.White, 20);
        Pen darkBluePen = new Pen(Color.DarkBlue, 24);
        //create brushes
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush pinkBrush = new SolidBrush(Color.HotPink);
        SolidBrush purpleBrush = new SolidBrush(Color.MediumSlateBlue);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blueBrush = new SolidBrush(Color.DarkBlue);

        int counter = 1;
        int x = 10;
        int y = 10;
        int circleColor = 1;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            //when program starts, create a graphics object
            g = this.CreateGraphics();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //fill screen with blue and disco ball with white
            g.Clear(Color.DarkBlue);
            g.FillEllipse(whiteBrush, 97, 85, 175, 175);

            //draw inside disco ball
            OriginalDisco();

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
            //make font
            Font smallFont = new Font("Impact", 50, FontStyle.Bold);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            //move 4
            for (int i = 1; i <= 50; i++)
            {
                //cover old 4 with rectangle
                g.FillRectangle(blueBrush, 217, 286, 150, 58);

                //draw new 4 i*3 pixels over
                g.DrawString("4", smallFont, yellowBrush, 206 + i * 3, 275);
                Thread.Sleep(5);
            }
            //create 5
            for (int i = 1; i <= 50; i++)
            {
                //cover old 4 with rectangle
                g.FillRectangle(blueBrush, 217, 286, 150, 58);

                //draw new 4 i*3 pixels over
                g.DrawString("5", smallFont, yellowBrush, 356 - i * 3, 275);
                Thread.Sleep(5);
            }

            //sound
            sp.Play();

            //flash disco
            for (int i = 1; i <= 15; i++)
            {
                OriginalDisco();
                Thread.Sleep(250);
                Disco2();
                Thread.Sleep(250);
            }

            timer.Enabled = true;
        }

        public void OriginalDisco()
        {
            //center column
            g.FillRectangle(pinkBrush, 163, 95, 45, 25);
            for (int i = 1; i <= 5; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(pinkBrush, 163, 95 + i * 27, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(orangeBrush, 163, 95 + i * 27, 45, 25);
                }
                else
                {
                    g.FillRectangle(purpleBrush, 163, 95 + i * 27, 45, 25);
                }
            }

            //right column
            g.FillRectangle(purpleBrush, 210, 95, 45, 25);
            for (int i = 1; i <= 5; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(purpleBrush, 210, 95 + i * 27, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(pinkBrush, 210, 95 + i * 27, 45, 25);
                }
                else
                {
                    g.FillRectangle(orangeBrush, 210, 95 + i * 27, 45, 25);
                }
            }

            //far right column
            for (int i = 1; i <= 4; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(orangeBrush, 257, 95 + i * 27, 20, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(purpleBrush, 257, 95 + i * 27, 20, 25);
                }
                else
                {
                    g.FillRectangle(pinkBrush, 257, 95 + i * 27, 20, 25);
                }
            }

            //left column
            g.FillRectangle(orangeBrush, 116, 95, 45, 25);
            for (int i = 1; i <= 5; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(orangeBrush, 116, 95 + i * 27, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(purpleBrush, 116, 95 + i * 27, 45, 25);
                }
                else
                {
                    g.FillRectangle(pinkBrush, 116, 95 + i * 27, 45, 25);
                }
            }

            //far left column
            for (int i = 1; i <= 4; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(purpleBrush, 94, 95 + i * 27, 20, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(pinkBrush, 94, 95 + i * 27, 20, 25);
                }
                else
                {
                    g.FillRectangle(orangeBrush, 94, 95 + i * 27, 20, 25);
                }
            }

            Top();
        }

        public void Disco2()
        {
            //center column
            g.FillRectangle(orangeBrush, 163, 95, 45, 25);
            for (int i = 1; i <= 5; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(orangeBrush, 163, 95 + i * 27, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(purpleBrush, 163, 95 + i * 27, 45, 25);
                }
                else
                {
                    g.FillRectangle(pinkBrush, 163, 95 + i * 27, 45, 25);
                }
            }

            //right column
            g.FillRectangle(pinkBrush, 210, 95, 45, 25);
            for (int i = 1; i <= 5; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(pinkBrush, 210, 95 + i * 27, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(orangeBrush, 210, 95 + i * 27, 45, 25);
                }
                else
                {
                    g.FillRectangle(purpleBrush, 210, 95 + i * 27, 45, 25);
                }
            }

            //far right column
            for (int i = 1; i <= 4; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(purpleBrush, 257, 95 + i * 27, 20, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(pinkBrush, 257, 95 + i * 27, 20, 25);
                }
                else
                {
                    g.FillRectangle(orangeBrush, 257, 95 + i * 27, 20, 25);
                }
            }

            //left column
            g.FillRectangle(purpleBrush, 116, 95, 45, 25);
            for (int i = 1; i <= 5; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(purpleBrush, 116, 95 + i * 27, 45, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(pinkBrush, 116, 95 + i * 27, 45, 25);
                }
                else
                {
                    g.FillRectangle(orangeBrush, 116, 95 + i * 27, 45, 25);
                }
            }

            //far left column
            for (int i = 1; i <= 4; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillRectangle(pinkBrush, 94, 95 + i * 27, 20, 25);
                }
                else if (i % 3 == 1)
                {
                    g.FillRectangle(orangeBrush, 94, 95 + i * 27, 20, 25);
                }
                else
                {
                    g.FillRectangle(purpleBrush, 94, 95 + i * 27, 20, 25);
                }
            }

            Top();
        }

        public void Top()
        {
            //edges
            g.DrawEllipse(whitePenBold, 97, 85, 175, 175);
            g.DrawEllipse(darkBluePen, 89, 78, 191, 190);

            //create disco ball line
            g.DrawLine(whitePenThin, 185, 0, 185, 95);

            //create "Happy New Year!" font and draw this text
            Font bigFont = new Font("Impact", 30, FontStyle.Bold);
            g.DrawString("Happy New Year!", bigFont, yellowBrush, 32, 20);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //add 1 to counter
            counter++;

            //cover old circle
            //g.FillEllipse(blueBrush, x, y, 20, 20);

            //new circle
            if (counter > 0 && counter < 169)
            {
                if (y <= 340 && x < 15)
                {
                    y += 8;
                }
                else if (y > 340 && x < 325)
                {
                    x += 8;
                }
                else if (x >= 320 && y >= 10)
                {
                    y -= 8;
                }
                else if (x > 10 && y <= 15)
                {
                    x -= 8;
                }

                CircleColor();

            }
        }

        public void CircleColor()
        {
            if (circleColor == 1)
            {
                g.FillEllipse(orangeBrush, x, y, 20, 20);
                circleColor++;
            }
            else if (circleColor == 2)
            {
                g.FillEllipse(pinkBrush, x, y, 20, 20);
                circleColor++;
            }
            else
            {
                g.FillEllipse(purpleBrush, x, y, 20, 20);
                circleColor = 1;
            }
        }
    }
}
