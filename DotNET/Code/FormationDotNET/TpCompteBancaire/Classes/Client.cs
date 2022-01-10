using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaire.Classes
{
    internal class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string email;
        private static int compteur = 0;

        public Client()
        {
            id = ++compteur;
        }
        public Client(string nom, string prenom, string telephone, string email) : this()
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Email = email;
        }

        public int Id { get => id; }
        public string Nom
        {
            get => nom;
            set
            {
                if (Tools.IsName(value))
                    nom = value;
                else
                    throw new FormatException("Erreur nom");
            }
        }
        public string Prenom
        {
            get => prenom;
            set
            {
                if (Tools.IsName(value))
                    prenom = value;
                else
                    throw new FormatException("Erreur prénom");
            }
        }
        public string Telephone
        {
            get => telephone;
            set
            {
                if (Tools.IsPhone(value))
                    telephone = value;
                else
                    throw new FormatException("Erreur téléphone");
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (Tools.IsEmail(value))
                    email = value;
                else
                    throw new FormatException("Erreur Adresse Email");
            }
        }
        public static int Compteur { get => compteur; }

        public override string ToString()
        {
            return $"Nom : {Nom}, prénom : {Prenom}, Téléphone : {Telephone}, Email : {Email}";
        }
    }
}
