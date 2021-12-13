using System;
using System.Text;

namespace Exercice15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? --- \n");

            #region Déclaration des variables
            int salaire;
            int age;
            int anciennete;
            double indemnite;
            #endregion

            #region Récupération saisies utilisateur
            Console.Write("Merci de saisir le dernier salaire (en €uros): ");
            salaire = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir votre âge : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir le nombre d'années d'ancienneté : ");
            anciennete = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Calcul de l'indemnité
            Console.WriteLine(" ");
            indemnite = 0;
            if (anciennete >= 1 && anciennete <= 10)
            {
                indemnite += anciennete * salaire / 2;
            }
            if (anciennete > 10)
            {
                indemnite += 10 * salaire / 2;
                indemnite += (anciennete - 10) * salaire;
            }
            if (anciennete >= 1 && age > 45)
            {
                if (age >= 50)
                {
                    indemnite += 5 * salaire;
                }
                else
                {
                    indemnite += 2 * salaire;
                }
            }
            #endregion

            #region Sugar Syntaxe

            //if (age > 45 && anciennete >=1)
            //{
            //    indemnite += (age < 50) ? 2 * salaire : 5 * salaire;
            //}

            #endregion

            #region Affichage des résultats
            Console.WriteLine("Votre indemnité est de : " + indemnite + " € \n");
            #endregion

            Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
            Console.Read();
        }
    }
}
