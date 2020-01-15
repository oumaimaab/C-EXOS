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
        String resText;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Class1), "tcp://localhost:5150/RemoteServer");
            proxy = new Class1();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            int nb_guessed = Int16.Parse(nbr.Text);
            resText = proxy.jouer(nb_guessed);
            res.Text = resText;
            nbEssai.Text = proxy.getNombreTentatives().ToString();
        }

        private void scoreBtn_Click(object sender, EventArgs e)
        {
            if(resText== "Gagné")
                scoreLabel.Text = proxy.score().ToString();
            else
                 scoreLabel.Text = "0";
            
        }
    }
}
