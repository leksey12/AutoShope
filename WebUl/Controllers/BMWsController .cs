using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUl.Controllers
{
    public class BMWsController : Controller
    {
        // конструктор, который объявляет зависимость от интерфейса IAutoRepository
        private IBMWRepository B;
        public BMWsController(IBMWRepository b)
        {
            B = b;
        }
        // метод действия List(), который создает представление
        public ViewResult List()
        {
            return View(B.BMWs);
        }
    }
}