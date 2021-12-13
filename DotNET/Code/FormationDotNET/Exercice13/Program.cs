using System;

namespace Exercice13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Quelle est la nature du triangle ABC ? --- \n");

            #region Déclaration des variables
            double longeurAB;
            double longeurBC;
            double longeurAC;
            #endregion


            #region Recupération saisie utilisateur
            Console.Write("Entrez la longeur du segment AB : ");
            longeurAB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez la longeur du segment BC : ");
            longeurBC = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez la longeur du segment CA : ");
            longeurAC = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Test pour affichage du résultat
            Console.WriteLine(" ");
            if (longeurAB == longeurBC && longeurAB == longeurAC)
            {
                Console.WriteLine("Le triangle est équilatéral.\n");
            }
            else
            {
                if (longeurAB == longeurAC)
                {
                    Console.WriteLine("Le triangle est isocèle en A.\n");
                }
                else
                {
                    if (longeurAB == longeurBC)
                    {
                        Console.WriteLine("Le triangle est isocèle en B.\n");
                    }
                    else
                    {
                        if (longeurBC == longeurAC)
                        {
                            Console.WriteLine("Le triangle est isocèle en C.\n");
                        }
                        else
                        {
                            Console.WriteLine("Le triangle n'est isocèle ni en A, ni en B, ni en C.\n");
                        }
                    }
                }
            }
            #endregion

            Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
            Console.Read();
        }
    }
}
