using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.AutoShop;

namespace WebUl.Controllers
{
    public class AdminPorsheController : Controller
    {
        IPorsheRepository repository;

        public AdminPorsheController(IPorsheRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Porshe);
        }
        public ViewResult Edit(int Id)
        {
            Porshe game = repository.Porshe
                 .FirstOrDefault(g => g.Id == Id);
            return View(game);
        }
        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(Porshe game)
        {
            if (ModelState.IsValid)
            {
                repository.SavePorshe(game);
                TempData["message"] = string.Format("Изменения в PORSHE \"{0}\" были сохранены", game.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(game);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new Porshe());
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Porshe deletedPorshe = repository.DeletePorshe(Id);
            if (deletedPorshe != null)
            {
                TempData["message"] = string.Format("Машина \"{0}\" была удалена",
                    deletedPorshe.Name);
            }
            return RedirectToAction("Index");
        }
    }
}