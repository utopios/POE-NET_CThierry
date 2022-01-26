namespace CoursAspNET.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;
        int id;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; set => id = value; }

        public static List<Person> GetPersons()
        {
            return new List<Person>() {
                new Person()  {Id = 1 ,FirstName="Toto", LastName="Tata"},
                new Person()  {Id = 2 ,FirstName="Minet", LastName="Titi"},
            };
        }

        public static Person GetPerson(int id)
        {
            Person p = new Person();
            return p;
        }
    }
}
