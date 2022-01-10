using System;
using LesExceptionRegex.Classes;
namespace LesExceptionRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();

            try
            {
                c.FirstName = "Anthony";
                c.LastName = "Di Persio";
                c.Telephone = "+33 6 02 03 04 05";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(c);

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
