using Microsoft.AspNetCore.Mvc;

namespace RistoranteMVC.MVC.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
