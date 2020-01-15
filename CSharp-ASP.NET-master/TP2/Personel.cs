using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Personell
    {
        List<Employe> list_emp = new List<Employe>();

        public void ajouterEmploye(Employe e)
        {
            list_emp.Add(e);
        }
        public void show()
        {
            foreach (Employe employe in list_emp)
            {
                employe.affiche();
                Console.WriteLine("//==============================");
            }
        }

        public List<string> getPersonnel()
        {
            List<string> list = new List<string>();
            foreach(Employe em in list_emp)
            {
                list.Add(em.affiche());
            }

            return list;
        }

        public double salaireMoyen()
        {
            int nbEmploye = 0;
            double sumSalire = 0;
            foreach (Employe employe in list_emp)
            {
                nbEmploye++;
                sumSalire += employe.CalculSalaire();
            }

            return sumSalire / nbEmploye;
        }

        public int NbEmployes()
        {
            int nbEmploye = 0;
            foreach (Employe employe in list_emp)
            {
                nbEmploye++;
            }

            return nbEmploye;
        }
    }
}
