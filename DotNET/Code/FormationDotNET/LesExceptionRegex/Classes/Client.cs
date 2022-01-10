using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExceptionRegex.Classes
{
    internal class Client
    {
        private int id;
        private string firstName;
        private string lastName;
        private string telephone;
        private string email;
        private static int compteur = 0;

        public Client()
        {
            id = ++compteur;
        }
        public Client(string firstName, string lastName, string telephone, string email) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Telephone = telephone;
            Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (Tools.IsName(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new FormatException("Erreur de saisie du prénom");
                }
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (Tools.IsName(value))
                {
                    lastName = value;
                }
                else
                {
                    throw new FormatException("Erreur de saisie du nom de famille");
                }
            }
        }
        public string Telephone { 
            get => telephone;
            set
            {
                if (Tools.IsPhone(value))
                {
                    telephone = value;
                }
                else
                {
                    throw new FormatException("Erreur de saisie du téléphone");
                }
            }
        }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"Nom = {LastName} - Prénom = {FirstName} - Phone = {Telephone} - Email = {Email}";
        }
    }
}
