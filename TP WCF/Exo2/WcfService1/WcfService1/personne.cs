using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [DataContract]
    public class Personne
    {
        private string nom, prenom;
        private int age;

      
        
        [DataMember]
        public string getNomP3
        {
            get { return nom; }
            set { nom = value; }
        }
        [DataMember]

        public int Age { get => age; set => age = value; }
    }
}