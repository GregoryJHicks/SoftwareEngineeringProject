using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoftwareEngineeringProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //View section: it contains all of the actions that run each page
        public IActionResult Index()
        {
            FullMenu temp = new FullMenu();
            return View(temp);
        }

        public IActionResult Payment()
        {
            return View();
        }

        public IActionResult Reciept()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Orders()
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
