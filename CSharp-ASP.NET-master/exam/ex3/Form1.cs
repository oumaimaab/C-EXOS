using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        Class1 c = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void deposerButton_Click(object sender, EventArgs e)
        {
            c.Deposer(Int32.Parse(numInput.Text),Double.Parse(montantInput.Text));
        }

        private void afficherButton_Click(object sender, EventArgs e)
        {
            Dictionary<Sring, int> dic = c.DonPlusEleve();
            foreach (var x in dic)
            {
                chart1.Series["Nombre Etudiant"].Points.AddXY(x.Key, x.Value);

            }
        }
    }
}
