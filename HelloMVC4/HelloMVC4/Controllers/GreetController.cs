using HelloMVC4.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC4.Controllers
{
    public class GreetController : Controller
    {
        public ViewResult Index(string name)
        {
            var model = new GreetModel();
            model.Name = name;
            return View(model);
        }
    }
}
