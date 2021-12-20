using System;

namespace LesMethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Méthode sans paramètres
            AffichageBienvenue();
            AffichageBienvenue();
            int autreChiffre = AfficherChiffre();
            Console.WriteLine("Les chiffre est {0}", autreChiffre);
            string autreChaine = AfficheTexte();
            Console.WriteLine("La chaine retournée est : {0}", autreChaine);
            #endregion


            #region Méthode avec paramètres
            string prenom;
            string langage;
            int chiffre1;
            int chiffre2;
            AffichagePersonnalise("Anthony", "C#");
            AffichagePersonnalise("Jeanne", "Javascript");
            Console.Write("Entrez votre prénom : ");
            prenom = Console.ReadLine();
            Console.Write("Quel langage apprennez-vous? : ");
            langage = Console.ReadLine();
            AffichagePersonnalise(prenom, langage);
            Console.Write("Entrez le premier chiffre : ");
            chiffre1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le chiffre 2 : ");
            chiffre2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Les résultat est : {0}", Additionner(chiffre1, chiffre2));

            #endregion

            #region Passer un tableau en paramètre
            string[] tab = new string[] { "toto", "titi", "tata", "minet" };
            AfficherTableau(tab);

           

            #endregion
            Console.Read();
        }
        static void AffichageBienvenue()
        {
            Console.WriteLine("Bonjour");
            Console.WriteLine("----------");
            Console.WriteLine("Bienvenue sur le serveur");
            Console.WriteLine("------------------------");
        }
        static int AfficherChiffre()
        {
            int chiffre = 10;
            return chiffre;
        }
        static string AfficheTexte()
        {
            string chaine = "coucou";
            return chaine;
        }
        static void AffichagePersonnalise(string prenom, string langage)
        {
            Console.WriteLine("Bonjour {0}", prenom);
            Console.WriteLine("------------------------");
            Console.WriteLine("Vous apprenez le {0}", langage);
            Console.WriteLine("------------------------");
        }
        static int Additionner(int nb1, int nb2)
        {
            int resultat = nb1 + nb2;
            return resultat;
        }
        static void AfficherTableau(string[] contacts)
        {
            foreach (string c in contacts)
                Console.WriteLine("Le nom du contact est : {0}", c);
        }
    }
}
