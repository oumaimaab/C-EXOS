using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Bonjour(string n);

        [OperationContract]
        DataTable GetFiliers();

        [OperationContract]
        string DescriptionPersonne(Personne p);

    }

        [DataContract]
        public class Personne
        {
            string nom;
            string prenom;
            int age;

            [DataMember]
            public string Nom { get { return nom;  }  set { nom = value; } }
            [DataMember]
            public string Prenom { get { return prenom; } set { prenom = value; } }
            [DataMember]
            public int Age { get { return age; } set { age = value; } }
        }

    
}
