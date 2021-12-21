using System;

namespace CopieTableauCopyTo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Création d'un tableau T1 de type int
            Console.WriteLine("Creation d'un tableau T1");
            int[] T1 = { 1, 2, 3 };
            #endregion

            #region Itération du tableau T1
            Console.WriteLine("Contenu de T1 : ");
            for (int i = 0; i < T1.Length; i++)
                Console.WriteLine(T1[i]);
            #endregion

            #region Création d'un tableau T2 de type int
            Console.WriteLine("Creation d'un tableau T2");
            int[] T2 = new int[10];
            #endregion

            #region Itération du tableau T2
            Console.WriteLine("Contenu de T2 : ");
            for (int i = 0; i < T2.Length; i++)
                Console.WriteLine(T2[i]);
            #endregion

            #region Copie de T1 dans T2 avec la méthode CopyTo()
            Console.WriteLine("Copie de T1 dans T2");
            T1.CopyTo(T2,5);
            #endregion

            #region Modification de T1
            Console.WriteLine("Modification de T1 : T1[0] = 18");
            T1[0] = 18;
            #endregion

            #region Affichage des tableaux T1 et T2
            Console.WriteLine("Contenu de T1 après copie et modification: ");
            for (int i = 0; i < T1.Length; i++)
                Console.WriteLine(T1[i]);
            Console.WriteLine("Contenu de T2 après copie et modification de T1: ");
            for (int i = 0; i < T2.Length; i++)
                Console.WriteLine(T2[i]);
            #endregion

            Console.WriteLine("Appuyez sur enter pour fermer le programme...");
            Console.Read();
        }
    }
}
