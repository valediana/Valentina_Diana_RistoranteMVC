using Microsoft.AspNetCore.Mvc;
using RistoranteMVC.Core.BusinessLayer;
using RistoranteMVC.MVC.Helper;
using RistoranteMVC.MVC.Models;

namespace RistoranteMVC.MVC.Controllers
{
    public class PiattiController : Controller
    {
        private readonly IBusinessLayer BL; 

        public PiattiController(IBusinessLayer bl)
        {
            BL = bl; 
        }
        public IActionResult Index()
        {
            var piatti = BL.GetAllPiatti();
            List<PiattoViewModel> piattiViewModel = new List<PiattoViewModel>();
            foreach (var item in piatti)
            {
                piattiViewModel.Add(item.ToPiattoViewModel());
            }
            return View(piattiViewModel);
            
        }
    }
}
