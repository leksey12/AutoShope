using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.AutoShop;

namespace WebUl.Controllers
{
    public class AdminLadaController : Controller
    {
        ILadaRepository repository;

        public AdminLadaController(ILadaRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Lada);
        }
        public ViewResult Edit(int Id)
        {
            Lada game = repository.Lada
                 .FirstOrDefault(g => g.Id == Id);
            return View(game);
        }
        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(Lada game)
        {
            if (ModelState.IsValid)
            {
                repository.SaveLada(game);
                TempData["message"] = string.Format("Изменения в ВИКИНГИ \"{0}\" были сохранены", game.Name);
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