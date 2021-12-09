using System;

namespace Exercice8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calcul de la T.V.A d'un produit ---"+ Environment.NewLine);
            Console.Write("Entrez le prixH.T de l'objet (en euros) : ");
            double prixHt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez le taux de T.V.A applicable (en %) :  ");
            double TauxTVA = Convert.ToDouble(Console.ReadLine());
            TauxTVA /= 100;
            double montantTVA = prixHt*TauxTVA;
            double prixTTC = prixHt + montantTVA;
            Console.WriteLine($"Le montant de la T.V.A est de {montantTVA} Euros ");
            Console.WriteLine($"Le prix T.T.C de l'objet est de {prixTTC} Euros ");




            Console.WriteLine("\n\nAppuyez sur Enter pour ferme le programme...");
            Console.Read();
        }
    }
}
