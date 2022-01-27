using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirageWPF.Classes
{
    internal class Person
    {
        private string lastName;
        private string firstName;
        private string title;

        public Person(string title, string lastName, string firstName)
        {
            Title = title;
            LastName = lastName;
            FirstName = firstName;
        }

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Title { get => title; set => title = value; }

        public override string ToString()
        {
            return $"{Title} {LastName} {FirstName}";
        }
    }
}
