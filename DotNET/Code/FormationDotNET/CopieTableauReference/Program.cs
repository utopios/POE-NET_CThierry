using System;

namespace CopieTableauReference
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Copie de tableau
            Console.WriteLine("Creation d'un tableau T1");
            int[] T1 = { 1, 2, 3 };
            Console.WriteLine("Contenur de T1 : ");
            for (int i = 0; i < T1.Length; i++)
                Console.WriteLine(T1[i]);
            Console.WriteLine("Creation d'un tableau T2");
            int[] T2 = new int[10];
            Console.WriteLine("Contenur de T2 : ");
            for (int i = 0; i < T2.Length; i++)
                Console.WriteLine(T2[i]);

            T2 = T1;
            Console.WriteLine("Contenur de T2 : ");
            for (int i = 0; i < T2.Length; i++)
                Console.WriteLine(T2[i]);
            T1[0] = 18;
            Console.WriteLine("Contenur de T2 : ");
            for (int i = 0; i < T2.Length; i++)
                Console.WriteLine(T2[i]);
            #endregion
            Console.WriteLine("Appuyez sur enter pour fermer le programme...");
            Console.Read();
        }
    }
}
