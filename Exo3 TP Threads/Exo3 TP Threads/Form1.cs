using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo3_TP_Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int number =int.Parse(textBox1.Text);
            Prime prime = new Prime(number);
            string[] tab = new string[prime.isPrime(number).Count];
            for (int i = 0; i < prime.isPrime(number).Count; i++)
            {
                tab[i] = prime.isPrime(number)[i].ToString();
            }
            listBox1.Items.AddRange(tab);
            
        }
    }
}
