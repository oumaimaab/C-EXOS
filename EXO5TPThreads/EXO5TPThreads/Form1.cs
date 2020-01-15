using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO5TPThreads
{
    public partial class Form1 : Form
    {
        private int x = 220, y = 120,width = 80, height = 20;
        private bool makeLarger = true, makeSmaller = false, rectangle = true , cercle = false;

        

        Brush brush = Brushes.Blue;

        

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30;
            timer1.Start();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rectangle)
            {
                DrawRectangle();
            }
            else if(cercle)
            {
                DrawCercle();
            }
            
        }

        

        public void DrawRectangle()
        {
            if(makeLarger && x>120 && y > 30)
            {
                width += 2;
                height += 2;
                x--;
                y--;
                Rectangle rectangle = new Rectangle(x, y, width, height);
                panel1.CreateGraphics().FillRectangle(brush, rectangle);
                if (x==140 && y == 40)
                {
                    makeSmaller = true;
                    makeLarger = false;
                }
            }
            if(makeSmaller && x<220 && y < 120)
            {
                width -= 2;
                height -= 2;
                x++;
                y++;
                panel1.CreateGraphics().Clear(BackColor);
                Rectangle rectangle = new Rectangle(x, y, width, height);
                panel1.CreateGraphics().FillRectangle(brush, rectangle);
                if (x == 220 && y == 120)
                {
                    makeSmaller = false;
                    makeLarger = true;
                }
            }
            
        }

        

        public void DrawCercle()
        {
            if (makeLarger && x > 120 && y > 30)
            {
                width += 2;
                height += 2;
                x--;
                y--;
                Rectangle rectangle = new Rectangle(x, y, width, height);
                panel1.CreateGraphics().FillEllipse(brush, rectangle);
                if (x == 140 && y == 40)
                {
                    makeSmaller = true;
                    makeLarger = false;
                }
            }
            if (makeSmaller && x < 220 && y < 120)
            {
                width -= 2;
                height -= 2;
                x++;
                y++;
                panel1.CreateGraphics().Clear(BackColor);
                Rectangle rectangle = new Rectangle(x, y, width, height);
                panel1.CreateGraphics().FillEllipse(brush, rectangle);
                if (x == 220 && y == 120)
                {
                    makeSmaller = false;
                    makeLarger = true;
                }
            }

        }

       

        private void lenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }
        private void moyenneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 30;
        }
        private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2;
        }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cercle = false;
            rectangle = true;
            DrawRectangle();
        }
        private void cercleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cercle = true;
            rectangle = false;
            DrawCercle();
        }
        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brush = Brushes.Red;
        }
        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brush = Brushes.Blue;
        }
    }
}
