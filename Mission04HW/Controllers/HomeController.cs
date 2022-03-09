using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission04HW.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04HW.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext movieContext { get; set; }

        public HomeController(MovieContext someName)
        {
            movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.categories = movieContext.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            if (ModelState.IsValid) //if the input meets requirements
            {
                movieContext.Add(ar); //add it to variable ar
                movieContext.SaveChanges();
                return View("Movielist", ar);
            }
            else
            {
                ViewBag.categories = movieContext.categories.ToList();
                return View(ar); //tell em to fix their input and send em back
            }
        }

        public IActionResult Bacon()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Movielist ()
        {
            var applications = movieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int applicationid)
        {//we reused some code from adding a new record but I don't really understand it
            ViewBag.categories = movieContext.categories.ToList();
            var application = movieContext.responses.Single(x => x.ApplicationId == applicationid);
            return View("MovieForm", application);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            movieContext.Update(blah);
            movieContext.SaveChanges();
            return RedirectToAction("Movielist");
        }
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = movieContext.responses.Single(x => x.ApplicationId == applicationid);
            return View(application);
            // i'm not sure what this does
            //i know the .Single selects one record for deletion
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            movieContext.responses.Remove(ar);
            movieContext.SaveChanges();
            return RedirectToAction("Movielist");
        }
    }
}
