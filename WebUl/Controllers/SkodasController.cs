﻿using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUl.Controllers
{
    public class SkodasController : Controller
    {
        // конструктор, который объявляет зависимость от интерфейса IAutoRepository
        private ISkodaRepository repository;
        public SkodasController(ISkodaRepository repo)
        {
            repository = repo;
        }
        // метод действия List(), который создает представление
        public ViewResult Skoda()
        {
            return View(repository.Skodas);
        }
    }
}