using System;

namespace Exercice9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calcul des intérêts ---"+ Environment.NewLine);
            #region Déclaration des variables
            double capitalDepart;
            double tauxInteret;
            double duree;
            double capitalFinal;
            double montantInterets;

            #endregion

            #region Récupération des saisies utilisateur
            Console.Write("Entrez Capital de départ (en euros) : ");
            capitalDepart = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez taux de l'épargne  (en %) : ");
            tauxInteret = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la durée de l'épargne (en années) : ");
            duree = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            #endregion

            #region Calcul des intérêts
            capitalFinal = Math.Round(capitalDepart*Math.Pow(1+(tauxInteret/100),duree), 2);
            montantInterets = Math.Round(capitalFinal - capitalDepart,2);
            #endregion

            #region Affichage des résultats
            Console.WriteLine($"Le montant des interêt sera de  {montantInterets} Euros ");
            Console.WriteLine($"Le capital final sera de {capitalFinal} Euros ");

            #endregion





            Console.WriteLine("\n\nAppuyez sur Enter pour ferme le programme...");
            Console.Read();
        }
    }
}
