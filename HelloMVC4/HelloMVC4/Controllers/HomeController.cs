using Microsoft.AspNetCore.Mvc;
using HelloMVC4.Controllers;

namespace HelloMVC4.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
