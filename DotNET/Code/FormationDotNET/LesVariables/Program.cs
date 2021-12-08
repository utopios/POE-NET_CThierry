using System;

namespace LesVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Les chaines de caractères
            string nom; // Déclaration de la variables
            nom = "Di Persio"; // Assignation de la valeur à la variable

            string nom2 = "Corbeel"; // Déclaration et assignation de valeur en une instruction

            nom = nom2; // nom prend la valeur de nom2

            nom2="Durant";

            Console.WriteLine(nom);// affichage de la variable nom
            Console.WriteLine(nom2);// affichage de la variable nom


            #endregion

            #region Les variable de type numérique
            int age; // Déclaration de variable de type entier
            age = 25;
            Console.WriteLine("Mon age est : " + age + " ans");

            int age2 = 44;

            age = age2;
            age2 = 38;

            age2 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(age);
            Console.WriteLine(age2);
            #endregion

            #region Les variables de type object
            object monObjet;
            monObjet = "Ma chaine objet";

            object monObjet2 = "Ma deuxieme chaine objet";

            Console.WriteLine(monObjet2);

            monObjet2=monObjet;

            monObjet2 = "Ma nouvele chaine";

            Console.WriteLine(monObjet);
            Console.WriteLine(monObjet2);
            #endregion

        }
    }
}
