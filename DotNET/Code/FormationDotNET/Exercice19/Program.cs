using System;

namespace Exercice19
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Déclaration des variables
            double revenus;
            int nbAdulte;
            int nbEnfants;
            double nbParts;
            double revenuImposable;
            double montantImpot;
            #endregion

            #region Demande les saisies utilisateur et les stockes dans des variables
            Console.WriteLine("--- Quelle sera le montant des mes impôts ? --- \n");
            Console.Write("Entrez le montant net imposable du foyer (en Euros): ");
            revenus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez le nombre d'adulte du foyer : ");
            nbAdulte = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le nombre d'enfants du foyer : ");
            nbEnfants = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            #endregion

            #region Calcul du nombre de parts
            nbParts= nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;
            #endregion

            #region Calcul du montant de l'impôt            
            revenuImposable = revenus / nbParts;
            montantImpot = 0;

            switch (revenuImposable)
            {
                case double montantImposable when montantImposable >= 10085 && montantImposable <= 25710:
                    montantImpot = Math.Round((revenuImposable - 10084) * 0.11, 0); break;
                case double montantImposable when montantImposable >= 25711 && montantImposable <= 73516:
                    montantImpot = Math.Round((revenuImposable - 25710) * 0.3 + ((25710-10084)*0.11), 0); break;
                case double montantImposable when montantImposable >= 73517 && montantImposable <= 158122:
                    montantImpot = Math.Round((revenuImposable - 73516) * 0.41 + ((25710-10084)*0.11) + ((73516-25710)*0.3), 0); break;
                case double montantImposable when (montantImposable >= 158123):
                    montantImpot = Math.Round((revenuImposable - 158122) * 0.45 + ((25710-10084)*0.11) + ((73516-25710)*0.3) + ((158122-73516)*0.41), 0); break;
            }

            //montantImpot = montantImpot * nbParts;
            montantImpot *= nbParts;
            #endregion

            #region Affichage à l'utilisateur
            Console.WriteLine("Vous allez payer " + montantImpot + " Euros\n");
            Console.WriteLine($"Vous allez payer {montantImpot} Euros\n");
            Console.WriteLine("Vous allez payer {0} Euros\n", montantImpot);
            #endregion

            Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
            Console.Read();
        }
    }
}

