using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.AutoShop;

namespace WebUl.Controllers
{
    public class AdminBMWController : Controller
    {
        IBMWRepository repository;

        public AdminBMWController(IBMWRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.BMWs);
        }
        public ViewResult Edit(int Id)
        {
            BMW game = repository.BMWs
                 .FirstOrDefault(g => g.Id == Id);
            return View(game);
        }
        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(BMW game)
        {
            if (ModelState.IsValid)
            {
                repository.SaveBMW(game);
                TempData["message"] = string.Format("Изменения в Изар-Авто \"{0}\" были сохранены", game.Name);
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
            return View("Edit", new BMW());
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            BMW deletedBMW = repository.DeleteBMW(Id);
            if (deletedBMW != null)
            {
                TempData["message"] = string.Format("Машина \"{0}\" была удалена",
                    deletedBMW.Name);
            }
            return RedirectToAction("Index");
        }
    }
}