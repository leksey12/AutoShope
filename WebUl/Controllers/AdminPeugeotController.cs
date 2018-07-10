using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.AutoShop;

namespace WebUl.Controllers
{
    public class AdminPeugeotController : Controller
    {
        IPeugeotRepository repository;

        public AdminPeugeotController(IPeugeotRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Peugeot);
        }
        public ViewResult Edit(int Id)
        {
            Peugeot game = repository.Peugeot
                 .FirstOrDefault(g => g.Id == Id);
            return View(game);
        }
        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(Peugeot game)
        {
            if (ModelState.IsValid)
            {
                repository.SavePeugeot(game);
                TempData["message"] = string.Format("Изменения в Envy Motors \"{0}\" были сохранены", game.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(game);
            }
        }
    }
}