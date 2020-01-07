using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 동그라미ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 별ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 다중삼각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 직선ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 굵게ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 얇게ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 중간ToolStripMenuItem_Click(object sender, EventArgs e) {

        }
        Graphics g;
        private void ToolStripMenuItem_Click(object sender, EventArgs e) {
            //g.Clear(Color.White);
            g = CreateGraphics();
            Rectangle r = new Rectangle(30, 30, 150, 150);
            
            if (동그라미ToolStripMenuItem.Checked)
            {
                //동그라미ToolStripMenuItem.Checked = false;
                사각형ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;

                if (빨간색ToolStripMenuItem.Checked)
                {
                    노란색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillEllipse(Brushes.Red, r);
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillEllipse(Brushes.Yellow, r);
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillEllipse(Brushes.Green, r);
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    g.FillEllipse(Brushes.Blue, r);
                }

                if (얇게ToolStripMenuItem.Checked)
                {
                    굵게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 1);
                    g.DrawEllipse(p, r);
                }

                else if (중간ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    굵게ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 3);
                    g.DrawEllipse(p, r);
                }

                else if (굵게ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 5);
                    g.DrawEllipse(p, r);
                }
            }

            else if (사각형ToolStripMenuItem.Checked)
            {
                동그라미ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;

                if (빨간색ToolStripMenuItem.Checked)
                {
                    노란색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillRectangle(Brushes.Red, r);
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillRectangle(Brushes.Yellow, r);
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillRectangle(Brushes.Green, r);
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    g.FillRectangle(Brushes.Blue, r);
                }

                if (얇게ToolStripMenuItem.Checked)
                {
                    굵게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 1);
                    g.DrawRectangle(p, r);
                }

                else if (중간ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    굵게ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 3);
                    g.DrawRectangle(p, r);
                }

                else if (굵게ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 5);
                    g.DrawRectangle(p, r);
                }
            }

            else if (별ToolStripMenuItem.Checked)
            {

                Point[] pts = {
                new Point(120,60), new Point(46,133), new Point(177,139), new Point(61,75),new Point(108,169)
            };
                동그라미ToolStripMenuItem.Checked = false;
                사각형ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;

                if (빨간색ToolStripMenuItem.Checked)
                {
                    노란색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Red, pts);
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Yellow, pts);
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Green, pts);
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Blue, pts);
                }

                if (얇게ToolStripMenuItem.Checked)
                {
                    굵게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 1);
                    g.DrawPolygon(p, pts);
                }

                else if (중간ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    굵게ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 3);
                    g.DrawPolygon(p, pts);
                }

                else if (굵게ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 5);
                    g.DrawPolygon(p, pts);
                }
            }

            else if (다중삼각형ToolStripMenuItem.Checked)
            {
                Point[] pts = {
                new Point(50,50), new Point(200, 180), new Point(130,180), new Point(114,107),new Point(50,90), new Point(130,180), new Point(50,180)
            };
                동그라미ToolStripMenuItem.Checked = false;
                사각형ToolStripMenuItem.Checked = false;
                직선ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;

                if (빨간색ToolStripMenuItem.Checked)
                {
                    노란색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Red, pts);
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Yellow, pts);
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Green, pts);
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    g.FillPolygon(Brushes.Blue, pts);
                }

                if (얇게ToolStripMenuItem.Checked)
                {
                    굵게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 1);
                    g.DrawPolygon(p, pts);
                }

                else if (중간ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    굵게ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 3);
                    g.DrawPolygon(p, pts);
                }

                else if (굵게ToolStripMenuItem.Checked)
                {
                    얇게ToolStripMenuItem.Checked = false;
                    중간ToolStripMenuItem.Checked = false;
                    Pen p = new Pen(Color.Black, 5);
                    g.DrawPolygon(p, pts);
                }
            }

            else if (직선ToolStripMenuItem.Checked)
            {
                동그라미ToolStripMenuItem.Checked = false;
                사각형ToolStripMenuItem.Checked = false;
                별ToolStripMenuItem.Checked = false;
                다중삼각형ToolStripMenuItem.Checked = false;

                if (빨간색ToolStripMenuItem.Checked)
                {
                    노란색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    if (얇게ToolStripMenuItem.Checked)
                    {
                        굵게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Red, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        굵게ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Red, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (굵게ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Red, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }

                else if (노란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    if (얇게ToolStripMenuItem.Checked)
                    {
                        굵게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Yellow, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        굵게ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Yellow, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (굵게ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Yellow, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }

                else if (초록색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    파란색ToolStripMenuItem.Checked = false;
                    if (얇게ToolStripMenuItem.Checked)
                    {
                        굵게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Green, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        굵게ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Green, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (굵게ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Green, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }

                else if (파란색ToolStripMenuItem.Checked)
                {
                    빨간색ToolStripMenuItem.Checked = false;
                    초록색ToolStripMenuItem.Checked = false;
                    노란색ToolStripMenuItem.Checked = false;
                    if (얇게ToolStripMenuItem.Checked)
                    {
                        굵게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Blue, 1);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (중간ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        굵게ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Blue, 3);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }

                    else if (굵게ToolStripMenuItem.Checked)
                    {
                        얇게ToolStripMenuItem.Checked = false;
                        중간ToolStripMenuItem.Checked = false;
                        Pen p = new Pen(Color.Blue, 5);
                        g.DrawLine(p, 50, 50, 200, 180);
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = e.X + ":" + e.Y;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
