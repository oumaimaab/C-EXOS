using RemoteObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        Class1 proxy;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void equalAdd_Click(object sender, EventArgs e)
        {
            int nb1 = Int32.Parse(inputAdd1.Text);
            int nb2 = Int32.Parse(inputAdd1.Text);

            int res = proxy.addition(nb1, nb2);

            inputAddRes.Text = res.ToString();

        }

        private void equalMult_Click(object sender, EventArgs e)
        {
            int nb1 = Int32.Parse(inputMult1.Text);
            int nb2 = Int32.Parse(inputMult1.Text);

            int res = proxy.multiplication(nb1, nb2);

            inputMultRes.Text = res.ToString();
        }

        private void IncrementerBtn_Click(object sender, EventArgs e)
        {
           int nb = Int32.Parse(nbIncrment.Text);

            int res = proxy.incrementation(nb);

            incrementRes.Text = res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Class1), "tcp://localhost:5150/RemoteServer");
            proxy = new Class1();
        }
    }
}
