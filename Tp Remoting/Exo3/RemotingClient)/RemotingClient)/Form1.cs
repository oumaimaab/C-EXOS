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

namespace RemotingClient_
{
    public partial class Form1 : Form
    {
        NombreCache.ClassLibrary1 proxy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int n = Int32.Parse(textBox1.Text);
            //textBox3.Text = proxy.joueur(Int32.Parse(textBox1.Text));
            textBox3.Text = proxy.joueur(7);
            textBox2.Text = proxy.getNombreTentatives().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.RegisterActivatedClientType(typeof(NombreCache.ClassLibrary1), "tcp://localhost:100");
            proxy = new NombreCache.ClassLibrary1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (proxy.getNombreTentatives() <= 4)
            {
                MessageBox.Show("Votre résultat est : " + proxy.score() + ".");
            }
            
        }
    }
}
