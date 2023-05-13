using GunsOfTheOldWest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;

namespace GunsOfTheOldWest.Controllers
{
    public class HomeController : Controller
    {
        private readonly Gun _userGun;
        private readonly User _user;

        public HomeController(Gun usergun)
        {
            _userGun = usergun;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_userGun);
        }

        [HttpGet]
        public IActionResult Shoot()
        {
            _userGun.Geschoten();
            int getal = RandomGetal();
            
            switch (getal)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return RedirectToAction("Winnaar");
                default:
                    return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Winnaar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Winnaar(User User)
        {
            _user.GetUser(User);
            return View("Samenvatting", User);
        }

        private int RandomGetal()
        {
            Random r = new Random();
            return r.Next(11);
        }


    }
}