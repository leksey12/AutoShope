using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUl.Controllers
{
    public class SkodaController : Controller
    {
        // конструктор, который объявляет зависимость от интерфейса IAutoRepository
        private ISkodaRepository repository;
        public SkodaController(ISkodaRepository repo)
        {
            repository = repo;
        }
        // метод действия List(), который создает представление
        public ViewResult List()
        {
            return View(repository.AutoSkoda);
        }
    }
}