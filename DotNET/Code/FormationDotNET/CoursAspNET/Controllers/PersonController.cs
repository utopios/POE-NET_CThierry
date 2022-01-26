using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoursAspNET.Models;

namespace CoursAspNET.Controllers
{
    public class PersonController : Controller
    {
        // GET: PersonController
        public IActionResult Index()
        {
            List<Person> liste = Person.GetPersons();
            return View(liste);
        }

        // GET: PersonController/Details/6
        public IActionResult Details(int id)
        {
            // Person person = Person.GetPerson(id);
            Person p = new Person() { LastName="Di Persio", FirstName="Anthony",Id=id};
            return View(p);
        }

        // GET: PersonController/Create
        public IActionResult FormPerson()
        {
            return View();
        }

        public IActionResult SubmitPerson(string LastName , string FirstName)
        {
            Person person = new Person() { FirstName = FirstName, LastName= LastName };
            return View(person);
        }
    }
}
