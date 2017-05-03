using Microsoft.AspNetCore.Mvc;
using MvcApp.ViewModel;

namespace MvcApp.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            var people = new[]
            {
                new PersonModel(Salutation.Mr, "Albert", "Weinert"),
                new PersonModel(Salutation.Mr, "Stefan", "Lange"),
                new PersonModel(Salutation.Ms, "Melanie", "Eibl"),
                new PersonModel(Salutation.Mr, "Roland", "Weigelt")
            };
            return View(people);
        }
    }
}