using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2DB
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataClasses1DataContext();
            var data = from student in dt.etudiants where student.cne==Int32.Parse(comboBox1.SelectedItem.ToString()) select student;
            dataGridView1.DataSource = data;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dt = new DataClasses1DataContext();
            var data = from student in dt.etudiants join filiere in dt.Filieres on student.id_fil equals filiere.Id_filiere select new {student.cne,student
            .nom,student.prenom,student.date_naiss,filiere.Nom_filiere};
            foreach(var i in data)
            {
                comboBox1.Items.Add(i.cne);
            }
            dataGridView1.DataSource = data;
            dataGridView1.Sort(dataGridView1.Columns["nom"],ListSortDirection.Ascending);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 crystalReport1 = new CrystalReport1();
            crystalReport1.SetDataSource();
        }
    }
}
