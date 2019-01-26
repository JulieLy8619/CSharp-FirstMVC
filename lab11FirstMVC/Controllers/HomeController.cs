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
        /// <summary>
        /// this will call the "home" page to diplay
        /// </summary>
        /// <returns>the page to display</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// this will collect information from the user in the form
        /// </summary>
        /// <param name="begYear">start year user would like to know the people of the year</param>
        /// <param name="endYear">end year user would like to know of the people of the year</param>
        /// <returns>the page to display</returns>
        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {
            return RedirectToAction("Results", new { begYear, endYear });
        }

        /// <summary>
        /// This will be the page that displays the results
        /// </summary>
        /// <param name="begYear">start year user would like to know the people of the year</param>
        /// <param name="endYear">end year user would like to know of the people of the year</param>
        /// <returns>the page with results to display</returns>
        [HttpGet]
        public IActionResult Results(int begYear, int endYear)
        {
            return View(TimePerson.GetPersons(begYear, endYear));
        }
    }
}
