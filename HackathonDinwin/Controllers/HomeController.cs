using System;
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
            return View(GlobalVariables.ActiveSession);
        }

        public IActionResult Create(string userName)
        {
            var user = Models.User.Create(userName);
            GlobalVariables.ActiveSession.ActiveUser = user;
            return RedirectToAction("Index");
        }

        #region buildings

        [HttpGet]
        [Route("Buildings/{username}")]
        public IActionResult Buildings(string username)
        {
            if (!GlobalVariables.ActiveSession.AllUsers.Any(x => x.Name == username))
            {
                RedirectToAction("Index");
            }

            var model = new UserBuildings(username);

            return View(model);
        }

        [HttpPost]
        [Route("AddBuilding")]
        public IActionResult AddBuilding(Building building)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            GlobalVariables.Buildings.Add(building);

            return RedirectToAction($"Buildings", new { UserName = building.UserName });
        }

        [HttpPost]
        [Route("UpdateUserBuildings")]
        public IActionResult UpdateUserBuildings(UserBuildings userBuildings)
        {
            foreach (var building in userBuildings.Buildings)
            {
                var index = GlobalVariables.Buildings.FindIndex(x => x.BuildingName == building.BuildingName);
                GlobalVariables.Buildings.RemoveAt(index);
                GlobalVariables.Buildings.Insert(index, building);
            }

            return RedirectToAction($"Buildings", new { UserName = userBuildings.ActiveUser.Name });
        }

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
