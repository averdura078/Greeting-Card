using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Pen yellowPen = new Pen(Color.Yellow, 5);

            //create brushes
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            //create "Happy New Year!" font and draw this text
            Font bigFont = new Font("Impact", 30, FontStyle.Bold);
            g.DrawString("Happy New Year!", bigFont, yellowBrush, 32, 20);

            //create "202" and "4" font and draw this text
            Font smallFont = new Font("Impact", 50, FontStyle.Bold);
            g.DrawString("202", smallFont, yellowBrush, 100, 275);
            g.DrawString("4", smallFont, yellowBrush, 206, 275);

            //draw image
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
