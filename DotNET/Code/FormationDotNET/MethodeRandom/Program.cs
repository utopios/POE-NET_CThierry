﻿using System;

namespace MethodeRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int nombre = aleatoire.Next(1, 51);
            Console.WriteLine(nombre);
            Console.Read();
        }
    }
}
