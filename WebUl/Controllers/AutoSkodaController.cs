using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.AutoShop;

namespace WebUl.Controllers
{
    public class AutoSkodaController : Controller
    {
        private IAutoSkodaRepository repository;
        public AutoSkodaController(IAutoSkodaRepository repo)
        {
            repository = repo;
        }
        
    }
}