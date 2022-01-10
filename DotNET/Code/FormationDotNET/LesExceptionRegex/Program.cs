using System;
using System.Text.RegularExpressions;
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
                c.Email = "anthony.di-persio@mail.utopios.net";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(c);

            try
            {
                c= new Client("Ihab","Abadi","+33.6.12.36.54.78","ihab@utopios.net");    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(c);

            // Split
            string[] tab = Regex.Split(c.Telephone,@"\.");
            foreach (string s in tab)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
