using System;

namespace TP2
{
    class Representant:Commercial
    {
        public Representant(string nom, string prenom, int age, int annee_rec, double ChiffreAffaire) : base(nom, prenom, age, annee_rec, ChiffreAffaire)
        {

        }
        public override double CalculSalaire()
        {
            return (ChiffreAffaire * 0.2) + 400;
        }
    }
}
