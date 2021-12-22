using System;
using TpClasseSalarie.Classes;

namespace TpClasseSalarie
{
    internal class Application
    {
        static void Main(string[] args)
        {
            double somme = 0;
            Salarie s1 = new Salarie();
            s1.Nom="Toto";
            s1.Matricule="M001";
            s1.Categorie="C001";
            s1.Service="S001";
            s1.Salaire=2000;



            // Console.WriteLine(s1);

            Salarie s2 = new Salarie("M002", "C002", "M002", "Titi", 2300);
            Salarie s3 = new Salarie("M003", "C003", "M003", "Tata", 3000);
            Salarie s4 = new Salarie("M004", "C004", "M004", "Tete", 3500);

            Salarie[] tab = { s1, s2, s3, s4 };

            foreach (Salarie s in tab)
            {
                s.Afficher();
                somme+=s.Salaire;
            }

            Console.WriteLine($"Le montant total des salaires mensuels est de {somme}");
            Salarie.AfficherCompteur();
            Salarie.ModifierCompteur(15);
            Salarie.AfficherCompteur();






            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }

    }
}
