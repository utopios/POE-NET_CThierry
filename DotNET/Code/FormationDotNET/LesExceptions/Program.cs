using System;
using LesExceptions.Classes;

namespace LesExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Division -----------------");
            Console.Write("Veuillez saisir un Chiffre / Nombre à diviser : ");
            double nb1=-1;
            bool valid=false;
            //while (!double.TryParse(Console.ReadLine(),out nb1))
            //{
            //    Console.Write("Erreur de saisie, Veuillez saisir un chiffre / nombre : ");
            //}
            while (!valid)
            {
                try
                {
                    nb1 = Convert.ToDouble(Console.ReadLine());
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.Write($"{e.Message} Veuillez saisir un Chiffre / nombre : ");
                }
            }
            

            Console.Write("Veuillez saisir un Chiffre / Nombre diviseur : ");
            double nb2=-1;
            valid = false;
            //while (!double.TryParse(Console.ReadLine(), out nb2))
            //{
            //    Console.Write("Erreur de saisie, Veuillez saisir un chiffre / nombre pour le diviseur : ");
            //}

            while (!valid)
            {
                try
                {
                    nb2 = Convert.ToDouble(Console.ReadLine());
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.Write($"{e.Message} Veuillez saisir un Chiffre / nombre : ");
                }
            }

            double result;

            try
            {
                result = ExceptionTest.SafeDivision(nb1, nb2);
                Console.WriteLine("{0} divisé par {1} = {2}",nb1,nb2,result);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Cette instruction est appliquée quelque soit l'issue du Try");
            }


            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
