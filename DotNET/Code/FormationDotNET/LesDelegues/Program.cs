using System;
using LesDelegues.Classes;
namespace LesDelegues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculatrice c =new Calculatrice();

            // Utilisation du dlegate avec la méthode Addition ci-dessous
            c.Calcule(10.2, 11.5, Addition);

            // utilisation du délégate avec une fonction anonyme (expression lambda)
            c.Calcule(45.2, 23.6, delegate (double a, double b) { return a - b; });

            // utilisation du délégate avec une fonction anonyme(expression lambda)
            c.Calcule(45.2, 23.6, (double a, double b) => { return a * b; });

            // Si on à qu'une seule instruction pour le return (accolade facultatives)
            c.Calcule(30, 10, (a, b) => a / b );

            c.HowToDisplay("Hello World !", AfficherPlus);


            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
        public static double Addition(double a, double b) { return a + b; }
        
        public static void Afficher(string s) {Console.WriteLine(s);}
        public static void AfficherPlus(string s) {Console.WriteLine(s+"... Et bien plus encore");}
    }
}
