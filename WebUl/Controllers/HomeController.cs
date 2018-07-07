using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUl.Controllers
{
    public class HomeController : Controller
    {

        private readonly EFDbContext _db = new EFDbContext();
        // GET: Home
        public ViewResult Skodas()
        {
            var Skodas = _db.Skodas.ToList();
            ViewBag.Skodas = Skodas;
            return View();
        }
        public ViewResult Index()
        {
            return View();
        }
    }
}