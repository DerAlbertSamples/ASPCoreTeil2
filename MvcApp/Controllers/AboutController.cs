using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MvcApp.Controllers
{
    public class AboutController
    {
        [ActionContext]
        public ActionContext ActionContext { get; set; }

        [ViewDataDictionary]
        public ViewDataDictionary ViewData { get; set; }

        public string FullName { get; set; }

        public IActionResult Index()
        {
            return new ViewResult();
        }
    }
}