using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProprietes.Classes
{
    internal class Personne
    {
        private static int counter = 1;
        private int id;
        private string nom;
        private string prenom;
        private string email = null;

        public Personne()
        {
            Id = counter;
            counter++;
        }

        public Personne(string nom, string prenom, string email) : this()
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
        }

        public static int Counter { get => counter; set => counter = value; }
        public string Nom
        {
            get => nom;
            set
            {
                if (value.Length >= 2)
                {
                    nom = value;
                }
                else
                    Console.WriteLine("Le nom doit contenir au moins deux caractères...");
                    //throw new Exception("Le nom doit contenir au moin deux caractères...");

            }
        }
        public string Prenom
        {
            get => prenom;
            set
            {

                if (value.Length >= 2)
                {
                    prenom = value;
                }
                else
                    Console.WriteLine("Le nom doit contenir au moins deux caractères...");
                    //throw new Exception("Le nom doit contenir au moin deux caractères...");

            }
        }

        public string Email { get => email; init => email = value; } // CSharp9
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Email !=null? $"Id : {Id} - Nom : {Nom} - Prénom : {Prenom} - Email = {Email}" : $"Id : {Id} - Nom : {Nom} - Prénom : {Prenom}";
        }
    }
}
