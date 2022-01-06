using System;
using System.Collections.Generic;
using ExtentionMethodes.Classes;

namespace ExtentionMethodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 1, 2, 3, 4, 5, 6 };
            l.Shuffle();

            foreach (int i in l)
            {
                Console.WriteLine(i);
            }

            List<string> s =new List<string>() { "Titi","Tata","Toto"};
            s.Shuffle();

            foreach (string nom in s)
            {
                Console.WriteLine(nom);
            }
            Console.WriteLine("Appuyez sur ENTER pour fermer le programe...");
            Console.Read();
        }
    }
}
