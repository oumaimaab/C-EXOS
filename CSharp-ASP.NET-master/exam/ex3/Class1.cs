using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ex3
{
    class Class1
    {
        DataClassesDataContext cl = new DataClassesDataContext();
        Dictionary<String, int> dic = new Dictionary<string, int>();
        public Donateur getDonateur(int num)
        {
            var don = (from d in cl.Donateur
                       where d.NumDonateur == num
                       select d).SingleOrDefault();
            return don;
        }
        public void Deposer(int num,double montant)
        {

            if (montant > 0)
            {
                using (TransactionScope tr = new TransactionScope())
                {
                    var assoc = (from a in cl.Association
                                 where a.Annee == 2019
                                 select new { a.solde }).SingleOrDefault();

                    var don = (from d in cl.Donateur
                               where d.NumDonateur == num
                               select d).SingleOrDefault();

                    don.solde -= assoc.solde;
                    assoc.solde += assoc.solde;

                    cl.SubmitChanges();
                    tr.Complete();
                }
            }
            else
            {
                Console.WriteLine("Le montant ne peut etre negative ou 0");
            }

        }

        public void Ajouter(String NomDonateur,int montant)
        {
            if (dic.ContainsKey(NomDonateur))
            {
                int montantDeja = dic[NomDonateur];
                dic[NomDonateur] = Math.Max(montantDeja, montant);
            }
            else
            {
                dic.Add(NomDonateur, montant);
            }
        }

        public Dictionary<String,int> DonPlusEleve()
        {
            var tempDic = (from f in dic orderby dic.Keys ascending select f).Take(5);
           return tempDic;
        }

    }
}
