using lab11FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {
            return RedirectToAction("Results", new { begYear, endYear });
        }

        [HttpGet]
        public IActionResult Results(int begYear, int endYear)
        {
            return View(TimePerson.GetPersons(begYear, endYear));
        }
    }
}
