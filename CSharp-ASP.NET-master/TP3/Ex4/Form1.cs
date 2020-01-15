using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        private int count = 0; 
        public Form1()
        {
            StartTimer();
            InitializeComponent();
        }
        private void StartTimer()
        {
            Timer tmr = new Timer();
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = (++count).ToString();
        }
    }
}
