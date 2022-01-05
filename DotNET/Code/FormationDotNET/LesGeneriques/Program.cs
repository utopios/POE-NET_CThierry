using System;
using System.Collections.Generic;
using LesGeneriques.Classes;

namespace LesGeneriques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Création classe opération (Elements génériques)
            Console.WriteLine("*** Les Elements Génériques ***");
            Console.WriteLine("Avec des variables de type INT : ");
            Operation<int> obj1 = new Operation<int>();
            Console.WriteLine(obj1.EstEquivalent(2,2));
            //Console.WriteLine(Operation<int>.EstEquivalent(2,2));
            
            Operation<double> obj2 = new Operation<double>();
            Console.WriteLine(obj2.EstEquivalent(2.55,2.55));

            Operation<string> obj3 = new Operation<string>();
            string A = "A";
            string B = "A";
            Console.WriteLine(obj3.EstEquivalent(A, B));
            #endregion

            #region Les Queues => FIFO (First In First OUT)
            Console.WriteLine("*** LES QUEUES ***");
            Console.WriteLine("Avec des variables de type INT : ");
            Queue<int> file = new Queue<int>();
            file.Enqueue(1);
            file.Enqueue(2);
            file.Enqueue(3);
            file.Enqueue(4);
            file.Enqueue(5);

            int valeur = file.Dequeue();
            AfficherChiffre(valeur);
            valeur = file.Dequeue();
            AfficherChiffre(valeur);
            valeur = file.Dequeue();
            AfficherChiffre(valeur);
            valeur = file.Dequeue();
            AfficherChiffre(valeur);
            valeur = file.Dequeue();
            AfficherChiffre(valeur);

            //foreach (var item in file)
            //{
            //    valeur = file.Dequeue();
            //    AfficherChiffre(valeur);
            //}

            Console.WriteLine("Avec des variables de type STRING : ");
            Queue<string> chaine = new Queue<string>();
            chaine.Enqueue("Chaine 1");
            chaine.Enqueue("Chaine 2");
            chaine.Enqueue("Chaine 3");
            chaine.Enqueue("Chaine 4");
            chaine.Enqueue("Chaine 5");

            string valeur2 = chaine.Dequeue();
            AfficherChaine(valeur2);
            valeur2 = chaine.Dequeue();
            AfficherChaine(valeur2);
            valeur2 = chaine.Dequeue();
            AfficherChaine(valeur2);
            valeur2 = chaine.Dequeue();
            AfficherChaine(valeur2);
            valeur2 = chaine.Dequeue();
            AfficherChaine(valeur2);
            #endregion

            #region Les piles => LIFO
            Console.WriteLine("*** Les Piles ***");
            Console.WriteLine("Avec des variables de type INT : ");
            Pile<int> pileEntier = new Pile<int>(3);
            pileEntier.Empiler(1);
            pileEntier.Empiler(25);
            pileEntier.Empiler(45);
            pileEntier.Empiler(65);


            Console.WriteLine("L'element en place 1 dans la pile est : {0}",pileEntier.Get(0));
            Console.WriteLine("L'element en place 2 dans la pile est : {0}",pileEntier.Get(1));
            Console.WriteLine("L'element en place 3 dans la pile est : {0}",pileEntier.Get(2));
            // Console.WriteLine("L'element en place 4 dans la pile est : {0}",pileEntier.Get(3));

            pileEntier.Depiler();

            Console.WriteLine("L'element en place 1 dans la pile est : {0}", pileEntier.Get(0));
            Console.WriteLine("L'element en place 2 dans la pile est : {0}", pileEntier.Get(1));
            Console.WriteLine("L'element en place 3 dans la pile est : {0}", pileEntier.Get(2));

            Console.WriteLine("Avec des objets de type Personne : ");
            Pile<Personne> pilePersonnes = new Pile<Personne>(3);

            pilePersonnes.Empiler(new Personne("Di Persio", "Anthony", "Anthony@utopios.net"));
            pilePersonnes.Empiler(new Personne("Abadi", "Ihab", "Ihab@utopios.net"));
            pilePersonnes.Empiler(new Personne("Abadi", "Marine", "marine@utopios.net"));
            pilePersonnes.Empiler(new Personne("Titi", "Toto", "toto@utopios.net"));


            Console.WriteLine("L'element en place 1 dans la pile est : {0}", pilePersonnes.Get(0));
            Console.WriteLine("L'element en place 2 dans la pile est : {0}", pilePersonnes.Get(1));
            Console.WriteLine("L'element en place 3 dans la pile est : {0}", pilePersonnes.Get(2));
            // Console.WriteLine("L'element en place 4 dans la pile est : {0}",pilePersonnes.Get(3));

            pilePersonnes.Depiler();
            pilePersonnes.Depiler();

            Console.WriteLine("L'element en place 1 dans la pile est : {0}", pilePersonnes.Get(0));
            Console.WriteLine("L'element en place 2 dans la pile est : {0}", pilePersonnes.Get(1));
            Console.WriteLine("L'element en place 3 dans la pile est : {0}", pilePersonnes.Get(2));
            #endregion

            #region Les Dictionnaires
            Console.WriteLine("*** Les Dictionnaires ***");
            Dictionary<string, Personne> annuaire = new Dictionary<string, Personne>();
            annuaire.Add("06 07 08 09 10", new Personne { Prenom = "Anthony" });
            annuaire.Add("06 08 08 09 10", new Personne { Prenom = "Nicolas" });
            annuaire.Add("06 09 08 09 10", new Personne { Prenom = "Jeanne" });
            // annuaire.Add("06 09 08 09 10", new Personne { Prenom = "Jeanne" }); // Erreur de compilation car la clé doit etre unique

            Personne p = annuaire["06 07 08 09 10"];
            Console.WriteLine(p);


            p = annuaire["06 08 08 09 10"];
            Console.WriteLine(p);
            #endregion

            #region Les LIST<T>
            Console.WriteLine("*** Les LIST<T> ***");
            Console.WriteLine("Avec des variables de type INT : ");
            List<int> listeEntier = new List<int>();
            listeEntier.Add(10);
            listeEntier.Add(20);
            listeEntier.Add(30);
            listeEntier.Add(40);

            Console.WriteLine("La liste contient {0} entiers",listeEntier.Count);
            
            Console.WriteLine("=======================");

            foreach (int item in listeEntier)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=======================");
            Console.WriteLine("Je retire la valeur 10 ");
            listeEntier.Remove(20);

            foreach (int item in listeEntier)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=======================");



            #endregion

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
        static void AfficherChiffre(int i)
        {
            Console.WriteLine("Le chiffre extrait est : {0}",i);
        }

        static void AfficherChaine(string s)
        {
            Console.WriteLine("La chaine extraite est : {0}", s);
        }
    }
}
