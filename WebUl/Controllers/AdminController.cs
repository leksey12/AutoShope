﻿using Domain.Abstract;
using Domain.AutoShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUl.Controllers
{
    public class AdminController : Controller
    {
        ISkodaRepository repository;

        public AdminController(ISkodaRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Skodas);
        }
        public ViewResult Edit(int Id)
        {
           Skoda game = repository.Skodas
                .FirstOrDefault(g => g.Id == Id);
            return View(game);
        }
        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(Skoda game)
        {
            if (ModelState.IsValid)
            {
                repository.SaveSkoda(game);
                TempData["message"] = string.Format("Изменения в Auto City Skoda \"{0}\" были сохранены", game.Name);
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
            return View("Edit", new Skoda());
        }

    }
}