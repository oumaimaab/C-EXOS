using System;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace JeuClient
{
    public partial class Form1 : Form
    {
        private Exo2.ClassLibrary proxy;
        
        public Form1()
        {   
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exo2.ClassLibrary proxy = new Exo2.ClassLibrary();
            int n1 = Int32.Parse(textBox1.Text);
            int n2 = Int32.Parse(textBox2.Text);
            int n3 = this.proxy.addition(n1, n2);
            textBox3.Text = n3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox4.Text);
            int n2 = Int32.Parse(textBox5.Text);
            int n3 = proxy.multiplication(n1, n2);
            textBox6.Text = n3.ToString();
        }

        private void textBox590_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox7.Text);
            int n3 = proxy.incrementation(n1);
            textBox8.Text = n3.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.RegisterActivatedClientType(typeof(Exo2.ClassLibrary), "tcp://localhost:20/service");
            proxy = new Exo2.ClassLibrary();
        }
    }
}
