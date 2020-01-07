using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private void start()
        {
            별ToolStripMenuItem.Checked = true;
            빨간색ToolStripMenuItem.Checked = true;
            중간ToolStripMenuItem.Checked = true;

            Graphics g = CreateGraphics();

            Point[] pts = {
                new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
            };

            g.FillPolygon(red, pts);
            g.DrawPolygon(two, pts);
        }

        public Form1()
        {
            InitializeComponent();
        }

        Pen one = new Pen(Color.Black, 5);
        Pen two = new Pen(Color.Black, 3);
        Pen three = new Pen(Color.Black, 1);

        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush blue = new SolidBrush(Color.Blue);



        private void 동그라미ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (동그라미ToolStripMenuItem.Checked)
            {
                사각형ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);

                Rectangle r = new Rectangle(50, 50, 100, 100);

                if (빨간색ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(red, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(yellow, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(green, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(blue, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }
            }

            else {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }
        private void 사각형ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (사각형ToolStripMenuItem.Checked) {
                동그라미ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;

                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);

                Rectangle r = new Rectangle(50, 50, 100, 100);

                if (빨간색ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(red, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(yellow, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(green, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(blue, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }

        }

        private void 별ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (별ToolStripMenuItem.Checked)
            {
                사각형ToolStripMenuItem.Checked = false;
                동그라미ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;

                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);

                Point[] pts = {
                new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
            };

                if (빨간색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(red, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(yellow, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(green, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(blue, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 다중삼각형ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (다중삼각형ToolStripMenuItem.Checked)
            {

                사각형ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;
                동그라미ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;

                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);

                Point[] pts = {
                    new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)
                };

                if (빨간색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(red, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(yellow, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(green, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    g.FillPolygon(blue, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 직선ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (직선ToolStripMenuItem.Checked)
            {

                사각형ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;
                동그라미ToolStripMenuItem.Checked = false;
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
                

                if (빨간색ToolStripMenuItem.Checked)
                {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 5);
                        g.DrawLine(p,50,50,200,180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 빨간색ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (빨간색ToolStripMenuItem.Checked) {
                노란색ToolStripMenuItem.Checked = false;
                초록색ToolStripMenuItem.Checked = false;
                파란색ToolStripMenuItem.Checked = false;

                Graphics g = CreateGraphics();
                Rectangle r = new Rectangle(50, 50, 100, 100);

                if (동그라미ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(red, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }

                else if (사각형ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(red, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }

                else if (별ToolStripMenuItem.Checked)
                {
                    Point[] pts = {
                    new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
                };
                    g.FillPolygon(red, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (다중삼각형ToolStripMenuItem.Checked) {
                    Point[] pts = {
                    new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)
                };
                    g.FillPolygon(red, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (직선ToolStripMenuItem.Checked) {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else
                    {
                        g.FillRectangle(Brushes.White, ClientRectangle);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 노란색ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(노란색ToolStripMenuItem.Checked) {
                빨간색ToolStripMenuItem.Checked = false;
                초록색ToolStripMenuItem.Checked = false;
                파란색ToolStripMenuItem.Checked = false;
                Graphics g = CreateGraphics();
                Rectangle r = new Rectangle(50, 50, 100, 100);

                if (동그라미ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(yellow, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }

                else if (사각형ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(yellow, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }

                else if (별ToolStripMenuItem.Checked)
                {
                    Point[] pts = {
                    new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
                };
                    g.FillPolygon(yellow, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (다중삼각형ToolStripMenuItem.Checked)
                {
                    Point[] pts = {
                        new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)
                    
                };
                    g.FillPolygon(yellow, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (직선ToolStripMenuItem.Checked)
                {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else
                    {
                        g.FillRectangle(Brushes.White, ClientRectangle);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 초록색ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (초록색ToolStripMenuItem.Checked)
            {
                노란색ToolStripMenuItem.Checked = false;
                빨간색ToolStripMenuItem.Checked = false;
                파란색ToolStripMenuItem.Checked = false;
                Graphics g = CreateGraphics();
                Rectangle r = new Rectangle(50, 50, 100, 100);

                if (동그라미ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(green, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }

                else if (사각형ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(green, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }

                else if (별ToolStripMenuItem.Checked)
                {
                    Point[] pts = {
                    new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
                };
                    g.FillPolygon(green, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (다중삼각형ToolStripMenuItem.Checked)
                {
                    Point[] pts = {
                    new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)                };
                    g.FillPolygon(green, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (직선ToolStripMenuItem.Checked)
                {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else
                    {
                        g.FillRectangle(Brushes.White, ClientRectangle);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 파란색ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (파란색ToolStripMenuItem.Checked)
            {
                노란색ToolStripMenuItem.Checked = false;
                초록색ToolStripMenuItem.Checked = false;
                빨간색ToolStripMenuItem.Checked = false;
                Graphics g = CreateGraphics();
                Rectangle r = new Rectangle(50, 50, 100, 100);

                if (동그라미ToolStripMenuItem.Checked)
                {
                    g.FillEllipse(blue, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawEllipse(three, r);
                    }
                }

                else if (사각형ToolStripMenuItem.Checked)
                {
                    g.FillRectangle(blue, r);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(one, r);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(two, r);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawRectangle(three, r);
                    }
                }

                else if (별ToolStripMenuItem.Checked)
                {
                    Point[] pts = {
                    new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
                };
                    g.FillPolygon(blue, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (다중삼각형ToolStripMenuItem.Checked)
                {
                    Point[] pts = {
                    new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)
                };
                    g.FillPolygon(blue, pts);
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(one, pts);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(two, pts);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (직선ToolStripMenuItem.Checked)
                {
                    if (굵게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (얇게ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else
                    {
                        g.FillRectangle(Brushes.White, ClientRectangle);
                    }
                }
            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 굵게ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (굵게ToolStripMenuItem.Checked)
            {
                중간ToolStripMenuItem.Checked = false;
                얇게ToolStripMenuItem.Checked = false;


                if (동그라미ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Rectangle r = new Rectangle(50, 50, 100, 100);

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(red, r);
                        g.DrawEllipse(one, r);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(yellow, r);
                        g.DrawEllipse(one, r);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(green, r);
                        g.DrawEllipse(one, r);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(blue, r);
                        g.DrawEllipse(one, r);

                    }
                }

                else if (사각형ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Rectangle r = new Rectangle(50, 50, 100, 100);

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(red, r);
                        g.DrawRectangle(one, r);
                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(yellow, r);
                        g.DrawRectangle(one, r);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(green, r);
                        g.DrawRectangle(one, r);
                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(blue, r);
                        g.DrawRectangle(one, r);
                    }
                }

                else if (별ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Point[] pts = {
                new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
            };

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(red, pts);
                            g.DrawPolygon(one, pts);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(yellow, pts);
                            g.DrawPolygon(one, pts);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(green, pts);
                            g.DrawPolygon(one, pts);
                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(blue, pts);
                            g.DrawPolygon(one, pts);
                    }
                }

                else if (다중삼각형ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Point[] pts = {
                    new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)
                };

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(red, pts);
                            g.DrawPolygon(one, pts);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(yellow, pts);
                            g.DrawPolygon(one, pts);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(green, pts);
                            g.DrawPolygon(one, pts);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(blue, pts);
                            g.DrawPolygon(one, pts);

                    }
                }

                else if (직선ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);


                    if (빨간색ToolStripMenuItem.Checked)
                    {
                            Pen p = new Pen(Color.Red, 5);
                            g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                            Pen p = new Pen(Color.Yellow, 5);
                            g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                            Pen p = new Pen(Color.Green, 5);
                            g.DrawLine(p, 50, 50, 200, 180);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                            Pen p = new Pen(Color.Blue, 5);
                            g.DrawLine(p, 50, 50, 200, 180);

                    }
                }

            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 중간ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (중간ToolStripMenuItem.Checked)
            {
                굵게ToolStripMenuItem.Checked = false;
                얇게ToolStripMenuItem.Checked = false;


                if (동그라미ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Rectangle r = new Rectangle(50, 50, 100, 100);

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(red, r);
                        g.DrawEllipse(two, r);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(yellow, r);
                        g.DrawEllipse(two, r);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(green, r);
                        g.DrawEllipse(two, r);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(blue, r);
                        g.DrawEllipse(two, r);

                    }
                }

                else if (사각형ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Rectangle r = new Rectangle(50, 50, 100, 100);

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(red, r);
                        g.DrawRectangle(two, r);
                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(yellow, r);
                        g.DrawRectangle(two, r);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(green, r);
                        g.DrawRectangle(two, r);
                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(blue, r);
                        g.DrawRectangle(two, r);
                    }
                }

                else if (별ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Point[] pts = {
                new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
            };

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(red, pts);
                        g.DrawPolygon(two, pts);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(yellow, pts);
                        g.DrawPolygon(two, pts);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(green, pts);
                        g.DrawPolygon(two, pts);
                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(blue, pts);
                        g.DrawPolygon(two, pts);
                    }
                }

                else if (다중삼각형ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Point[] pts = {
                    new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)
                };

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(red, pts);
                        g.DrawPolygon(two, pts);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(yellow, pts);
                        g.DrawPolygon(two, pts);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(green, pts);
                        g.DrawPolygon(two, pts);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(blue, pts);
                        g.DrawPolygon(two, pts);

                    }
                }

                else if (직선ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);


                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 3);
                        g.DrawLine(p, 50, 50, 200, 180);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 3);
                        g.DrawLine(p, 50, 50, 200, 180);

                    }
                }

            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }

        private void 얇게ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (얇게ToolStripMenuItem.Checked)
            {
                중간ToolStripMenuItem.Checked = false;
                굵게ToolStripMenuItem.Checked = false;


                if (동그라미ToolStripMenuItem.Checked)
                {                   Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Rectangle r = new Rectangle(50, 50, 100, 100);

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(red, r);
                        g.DrawEllipse(three, r);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(yellow, r);
                        g.DrawEllipse(three, r);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(green, r);
                        g.DrawEllipse(three, r);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillEllipse(blue, r);
                        g.DrawEllipse(three, r);

                    }
                }

                else if (사각형ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Rectangle r = new Rectangle(50, 50, 100, 100);

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(red, r);
                        g.DrawRectangle(three, r);
                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(yellow, r);
                        g.DrawRectangle(three, r);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(green, r);
                        g.DrawRectangle(three, r);
                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillRectangle(blue, r);
                        g.DrawRectangle(three, r);
                    }
                }

                else if (별ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Point[] pts = {
                new Point(113,64), new Point(78,145), new Point(165,140), new Point(70,69), new Point(131,173)
            };

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(red, pts);
                        g.DrawPolygon(three, pts);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(yellow, pts);
                        g.DrawPolygon(three, pts);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(green, pts);
                        g.DrawPolygon(three, pts);
                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(blue, pts);
                        g.DrawPolygon(three, pts);
                    }
                }

                else if (다중삼각형ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);

                    Point[] pts = {
                    new Point(44, 44), new Point(44,157), new Point(88,157), new Point(44, 115), new Point(88,100), new Point(88,157), new Point(132,157)
                };

                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(red, pts);
                        g.DrawPolygon(three, pts);

                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(yellow, pts);
                        g.DrawPolygon(three, pts);

                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(green, pts);
                        g.DrawPolygon(three, pts);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        g.FillPolygon(blue, pts);
                        g.DrawPolygon(three, pts);

                    }
                }

                else if (직선ToolStripMenuItem.Checked)
                {
                    Graphics g = CreateGraphics();

                    g.FillRectangle(Brushes.White, ClientRectangle);


                    if (빨간색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Red, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (노란색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Yellow, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (초록색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Green, 1);
                        g.DrawLine(p, 50, 50, 200, 180);

                    }

                    else if (파란색ToolStripMenuItem.Checked)
                    {
                        Pen p = new Pen(Color.Blue, 1);
                        g.DrawLine(p, 50, 50, 200, 180);

                    }
                }

            }
            else
            {
                Graphics g = CreateGraphics();

                g.FillRectangle(Brushes.White, ClientRectangle);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) 
                start();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            start();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 직선ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 도형SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
