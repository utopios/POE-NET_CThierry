using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpClasseChaise.Classes
{
    internal class Chaise
    {
        // Déclaration des attributs privés (protégés par l'encapsulation)
        private int nbPieds;
        private string couleur;
        private string materiaux;

        public Chaise()
        {

        }

        public Chaise(int nbPieds, string couleur, string materiaux)
        {
            NbPieds=nbPieds;
            Couleur=couleur;
            Materiaux=materiaux;
        }


        // Propriétés publiques permettant d'acceder aux attibuts
        public int NbPieds { get => nbPieds; set => nbPieds=value; }
        public string Couleur { get => couleur; set => couleur=value; }
        public string Materiaux { get => materiaux; set => materiaux=value; }

        public override string ToString()
        {
            return $"Nb Pieds : {NbPieds} - Matériaux : {Materiaux} - Couleur : {Couleur}";
        }

        public void Afficher()
        {
            Console.WriteLine("---------------------- Affichage d'un nouvel objet ----------------------\n");
            Console.WriteLine($"Je suis une chaise avec {NbPieds} pieds en {Materiaux} et de couleur {Couleur}\n");
            Console.WriteLine("-------------------------------------------------------------------------\n");
        }
    }
}
