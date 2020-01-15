using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPREPAEXO2TP
{
    public class FilOps
    {
        DataClasses1DataContext dtx = new DataClasses1DataContext();
        static ObservableCollection<Filiere> filieres;

        public FilOps()
        {
            filieres = new ObservableCollection<Filiere>(dtx.Filieres.ToList());
        }
        public ObservableCollection<Filiere> Filiere
        {
            get
            {
                return filieres;
            }
            set
            {
                filieres = value;
            }
        }
    }
}
