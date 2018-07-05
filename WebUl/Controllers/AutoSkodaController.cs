using System;
using System.Linq;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.AutoShop;
using WebUl.Models;
namespace WebUl.Controllers
{
    public class AutoSkodaController : Controller
    {
        //private IAutoSkodaRepository repository;
        //public AutoSkodaController(IAutoSkodaRepository repo)
        //{
        //    repository = repo;
        //}
        public ViewResult Index(string returnUrl)
        {
            return View(new AutoSkodaIndexViewModel
            {
      AutoSkoda = GetAutoSkoda(),
      ReturnUrl= returnUrl
            });

        }
        public RedirectToRouteResult AddToAuto(int autoId, string returnUrl)
        {
            Auto auto = repository.Autos
                .FirstOrDefault(g => g.Id == autoId);

            if (auto != null)
            {
             // GetAutoSkoda().AddItem(auto, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private AutoSkoda GetAutoSkoda()
        {
            AutoSkoda autoskoda = (AutoSkoda)Session["AutoSkoda"];
            if (autoskoda == null)
            {
                autoskoda = new AutoSkoda();
                Session["AutoSkoda"] = autoskoda;
            }
            return autoskoda;
        }

        private IAutoRepository repository;
        public AutoSkodaController(IAutoRepository repo)
        {
            repository = repo;
        }
        
    }
}