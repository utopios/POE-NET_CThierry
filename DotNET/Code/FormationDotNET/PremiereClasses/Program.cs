using System;
using PremiereClasses.Classes;

namespace PremiereClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un instance de la classe Voiture ( Constructeur vide )
            Voiture voitureDeNicolas = new Voiture();
            // Affectation de valeur aux propriété de l'objet Voiture
            voitureDeNicolas.Model="Clio";
            voitureDeNicolas.Couleur="Noir";
            voitureDeNicolas.Reservoir=45;
            voitureDeNicolas.Autonomie=900;

            Voiture voitureDeJulie = new Voiture("208", "Blanche", 40, 800);
            Voiture voitureDeFabien = new Voiture("Camaro", "Noir", 140, 200);
            Voiture voitureDeMeriem = new Voiture("Ferrari", "Rouge", 140, 200);

            Afficher(voitureDeNicolas);
            Afficher(voitureDeJulie);
            Afficher(voitureDeFabien);
            Afficher(voitureDeMeriem);

            voitureDeFabien.Demarrer();
            voitureDeFabien.Demarrer();


            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
        public static void Afficher(Voiture Toto)
        {
            Console.WriteLine($"Notre voiture est une {Toto.Model} de couleur {Toto.Couleur}.");
            Console.WriteLine($"Elle a un réservoir de {Toto.Reservoir} litres pour un autonomie de {Toto.Autonomie} km.");
        }
    }
}
