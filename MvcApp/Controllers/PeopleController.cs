using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Data;
using MvcApp.ViewModel;

namespace MvcApp.Controllers
{
    public class PeopleController : Controller
    {
        private readonly AppDbContext _dbContext;

        public PeopleController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActionResult Index()
        {

            var people = from p in _dbContext.People
                select new PersonModel(p.Salutation, p.FirstName, p.LastName) {Id = p.Id};

            return View(people);
        }

        public IActionResult Edit(long id)
        {
            var person = _dbContext.People.Find(id);

            if (person == null)
            {
                return NotFound();
            }

            return View(new PersonModel(person.Salutation, person.FirstName, person.LastName) { Id = person.Id });
        }

        [HttpPost]
        public IActionResult Edit(long id, PersonModel model)
        {
            var person = _dbContext.People.Find(id);

            if (person == null)
            {
                return NotFound();
            }

            person.Salutation = model.Salutation;
            person.FirstName = model.FirstName;
            person.LastName = model.LastName;

            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}