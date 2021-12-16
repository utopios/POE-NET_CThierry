using System;

namespace InstructionBreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            int test = 0;

            while (!ok)
            {
                Console.WriteLine("Je suis dans le while");
                test=Convert.ToInt32(Console.ReadLine());

                if (test == 0)
                {
                    ok = true;
                }
                if (test==1)
                {
                    break;
                }
                if (test==2)
                {
                    continue;
                }

                Console.WriteLine("Je suis toujours dans le while");
            }



            Console.WriteLine("Appuyez sur ENTER pour fermer le programme");
            Console.ReadLine();
        }
    }
}
