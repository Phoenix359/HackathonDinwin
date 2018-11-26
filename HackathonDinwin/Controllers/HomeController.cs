﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackathonDinwin.Models;

namespace HackathonDinwin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Session());
        }

        public IActionResult Create(string userName)
        {
            var user = Models.User.Create(userName);
            return View("Index", new Session(){ActiveUser = user, AllUsers = Models.User.GetAll()});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
