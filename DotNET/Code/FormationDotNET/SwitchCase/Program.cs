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
            int age = Convert.ToInt32( Console.ReadLine());
            switch (age)
            {
                case 1:
                    Console.WriteLine("Vous êtes mineur");
                    break ;
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
            Console.Read();
        }
    }
}
