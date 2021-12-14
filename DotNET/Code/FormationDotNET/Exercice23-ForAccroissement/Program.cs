using System;

namespace Exercice23_ForAccroissement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration des variables
            double nbHabitant = 96809;
            double taux = 0.0089;
            int date = 2015;
            int nbAnnee = 0;
            #endregion

            #region Calcul de l'accroissement de le population
            for (int i = 1; i <= 50; i++)
            {
                nbHabitant += nbHabitant*taux;
                date++;
                nbAnnee++;
                if (nbHabitant>=120000)
                {
                    break;
                }
            }
            #endregion

            #region Affichage des résultats
            Console.WriteLine("--- Accroissement de la population ---\n");
            Console.WriteLine($"Il faudra {nbAnnee} an(s), nous serons en {date}.");
            Console.WriteLine("Il y aura "+Math.Round(nbHabitant, 0)+ " habitants en "+ date + ".");
            #endregion


            Console.WriteLine("\nAppuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
