using System;

namespace Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {

            #region If...Else... imbriqués
            Console.WriteLine("--- Dans quelle catégorie mon enfant est-il...? --- \n");
            Console.Write("Entrez l'âge de votre enfant : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            if (age < 3)
            {
                Console.WriteLine("Votre enfant est trop jeune pour pratiquer !\n");
            }
            else
            {
                if (age >= 3 && age <= 6)
                {
                    Console.WriteLine("Votre enfant est dans la catégorie \"Baby\" !\n");
                }
                else
                {
                    if (age >= 7 && age <= 8)
                    {
                        Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\" !\n");
                    }
                    else
                    {
                        if (age >= 9 && age <= 10)
                        {
                            Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\" !\n");
                        }
                        else
                        {
                            if (age >= 11 && age <= 12)
                            {
                                Console.WriteLine("Votre enfant est dans la catégorie \"Minime\" !\n");
                            }
                            else
                            {
                                if (age >= 13 && age <= 17)
                                {
                                    Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\" !\n");
                                }
                                else
                                    Console.WriteLine("Mais ce n'est plus un enfant !\n");
                            }
                        }
                    }
                }
            }


            #endregion

            #region If... Else If... Else
            Console.WriteLine("--- Dans quelle catégorie mon enfant est-il...? --- \n");
            Console.Write("Entrez l'âge de votre enfant : ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            if (age < 3)
            {
                Console.WriteLine("Votre enfant est trop jeune pour pratiquer !\n");
            }
            else if (age2 >= 3 && age2 <= 6)
            {
                Console.WriteLine("Votre enfant est dans la catégorie \"Baby\" !\n");
            }
            else if (age2 >= 7 && age2 <= 8)
            {
                Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\" !\n");
            }
            else if (age2 >= 9 && age2 <= 10)
            {
                Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\" !\n");
            }
            else if (age2 >= 11 && age2 <= 12)
            {
                Console.WriteLine("Votre enfant est dans la catégorie \"Minime\" !\n");
            }
            else if (age2 >= 13 && age2 <= 17)
            {
                Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\" !\n");
            }
            else
                Console.WriteLine("Mais ce n'est plus un enfant !\n");

            #endregion

            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
