using System;

namespace InstructionIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double compteEnBanque = 300;
            bool estVrai = compteEnBanque >=0;
            if (compteEnBanque >=0)
                Console.WriteLine("Votre compte est créditeur");

            if (compteEnBanque >=0)
            {
                Console.WriteLine("Votre compte est créditeur");
                Console.WriteLine("Le solde de votre compte est de {0} Euros", compteEnBanque);
            }
            if (compteEnBanque<0)
            {
                Console.WriteLine("Votre compte est débiteur");
                Console.WriteLine("Le solde de votre compte est de {0} Euros", compteEnBanque);
            }

            if (compteEnBanque >=0 && estVrai)
            {
                Console.WriteLine("Votre compte est créditeur");
                Console.WriteLine("Le solde de votre compte est de {0} Euros", compteEnBanque);
            }
            else
            {
                Console.WriteLine("Votre compte est débiteur");
                Console.WriteLine("Le solde de votre compte est de {0} Euros", compteEnBanque);
            }
            Console.WriteLine(estVrai);

            if (!true)
            {
                Console.WriteLine("C'est vrai");
            }
            else
            {
                Console.WriteLine("C'est faux");
            }

        }
    }
}
