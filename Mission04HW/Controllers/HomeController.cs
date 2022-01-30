using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieContext _instanceContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            _instanceContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            _instanceContext.Add(ar);
            _instanceContext.SaveChanges();
            return View("Index", ar);
        }

        public IActionResult Bacon()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
