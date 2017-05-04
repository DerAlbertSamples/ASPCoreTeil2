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
                select new PersonModel(p.Salutation, p.FirstName, p.LastName);

            return View(people);
        }
    }
}