using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Avec string en condition d'accès
            Console.Write("Veuillez saisir M. ou Mme. ou Mlle. : ");
            string civilite = Console.ReadLine();
            switch (civilite)
            {
                case "M.":
                    Console.WriteLine("Bonjour Monsieur");
                    break;
                case "Mme.":
                    Console.WriteLine("Bonjour Madame");
                    break;
                case "Mlle.":
                    Console.WriteLine("Bonjour Mademoiselle");
                    break;
                default:
                    Console.WriteLine("Cas par defaut");
                    break;
            }
            #endregion


            #region Avec un int en condition d'accès
            Console.Write("Veuillez saisir 1, 5, 12 ou 18 : ");
            int age = Convert.ToInt32(Console.ReadLine());
            switch (age)
            {
                case 1:
                    Console.WriteLine("Vous êtes mineur");
                    break;
                case 5:
                    Console.WriteLine("Vous êtes un enfant");
                    goto case 1;
                case 12:
                    Console.WriteLine("Vous êtes un ado");
                    goto case 1;
                case 18:
                    Console.WriteLine("Vous êtes Majeur");
                    break;
                default:
                    Console.WriteLine("Merci de saisir le bon age");
                    break;
            }
            #endregion


            #region Switch avec range
            switch (age)
            {
                case int ageTmp when ageTmp < 0:
                    Console.WriteLine("Heuuu... vous êtes sur...?");
                    break; 
                case int ageTmp when ageTmp < 18:
                    Console.WriteLine("Vous êtes mineur");
                    break; 
                case int ageTmp when ageTmp >= 18 && ageTmp<60:
                    Console.WriteLine("Vous êtes actif");
                    break;
                case int ageTmp when ageTmp >= 60 && ageTmp < 123:
                    Console.WriteLine("Vous êtes retraité");
                    break;
                case int ageTmp when ageTmp >= 123:
                    Console.WriteLine("Record battu! Appelez le guiness Book");
                    break;
                default:
                    Console.WriteLine("Merci de saisir une age !");
                    break;
            }
            #endregion



            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
