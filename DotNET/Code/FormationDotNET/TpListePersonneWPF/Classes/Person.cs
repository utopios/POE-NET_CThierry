using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListePersonneWPF.DAO;
using TpListePersonneWPF.Data;

namespace TpListePersonneWPF.Classes
{
    internal class Person
    {
        private int id;
        private string title;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;

        public Person()
        {

        }
        public Person(string title, string firstName, string lastName, string email, string phone)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public string Title { get => title; set => title = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Id { get => id; set => id = value; }

        
        public int Add()
        {
            return PersonDAO.AjouterPersonne(this);
        }

        public static Person Get(string Nom, string Prenom)
        {
            return PersonDAO.TrouverPersonne(Nom, Prenom);
        }

        public bool Delete()
        {
            return PersonDAO.SupprimerPersonne(this) ? true : false;
        }

        public bool Update()
        {
            return PersonDAO.UpdatePersonne(this) ? true : false;
        }

        public static List<Person> GetList()
        {
            return PersonDAO.AvoirListePersonne();
        }

        public override string ToString()
        {
            return $"{Title} {LastName} {FirstName}";
        }
    }
}
