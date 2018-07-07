using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUl.Controllers
{
    public class LadaController : Controller
    {
        // конструктор, который объявляет зависимость от интерфейса IAutoRepository
        private ILadaRepository repository;
        public LadaController(ILadaRepository repo)
        {
            repository = repo;
        }
        // метод действия List(), который создает представление
        public ViewResult List()
        {
            return View(repository.Lada);
        }
    }
}