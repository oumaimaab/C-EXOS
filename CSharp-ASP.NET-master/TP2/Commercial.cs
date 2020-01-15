using System;

namespace TP2
{
    class Commercial:Employe
    {
        protected double ChiffreAffaire;
        public Commercial(string nom, string prenom, int age, int annee_rec,double ChiffreAffaire) : base(nom, prenom, age, annee_rec)
        {
            this.ChiffreAffaire = ChiffreAffaire;
        }


        public override string affiche()
        {
            return base.affiche()+ " Chiffre d'affaire : " + ChiffreAffaire;
        }
    }
}
