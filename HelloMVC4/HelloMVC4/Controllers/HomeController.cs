using Microsoft.AspNetCore.Mvc;

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
