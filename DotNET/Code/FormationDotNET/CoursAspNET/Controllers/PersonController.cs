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
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
