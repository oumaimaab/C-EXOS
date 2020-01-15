using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EXO2
{
    public class FilOperation
    {
        static ObservableCollection<Filiere> filieres;

        public FilOperation()
        {
            DataClasses1DataContext dtx = new DataClasses1DataContext();
            //var f = from fil in dtx.Filieres select fil;
            filieres = new ObservableCollection<Filiere>();
        }
        public ObservableCollection<Filiere> filiere
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
