using System;
using LesStructures.Classes;
namespace LesStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonneStruct p1 = new PersonneStruct() { Nom = "Di Persio", Prenom="Anthony"};
            p1.Afficher();



            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
