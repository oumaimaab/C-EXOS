using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isPrime(int n)
        {
            // Corner case 
            if (n <= 1)
                return false;

            // Check from 2 to n-1 
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    

        private void add_Click(object sender, EventArgs e)
        {
            int n = int.Parse(input.Text);

            for (int i = 2; i <= n; i++)
            {
                if (isPrime(i))
                    list.Items.Add(i);

            }
            
        }
    }
}
