using System;

namespace Exercice38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Où est passé mon numéros ? ---");
            int[] tab = new int[10];
            Random aleatoire = new Random();
            string chaine = "";
            int nb = 0;
            int index;
            Console.WriteLine("Affectation des valeures... \n");
            for (int i = 0; i < tab.Length; i++)
                tab[i] = aleatoire.Next(1, 51);

            Console.WriteLine("Affichage avant triage : ");
            foreach (int t in tab)
            {
                Console.WriteLine(chaine + t);
                chaine += "  ";
            }
            nb = tab[0];
            Array.Sort(tab); // Pour trier (ordre croissant)
            Array.Reverse(tab); // Pour inverser un tableau
            chaine = " ";
            Console.WriteLine("Après : ");
            foreach (int t in tab)
            {
                Console.WriteLine(chaine + t);
                chaine += "  ";
            }
            index = Array.IndexOf(tab, nb) + 1;
           
            Console.WriteLine("\nLe nombre {0} se trouvait en 1ère position", nb);
            Console.WriteLine("Il se retrouve à la position {0} après triage.", index);
            Console.Read();
        }
    }
}
